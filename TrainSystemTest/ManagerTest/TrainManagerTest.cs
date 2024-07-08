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
        public void GetTrainTest()
        {
            var trainMana = new TrainManager();
            var seatType = SeatType.普通;

            var normalTrain = trainMana.GetTrain(TrainType.普通列車, seatType);
            var expressTrain = trainMana.GetTrain(TrainType.急行列車, seatType);
            var limetedExpressTrain = trainMana.GetTrain(TrainType.特急列車, seatType);

            Assert.IsTrue(normalTrain is NormalTrain);
            Assert.IsTrue(expressTrain is ExpressTrain);
            Assert.IsTrue(limetedExpressTrain is LimetedExpressTrain);
        }
    }
}