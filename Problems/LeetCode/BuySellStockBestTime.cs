using System;
using System.Linq;

namespace CodingPractice.Problems.LeetCode
{
	public class BuySellStockBestTime : AbsProblem, IProblem
	{
		public BuySellStockBestTime() : base("Best Time To Buy Stocks")
		{
            /*
			 *	Input: prices = [7,1,5,3,6,4]
			 *	Output: 5
			 *	Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
			 *	
			 *	
			 *	Input: prices = [7,6,4,3,1]
			 *	Output: 0
			 *	Explanation: In this case, no transactions are done and the max profit = 0.
			 */
        }

        public override void Begin()
        {
			int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };

			Console.WriteLine($"Most profit that can be achieved by buying Stock: {getBestProfit(prices)}");
        }
		/// <summary>
		/// Returns most profit that can be earned for the set.
		/// </summary>
		/// <param name="prices"></param>
		/// <returns></returns>
		public int getBestProfit(int[] prices)
		{
            //[7,1,5,3,6,4]
            int bestProfit = 0;
            int buy = int.MaxValue;

            //Best runtime solution

            

            ////Iterate through all elements 
            //for(int i = 1; i < prices.Length; i++)
            //{
            //    //Set sell price in each iteration
            //    sell = prices[i]; // 6
            //    if(sell > buy)  //6 > 1
            //    {
            //        bestProfit = Math.Max(bestProfit, sell - buy); // 5
            //    }
            //    else
            //    {
            //        //Set the buy price if sell is less than buy
            //        buy = sell; // buy = 1
            //    }
            //}

            return bestProfit;
        }
    }
}

