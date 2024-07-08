using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemTest.ModelTest
{
    [TestClass]
    public class LimetedExpressTrainTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var limetedExpressTrrain = new NormalTrain(2, 3, SeatType.普通);

            Assert.AreEqual(2, limetedExpressTrrain.AdultCount);
            Assert.AreEqual(3, limetedExpressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.普通, limetedExpressTrrain.SeatType);
        }

        [TestMethod]
        public void SpecifiedSeatTest()
        {
            var limetedExpressTrrain = new NormalTrain(2, 3, SeatType.指定);

            Assert.AreEqual(2, limetedExpressTrrain.AdultCount);
            Assert.AreEqual(3, limetedExpressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.指定, limetedExpressTrrain.SeatType);
        }

        [TestMethod]
        public void GreenSpecifiedSeatTest()
        {
            var limetedExpressTrrain = new NormalTrain(2, 3, SeatType.グリーン指定);

            Assert.AreEqual(2, limetedExpressTrrain.AdultCount);
            Assert.AreEqual(3, limetedExpressTrrain.ChildrenCount);
            Assert.AreEqual(SeatType.グリーン指定, limetedExpressTrrain.SeatType);
        }
    }
}