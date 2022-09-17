using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceniTridy1209
{
    internal class Primka
    {
        private Point start;
        private Point end;

        public Primka(Point point, Point end)
        {
            this.start = point;
            this.end = end;
        }

        public Point Start
        {
            get { return start; }
            set
            {
                start = value;
            }
        }

        public Point End
        {
            get { return end; }
            set
            {
                end = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < start.lengthBetween(end); i++)
            {
                result.Append("*");
            }
            return result.ToString();
        }
    }
}
