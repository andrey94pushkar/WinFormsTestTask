using WinFormsTestTask.Entity;
using System.Drawing.Drawing2D;

namespace WinFormsTestTask
{
    public partial class Form1 : Form
    {
        private DrawTool _drawTool;
        private bool _isMouseDown;
        private Bitmap _bitmap;
        private Bitmap _invertBitmap;
        private string _fileName = "";
        private Pen _pen;
        private int _penThickness = 1;
        private bool _fillColor = false;
        private Graphics _graphics;
        private List<DrawAction> _drawActions = new List<DrawAction>();
        private Point _lastPoint;
        private Point _currentPoint;
        private List<Line> _lines = new List<Line>();
        private string _text = "";
        private object lockObject = new object();

        public Form1()
        {
            InitializeComponent();
            _drawTool = DrawTool.Pencil;
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _pen = new Pen(btnSetCustomColor.BackColor, _penThickness);
            _pen.StartCap = LineCap.Round;
            _pen.EndCap = LineCap.Round;
            _graphics = Graphics.FromImage(_bitmap);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;

            switch (_drawTool)
            {
                case DrawTool.Line:
                case DrawTool.Rectangle:
                case DrawTool.Cyrcle:
                    _lastPoint = new Point(e.X, e.Y);
                    break;
                default:
                    break;
            }

            cbFillColor.Checked = _fillColor;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown && _drawTool != DrawTool.Text) { return; }

            switch (_drawTool)
            {
                case DrawTool.Pencil:
                    if (_lastPoint.IsEmpty)
                    {
                        _lastPoint = new Point(e.X, e.Y);
                    }
                    else
                    {
                        _lastPoint = _currentPoint;
                    }
                    _currentPoint = new Point(e.X, e.Y);
                    _lines.Add(new Line(_lastPoint, _currentPoint));
                    _graphics.DrawLine(_pen, _lastPoint, _currentPoint);
                    break;
                case DrawTool.Line:
                case DrawTool.Rectangle:
                case DrawTool.Cyrcle:
                case DrawTool.Text:
                    _currentPoint = new Point(e.X, e.Y);
                    break;
                default:
                    break;
            }

            pictureBox1.Image = _bitmap;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;

            DrawAction drawAction = new DrawAction() { 
                DrawTool = _drawTool,
                Lines = _lines,
                LastPoint = _lastPoint,
                CurrentPoint = _currentPoint,
                Text = _text,
                FillColor = _fillColor,
                Pen = (Pen)_pen.Clone(),
                PenThickness = _penThickness
            };
            _drawActions.Add(drawAction);

            Draw();

            _lines = new List<Line>();

            _lastPoint = Point.Empty;

            pictureBox1.Cursor = Cursors.Default;

            btnUndo.Enabled = true;
            pictureBox1.Image = _bitmap;
            _graphics = Graphics.FromImage(_bitmap);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (_drawTool)
            {
                case DrawTool.Line:
                    if (!_lastPoint.IsEmpty && !_currentPoint.IsEmpty)
                        e.Graphics.DrawLine(_pen, _lastPoint, _currentPoint);
                    break;
                case DrawTool.Rectangle:
                    Point rectanglePoint = _currentPoint;
                    int rectanglePositionX = Math.Min(_lastPoint.X, rectanglePoint.X);
                    int rectanglePositionY = Math.Min(_lastPoint.Y, rectanglePoint.Y);
                    int rectangleWidth = Math.Abs(rectanglePoint.X - _lastPoint.X);
                    int rectangleHeight = Math.Abs(rectanglePoint.Y - _lastPoint.Y);
                    if (rectangleWidth > 2 && rectangleHeight > 2 && rectanglePositionX > 0 && rectanglePositionY > 0)
                        if (_fillColor)
                            e.Graphics.FillRectangle(_pen.Brush, new Rectangle(rectanglePositionX, rectanglePositionY, rectangleWidth, rectangleHeight));
                        else
                            e.Graphics.DrawRectangle(_pen, new Rectangle(rectanglePositionX, rectanglePositionY, rectangleWidth, rectangleHeight));
                    break;
                case DrawTool.Cyrcle:
                    Point cyrclePoint = _currentPoint;
                    int cyrclePositionX = Math.Min(_lastPoint.X, cyrclePoint.X);
                    int cyrclelePositionY = Math.Min(_lastPoint.Y, cyrclePoint.Y);
                    int cyrcleWidth = Math.Abs(cyrclePoint.X - _lastPoint.X);
                    int cyrcleHeight = Math.Abs(cyrclePoint.Y - _lastPoint.Y);
                    if (cyrcleWidth > 2 && cyrcleHeight > 2 && cyrclePositionX > 0 && cyrclelePositionY > 0)
                        if (_fillColor)
                            e.Graphics.FillEllipse(_pen.Brush, cyrclePositionX, cyrclelePositionY, cyrcleWidth, cyrcleHeight);
                        else
                            e.Graphics.DrawEllipse(_pen, cyrclePositionX, cyrclelePositionY, cyrcleWidth, cyrcleHeight);
                    break;
                case DrawTool.Text:
                    e.Graphics.DrawString(_text, new Font("Arial", _penThickness * 3), _pen.Brush, _currentPoint.X, _currentPoint.Y);
                    break;
                default:
                    break;
            }
        }

        private void Draw()
        {
            Point point = _currentPoint;
            int objectPositionX = Math.Min(_lastPoint.X, point.X);
            int objectPositionY = Math.Min(_lastPoint.Y, point.Y);
            int objectWidth = Math.Abs(point.X - _lastPoint.X);
            int objectHeight = Math.Abs(point.Y - _lastPoint.Y);

            switch (_drawTool)
            {
                case DrawTool.Line:
                    _graphics.DrawLine(_pen, _lastPoint, _currentPoint);
                    break;
                case DrawTool.Rectangle:
                    if (objectWidth > 2 && objectHeight > 2)
                        if (_fillColor)
                            _graphics.FillRectangle(_pen.Brush, new Rectangle(objectPositionX, objectPositionY, objectWidth, objectHeight));
                        else
                            _graphics.DrawRectangle(_pen, new Rectangle(objectPositionX, objectPositionY, objectWidth, objectHeight));
                    break;
                case DrawTool.Cyrcle:
                    if (objectWidth > 2 && objectHeight > 2)
                        if (_fillColor)
                            _graphics.FillEllipse(_pen.Brush, objectPositionX, objectPositionY, objectWidth, objectHeight);
                        else
                            _graphics.DrawEllipse(_pen, objectPositionX, objectPositionY, objectWidth, objectHeight);
                    break;
                case DrawTool.Text:
                    _graphics.DrawString(_text, new Font("Arial", _penThickness * 3), _pen.Brush, _currentPoint.X, _currentPoint.Y);
                    _drawTool = DrawTool.Pencil;
                    pictureBox1.Cursor = Cursors.Default;
                    break;
                default:
                    break;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Clean();
            if (_fileName != "")
            {
                pictureBox1.Image = Image.FromFile(_fileName);
                _bitmap = new Bitmap(openFileDialog1.FileName);
                _graphics = Graphics.FromImage(_bitmap);
            }


            if (_drawActions.Count > 1)
            {
                List<DrawAction> actions = _drawActions.GetRange(0, _drawActions.Count - 1);
                foreach (DrawAction action in actions)
                {
                    _lastPoint = action.LastPoint;
                    _currentPoint = action.CurrentPoint;
                    _drawTool = action.DrawTool;
                    _text = action.Text;
                    _fillColor = action.FillColor;
                    _pen = action.Pen;
                    btnSetCustomColor.BackColor = action.Pen.Color;
                    _penThickness = action.PenThickness;
                    _pen.Width = action.PenThickness;

                    if (action.DrawTool == DrawTool.Pencil)
                    {
                        foreach (Line line in action.Lines)
                        {
                            _graphics.DrawLine(_pen, line.StartPoint, line.EndPoint);
                        }
                        pictureBox1.Image = _bitmap;
                    }
                    else if (action.DrawTool == DrawTool.Invert)
                    {
                        _bitmap = (Bitmap)_invertBitmap.Clone();
                        pictureBox1.Image = _bitmap;
                    }
                    else
                    {
                        Draw();
                    }
                }

                _drawActions = actions;
            }
            else
            {
                _drawActions = new List<DrawAction>();
                btnUndo.Enabled = false;
            }
            _graphics = Graphics.FromImage(_bitmap);
        }

        private void setColor(object sender, EventArgs e)
        {
            SetColor(((Button)sender).BackColor);
        }
        
        private void SetColor(Color color)
        {
            btnSetCustomColor.BackColor = color;
            _pen.Color = btnSetCustomColor.BackColor;
            _pen.Brush = new SolidBrush(btnSetCustomColor.BackColor);
        }

        private void btnSetCustomColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SetColor(colorDialog1.Color);
            }
        }

        private void btnSetLineTool_Click(object sender, EventArgs e)
        {
            _drawTool = DrawTool.Line;
        }

        private void btnSetPencilTool_Click(object sender, EventArgs e)
        {
            _drawTool = DrawTool.Pencil;
        }

        private void btnSetRectangleTool_Click(object sender, EventArgs e)
        {
            _drawTool = DrawTool.Rectangle;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            _pen.Width = trackBar1.Value;
            _penThickness = trackBar1.Value;
        }

        private void btnSetCyrcleTool_Click(object sender, EventArgs e)
        {
            _drawTool = DrawTool.Cyrcle;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
            _drawActions = new List<DrawAction>();
            btnUndo.Enabled = false;
        }

        private void Clean()
        {
            _graphics.Clear(Color.White);
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_bitmap);
            pictureBox1.Image = _bitmap;
            _lastPoint = Point.Empty;
            _currentPoint = Point.Empty;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Clean();
                _fileName = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                _bitmap = new Bitmap(openFileDialog1.FileName);
                _graphics = Graphics.FromImage(_bitmap);

                _drawActions.Clear();
            }
        }

        private void btnSetTextTool_Click(object sender, EventArgs e)
        {
            TextForm textForm = new TextForm();
            textForm.BtnOkClicked += TextForm_BtnOkClicked;
            textForm.BtnCancelClacked += TextForm_BtnCancelClacked;
            textForm.Show();
        }

        private void TextForm_BtnCancelClacked(object? sender, EventArgs e)
        {
            var form = (TextForm)sender;
            form.Close();
            _drawTool = DrawTool.Pencil;
        }

        private void TextForm_BtnOkClicked(object sender, EventArgs e)
        {
            var form = (TextForm)sender;
            _text = form.Text;
            form.Close();
            pictureBox1.Cursor = Cursors.Cross;
            _drawTool = DrawTool.Text;
        }

        private async Task InvertBitmapColorsAsync()
        {

            toolStripProgressBar1.ProgressBar.Minimum = 0;
            toolStripProgressBar1.ProgressBar.Maximum = _bitmap.Width;
            pictureBox1.Enabled = false;
            btnUndo.Enabled = false;
            openToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;

            await Task.Run(() =>
            {
                Bitmap invertedBitmap = new Bitmap(_bitmap.Width, _bitmap.Height);
                Bitmap imgClone;
                lock (lockObject)
                {
                    imgClone = (Bitmap)_bitmap.Clone();
                }
                for (int x = 0; x < imgClone.Width; x++)
                {
                    for (int y = 0; y < imgClone.Height; y++)
                    {
                        Color pixelColor = imgClone.GetPixel(x, y);
                        pixelColor = Color.FromArgb(pixelColor.ToArgb() ^ 0xffffff);
                        invertedBitmap.SetPixel(x, y, pixelColor);
                    }
                    toolStripProgressBar1.ProgressBar.Invoke((MethodInvoker)(() => toolStripProgressBar1.ProgressBar.Value = x));
                }

                _bitmap = invertedBitmap;
            });
            _invertBitmap = (Bitmap)_bitmap.Clone();
            pictureBox1.Image = _bitmap;
            pictureBox1.Update();
            pictureBox1.Enabled = true;
            btnUndo.Enabled = true;
            openToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            toolStripProgressBar1.ProgressBar.Value = 0; 
            _graphics = Graphics.FromImage(_bitmap);
            //_drawTool = DrawTool.Pencil;
            //_drawActions = new List<DrawAction>();
            _drawActions.Add(new DrawAction() { DrawTool = DrawTool.Invert});
            btnUndo.Enabled = false;
            //_drawActions.Add(new DrawAction () { DrawTool = DrawTool.Invert});
        }

        private async void btnInvert_Click(object sender, EventArgs e)
        {
            _drawActions.Clear();
            btnUndo.Enabled = false;
            await InvertBitmapColorsAsync();
        }

        private void cbFillColor_CheckedChanged(object sender, EventArgs e)
        {
            _fillColor = cbFillColor.Checked;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = Width - 20;
            panel1.Height = Height - 190;
        }
    }
}