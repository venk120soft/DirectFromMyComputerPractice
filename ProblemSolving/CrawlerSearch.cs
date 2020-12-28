using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    /// <summary>
    /// In a given string search for the substring
    /// </summary>
    class CrawlerSearch
    {
        /// <summary>
        /// Get the List of items with the count of it
        /// This is an assignment given to me
        /// </summary>
        /// <param name="givenArray"></param>
        /// <returns></returns>
        private Dictionary<string, int> GetItemsWithCount(string[] givenArray)
        {
            Dictionary<string, int> temp = new Dictionary<string, int>();

            for (int i = 0; i < givenArray.Length; i++)
            {

                if (!temp.ContainsKey(givenArray[i]))
                {
                    temp.Add(givenArray[i], 1);
                }
                else
                {
                    // If the element (key) is exist then increasing the count with 1
                    temp[givenArray[i]] += 1;
                }
            }

            return temp;
        }

        private Dictionary<string, int> GetResultedItems(Dictionary<string, int> givenItems, string[] excludeItems, int returnItems)
        {
            var items = givenItems.OrderByDescending(x => x.Value);
            var result = new Dictionary<string, int>();

            foreach (var item in items)
            {
                if (result.Count == returnItems)
                {
                    break;
                }
                if (!excludeItems.Contains(item.Key))
                {
                    result.Add(item.Key, item.Value);
                }
            }
            return result;
        }

        public void PrintResult(string givenString, string[] excludeItems, int returnItems = 10)
        {
            var getItemsWithCount = GetItemsWithCount(givenString.Split(' '));
            getItemsWithCount = GetResultedItems(getItemsWithCount, excludeItems, returnItems);

            foreach (var item in getItemsWithCount)
            {
                Console.WriteLine(item.Key + " No Of Occurances:" + item.Value);
            }
        }

        private string[] getArrayOfStrings()
        {
            Console.WriteLine("Enter the , seperted string to exclude from search:");
            string excludeString = Console.ReadLine();
            return excludeString.Split(',');
        }

        //public static void Main(string[] args)
        //{
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

        //    var excludeStrings = crawlerSearch.getArrayOfStrings();
        //    Console.WriteLine("Enter the count of values to print");
        //    var printCount = Console.ReadLine();
        //    crawlerSearch.PrintResult(givenString, excludeStrings, int.Parse(printCount));
        //    Console.ReadLine();
        //}
    }
}
