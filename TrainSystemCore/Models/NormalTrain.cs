using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public class NormalTrain : Train
    {
        private const string NAME = "普通列車";
        private const int PRICE = 1000;

        public NormalTrain(SeatType seatType) : base(seatType)
        {
            Name = NAME;
            Price = PRICE;
        }
    }
}