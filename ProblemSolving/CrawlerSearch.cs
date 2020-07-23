using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class CrawlerSearch
    {
        /// <summary>
        /// Get the List of items with the count of it
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
                    // If the element (key) is already there then increasing the value count with 1
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
    }
}
