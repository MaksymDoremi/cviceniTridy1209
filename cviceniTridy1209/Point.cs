using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceniTridy1209
{
    internal class Point
    {

        private int pointValue;

        public Point(int pointValue)
        {
            PointValue = pointValue;
        }

        public int PointValue
        {
            get { return pointValue; }
            set { pointValue = value; }
        }

        public int lengthBetween(Point point2)
        {
            int high = Math.Max(this.PointValue, point2.PointValue);
            int low = Math.Min(this.PointValue, point2.PointValue);

            return (high - low);
        }
    }
}
