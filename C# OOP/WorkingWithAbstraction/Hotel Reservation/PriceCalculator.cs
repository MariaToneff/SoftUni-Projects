using System;

namespace HotelReservation
{
    public class PriceCalculator
    {
        public PriceCalculator(string[] input)
        {
            this.PricePerDay = double.Parse(input[0]);
            this.NumberOfDays = int.Parse(input[1]);
            this.Season = Enum.Parse<Season>(input[2]);
            this.DiscountType = DiscountType.None;

            if (input.Length > 3)
            {
                this.DiscountType = Enum.Parse<DiscountType>(input[3]);
            }
        }
        public double PricePerDay { get; set; }
        public int NumberOfDays { get; set; }
        public Season Season { get; set; }
        public DiscountType DiscountType { get; set; }
        public double GetTotalPrice()
        {
            var price = this.PricePerDay * this.NumberOfDays * (int)this.Season;
            var totalPrice = price - (price * (int)this.DiscountType / 100);
            return totalPrice;
        }
    }
}
