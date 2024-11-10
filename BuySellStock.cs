using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* 
Array i'th element is price of a given stock on day i
Perform only one transaction ( buy one and sell one) design algo for max profit

Note: Cannot sell stock before you buy one

Input: [7,1,5,3,6,4]
Output: 5
Buy on day 2 and sell on day 5 will maximise the profit
*/
namespace Leetcode
{
    public class BuySellStock
    {
        public static void Main()
        {
            int[] prices = {7,2,5,3,6,1,4,9,8};
            int maxP = 0;
            int buyDay = 0;
            int sellDay = 0;

            int left = 0; int right = 1; // Two-pointers declaration
            while (right < prices.Length)
            {
                if (prices[right] > prices[left])
                {
                    int profit = prices[right] - prices[left];
                    if (profit > maxP)
                    {
                        maxP = profit;
                        buyDay = left;
                        sellDay = right;
                    }
                }
                else {
                    left = right;
                }
                right++;
            }

            Console.WriteLine($"Max profit is {maxP}");
            Console.WriteLine($"Buy on day {buyDay + 1} and sell on day {sellDay + 1}");
        }
    }
}