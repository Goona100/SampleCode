using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Case1: Enter 10 and it should return 23
            Console.WriteLine("Enter the Number");
            int mulNumber = int.Parse(Console.ReadLine());
            int mulSum = 0;

            for (int i = 0; i < mulNumber; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0)) 
                {
                    mulSum += i;
                }
            }
            Console.WriteLine("Sum of multiples of 3 or 5 below " + mulNumber.ToString() + " : " + mulSum);
            Console.ReadLine();
        }
    }
}
