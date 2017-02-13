using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpr_strategyPattern_diskManagement
{
    interface IAlgorithmStrategy
    {
        /// <summary>
        /// According to algorithm finds index of next number
        /// </summary>
        /// <param name="positionIndex"></param>
        /// <returns>index of next number, case list is empty returns -1</returns>
        int Next(List<int> diskQueue, System.Windows.Forms.TrackBar tracBar);
    }
}
