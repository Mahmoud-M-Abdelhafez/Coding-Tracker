namespace Coding_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kemo Code*/


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
