﻿using TrainSystemCore.Enums;

namespace TrainSystemCore.Models
{
    public class LimetedExpressTrain : Train
    {
        //定数
        private const string NAME = "特急列車";
        private const int PRICE = 2000;

        //コンストラクタ
        public LimetedExpressTrain(SeatType seatType) : base(seatType)
        {
            Name = NAME;
            Price = PRICE;
        }
    }
}