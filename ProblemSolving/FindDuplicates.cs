using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProblemSolving
{
    /// <summary>
    /// In below code you can find how we can print duplicate and uniq elements from array (normal and sorted) and string
    /// </summary>
    class FindDuplicates
    {

        // private int[] temp = new int[] { 1, 1, 3, 2, 1 };
        /// <summary>
        /// Remove duplicates with O(n) and O(n) constant space complexity using array or list.
        /// </summary>
        /// <param name="givenArray"></param>
        /// <returns></returns>
        public int[] RemoveDuplicatesFromAnyArray(int[] givenArray)
        {
            List<int> temp = new List<int>();

            for (int i = 0; i < givenArray.Length; i++)
            {
                // If the element is not exist in temp then adding to the temp
                if (temp.IndexOf(givenArray[i]) <= -1)
                {
                    temp.Add(givenArray[i]);
                }
            }

            return temp.ToArray();
        }

        /// <summary>
        /// Remove duplicates with O(n) and O(n) constant space complexity using dictionary.
        /// </summary>
        /// <param name="givenArray"></param>
        /// <returns></returns>
        public void RemoveDuplicatesFromAnyArrayDictionary(int[] givenArray)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (!temp.ContainsKey(givenArray[i]))
                {
                    temp.Add(givenArray[i], 1);
                }
                else
                {
                    // If the element (key) is already there then increasing the value count with 1
                    temp[givenArray[i]] += 1;
                }

            }

            foreach (var item in temp)
            {
                // For printing uniq elements in an array
                Console.WriteLine(item.Key);

                // To print only duplicates
                //if (item.Value > 1)
                //{
                //    Console.WriteLine(item.Key + " Repeated " + item.Value + " times.");
                //}
            }
        }

        /// <summary>
        /// Remove Duplicates from sorted array with time: O(n) space: O(n)
        /// </summary>
        /// <param name="givenArray"></param>
        /// <returns></returns>
        public int[] RemoveDuplicatesFromSortedArray(int[] givenArray)
        {
            int arrayLength = givenArray.Length;
            var temp = new int[arrayLength];
            int j = 0;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (givenArray[i] != givenArray[i + 1])
                {
                    temp[j] = givenArray[i];
                    j += 1;
                }
            }

            // Adding Last element
            temp[j] = givenArray[arrayLength - 1];
            return temp;
        }

        /// <summary>
        /// Remove duplicates with O(n) and O(1) constant space complexity
        /// </summary>
        /// <param name="givenArray"></param>
        /// <returns></returns>
        public int[] RemoveDuplicatesFromSortedArrayInPlace(int[] givenArray)
        {
            int j = 0;

            for (int i = 0; i < givenArray.Length - 1; i++)
            {
                if (givenArray[i] != givenArray[i + 1])
                {
                    // re constructing the given array
                    givenArray[j++] = givenArray[i];
                }
            }

            // Adding the last element
            givenArray[j++] = givenArray[givenArray.Length - 1];

            // As we are re constructing array the remaining elements will stay as is, so changing them to 0
            for (int i = j; i < givenArray.Length; i++)
            {
                givenArray[i] = 0;
            }

            return givenArray;

        }

        /* Print Uniq chars present in 
        the passed string */
        public void PrintUniqCharInString(String str)
        {
            int noOfChars = 256;

            // Create an array of size 256 and 
            // fill count of every character in it 
            int[] count = new int[noOfChars];
            count = FillCharCounts(str, count);

            for (int i = 0; i < noOfChars; i++)
            {
                // for printing duplicate chars
                //if (count[i] > 1)
                //{
                //    Console.WriteLine((char)i + ", " + "count = " + count[i]);
                //}

                //for printing uniq chars
                if (count[i] != 0)
                {
                    Console.WriteLine((char)i + ",");
                }
            }
        }

        #region helper methods

        /* Fills count array with frequency of characters */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private int[] FillCharCounts(String str, int[] count)
        {
            for (int i = 0; i < str.Length; i++)
            {
                // ex: str[i] = 'A' then  Asci value for 'A' is 65. key in count array is 65 value is 0 when it increments it is going to be 1
                count[str[i]]++;
            }
            return count;
        }

        #endregion

    }
}
