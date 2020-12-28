using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class IsEvenNumber
    {
        private bool isEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
                return true;
            }
            else
            {
                Console.WriteLine("Number is odd");
                return false;
            }
        }

        // Divide the given number with 2 then if the result is Odd 
        // Substitute 1 from result to make even number
        // like wise Find the number of steps required make the number to 0
        private int NumberOfSteps(int num)
        {
            //int numberOfSteps = 0;
            //var IsEvenNumber = num % 2; // it will give 1 for Odd, 0 for Even
            //var r1 = num / 2; // it will give odd or even number
            //while (r1 != 0)
            //{
            //    if (IsEvenNumber == 1)
            //    {
            //        // if it is Odd number substracting 1 from it and making it even
            //        r1 -= 1;
            //        numberOfSteps += 1;
            //    }
            //    numberOfSteps += 1;
            //    r1 = r1 / 2;
            //    IsEvenNumber = r1 % 2;
            //}
            //    return numberOfSteps;
            int steps = 0;
            if (num == 0)
            {
                return 0;
            }
            while (num > 0)
            {
                if (num % 2 == 1)
                {
                    num -= 1;
                    steps += 1;
                }
                else
                {
                    num /= 2;
                    steps += 1;
                }
            }
            return steps;
        }

        static void Main(string[] args)
        {
            IsEvenNumber isEven = new IsEvenNumber();
            int number = int.Parse(Console.ReadLine());
            int count = isEven.NumberOfSteps(number);
            Console.WriteLine("No of steps are: {0} ", count);
            Console.ReadLine();
        }
    }
}
