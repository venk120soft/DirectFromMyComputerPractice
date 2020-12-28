using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    /// <summary>
    /// https://leetcode.com/problems/duplicate-zeros/solution/
    /// </summary>
    class DuplicateZeros
    {
        // O(n) In place solution Accepted Best one
        public void DuplicateZeros1(int[] arr)
        {
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                q.Enqueue(arr[i]);
                if (arr[i] == 0)
                    q.Enqueue(0);
                arr[i] = q.Dequeue();
            }
        }

        // This is also accepted
        public void DuplicateZeros2(int[] arr)
        {
            int possibleDups = 0;
            int length = arr.Length - 1;

            // Find the number of zeros to be duplicated
            // Stopping when left points beyond the last element in the original array
            // which would be part of the modified array
            for (int i = 0; i <= length - possibleDups; i++)
            {
                // Count the zeros
                if (arr[i] == 0)
                {
                    // Edge case: This zero can't be duplicated. We have no more space,
                    // as left is pointing to the last element which could be included  
                    if (i == length - possibleDups)
                    {
                        // For this zero we just copy it without duplication.
                        arr[length] = 0;
                        length -= 1;
                        break;
                    }
                    possibleDups++;
                }
            }

            // Start backwards from the last element which would be part of new array.
            int last = length - possibleDups;

            // Copy zero twice, and non zero once.
            for (int i = last; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    arr[i + possibleDups] = 0;
                    possibleDups--;
                    arr[i + possibleDups] = 0;
                }
                else
                {
                    arr[i + possibleDups] = arr[i];
                }
            }
        }

        // Not accepted, we might need to handle edge cases.
        public void DuplicateZeros3(int[] arr)
        {
            HelperUtil.PrintArray(arr, "Before:");
            int length = arr.Length;
            int y = 0;
            int[] myArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (y < length)
                {
                    myArray[y] = arr[i];
                    if (arr[i] == 0)
                    {
                        y += 1;
                        if (y < length)
                        {
                            myArray[y] = 0;
                        }
                        else break;
                    }
                    y++;
                }
                else break;
            }
            arr = myArray;
            HelperUtil.PrintArray(arr, "After:");
        }

        // Not accepted, we might need to handle edge cases.
        public void DuplicateZeros4(int[] arr)
        {
            int length = arr.Length;
            int dups = 0;
            // count the zeros
            for (int i = 0; i < length; i++)
            {
                if (arr[i] == 0)
                    dups++;
            }

            int endIndex = dups == 0 ? length - 1 : (length) - dups;
            for (int i = length - 1; i > -1; i--)
            {
                if (endIndex > -1)
                {
                    arr[i] = arr[endIndex];
                    if (arr[endIndex] == 0)
                    {
                        i -= 1;
                        arr[i] = 0;
                    }
                    endIndex--;
                }
            }
        }

        //public static void Main(string[] args)
        //{
        //    var duplicateZerosArray = new DuplicateZeros();
        //    var arr = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
        //    //arr = new int[] { 1, 2, 3 };
        //    HelperUtil.PrintArray(arr, "Before");
        //    HelperUtil.StartProgram(() => duplicateZerosArray.DuplicateZeros3(arr));
        //    HelperUtil.PrintArray(arr, "After");
        //    Console.ReadLine();
        //}
    }
}