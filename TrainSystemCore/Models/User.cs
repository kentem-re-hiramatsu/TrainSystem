using System;

namespace TrainSystemCore.Models
{
    public class User
    {
        public string Name { get; set; }
        public int AdultCount { get; set; }
        public int ChildrenCount { get; set; }
        public Train TrainType { get; set; }

        public User(string name, int adultCount, int childrenCount, Train trainType)
        {
            if (adultCount > 0 && childrenCount > 0)
            {
                Name = name;
                AdultCount = adultCount;
                ChildrenCount = childrenCount;
                TrainType = trainType;
            }
            else
            {
                throw new Exception(Consts.INPUT_COUNT_ERROR_MESSAGE);
            }
        }
    }
}