using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemTest.ModelTest
{
    [TestClass]
    public class ExpressTrainTest
    {
        [TestMethod]
        public void NormalSeatTest()
        {
            var expressTrrain = new ExpressTrain(2, 3, SeatType.普通);

            Assert.AreEqual(2, expressTrrain.AdultCount);
            Assert.AreEqual(3, expressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.普通, expressTrrain.SeatType);

            var price = expressTrrain.Price + (int)SeatType.普通;
            var adultPrice = price * expressTrrain.AdultCount;
            var childrenPrice = price / 2 * expressTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, expressTrrain.GetPrice());
        }

        [TestMethod]
        public void SpecifiedSeatTest()
        {
            var expressTrrain = new ExpressTrain(2, 3, SeatType.指定);

            Assert.AreEqual(2, expressTrrain.AdultCount);
            Assert.AreEqual(3, expressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.指定, expressTrrain.SeatType);

            var price = expressTrrain.Price + (int)SeatType.指定;
            var adultPrice = price * expressTrrain.AdultCount;
            var childrenPrice = price / 2 * expressTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, expressTrrain.GetPrice());
        }

        [TestMethod]
        public void GreenSpecifiedSeatTest()
        {
            var expressTrrain = new ExpressTrain(2, 3, SeatType.グリーン指定);

            Assert.AreEqual(2, expressTrrain.AdultCount);
            Assert.AreEqual(3, expressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.グリーン指定, expressTrrain.SeatType);

            var price = expressTrrain.Price + (int)SeatType.グリーン指定;
            var adultPrice = price * expressTrrain.AdultCount;
            var childrenPrice = price / 2 * expressTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, expressTrrain.GetPrice());
        }

        [TestMethod]
        public void InputErrorTest()
        {
            var expressTrain = new ExpressTrain(1, 1, SeatType.グリーン指定);

            Assert.AreEqual(1, expressTrain.AdultCount);
            Assert.AreEqual(1, expressTrain.ChildrenCount);

            Assert.ThrowsException<Exception>(() => new ExpressTrain(0, 3, SeatType.グリーン指定));
            Assert.ThrowsException<Exception>(() => new ExpressTrain(-1, 3, SeatType.グリーン指定));

            Assert.ThrowsException<Exception>(() => new ExpressTrain(3, 0, SeatType.グリーン指定));
            Assert.ThrowsException<Exception>(() => new ExpressTrain(3, -1, SeatType.グリーン指定));
        }
    }
}