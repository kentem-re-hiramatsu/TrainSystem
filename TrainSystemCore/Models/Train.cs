using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public abstract class Train
    {
        public string Name { get; protected set; }
        public int Price { get; protected set; }
        public SeatType SeatType { get; }
        public int AdultCount { get; set; }
        public int ChildrenCount { get; set; }

        public Train(int adultCount, int childrenCount, SeatType seatType)
        {
            AdultCount = adultCount;
            ChildrenCount = childrenCount;
            SeatType = seatType;
        }

        public int GetPrice()
        {
            int price = Price + (int)SeatType;
            return price * AdultCount + price / 2 * ChildrenCount;
        }
    }
}