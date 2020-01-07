namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            this.TopLeft = new Point(topLeftX, topLeftY);
            this.BottomRight = new Point(bottomRightX, bottomRightY);
        }

        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public bool Contains(Point point)
        {
            if (point.X >= this.TopLeft.X
                && point.X <= this.BottomRight.X
                && point.Y >= this.TopLeft.Y
                && point.Y <= this.BottomRight.Y)
            {
                return true;
            }

            return false;
        }
    }
}
