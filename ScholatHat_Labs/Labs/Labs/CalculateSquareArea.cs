
using System.ComponentModel.DataAnnotations;

namespace Labs
{
    class CalculateSquareArea
    {
        public CalculateSquareArea() 
        { 
            
        }
    }

    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    class Square : Shape
    {
        double _length;
        double _area;
        double _perimeter;
        int _option;

        public int option 
        {
            get
            { 
                return _option;
            }
            set
            {
                if ((value != 1) && (value != 2))
                {
                    throw new Exception("Invalid Option");
                }
                _option = value;
            }
        }
        public double area
        { get
            {
                return _area;
            } 
        }
        public double perimeter
        {
            get
            {
                return _perimeter;
            }    
        }
        public double length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid Square length");
                }
                _length = value;
            }
        }
        public Square()
        {
            
        }

        public override double CalculateArea() 
        {
            this._area = this.length * this.length; 

            return this.area;
        }

        public override double CalculatePerimeter()
        {
            this._perimeter = 4 * this.length;
            return this.perimeter;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Square square = new Square();
            //
            //calculate area of square
            //Geometrycally size of square are equal
            //So we consider size of square is legnth
            while (true)
            {
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
