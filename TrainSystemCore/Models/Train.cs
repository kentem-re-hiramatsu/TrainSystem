using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public abstract class Train
    {
        public string Name { get; protected set; }
        public int Price { get; protected set; }
        public SeatType SeatType { get; }

        public Train(SeatType seatType)
        {
            SeatType = seatType;
        }

        public int GetTrainPrice()
        {
            return Price + (int)SeatType;
        }
    }
}