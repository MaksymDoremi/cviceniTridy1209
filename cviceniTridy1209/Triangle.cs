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
            if (triangleInequality(a, b, c))
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                throw new Exception("Triangle inequality doesn't match. Can't create triangle");
            }

        }

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
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
                if (value <= 0)
                {
                    throw new Exception("side C is less than zero");
                }
                c = value;
            }
        }

        private bool triangleInequality(int a, int b, int c)
        {
            //case 1
            if (a + b > c)
            {
                return true;
            }
            //case 2
            else if (a + c > b)
            {
                return true;
            }
            //case 3
            else if (b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool rovnostranny(int a, int b, int c)
        {
            if (a == c && a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool rovnoramenny(int a, int b, int c)
        {
            if (triangleInequality(a, b, c) && //basic triangle inequality
                ((a == b && a != c) || //case 1
                (a == c && a != b) || //case 2
                (b == c && b != a))) //case 3
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool pravouhly(int a, int b, int c)
        {
            if(triangleInequality(a, b, c) && 
                ((Math.Pow(c, 2) == Math.Pow(b,2) + Math.Pow(a, 2)) || //case 1
                (Math.Pow(b, 2) == Math.Pow(c, 2) + Math.Pow(a, 2)) || //case 2
                (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))))  //case 3
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
