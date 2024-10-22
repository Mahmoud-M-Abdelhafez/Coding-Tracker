
namespace Coding_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kemo Code*/
            Console.WriteLine("Select:\n 1.CalcArea \n 2.CalcPerimeter");
            var selected = int.Parse(Console.ReadLine());
            var squre = new Squre();
            float width;
            float length;
            float result = 0;
            switch (selected)
            {
                case 1:
                    Console.WriteLine("Enter the width and length:");
                    width = float.Parse(Console.ReadLine());
                    length = float.Parse(Console.ReadLine());
                    result = squre.Calc_Area(length, width);
                    break;
                case 2:
                    Console.WriteLine("Enter the length and width");
                    length = float.Parse(Console.ReadLine());
                    width = float.Parse(Console.ReadLine());
                    result = squre.Calc_Perimeter(length, width);
                    break;
            }
            Console.WriteLine($"The result is equal to:{result}");




            /*Mahmoud Code*/

            double Base = 0, height = 0 , area = 0 , perimeter=0;
            Console.WriteLine("please, Enter Base of Triangle : ");
            Base = float.Parse(Console.ReadLine());
            Console.WriteLine("please, Enter height of Triangle : ");
            height = float.Parse(Console.ReadLine());
            CalcFunctions calcFunctions = new CalcFunctions();
            area= calcFunctions.TriangleArea(Base, height);
            Console.WriteLine(area);
            double X=0 , y=0 , Z=0 ;
            Console.WriteLine("please, Enter Length of X : ");
            X = float.Parse(Console.ReadLine());
            Console.WriteLine("please, Enter Length of Y : ");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("please, Enter Length of Z : ");
            Z = float.Parse(Console.ReadLine());
            perimeter = calcFunctions.TrianglePerimeter(X, y, Z);
            Console.WriteLine(perimeter);



        }
    }
}
