using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainSystemCore.Enums;
using TrainSystemCore.Managers;
using TrainSystemCore.Models;

namespace TrainSystemTest.ManagerTest
{
    [TestClass]
    public class TrainManagerTest
    {
        [TestMethod]
        public void AddTest()
        {
            var trainMana = new TrainManager();

            var normalTrain = new NormalTrain(2, 5, SeatType.普通);
            var expressTrain = new ExpressTrain(1, 2, SeatType.指定);

            Assert.AreEqual(0, trainMana.TrainDatas.Count);

            trainMana.Add(normalTrain);
            trainMana.Add(expressTrain);

            Assert.AreEqual(2, trainMana.TrainDatas.Count);

            Assert.IsTrue(trainMana.Get(0) is NormalTrain);
            Assert.AreEqual(2, normalTrain.AdultCount);
            Assert.AreEqual(5, normalTrain.ChildrenCount);
            Assert.AreEqual(SeatType.普通, normalTrain.SeatType);

            Assert.IsTrue(trainMana.Get(1) is ExpressTrain);
            Assert.AreEqual(1, expressTrain.AdultCount);
            Assert.AreEqual(2, expressTrain.ChildrenCount);
            Assert.AreEqual(SeatType.指定, expressTrain.SeatType);
        }

        [TestMethod]
        public void GetTotalPriceTest()
        {
            var trainMana = new TrainManager();

            var normalTrain = new NormalTrain(2, 5, SeatType.普通);
            var expressTrain = new ExpressTrain(1, 2, SeatType.指定);

            trainMana.Add(normalTrain);
            trainMana.Add(expressTrain);

            var normalTrainPrice = 1000;
            var normalSeatPrice = 0;
            var normalTrainAdultPrice = (normalTrainPrice + normalSeatPrice) * 2;
            var normalTrainChildrenPrice = (normalTrainPrice + normalSeatPrice) / 2 * 5;

            var expressTrainPrice = 1500;
            var SpecifiedSeatPrice = 200;
            var expressTrainAdultPrice = (expressTrainPrice + SpecifiedSeatPrice) * 1;
            var expressTrainChildrenPrice = (expressTrainPrice + SpecifiedSeatPrice) / 2 * 2;

            var TotalPrice = normalTrainAdultPrice + normalTrainChildrenPrice + expressTrainAdultPrice + expressTrainChildrenPrice;

            Assert.AreEqual(TotalPrice, trainMana.GetTotalPrice());
        }
    }
}