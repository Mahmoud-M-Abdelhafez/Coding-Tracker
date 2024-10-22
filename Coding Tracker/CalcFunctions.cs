using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Tracker
{
    internal class CalcFunctions : ICalcFunctions
    {
        public double TriangleArea(double Base, double height)
        {
            return(((0.5)*Base) + height);
        }

        public double TrianglePerimeter(double x, double y, double z)
        {
            return(x+y+z);
        }
    }
}
