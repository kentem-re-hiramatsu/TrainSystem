using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemTest.ModelTest
{
    [TestClass]
    public class NormalTrainTest
    {
        //普通座席のテスト
        [TestMethod]
        public void NomalSeatTest()
        {
            var normalTrrain = new NormalTrain(SeatType.普通);

            Assert.AreEqual(SeatType.普通, normalTrrain.SeatType);

            var trainAndSeatPrice = new NormalTrain(SeatType.普通).Price + (int)SeatType.普通;

            Assert.AreEqual(trainAndSeatPrice, normalTrrain.GetTrainPrice());
        }

        //指定座席のテスト
        [TestMethod]
        public void SpecifiedSeatTest()
        {
            var normalTrrain = new NormalTrain(SeatType.指定);

            Assert.AreEqual(SeatType.指定, normalTrrain.SeatType);

            var trainAndSeatPrice = new NormalTrain(SeatType.指定).Price + (int)SeatType.指定;

            Assert.AreEqual(trainAndSeatPrice, normalTrrain.GetTrainPrice());
        }

        //グリーン指定座席のテスト
        [TestMethod]
        public void GreenSpecifiedSeatTest()
        {
            var normalTrrain = new NormalTrain(SeatType.グリーン指定);

            Assert.AreEqual(SeatType.グリーン指定, normalTrrain.SeatType);

            var trainAndSeatPrice = new NormalTrain(SeatType.グリーン指定).Price + (int)SeatType.グリーン指定;

            Assert.AreEqual(trainAndSeatPrice, normalTrrain.GetTrainPrice());
        }
    }
}