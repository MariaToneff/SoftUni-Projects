using System;

namespace PointInRectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rectangleCoordinates = Console.ReadLine().Split();
            var topLeftX = int.Parse(rectangleCoordinates[0]);
            var topLeftY = int.Parse(rectangleCoordinates[1]);
            var bottomRightX = int.Parse(rectangleCoordinates[2]);
            var bottomRightY = int.Parse(rectangleCoordinates[3]);

            var rectangle = new Rectangle(topLeftX, topLeftY, bottomRightX, bottomRightY);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var pointCoordinates = Console.ReadLine().Split();
                var pointX = int.Parse(pointCoordinates[0]);
                var pointY = int.Parse(pointCoordinates[1]);

                var point = new Point(pointX, pointY);

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
