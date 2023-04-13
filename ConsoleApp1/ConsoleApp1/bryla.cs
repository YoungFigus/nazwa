using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class bryla
    {
        protected double h;
        public bryla(double h)
        {
            this.h = h;
        }

        public abstract double PolePodstawy();

        public abstract double PoleBoczne();

        public double PoleCalkowite()
        {
            return 2 * PolePodstawy() + PoleBoczne();
        }

        public double Objetosc()
        {
            return h * PolePodstawy();
        }
    }
}
