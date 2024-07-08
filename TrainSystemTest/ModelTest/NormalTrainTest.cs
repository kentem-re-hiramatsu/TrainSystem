using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemTest.ModelTest
{
    [TestClass]
    public class NormalTrainTest
    {
        [TestMethod]
        public void NomalSeatTest()
        {
            var normalTrrain = new NormalTrain(2, 3, SeatType.普通);

            Assert.AreEqual(2, normalTrrain.AdultCount);
            Assert.AreEqual(3, normalTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.普通, normalTrrain.SeatType);

            var price = normalTrrain.Price + (int)SeatType.普通;
            var adultPrice = price * normalTrrain.AdultCount;
            var childrenPrice = price / 2 * normalTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, normalTrrain.GetPrice());
        }

        [TestMethod]
        public void SpecifiedSeatTest()
        {
            var normalTrrain = new NormalTrain(2, 3, SeatType.指定);

            Assert.AreEqual(2, normalTrrain.AdultCount);
            Assert.AreEqual(3, normalTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.指定, normalTrrain.SeatType);

            var price = normalTrrain.Price + (int)SeatType.指定;
            var adultPrice = price * normalTrrain.AdultCount;
            var childrenPrice = price / 2 * normalTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, normalTrrain.GetPrice());
        }

        [TestMethod]
        public void GreenSpecifiedSeatTest()
        {
            var normalTrrain = new NormalTrain(2, 3, SeatType.グリーン指定);

            Assert.AreEqual(2, normalTrrain.AdultCount);
            Assert.AreEqual(3, normalTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.グリーン指定, normalTrrain.SeatType);

            var price = normalTrrain.Price + (int)SeatType.グリーン指定;
            var adultPrice = price * normalTrrain.AdultCount;
            var childrenPrice = price / 2 * normalTrrain.ChildrenCount;
            var TotalPrice = adultPrice + childrenPrice;

            Assert.AreEqual(TotalPrice, normalTrrain.GetPrice());
        }
    }
}