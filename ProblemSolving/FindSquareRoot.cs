using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class FindSquareRoot
    {
        public double FindSquareRootValue(float number)
        {
            // can also done by this.
            Console.WriteLine(Math.Sqrt(number));
            // this can be 0.001 for more accurate we can go more deep
            for (double i = 0; i < number; i = i + 0.01)
            {
                if (i * i >= number)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            return 0.00;
        }

        //public static void Main(string[] args)
        //{
        //    FindSquareRoot findSquareRoot = new FindSquareRoot();
        //    float input = 255;
        //    double result = findSquareRoot.FindSquareRootValue(input);
        //    Console.WriteLine($"Square Root value of {input} is:" + result);
        //}
    }
}
