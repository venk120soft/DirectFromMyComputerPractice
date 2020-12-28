using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class SquaresOfSortedArray
    {
        /*
       * Algo:
       * 1. From Given Sorted array we have to look for +ve and -ve's number 
       * 2. There should be some starting point for +ve integers. get that index
       * 3. Now, start doing the square of elements of both +ve and -ve and compare it
       * 4. Based on the comparision add the numbers to new list
       * 5. Increment the index if the +ve number is added to the new list until end of array
       * 5. If the negative number is added to the new list, decrement the index of array until reaches 0
       * 6. While adding the numbers to the new list increment the index of it
       * 7. Then Copy the remaining elements of -ve then +ve
       * Below Solution is of O(n) time complexity and O(n) space complexity
       */
        public int[] SortedSquares(int[] A) {
            int length = A.Length;
            int[] temp = new int[length];
            int midIndex = 0;
            // finding the middle index which seperates -ve and +ve numbers
            for (int k = 0; k < length; k++)
            {
                if (A[k] >= 0)
                {
                    midIndex = k;
                    break;
                }
            }

            int i = midIndex - 1;// first half end index
            int j = midIndex;// second half start index
            int index = 0; // new list index;

            while (i>=0 && j<length)
            {
                if (A[i] * A[i] > A[j] * A[j])
                {
                    temp[index] = A[j] * A[j];
                    j++;
                }
                else
                {
                    temp[index] = A[i] * A[i];
                    i--;
                }

                index++;
            }

            // Copying the remaining elements from -ve half
            while (i>=0)
            {
                temp[index++] = A[i] * A[i];
                i--;
            }

            // Copying the remaining elements from +ve half
            while (j < length)
            {
                temp[index++] = A[j] * A[j];
            }

            return temp;
        }

        // O(n logn)
        public int[] SortedSquareNormal(int[] A) {
            int length = A.Length;
            int[] temp = new int[length];
            for (int i = 0; i < length; i++)
            {
                temp[i] = A[i] * A[i];
            }

            // Then Sort using in built function
            Array.Sort(temp);

            return temp;
        }

        //static void Main(string[] args)
        //{
        //    SquaresOfSortedArray squaresOfSortedArray = new SquaresOfSortedArray();
        //    var test = new int[] {-10,-5,-3, 1, 2, 3, 4, 8 };
        //    // var test = new int[] { 12, 345, 2, 6, 7896 };

        //    var watch = new System.Diagnostics.Stopwatch();
        //    watch.Start();

        //    int[] sortedArray= squaresOfSortedArray.SortedSquares(test);

        //    Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        //    watch.Stop();

        //    int[] sortedArray1 = squaresOfSortedArray.SortedSquareNormal(test);

        //    for (int i = 0; i <sortedArray.Length; i++)
        //    {
        //        Console.WriteLine("Sorted arry is: {0} ", sortedArray[i] == sortedArray1[i]);
        //    }
        //    Console.ReadLine();
        //}
    }
}
