using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Tracker
{
    internal class squre : ISqure
    {
        /* write functions to calculate area and perimeter for squre*/
        public double Calc_Area(float length, float width)
        {
            double area = length * width;
            return area;
        }

        public double Calc_Perimeter(float length, float width)
        {
            double perimeter = length + width;
            return perimeter;
        }
    }
}
