using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class EvenNumberOfDigits
    {

        // 12 contains 2 digits. 
        // 345 contains 3 digits.
        private int GetNumberCount(int number) {

            int tempCount = 1;

            while (number / 10 >= 0)
            {
                number = number / 10;
                tempCount++;
            }
            return tempCount;
        }

        private int GetNumberCount1(int number)
        {
            return number.ToString().Length;
        }

        public int FindNumbers(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int numberCount = 0;
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                int tempCount = 1;
                while (nums[i] / 10 != 0)
                {
                    nums[i] = nums[i] / 10;
                    tempCount++;
                }

                // Checking for the Even Number of Digits
                if (tempCount % 2 == 0)
                {
                    numberCount += 1;
                }
            }
            return numberCount;
        }
        /*
            Input: nums = [12,345,2,6,7896]
            Output: 2
            Explanation: 
            12 contains 2 digits (even number of digits). 
            345 contains 3 digits (odd number of digits). 
            2 contains 1 digit (odd number of digits). 
            6 contains 1 digit (odd number of digits). 
            7896 contains 4 digits (even number of digits). 
            Therefore only 12 and 7896 contain an even number of digits.
        */
        //static void Main(string[] args)
        //{
        //    EvenNumberOfDigits evenNumberOfDigits = new EvenNumberOfDigits();
        //    var test = new int[] { 1, 2, 3, 4 };
        //    // var test = new int[] { 12, 345, 2, 6, 7896 };
        //    int evenNumbersCount = evenNumberOfDigits.FindNumbers(test);
        //    Console.WriteLine("Count of even numbers in a given list: {0} ", evenNumbersCount);
        //    Console.ReadLine();
        //}
    }
}
