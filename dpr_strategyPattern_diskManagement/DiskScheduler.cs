using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpr_strategyPattern_diskManagement
{
    class DiskScheduler
    {
        private static int generatedLength = 15;
        public static int diskSize = 100;
        public List<int> diskQueue;
        public IAlgorithmStrategy algorithmStrategy;

        public List<int> GetDiskQueue()
        {
            return diskQueue;
        }

        public DiskScheduler()
        {
            diskQueue = new List<int>();
        }

        public void AddToQueue(int number)
        {
            diskQueue.Add(number);
        }

        public void GenerateNumbers()
        {
            Random r = new Random();
            for (int i = 0; i < generatedLength; i++)
            {
                AddToQueue(r.Next(0, 100));
            }
        }

        public int AlgorithmGetNext(System.Windows.Forms.TrackBar target)
        {
            if (diskQueue.Count > 0)
            {
                int index = algorithmStrategy.Next(diskQueue, target);
                int removed = diskQueue[index];
                diskQueue.RemoveAt(index);
                return removed;
            }
            return -1;
        }        
    }
}
