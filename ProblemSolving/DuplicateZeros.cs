using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class DuplicateZeros
    {
        // Push Element to array
        public int[] GetDuplicateZeros(int[] arr)
        {

            return arr;
        }

        public void ShiftElementsInArray()
        {
            int[] test = new int[15];
            test[0] = 1;
            test[1] = 2;
            test[2] = 3;
            test[3] = 4;
            test[4] = 5;
            Console.WriteLine(test.Length + "");

            // Now lets add 6 at the index 0 by shifting all the elements to 
            // We can't directly do test[0] = 6 if we do this other elements will override
            // 1. Shift last element to its next position then last element position will be empty now
            // 2. Then we can shift one more to its next position which is empty
            // 3. like wise have to move all the elements

            for (int i = 4; i > 0; i--)
            {
                test[i + 1] = test[i];
            }
            test[0] = 6;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(test[i]);
            }

            // If we want to insert the number at index 3

            for(int i = 5; i > 3; i--)
            {
                Console.WriteLine(test[i]);
            }
            Console.WriteLine("Length is:{0}", test.Length);
            //return arr;
        }

        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            DuplicateZeros duplicateZeros = new DuplicateZeros();
            //duplicateZeros.ShiftElementsInArray(new int[] { 1, 0, 2, 4, 0, 5 });

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            watch.Stop();

            Console.ReadLine();
        }
    }
}
