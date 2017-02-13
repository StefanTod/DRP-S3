using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dpr_strategyPattern_diskManagement
{
    class FIFOStrategy : IAlgorithmStrategy
    {
        Random rand = new Random();

        public int Next(List<int> diskQueue, TrackBar tracBar)
        {
            diskQueue.Add(rand.Next(0, 100));
            return 0;
        }
    }
}
