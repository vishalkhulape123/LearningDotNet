
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;

namespace Labs
{
    class SmallProrams
    {
        static void Main()
        {
            SmallProrams sp = new SmallProrams();
            Char c = Console.ReadKey().KeyChar;
            if (sp.IsAlphabet(c))
            {
                Console.WriteLine("Entered character is an Alphabet");
            } else
            {
                Console.WriteLine("Entered character is not an Alphabet");
            }

          // if(sp.IsVowel(c))
            {
                Console.WriteLine("Entered character is Vowel");
            }
          // else
            {

                Console.WriteLine("Entered character is Consonent");
            }
            int num = Convert.ToInt32(Console.ReadLine());
            if (sp.IsEven(num))
            {
                Console.WriteLine("Entered number is Even");
            }
            else
            {
                Console.WriteLine("Entered number is ODD");
            }
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (sp.IsPositive(num1)) 
            {
                Console.WriteLine("Entered number is Positive");                    
            }
            else
            {
                Console.WriteLine("Entered number is Negative");
            }
            int element,max;
            Console.WriteLine("Enter array element size");
            element = Convert.ToInt32(Console.ReadLine());
            int[] inarr = new int[element];
            Console.WriteLine("Enter array element ");
            for (int i = 0;i<element;i++)
            {
                inarr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = sp.MaxNum(inarr);
            Console.WriteLine($"Largest number from array is : {max}");

            Console.WriteLine("Enter Fibo Series length");
            int fib = Convert.ToInt32(Console.ReadLine());
            sp.PrintFiboSeries(fib);
            Console.WriteLine("Enter number to find its factorial");
            int fact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {fact} = {sp.Factorial(fact)} ");
            Console.ReadKey();
        }

        public void PrintFiboSeries(int fibLength)
        {
            // 0,1,1,2,3,5,
            int first = 0;
            int second = 1;
            int next = first + second;
            if ((fibLength == 0) || (fibLength == 1))
            {
                Console.Write($"{first} ");
            }
            else
            {
                Console.Write($"{first},{second} ");
            }
            for (int i = 2; i < fibLength; i++)
                {                
                next = first + second;                  
                   
                Console.Write($"{next},");
                first = second;
                second = next;
            }           

        }
        public bool IsLeapYear(int year)
        {
            bool result = false;
            if ( ((year % 4 == 0) && ( year % 100 != 0)) || (year % 400 == 0) )
            {
                result = true;
            }
            return result;
        }
        public int MaxNum(int[] arr)
        {
            int max = arr[0];            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }                
            }
            return max;
        }

        public bool IsAlphabet(Char character)
        {
            if ((character >= 'a' &&  character <= 'z') || (character <= 'A' && character >= 'Z'))
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEven(int num)
        {
            if (num % 2 != 0) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsVowel(Char character) 
        {
            if ((char.ToUpper(character) == 'A') || (char.ToUpper(character) == 'E') || (char.ToUpper(character) == 'I') || (char.ToUpper(character) == 'O') || (char.ToUpper(character) == 'U'))
            {
                return true;
            }
            else
            {
                if (((int)character >= 65) && ((int)character <= 97))
                {
                    return false;
                }
                else
                {
                    throw new Exception("Invalid Input");
                }
            }
        }

        public bool IsPositive(int num)
        {
            if (num < 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public int MaxNum(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public int Factorial(int num)
        {
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
