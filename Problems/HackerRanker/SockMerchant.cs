using System;
using System.Collections.Generic;
using CodingPractice;

namespace HackerRank
{
    public class SockMerchant : AbsProblem, IProblem
    {
        private Dictionary<int, int> SockCollection = new Dictionary<int, int>();

        public SockMerchant() : base("Sock Merchant")
        {
        }

        public override void Begin()
        {
            DisplayMessage("Enter Number of socks in the Pile:");
            int n = Convert.ToInt32(Console.ReadLine());

            DisplayMessage("Enter the colors for each sock:");

            string[] input = Console.ReadLine().Split(' ');
            int[] ar = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                Int32.TryParse(input[i], out ar[i]);
            }

            int result = sockMerchant(n, ar);

            DisplayMessage(result.ToString());
        }

        private int sockMerchant(int n, int[] ar)
        {
            int answer = 0;

            //Store each sock in SockCollection
            for (int i = 0; i < ar.Length; i++)
            {
                if (SockCollection.ContainsKey(ar[i]))
                {
                    SockCollection[ar[i]]++;
                }
                else
                {
                    SockCollection.Add(ar[i], 1);
                }
            }

            int pairs = 0;
            foreach (var item in SockCollection)
            {
                if (item.Value > 1)
                {
                    pairs = item.Value / 2;
                    if (pairs >= 1)
                    {
                        answer += pairs;
                    }
                }
            }

            return answer;
        }
    }
}
