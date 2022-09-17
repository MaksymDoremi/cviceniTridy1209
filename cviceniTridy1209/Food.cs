using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceniTridy1209
{
    internal class Food
    {
        private string name;
        private double weight;
        private double kJ;
        private double kCal;


        public Food(string name, double weight, double kJ, double kCal)
        {
            Name = name;
            Weight = weight;
            KJ = kJ;
            KCal = kCal;
        }

        public Food(string name, double weight, double kJ)
        {
            Name = name;
            Weight = weight;
            KJ = kJ;
            KCal = KJtoKCal(kJ);
        }

      

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Weight can't be less than zero");
                }
                weight = value;
            }
        }

        public double KJ
        {
            get { return kJ; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("KJ can't be less than zero");
                }
                kJ = value;
            }
        }

        public double KCal
        {
            get { return kCal; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("KCal can't be less than zero");
                }
            }
        }

        public double KJtoKCal(double kJ)
        {
            return kJ * 0.239006;
        }
    }
}
