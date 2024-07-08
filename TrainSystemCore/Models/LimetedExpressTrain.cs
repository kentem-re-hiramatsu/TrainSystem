using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public class LimetedExpressTrain : Train
    {
        private const string NAME = "特急列車";
        private const int PRICE = 2000;

        public LimetedExpressTrain(int adultCount, int childrenCount, SeatType seatType) : base(adultCount, childrenCount, seatType)
        {
            Name = NAME;
            Price = PRICE;
        }
    }
}