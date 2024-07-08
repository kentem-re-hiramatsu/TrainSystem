using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainSystemCore.Enums;
using TrainSystemCore.Managers;
using TrainSystemCore.Models;

namespace TrainSystemTest.ManagerTest
{
    [TestClass]
    public class UserManagerTest
    {
        //ユーザーの追加テスト
        [TestMethod]
        public void AddTest()
        {
            var userMana = new UserManager();
            var train = new NormalTrain(SeatType.指定);

            var tarou = new User("太郎", 3, 2, train);
            var zirou = new User("次郎", 5, 1, train);

            Assert.AreEqual(0, userMana.UserDatas.Count);

            userMana.Add(tarou);
            userMana.Add(zirou);

            Assert.AreEqual(2, userMana.UserDatas.Count);

            Assert.AreEqual("太郎", userMana.Get(0).Name);
            Assert.AreEqual(3, userMana.Get(0).AdultCount);
            Assert.AreEqual(2, userMana.Get(0).ChildrenCount);
            Assert.AreEqual(SeatType.指定, userMana.Get(0).TrainType.SeatType);

            Assert.AreEqual("次郎", userMana.Get(1).Name);
            Assert.AreEqual(5, userMana.Get(1).AdultCount);
            Assert.AreEqual(1, userMana.Get(1).ChildrenCount);
            Assert.AreEqual(SeatType.指定, userMana.Get(1).TrainType.SeatType);
        }

        //合計金額のテスト
        [TestMethod]
        public void GetTotalPriceTest()
        {
            var userMana = new UserManager();
            var train = new NormalTrain(SeatType.指定);

            var tarou = new User("太郎", 3, 2, train);
            var zirou = new User("次郎", 5, 1, train);

            userMana.Add(tarou);
            userMana.Add(zirou);

            var tarouTotalPrice = (new NormalTrain(SeatType.指定).Price + (int)SeatType.指定) * (3 + 2 / 2);
            var zirouTotalPrice = (new NormalTrain(SeatType.指定).Price + (int)SeatType.指定) * (5 + 1 / 2);
            var totalPrice = tarouTotalPrice + zirouTotalPrice;

            Assert.AreEqual(totalPrice, userMana.GetTotalPrice());
        }
    }
}