using System;

namespace TrainSystemCore.Models
{
    public class User
    {
        //プロパティ
        public string Name { get; set; }
        public int AdultCount { get; set; }
        public int ChildrenCount { get; set; }
        public Train TrainType { get; set; }

        //コンストラクタ
        public User(string name, int adultCount, int childrenCount, Train trainType)
        {
            if (adultCount > -1 && childrenCount > -1)
            {
                Name = name;
                AdultCount = adultCount;
                ChildrenCount = childrenCount;
                TrainType = trainType;
            }
            //入力値が‐１以下の場合エラーを返す
            else
            {
                throw new Exception(Consts.INPUT_COUNT_ERROR_MESSAGE);
            }
        }
    }
}