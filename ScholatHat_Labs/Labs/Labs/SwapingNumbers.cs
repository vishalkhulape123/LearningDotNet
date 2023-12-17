
namespace Labs
{
    class SwapingNumbers
    {
        public SwapingNumbers() 
        { 
        
        }

        int _number1;
        int _number2;
        int _number3;

        public int number1
        {
            get
            { 
                return _number1;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value");
                }
                _number1 = value;
            }
        }
        public int number2
        {
            get
            {
                return _number2;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value");
                }
                _number2 = value;
            }
        }
        public int number3
        {
            get
            {
                return _number3;
            }
            set
            {   if (value < 0)
                {
                    throw new Exception("Invalid value");
                }
                _number3 = value;
            }
        }

        public void SwapingNumberByTemp()
        { 
           //number1 = a;  //10
           //number2 = b;  //20
            //Console.WriteLine($"Before swaping number1 = {number1} number2 = {number2}");
            //number3 = c;

            number3 = number1; //10           
            number1 = number2; //20
            number2 = number3; //10

           // Console.WriteLine($"After swaping number1 = {number1} number2 = {number2}");
        }

        public void SwapingNumber()
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
        }

        public void SwapingNum()
        {
            number1 = number1 ^ number2;
            number2 = number1 ^ number2;
            number1 = number1 ^ number2;
        }



        static void Main()
        {
            SwapingNumbers swapNum = new SwapingNumbers();
            Console.WriteLine("Enter Numbers to swap");
            swapNum.number1 = Convert.ToInt32(Console.ReadLine());
            swapNum.number2 = Convert.ToInt32(Console.ReadLine());
            //swapNum.number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swaping number1 = {swapNum.number1} number2 = {swapNum.number2}");
            swapNum.SwapingNumberByTemp();
            Console.WriteLine($"After swaping by third variable number1 = {swapNum.number1} number2 = {swapNum.number2}");
            swapNum.SwapingNumber();
            Console.WriteLine($"After swaping by arithmetic operation number1 = {swapNum.number1} number2 = {swapNum.number2}");
            swapNum.SwapingNum();
            Console.WriteLine($"After swaping by logical operation number1 = {swapNum.number1} number2 = {swapNum.number2}");

            Console.ReadLine();
        }
    }
}
