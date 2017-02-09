using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpr_strategyPattern_diskManagement
{
    class FIFOStrategy : IAlgorithmStrategy
    {
        public int Next(List<int> diskQueue)
        {
            return 0;
        }
    }
}
