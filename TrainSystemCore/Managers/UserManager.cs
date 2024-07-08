using System.Collections.Generic;
using System.Linq;
using TrainSystemCore.Models;

namespace TrainSystemCore.Managers
{
    public class UserManager
    {
        //メンバ変数
        private List<User> _userDatas = new List<User>();

        //読み込み専用で_userDatasを返す
        public IReadOnlyCollection<User> UserDatas { get { return _userDatas; } }

        //ユーザーのデータ追加
        public void Add(User user)
        {
            _userDatas.Add(user);
        }

        //ユーザーを取得
        public User Get(int index)
        {
            return _userDatas[index];
        }

        //合計金額取得
        public int GetTotalPrice()
        {
            return _userDatas.Sum(x => x.TrainType.GetTrainPrice() * (x.AdultCount + x.ChildrenCount / 2));
        }
    }
}