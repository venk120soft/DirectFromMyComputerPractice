using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    /// <summary>
    ///  Running Sum of 1d Array
    ///  https://leetcode.com/problems/running-sum-of-1d-array/
    /// Example 1:
    ///         Input: nums = [1,2,3,4]
    ///         Output: [1,3,6,10]
    ///         Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
    /// Example 2:
    ///     Input: nums = [1,1,1,1,1]
    ///     Output: [1,2,3,4,5]
    ///     Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
    /// Example 3:
    ///     Input: nums = [3,1,2,10,1]
    ///     Output: [3,4,6,16,17]
    /// </summary>
    class RunningSum1D
    {
        public int[] RunningSum0(int[] nums) {
             for(int i = 1; i < nums.Length ; i++){
                 nums[i] = nums[i-1] + nums[i];
             }
             return nums;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] RunningSum(int[] nums)
        {

            if (nums.Length < 2)
            {
                return nums;
            }

            int[] temp = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int remain = 0;

                for (int j = i; j >= 0; j--)
                {
                    remain += nums[j];
                }

                temp[i] = remain;
            }

            return temp;
        }

        //static void Main(string[] args)
        //{
        //    RunningSum1D runningSum1D = new RunningSum1D();
        //    var test = new int[] { 1, 2, 3, 4 };
        //    var sum= runningSum1D.RunningSum(test);
        //    Console.WriteLine("Sum is: ", sum);
        //    Console.ReadLine();
        //}
    }
}
