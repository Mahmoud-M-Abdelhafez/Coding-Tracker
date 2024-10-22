
namespace Coding_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Run=true;
            while (Run)
            {
                Console.WriteLine("Select Shape:\n 1.Square \n 2.Triangle \n 3.Exit");
                var Option = int.Parse(Console.ReadLine());

                switch (Option)
                {
                    case 1:
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
                                Console.WriteLine($"Area of Square = {result}");
                                break;
                            case 2:
                                Console.WriteLine("Enter the length and width");
                                length = float.Parse(Console.ReadLine());
                                width = float.Parse(Console.ReadLine());
                                result = squre.Calc_Perimeter(length, width);
                                Console.WriteLine($"Perimeter of Square = {result}");
                                break;
                            default:
                                Console.WriteLine("ERROR, Please Enter 1 or 2 !!!!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Select:\n 1.CalcArea \n 2.CalcPerimeter");
                        var Select = int.Parse(Console.ReadLine());
                        CalcFunctions calcFunctions = new CalcFunctions();
                        double Base = 0, height = 0, area = 0, perimeter = 0;
                        switch (Select)
                        {
                            case 1:
                                Console.WriteLine("please, Enter Base of Triangle : ");
                                Base = float.Parse(Console.ReadLine());
                                Console.WriteLine("please, Enter height of Triangle : ");
                                height = float.Parse(Console.ReadLine());
                                area = calcFunctions.TriangleArea(Base, height);
                                Console.WriteLine($"Area of Triangle = {area}");
                                break;
                            case 2:
                                double X = 0, y = 0, Z = 0;
                                Console.WriteLine("please, Enter Length of X , Y , Z : ");
                                X = float.Parse(Console.ReadLine());
                                y = float.Parse(Console.ReadLine());
                                Z = float.Parse(Console.ReadLine());
                                perimeter = calcFunctions.TrianglePerimeter(X, y, Z);
                                Console.WriteLine($"Perimeter of Triangle = {perimeter}");
                                break;
                            default:
                                Console.WriteLine("ERROR, Please Enter 1 or 2 !!!!");
                                break;
                        }
                        break;

                    case 3:
                        Run = false;
                        break;

                    default:
                        Console.WriteLine("ERROR, Please Enter 1 or 2 !!!!");
                        break;
                }
            }
            


            

            





        }
    }
}
