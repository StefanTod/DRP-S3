using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dpr_strategyPattern_diskManagement
{
    class ScanStrategy : IAlgorithmStrategy
    {
        enum Direction { UP, DOWN }
        private int position;
        private int diskSize;
        private Direction direction = Direction.UP;

        public ScanStrategy(int startPosition, int diskSize)
        {
            this.position = startPosition;
            this.diskSize = diskSize;
        }

        private int Do(List<int> queue, int pos)
        {
            for (int i = 0; i < queue.Count; i++)
            {
                if (queue[i] == position)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Next(List<int> diskQueue, TrackBar tracBar)
        {
            int index;
            while (true)
            {
                if (direction == Direction.UP)
                {
                    // if we get to edge turn around
                    if (diskSize == position)
                    {
                        position--;
                        direction = Direction.DOWN;
                    }
                    else
                        position++;
                }
                else
                {
                    // if get to edge turn around
                    if (0 == position)
                    {
                        position++;
                        direction = Direction.UP;
                    }
                    else
                        position--;
                }
                index = Do(diskQueue, position);
                if (index != -1)
                    return index;
                AnimateNext(tracBar);
            }
        }

        public void AnimateNext(TrackBar target)
        {
            target.Value = position;
            target.Invalidate();
        }

        //public int Next(List<int> diskQueue)
        //{
        //    int index = -1;
        //    // 1. do we need to move somewhere
        //    if (direction == Direction.UP)
        //    {
        //        // is there something up
        //    }

        //    if (direction == Direction.UP)
        //    {
        //        //TODO
        //        GetIndexOfClosestUP(diskQueue);
        //    }
        //    else
        //    {
        //        //TODO
        //        GetIndexOfClosestDown(diskQueue);

        //    }
        //    return indexSmallestDist;
        //}

        //private bool Up(List<int> queue)
        //{
        //    foreach (int item in queue)
        //    {
        //        if (position < item)
        //            return true;
        //    }
        //    return false;
        //}

        //private bool Down(List<int> queue)
        //{
        //    foreach (int item in queue)
        //    {
        //        if (position > item)
        //            return true;
        //    }
        //    return false;
        //}

        //private int GetIndexOfClosestUP(List<int> queue)
        //{
        //    int smallestDist = 1000000;
        //    int distance;
        //    int index = 0;

        //    for (int i = 0; i < queue.Count; i++)
        //    {
        //        if (queue[i] > position)
        //        {
        //            distance = queue[i] - position;
        //            if (distance < smallestDist)
        //            {
        //                smallestDist = distance;
        //                index = i;
        //            }
        //        }
        //    }
        //    return index;
        //}

        //private int GetIndexOfClosestDown(List<int> queue)
        //{
        //    int smallestDist = 1000000;
        //    int distance;
        //    int index = 0;

        //    for (int i = 0; i < queue.Count; i++)
        //    {
        //        if (queue[i] < position)
        //        {
        //            distance = position - queue[i];
        //            if (distance < smallestDist)
        //            {
        //                smallestDist = distance;
        //                index = i;
        //            }
        //        }
        //    }
        //    return index;
        //}
    }
}
