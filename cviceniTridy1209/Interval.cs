using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceniTridy1209
{
    internal class Interval
    {
        private int low;
        private int high;

        public int Low
        {
            get
            {
                return low;
            }
            set
            {
                if (value <= high)
                {
                    low = value;
                }
                else
                {
                    throw new Exception("Low can't be higher than High");
                }

            }
        }

        public int High
        {
            get
            {
                return high;
            }

            set
            {
                if (value >= low)
                {
                    high = value;
                }
                else
                {
                    throw new Exception("High can't be lower than Low");
                }
            }
        }

        public bool contains(int a)
        {
            if (a <= high || a >= low)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

    }
}
