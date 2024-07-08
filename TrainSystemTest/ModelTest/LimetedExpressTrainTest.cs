using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var limetedExpressTrrain = new LimetedExpressTrain(SeatType.普通);

            Assert.AreEqual(SeatType.普通, limetedExpressTrrain.SeatType);

            var trainAndSeatPrice = new LimetedExpressTrain(SeatType.普通).Price + (int)SeatType.普通;

            Assert.AreEqual(trainAndSeatPrice, limetedExpressTrrain.GetTrainPrice());
        }

        [TestMethod]
        public void SpecifiedSeatTest()
        {
            var limetedExpressTrrain = new LimetedExpressTrain(SeatType.指定);

            Assert.AreEqual(SeatType.指定, limetedExpressTrrain.SeatType);

            var trainAndSeatPrice = new LimetedExpressTrain(SeatType.指定).Price + (int)SeatType.指定;

            Assert.AreEqual(trainAndSeatPrice, limetedExpressTrrain.GetTrainPrice());
        }

        [TestMethod]
        public void GreenSpecifiedSeatTest()
        {
            var limetedExpressTrrain = new LimetedExpressTrain(SeatType.グリーン指定);

            Assert.AreEqual(SeatType.グリーン指定, limetedExpressTrrain.SeatType);

            var trainAndSeatPrice = new LimetedExpressTrain(SeatType.グリーン指定).Price + (int)SeatType.グリーン指定;

            Assert.AreEqual(trainAndSeatPrice, limetedExpressTrrain.GetTrainPrice());
        }
    }
}