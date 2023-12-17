
using System.Threading.Channels;

namespace Labs
{
    class SumAllNumbers
    {
        public SumAllNumbers() 
        { 
        
        }

        int _number;
        public int number
        {
            get
            { 
            return _number;
            }
            set
            { 
                if (value < 0)
                {
                    throw new Exception("Invalid Value");
                }
            _number = value;
            }
        }

        public int Sum(int a)
        { 
            int sum = 0;
            //get the right most digit
            do
            {
                sum += a % 10;
                a = a / 10;
            } while (a != 0);

            return sum;
        }

        static void Main()
        { 
            SumAllNumbers sum = new SumAllNumbers();
            Console.WriteLine("Enter number");
            sum.number = Convert.ToInt32(Console.ReadLine());
            int summation = sum.Sum(sum.number);
            Console.WriteLine($"Sum of all numbers is : {summation}");

            Console.Read();                
        }
    }
}
