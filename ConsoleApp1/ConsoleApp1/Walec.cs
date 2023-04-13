using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Walec : bryla
    {
        private double r;

        public Walec(double r, double h) : base(h)
        { 
        this.r = r;
        }
        public override double PolePodstawy()
        {
            return Math.PI * r * r;
        }

        public override double PoleBoczne()
        {
            return 2 * Math.PI * r * h;
        }
    }
}
