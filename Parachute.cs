using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    public class Parachute
    {
        public double Cd, V, h, W,area,diameter,shocCord;
        public Atmosphere atmosphere;
        public Parachute(double Cd_,double V_,double h_,double W_,Atmosphere atmosphere_)
        {
            Cd = Cd_;
            V = V_;
            h = h_;
            W = W_;
            atmosphere = atmosphere_;
        }
        public void CalcArea()
        {
            atmosphere.Calc();
            area = (2 * W * 9.1) / (Cd * atmosphere.density * V * V);
        }
        public void CalcDiameter()
        {
            diameter = Math.Sqrt((4*area)/Math.PI);
        }
        public void CalcShockCord()
        {
            shocCord = diameter / 2;
        }
    }
}
