using System.Collections.Generic;
using System.Linq;
using TrainSystemCore.Models;

namespace TrainSystemCore.Managers
{
    public class UserManager
    {
        private List<User> _userDatas = new List<User>();

        public IReadOnlyCollection<User> UserDatas { get { return _userDatas; } }

        public void Add(User user)
        {
            _userDatas.Add(user);
        }

        public User Get(int index)
        {
            return _userDatas[index];
        }

        public int GetTotalPrice()
        {
            return _userDatas.Sum(x => x.TrainType.GetTrainPrice() * (x.AdultCount + x.ChildrenCount / 2));
        }
    }
}