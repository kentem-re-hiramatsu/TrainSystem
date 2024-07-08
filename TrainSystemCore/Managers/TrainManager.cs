using System.Collections.Generic;
using System.Linq;
using TrainSystemCore.Models;

namespace TrainSystemCore.Managers
{
    public class TrainManager
    {
        private List<Train> _trainDatas = new List<Train>();

        public IReadOnlyCollection<Train> TrainDatas { get { return _trainDatas; } }

        public void Add(Train train)
        {
            _trainDatas.Add(train);
        }

        public Train Get(int index)
        {
            return _trainDatas[index];
        }

        public int GetTotalPrice()
        {
            return _trainDatas.Sum(x => x.GetPrice());
        }
    }
}