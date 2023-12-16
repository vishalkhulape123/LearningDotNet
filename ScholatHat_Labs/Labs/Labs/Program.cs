using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Square square = new Square();
            //
            //calculate area of square
            //Geometrycally size of square are equal
            //So we consider size of square is legnth
            while (true) {
                Console.WriteLine("Enter the length of Square");
                square.length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What do you want to calculate?Choose from option ");
                Console.WriteLine("1: Area of Square");
                Console.WriteLine("2: Perimeter of Square");
                square.option = Convert.ToInt32(Console.ReadLine());
                switch (square.option)
                {
                    case 1:
                        square.CalculateArea();
                        Console.WriteLine($"The Area of Square is : {square.area}");
                        break;
                    case 2:
                        square.CalculatePerimeter();
                        Console.WriteLine($"The Perimeter of Square is : {square.perimeter}");
                        break;
                    default:
                        Console.WriteLine("Enter Valid option");
                        break;
                }
                Console.WriteLine("Want to perform again Y/N?");
                if (char.ToUpper(Console.ReadKey().KeyChar) == 'N')
                {
                        break;
                }
                Console.ReadLine();
            }  
            Console.ReadLine();
        }
    }
}