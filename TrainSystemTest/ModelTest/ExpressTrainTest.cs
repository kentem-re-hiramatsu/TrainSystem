using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemTest.ModelTest
{
    [TestClass]
    public class ExpressTrainTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var expressTrrain = new NormalTrain(2, 3, SeatType.普通);

            Assert.AreEqual(2, expressTrrain.AdultCount);
            Assert.AreEqual(3, expressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.普通, expressTrrain.SeatType);
        }

        [TestMethod]
        public void SpecifiedSeatTest()
        {
            var expressTrrain = new NormalTrain(2, 3, SeatType.指定);

            Assert.AreEqual(2, expressTrrain.AdultCount);
            Assert.AreEqual(3, expressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.指定, expressTrrain.SeatType);
        }

        [TestMethod]
        public void GreenSpecifiedSeatTest()
        {
            var expressTrrain = new NormalTrain(2, 3, SeatType.グリーン指定);

            Assert.AreEqual(2, expressTrrain.AdultCount);
            Assert.AreEqual(3, expressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.グリーン指定, expressTrrain.SeatType);
        }
    }
}