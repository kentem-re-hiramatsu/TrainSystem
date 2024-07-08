using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemTest.ModelTest
{
    [TestClass]
    public class LimetedExpressTrainTest
    {
        [TestMethod]
        public void NormalSeatTest()
        {
            var limetedExpressTrrain = new LimetedExpressTrain(2, 3, SeatType.普通);

            Assert.AreEqual(2, limetedExpressTrrain.AdultCount);
            Assert.AreEqual(3, limetedExpressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.普通, limetedExpressTrrain.SeatType);

            var price = limetedExpressTrrain.Price + (int)SeatType.普通;
            var adultPrice = price * limetedExpressTrrain.AdultCount;
            var childrenPrice = price / 2 * limetedExpressTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, limetedExpressTrrain.GetPrice());
        }

        [TestMethod]
        public void SpecifiedSeatTest()
        {
            var limetedExpressTrrain = new LimetedExpressTrain(2, 3, SeatType.指定);

            Assert.AreEqual(2, limetedExpressTrrain.AdultCount);
            Assert.AreEqual(3, limetedExpressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.指定, limetedExpressTrrain.SeatType);

            var price = limetedExpressTrrain.Price + (int)SeatType.指定;
            var adultPrice = price * limetedExpressTrrain.AdultCount;
            var childrenPrice = price / 2 * limetedExpressTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, limetedExpressTrrain.GetPrice());
        }

        [TestMethod]
        public void GreenSpecifiedSeatTest()
        {
            var limetedExpressTrrain = new LimetedExpressTrain(2, 3, SeatType.グリーン指定);

            Assert.AreEqual(2, limetedExpressTrrain.AdultCount);
            Assert.AreEqual(3, limetedExpressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.グリーン指定, limetedExpressTrrain.SeatType);

            var price = limetedExpressTrrain.Price + (int)SeatType.グリーン指定;
            var adultPrice = price * limetedExpressTrrain.AdultCount;
            var childrenPrice = price / 2 * limetedExpressTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, limetedExpressTrrain.GetPrice());
        }

        [TestMethod]
        public void InputErrorTest()
        {
            var expressTrain = new LimetedExpressTrain(1, 1, SeatType.グリーン指定);

            Assert.AreEqual(1, expressTrain.AdultCount);
            Assert.AreEqual(1, expressTrain.ChildrenCount);

            Assert.ThrowsException<Exception>(() => new LimetedExpressTrain(0, 3, SeatType.グリーン指定));
            Assert.ThrowsException<Exception>(() => new LimetedExpressTrain(-1, 3, SeatType.グリーン指定));

            Assert.ThrowsException<Exception>(() => new LimetedExpressTrain(3, 0, SeatType.グリーン指定));
            Assert.ThrowsException<Exception>(() => new LimetedExpressTrain(3, -1, SeatType.グリーン指定));
        }
    }
}