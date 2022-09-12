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

        public Interval(int low, int high)
        {
            if(low > high)
            {
                throw new Exception("Low can't be higher than High");
            }
            this.low = low; 
            this.high = high;
        }

        public int Low
        {
            get
            {
                return low;
            }
            set
            {
               
                if(value < High)
                {
                    low = value;
                }
                else
                {
                    throw new Exception("Low ["+value+"] can't be higher than High");
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
                if (value > Low)
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


        public Interval? prunik(Interval interval2)
        {
            if (this.contains(interval2.Low))
            {
                return new Interval(interval2.Low, this.High);
            }else if (this.contains(interval2.High))
            {
                return new Interval(this.Low, interval2.High);
            }
            else
            {

                return null;
            }
        }

        public override string ToString()
        {
            return "Interval [" + Low +", "+High+"]";
        }

    }
}
