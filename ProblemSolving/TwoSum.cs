using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    /// <summary>
    /// Two Number Sum Problem Statement
    /// Given an array of integers, return the indices of the two numbers whose sum is equal to a given target.
    /// </summary>
    class TwoSum
    {
        /// <summary>
        /// Best solution with O(n) time and O(n) space complexity
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum0(int[] nums, int target)
        {
            // Best solution is using dictionary
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                // As we are adding target- nums[i] as a key we can search the same to
                // Get the associated value with the specified key
                if (dict.TryGetValue(target - nums[i], out int index))
                {
                    return new int[] { i, index };
                }
                dict[nums[i]] = i;

                // Can also be
                //if (dict.TryGetValue(nums[i], out int index))
                //{
                //    return new int[] { i, index };
                //}
                //dict[target-nums[i]] = i;

                //// Other solution can be
                //try
                //{
                //    int component = target - nums[i];
                //    If the key is not found it will throw an error
                //var s = dict[component];
                //    return new int[] { i, dict[component] };
                //}
                //catch (Exception e)
                //{
                //    logging the errors
                //    Console.WriteLine(e.Message);
                //}
                //dict[nums[i]] = i;
            }
            return null;

        }

        /// <summary>
        /// Best Solution for already sorted array, by sorting the array O(n logn) for sorting and O(logn) for sum check
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            // sort the array
            // take 2 pointers
            int start = 0; int end = nums.Length - 1;
            Array.Sort(nums);
            while (start != end)
            {

                if (nums[start] + nums[end] > target)
                {
                    end--;
                }
                else if (nums[start] + nums[end] == target)
                {
                    return new int[] { start, end };
                }
                else
                {
                    start++;
                }
            }
            return null;
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            // You can use this one also O(n2) because when you do IndexOf it go throw all elements
            for (int i = 0; i < nums.Length; i++)
            {
                int remaining = target - nums[i];
                int index = Array.IndexOf(nums, remaining);
                if (index != -1 && index != i)
                {
                    return new int[] { i, index };
                }
            }
            return null;
        }

        public int[] TwoSum3(int[] nums, int target)
        {
            // Algorithm for Bruit force: O(n2)
            // Compare Every Item with Other element skip comparing once the match found
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; i < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
