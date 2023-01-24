namespace WinFormsTestTask.Entity
{
    internal class Line
    {
        public Line(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
    }
}
