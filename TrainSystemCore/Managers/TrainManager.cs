using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemCore.Managers
{
    public class TrainManager
    {
        //電車の取得
        public Train GetTrain(TrainType trainType, SeatType seatType)
        {
            switch (trainType)
            {
                case TrainType.普通列車:
                    return new NormalTrain(seatType);
                case TrainType.急行列車:
                    return new ExpressTrain(seatType);
                case TrainType.特急列車:
                    return new LimetedExpressTrain(seatType);
                default: return null;
            }
        }
    }
}