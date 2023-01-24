namespace WinFormsTestTask.Entity
{
    internal class DrawAction
    {
        public DrawTool DrawTool { get; set; }
        public List<Line> Lines { get; set; }
        public Point LastPoint { get; set; }
        public Point CurrentPoint { get; set; }
        public string Text { get; set; }
        public bool FillColor { get; set; }
        public Pen Pen { get; set; }
        public int PenThickness { get; set; }
    }
}
