﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceniTridy1209
{
    internal class Point
    {

        private int pointValue;

        public Point(int pointXY)
        {
            PointValue = pointXY;
        }

        public int PointValue
        {
            get { return pointValue; }
            set { pointValue = value; }
        }

        public int comparePoints(Point point2)
        {
            int high = Math.Max(Math.Abs(this.PointValue), Math.Abs(point2.PointValue));
            int low = Math.Min(Math.Abs(this.PointValue), Math.Abs(point2.PointValue));

            return (high - low);
        }
    }
}