using System;
using System.Collections.Generic;
using System.Linq;
using CodingPractice;

namespace HackerRank
{
    public class BonAppetitInit : AbsProblem, IProblem
    {
        public BonAppetitInit() : base("Bon Appetit Problem")
        {
        }

        public override void Begin()
        {
            DisplayQuestionToUser("Enter Number of Items Ordered and Item that was not eaten. ");
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            DisplayQuestionToUser("Enter costs of each item");
            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().
                             Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            DisplayQuestionToUser("Enter Amount that was charged");
            int b = Convert.ToInt32(Console.ReadLine().Trim());

            string answer = BonAppetit(bill, k, b);

            Console.WriteLine($"{answer}");
        }

        private string BonAppetit(List<int> bill, int k, int b)
        {
            int answer = 0;

            int itemCost = bill[k];
            int sum = 0;

            foreach (var item in bill)
            {
                sum += item;
            }

            answer = (sum - itemCost) / 2;

            answer = b - answer;

            if (answer <= 0)
            {
                return "Bon Appetit";
            }

            return answer.ToString();
        }
    }
}
