using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public class ExpressTrain : Train
    {
        private const string NAME = "急行列車";
        private const int PRICE = 1500;

        public ExpressTrain(SeatType seatType) : base(seatType)
        {
            Name = NAME;
            Price = PRICE;
        }
    }
}