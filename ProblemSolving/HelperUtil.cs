using System;
using System.Diagnostics;

namespace ProblemSolving
{
    class HelperUtil
    {
        private static Stopwatch watch = Stopwatch.StartNew();
        public static void PrintArray(int[] arr, string operation = "Printing starts here")
        {
            Console.WriteLine(operation);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Item: " + arr[i]);
            }
        }

        public static void StartProgram(Action methodName)
        {
            if (!watch.IsRunning)
                watch.Restart(); // Reset time to 0 and start measuring

            // Run method
            methodName();

            watch.Stop();

            Console.WriteLine($"Loop 1 Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static T GetTimeTaken<T>(Func<T> funcToRun)
        {
            if (!watch.IsRunning)
                watch.Restart(); // Reset time to 0 and start measuring

            // Run method
            funcToRun();

            watch.Stop();

            Console.WriteLine($"Loop 1 Execution Time: {watch.ElapsedMilliseconds} ms");
            //Do stuff before running function as normal
            return funcToRun();
        }
    }
}
