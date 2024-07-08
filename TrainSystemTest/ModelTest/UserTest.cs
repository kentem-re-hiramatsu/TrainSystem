using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainSystemCore.Enums;
using TrainSystemCore.Models;

namespace TrainSystemTest.ModelTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var train = new NormalTrain(SeatType.普通);
            var user = new User("太郎", 3, 2, train);

            Assert.AreEqual("太郎", user.Name);
            Assert.AreEqual(3, user.AdultCount);
            Assert.AreEqual(2, user.ChildrenCount);
            Assert.IsTrue(user.TrainType is NormalTrain);
            Assert.AreEqual(SeatType.普通, user.TrainType.SeatType);

            Assert.ThrowsException<Exception>(() => new User("太郎", 0, 2, train));
            Assert.ThrowsException<Exception>(() => new User("太郎", -1, 2, train));

            Assert.ThrowsException<Exception>(() => new User("太郎", 2, 0, train));
            Assert.ThrowsException<Exception>(() => new User("太郎", 2, -1, train));
        }
    }
}