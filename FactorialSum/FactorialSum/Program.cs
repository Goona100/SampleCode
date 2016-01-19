using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace FactorialSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for factorial:");
            BigInteger number = int.Parse(Console.ReadLine());

            //Test Case1: Enter 3 and it should return 6
            //Test Case2: Enter 10 and it should return 3628800 
            Console.WriteLine("The factorial of " + number.ToString()+ " is: {0}\n", Fact(number));
            Console.ReadLine();

            //Test Case1: it should return 6 for digits sum of 3 factorial
            //Test Case2: it should return 27 for digits sum of  10 factorial (3628800 )
            int digSum = 0;
            BigInteger resValue = Fact(number);

            while (resValue > 0)
            {
                digSum += (int)(resValue % 10);
                resValue /= 10;
            }

            Console.WriteLine("The digits sum of  factorial "  + number.ToString() + " is: {0}\n", digSum);
            Console.ReadLine();
        }

        public static BigInteger Fact(BigInteger factNumber)
        {
          BigInteger factResult;
          
            if (factNumber <= 1)
            {
                return 1;
            }
            else
            {
                factResult = factNumber * Fact(factNumber - 1);
            }
            return factResult;
        }



    }
}
