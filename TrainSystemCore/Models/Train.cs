using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public abstract class Train
    {
        //プロパティ
        public string Name { get; protected set; }
        public int Price { get; protected set; }
        public SeatType SeatType { get; }

        //コンストラクタ
        public Train(SeatType seatType)
        {
            SeatType = seatType;
        }

        //電車とシートの合計金額取得
        public int GetTrainPrice()
        {
            return Price + (int)SeatType;
        }
    }
}