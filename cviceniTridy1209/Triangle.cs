using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceniTridy1209
{
    internal class Triangle
    {

        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("side A is less than zero");
                }
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                   throw new Exception("side B is less than zero");
                }
                b = value;

            }
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("side C is less than zero");
                }
                c = value;
            }
        }

        private bool triangleInequality(int a, int b, int c)
        {
            if (a + b > c)
            {
                return true;
            }
            else if (a + c > b)
            {
                return true;
            }
            else if (b + c > a)
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
