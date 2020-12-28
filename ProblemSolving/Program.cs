using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    class Program
    {
        private void FindSquareRoot(float number)
        {
            // this can be 0.001 for more accurate we can go more deep
            for (double i = 0; i < number; i = i + 0.01)
            {
                if (i * i >= number)
                {
                    Console.WriteLine(i);
                    break;

                }
            }
            Console.WriteLine(Math.Sqrt(number));
        }
        //static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    //p.FindSquareRoot(98);
        //    //MatrixProblems matrixProblems = new MatrixProblems();
        //    //int[,] givenMatrix = new int[,]
        //    //{
        //    //    {1,2,3,1 },
        //    //    {4,5,6,4 },
        //    //    {7,8,9,7 }
        //    //};
        //    ////matrixProblems.PrintPrincipleDiagonalElements(givenMatrix,3,3);
        //    ////matrixProblems.PrintAllDiagonalElements0(givenMatrix, 3, 3);
        //    //matrixProblems.PrintSpiralElements(givenMatrix, 3, 4);
        //    //MatrixProblems.spiralPrint(3, 4, givenMatrix);
        //    //Console.Read();

        //    // CrawlSearch
        //    CrawlerSearch crawlerSearch = new CrawlerSearch();
        //    Console.WriteLine("Once Enter the text that you want to do Search In press y to accept the string");
        //    List<string> lines = new List<string>();
        //    string givenString;
        //    while ((givenString = Console.ReadLine()) != null)
        //    {
        //        if (givenString.ToLower() == "y")
        //        {
        //            break;
        //        }
        //        // Either you do here something with each line separately or
        //        lines.Add(givenString);
        //    }
        //    givenString = string.Join(",", lines.ToArray());

        //    var excludeStrings = p.getArrayOfStrings();
        //    Console.WriteLine("Enter the count of values to print");
        //    var printCount = Console.ReadLine();
        //    crawlerSearch.PrintResult(givenString, excludeStrings, int.Parse(printCount));
        //    Console.ReadLine();
        //}

        private string[] getArrayOfStrings()
        {
            Console.WriteLine("Enter the , seperted string to exclude from search:");
            string excludeString = Console.ReadLine();
            return excludeString.Split(',');
        }
    }
}
