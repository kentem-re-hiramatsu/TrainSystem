using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public class NormalTrain : Train
    {
        private const string NAME = "普通列車";
        private const int PRICE = 1000;

        public NormalTrain(int adultCount, int childrenCount, SeatType seatType) : base(adultCount, childrenCount, seatType)
        {
            Name = NAME;
            Price = PRICE;
        }
    }
}