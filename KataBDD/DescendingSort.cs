using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    public class DescendingSort : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}
