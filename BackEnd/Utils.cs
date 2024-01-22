
namespace BackEnd
{
    class Utils
    {
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
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
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
            if ((character >= 'a' && character <= 'z') || (character <= 'A' && character >= 'Z'))
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
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public Boolean IsPrime(int num)
        {
            Boolean result = true;
            if (num < 2)
            {
                result = false;
            }

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}



