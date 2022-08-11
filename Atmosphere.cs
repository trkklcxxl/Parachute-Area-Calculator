using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    public class Atmosphere
    {
        public double h, T, P, density;
        public Atmosphere (double h_)
        {
            h = h_;
        }
        public void Calc()
        {
            if (h>25000)//upper stratosphere
            {
                T = -131.21 + (0.00299 * h);
                P=2.488 * Math.Pow(((T + 273.1) / 216.6),-11.388);
                density = P / (0.2869 * (T + 273.1));
            }
            if (h>11000 && h<25000 )//Lover stratosphere
            {
                T = -56.46;
                P = 22.65 * Math.Pow(Math.E,(1.73-0.000157*h));
                density = P / (0.2869 * (T + 273.1));
            }
            if (h<11000)//Troposphere
            {
                T = 15.04 - 0.00649 * h;
                P = 101.29 * Math.Pow(((T + 273.1) / 288.08), 5.256);
                density = P / (0.2869 * (T + 273.1));
            }
        }
    }
}
