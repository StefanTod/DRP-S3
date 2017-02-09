using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpr_strategyPattern_diskManagement
{
    class SSTFStrategy : IAlgorithmStrategy
    {
        private int position;

        public SSTFStrategy(int position)
        {
            this.position = position;
        }

        public int Next(List<int> diskQueue)
        {
            int shortestDist = 10000000;
            int indexOfShortest = 0;

            for (int i = 0; i < diskQueue.Count; i++)
            {
                int distance;
                if (diskQueue[i] > position)
                    distance = diskQueue[i] - position;
                else
                    distance = position - diskQueue[i];
                if (distance < shortestDist)
                {
                    shortestDist = distance;
                    indexOfShortest = i;
                }
            }
            position = diskQueue[indexOfShortest];

            return indexOfShortest;
        }
    }
}
