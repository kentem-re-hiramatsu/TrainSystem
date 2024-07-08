using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public class NormalTrain : Train
    {
        //定数
        private const string NAME = "普通列車";
        private const int PRICE = 1000;

        //コンストラクタ
        public NormalTrain(SeatType seatType) : base(seatType)
        {
            Name = NAME;
            Price = PRICE;
        }
    }
}