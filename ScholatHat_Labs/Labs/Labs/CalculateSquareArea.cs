
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

    }




}
