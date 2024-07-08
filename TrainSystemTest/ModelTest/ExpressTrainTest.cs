using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemTest.ModelTest
{
    [TestClass]
    public class ExpressTrainTest
    {
        //普通座席のテスト
        [TestMethod]
        public void NormalSeatTest()
        {
            var expressTrrain = new LimetedExpressTrain(SeatType.普通);

            Assert.AreEqual(SeatType.普通, expressTrrain.SeatType);

            var trainAndSeatPrice = new LimetedExpressTrain(SeatType.普通).Price + (int)SeatType.普通;

            Assert.AreEqual(trainAndSeatPrice, expressTrrain.GetTrainPrice());
        }

        //指定座席のテスト
        [TestMethod]
        public void SpecifiedSeatTest()
        {
            var expressTrrain = new LimetedExpressTrain(SeatType.指定);

            Assert.AreEqual(SeatType.指定, expressTrrain.SeatType);

            var trainAndSeatPrice = new LimetedExpressTrain(SeatType.指定).Price + (int)SeatType.指定;

            Assert.AreEqual(trainAndSeatPrice, expressTrrain.GetTrainPrice());
        }

        //グリーン指定座席のテスト
        [TestMethod]
        public void GreenSpecifiedSeatTest()
        {
            var expressTrrain = new LimetedExpressTrain(SeatType.グリーン指定);

            Assert.AreEqual(SeatType.グリーン指定, expressTrrain.SeatType);

            var trainAndSeatPrice = new LimetedExpressTrain(SeatType.グリーン指定).Price + (int)SeatType.グリーン指定;

            Assert.AreEqual(trainAndSeatPrice, expressTrrain.GetTrainPrice());
        }
    }
}