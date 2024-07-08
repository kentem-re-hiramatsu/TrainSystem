using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public class ExpressTrain : Train
    {
        //定数
        private const string NAME = "急行列車";
        private const int PRICE = 1500;

        //コンストラクタ
        public ExpressTrain(SeatType seatType) : base(seatType)
        {
            Name = NAME;
            Price = PRICE;
        }
    }
}