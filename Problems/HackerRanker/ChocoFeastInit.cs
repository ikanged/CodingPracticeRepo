using System;
using CodingPractice;

namespace HackerRank
{
    public class ChocoFeastInit : AbsProblem, IProblem
    {
        public ChocoFeastInit() : base("Chocolate Feast Problem")
        {
        }

        public override void Begin()
        {
            /*
             *   n: an integer representing Bobby's initial amount of money
             *   c: an integer representing the cost of a chocolate bar
             *   m: an integer representing the number of wrappers he can turn in for a free bar
             *
             *   Input:  The first line contains an integer, t, denoting the number of test cases to analyze. 
             *   Each of the next t lines contains three space-separated integers: n, c, and m. 
             *   They represent money to spend, cost of a chocolate, 
             *   and the number of wrappers he can turn in for a free chocolate.
             * 
             */
            DisplayQuestionToUser("Enter Number of Store Visits:");
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                DisplayQuestionToUser("Enter money, cost and wrappers:");
                string[] ncm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(ncm[0]);

                int c = Convert.ToInt32(ncm[1]);

                int m = Convert.ToInt32(ncm[2]);

                int result = calculateFeasts(n, c, m);

                Console.WriteLine(result);
            }
        }

        private int calculateFeasts(int money, int cost, int wrapperCost)
        {
            int answer = 0;
            int candy = money / cost;
            int wrappers = 0;

            //
            if (wrappers > wrapperCost)
            {
                wrappers = candy / wrapperCost;
            }
            answer = candy;

            //answer +=

            return answer;
        }
    }
}
