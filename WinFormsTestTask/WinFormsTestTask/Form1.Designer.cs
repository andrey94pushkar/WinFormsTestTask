namespace WinFormsTestTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpColor = new System.Windows.Forms.GroupBox();
            this.cbFillColor = new System.Windows.Forms.CheckBox();
            this.btnSetGreenColor = new System.Windows.Forms.Button();
            this.btnSetCustomColor = new System.Windows.Forms.Button();
            this.btnSetBlackColor = new System.Windows.Forms.Button();
            this.btnSetGrayColor = new System.Windows.Forms.Button();
            this.btnSetBlueColor = new System.Windows.Forms.Button();
            this.btnSetCyanColor = new System.Windows.Forms.Button();
            this.btnSetLimeColor = new System.Windows.Forms.Button();
            this.btnSetYellowColor = new System.Windows.Forms.Button();
            this.btnSetOrangeColor = new System.Windows.Forms.Button();
            this.btnSetRedColor = new System.Windows.Forms.Button();
            this.btnSetWhiteColor = new System.Windows.Forms.Button();
            this.gpTools = new System.Windows.Forms.GroupBox();
            this.btnSetTextTool = new System.Windows.Forms.Button();
            this.btnSetCyrcleTool = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnSetRectangleTool = new System.Windows.Forms.Button();
            this.btnSetLineTool = new System.Windows.Forms.Button();
            this.btnSetPencilTool = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnInvert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpColor.SuspendLayout();
            this.gpTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(950, 505);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // gpColor
            // 
            this.gpColor.Controls.Add(this.cbFillColor);
            this.gpColor.Controls.Add(this.btnSetGreenColor);
            this.gpColor.Controls.Add(this.btnSetCustomColor);
            this.gpColor.Controls.Add(this.btnSetBlackColor);
            this.gpColor.Controls.Add(this.btnSetGrayColor);
            this.gpColor.Controls.Add(this.btnSetBlueColor);
            this.gpColor.Controls.Add(this.btnSetCyanColor);
            this.gpColor.Controls.Add(this.btnSetLimeColor);
            this.gpColor.Controls.Add(this.btnSetYellowColor);
            this.gpColor.Controls.Add(this.btnSetOrangeColor);
            this.gpColor.Controls.Add(this.btnSetRedColor);
            this.gpColor.Controls.Add(this.btnSetWhiteColor);
            this.gpColor.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.gpColor.Location = new System.Drawing.Point(93, 32);
            this.gpColor.Name = "gpColor";
            this.gpColor.Size = new System.Drawing.Size(292, 80);
            this.gpColor.TabIndex = 2;
            this.gpColor.TabStop = false;
            this.gpColor.Text = "Color";
            // 
            // cbFillColor
            // 
            this.cbFillColor.AutoSize = true;
            this.cbFillColor.Location = new System.Drawing.Point(65, 40);
            this.cbFillColor.Name = "cbFillColor";
            this.cbFillColor.Size = new System.Drawing.Size(88, 24);
            this.cbFillColor.TabIndex = 12;
            this.cbFillColor.Text = "Fill color";
            this.cbFillColor.UseVisualStyleBackColor = true;
            this.cbFillColor.CheckedChanged += new System.EventHandler(this.cbFillColor_CheckedChanged);
            // 
            // btnSetGreenColor
            // 
            this.btnSetGreenColor.BackColor = System.Drawing.Color.Green;
            this.btnSetGreenColor.Location = new System.Drawing.Point(155, 51);
            this.btnSetGreenColor.Name = "btnSetGreenColor";
            this.btnSetGreenColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetGreenColor.TabIndex = 11;
            this.btnSetGreenColor.UseVisualStyleBackColor = false;
            this.btnSetGreenColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetCustomColor
            // 
            this.btnSetCustomColor.BackColor = System.Drawing.Color.Black;
            this.btnSetCustomColor.Location = new System.Drawing.Point(13, 28);
            this.btnSetCustomColor.Name = "btnSetCustomColor";
            this.btnSetCustomColor.Size = new System.Drawing.Size(46, 46);
            this.btnSetCustomColor.TabIndex = 10;
            this.btnSetCustomColor.UseVisualStyleBackColor = false;
            this.btnSetCustomColor.Click += new System.EventHandler(this.btnSetCustomColor_Click);
            // 
            // btnSetBlackColor
            // 
            this.btnSetBlackColor.BackColor = System.Drawing.Color.Black;
            this.btnSetBlackColor.Location = new System.Drawing.Point(259, 51);
            this.btnSetBlackColor.Name = "btnSetBlackColor";
            this.btnSetBlackColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetBlackColor.TabIndex = 8;
            this.btnSetBlackColor.UseVisualStyleBackColor = false;
            this.btnSetBlackColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetGrayColor
            // 
            this.btnSetGrayColor.BackColor = System.Drawing.Color.Gray;
            this.btnSetGrayColor.Location = new System.Drawing.Point(233, 51);
            this.btnSetGrayColor.Name = "btnSetGrayColor";
            this.btnSetGrayColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetGrayColor.TabIndex = 7;
            this.btnSetGrayColor.UseVisualStyleBackColor = false;
            this.btnSetGrayColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetBlueColor
            // 
            this.btnSetBlueColor.BackColor = System.Drawing.Color.Blue;
            this.btnSetBlueColor.Location = new System.Drawing.Point(207, 51);
            this.btnSetBlueColor.Name = "btnSetBlueColor";
            this.btnSetBlueColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetBlueColor.TabIndex = 6;
            this.btnSetBlueColor.UseVisualStyleBackColor = false;
            this.btnSetBlueColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetCyanColor
            // 
            this.btnSetCyanColor.BackColor = System.Drawing.Color.Cyan;
            this.btnSetCyanColor.Location = new System.Drawing.Point(181, 51);
            this.btnSetCyanColor.Name = "btnSetCyanColor";
            this.btnSetCyanColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetCyanColor.TabIndex = 5;
            this.btnSetCyanColor.UseVisualStyleBackColor = false;
            this.btnSetCyanColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetLimeColor
            // 
            this.btnSetLimeColor.BackColor = System.Drawing.Color.Lime;
            this.btnSetLimeColor.Location = new System.Drawing.Point(259, 25);
            this.btnSetLimeColor.Name = "btnSetLimeColor";
            this.btnSetLimeColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetLimeColor.TabIndex = 4;
            this.btnSetLimeColor.UseVisualStyleBackColor = false;
            this.btnSetLimeColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetYellowColor
            // 
            this.btnSetYellowColor.BackColor = System.Drawing.Color.Yellow;
            this.btnSetYellowColor.Location = new System.Drawing.Point(233, 25);
            this.btnSetYellowColor.Name = "btnSetYellowColor";
            this.btnSetYellowColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetYellowColor.TabIndex = 3;
            this.btnSetYellowColor.UseVisualStyleBackColor = false;
            this.btnSetYellowColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetOrangeColor
            // 
            this.btnSetOrangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSetOrangeColor.Location = new System.Drawing.Point(207, 25);
            this.btnSetOrangeColor.Name = "btnSetOrangeColor";
            this.btnSetOrangeColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetOrangeColor.TabIndex = 2;
            this.btnSetOrangeColor.UseVisualStyleBackColor = false;
            this.btnSetOrangeColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetRedColor
            // 
            this.btnSetRedColor.BackColor = System.Drawing.Color.Red;
            this.btnSetRedColor.Location = new System.Drawing.Point(181, 25);
            this.btnSetRedColor.Name = "btnSetRedColor";
            this.btnSetRedColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetRedColor.TabIndex = 1;
            this.btnSetRedColor.UseVisualStyleBackColor = false;
            this.btnSetRedColor.Click += new System.EventHandler(this.setColor);
            // 
            // btnSetWhiteColor
            // 
            this.btnSetWhiteColor.BackColor = System.Drawing.Color.White;
            this.btnSetWhiteColor.Location = new System.Drawing.Point(155, 25);
            this.btnSetWhiteColor.Name = "btnSetWhiteColor";
            this.btnSetWhiteColor.Size = new System.Drawing.Size(20, 20);
            this.btnSetWhiteColor.TabIndex = 0;
            this.btnSetWhiteColor.UseVisualStyleBackColor = false;
            this.btnSetWhiteColor.Click += new System.EventHandler(this.setColor);
            // 
            // gpTools
            // 
            this.gpTools.Controls.Add(this.btnSetTextTool);
            this.gpTools.Controls.Add(this.btnSetCyrcleTool);
            this.gpTools.Controls.Add(this.trackBar1);
            this.gpTools.Controls.Add(this.btnSetRectangleTool);
            this.gpTools.Controls.Add(this.btnSetLineTool);
            this.gpTools.Controls.Add(this.btnSetPencilTool);
            this.gpTools.Location = new System.Drawing.Point(391, 32);
            this.gpTools.Name = "gpTools";
            this.gpTools.Size = new System.Drawing.Size(454, 80);
            this.gpTools.TabIndex = 3;
            this.gpTools.TabStop = false;
            this.gpTools.Text = "Tools";
            // 
            // btnSetTextTool
            // 
            this.btnSetTextTool.Location = new System.Drawing.Point(208, 30);
            this.btnSetTextTool.Name = "btnSetTextTool";
            this.btnSetTextTool.Size = new System.Drawing.Size(46, 46);
            this.btnSetTextTool.TabIndex = 6;
            this.btnSetTextTool.Text = "Text";
            this.btnSetTextTool.UseVisualStyleBackColor = true;
            this.btnSetTextTool.Click += new System.EventHandler(this.btnSetTextTool_Click);
            // 
            // btnSetCyrcleTool
            // 
            this.btnSetCyrcleTool.Image = ((System.Drawing.Image)(resources.GetObject("btnSetCyrcleTool.Image")));
            this.btnSetCyrcleTool.Location = new System.Drawing.Point(156, 30);
            this.btnSetCyrcleTool.Name = "btnSetCyrcleTool";
            this.btnSetCyrcleTool.Size = new System.Drawing.Size(46, 46);
            this.btnSetCyrcleTool.TabIndex = 5;
            this.btnSetCyrcleTool.UseVisualStyleBackColor = true;
            this.btnSetCyrcleTool.Click += new System.EventHandler(this.btnSetCyrcleTool_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(261, 30);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(176, 46);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btnSetRectangleTool
            // 
            this.btnSetRectangleTool.Image = ((System.Drawing.Image)(resources.GetObject("btnSetRectangleTool.Image")));
            this.btnSetRectangleTool.Location = new System.Drawing.Point(106, 30);
            this.btnSetRectangleTool.Name = "btnSetRectangleTool";
            this.btnSetRectangleTool.Size = new System.Drawing.Size(46, 46);
            this.btnSetRectangleTool.TabIndex = 2;
            this.btnSetRectangleTool.UseVisualStyleBackColor = true;
            this.btnSetRectangleTool.Click += new System.EventHandler(this.btnSetRectangleTool_Click);
            // 
            // btnSetLineTool
            // 
            this.btnSetLineTool.Image = ((System.Drawing.Image)(resources.GetObject("btnSetLineTool.Image")));
            this.btnSetLineTool.Location = new System.Drawing.Point(56, 30);
            this.btnSetLineTool.Name = "btnSetLineTool";
            this.btnSetLineTool.Size = new System.Drawing.Size(46, 46);
            this.btnSetLineTool.TabIndex = 1;
            this.btnSetLineTool.UseVisualStyleBackColor = true;
            this.btnSetLineTool.Click += new System.EventHandler(this.btnSetLineTool_Click);
            // 
            // btnSetPencilTool
            // 
            this.btnSetPencilTool.Image = ((System.Drawing.Image)(resources.GetObject("btnSetPencilTool.Image")));
            this.btnSetPencilTool.Location = new System.Drawing.Point(6, 30);
            this.btnSetPencilTool.Name = "btnSetPencilTool";
            this.btnSetPencilTool.Size = new System.Drawing.Size(46, 46);
            this.btnSetPencilTool.TabIndex = 0;
            this.btnSetPencilTool.UseVisualStyleBackColor = true;
            this.btnSetPencilTool.Click += new System.EventHandler(this.btnSetPencilTool_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(851, 79);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(116, 33);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.BackgroundImage")));
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(12, 42);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 70);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 24);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(851, 41);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(116, 32);
            this.btnInvert.TabIndex = 7;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 120, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 580);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.gpTools);
            this.Controls.Add(this.gpColor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpColor.ResumeLayout(false);
            this.gpColor.PerformLayout();
            this.gpTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private GroupBox gpColor;
        private Button btnSetBlackColor;
        private Button btnSetGrayColor;
        private Button btnSetBlueColor;
        private Button btnSetCyanColor;
        private Button btnSetLimeColor;
        private Button btnSetYellowColor;
        private Button btnSetOrangeColor;
        private Button btnSetRedColor;
        private Button btnSetWhiteColor;
        private GroupBox gpTools;
        private Button btnSetRectangleTool;
        private Button btnSetLineTool;
        private Button btnSetPencilTool;
        private Button btnSetCustomColor;
        private ColorDialog colorDialog1;
        private Button btnSetGreenColor;
        private TrackBar trackBar1;
        private Button btnSetCyrcleTool;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btnClean;
        private Button btnSetTextTool;
        private Button btnUndo;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button btnInvert;
        private CheckBox cbFillColor;
        private Panel panel1;
    }
}