
namespace Coding_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kemo Code*/
            Console.WriteLine("Select:\n 1.CalcArea \n 2.CalcPerimeter");
            var selected =int.Parse( Console.ReadLine());
            var squre = new squre();
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
        }
    }
}
