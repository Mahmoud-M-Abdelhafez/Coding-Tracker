using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Tracker
{
    internal class Squre : ISqure
    {
        /* write functions to calculate area and perimeter for squre*/
        public float Calc_Area(float length, float width)
        {
            float area = length * width;
            return area;
        }

        public float Calc_Perimeter(float length, float width)
        {
            float perimeter = length + width;
            return perimeter;
        }
    }
}
