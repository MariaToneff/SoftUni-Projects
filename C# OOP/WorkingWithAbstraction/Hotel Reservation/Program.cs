using System;

namespace HotelReservation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var priceCalculator = new PriceCalculator(input);

            var result = priceCalculator.GetTotalPrice();

            Console.WriteLine($"{result:F2}");
        }
    }
}
