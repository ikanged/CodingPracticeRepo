using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CodingPractice;

namespace HackerRank
{ 
	internal class Mini_MaxSum : AbsProblem, IProblem
	{
		public Mini_MaxSum() : base("Mini Max Sum")
		{

		}

		public override void Begin()
		{
            var userInput = new UserInput();

            var intArray = userInput.intAryUserInput();

            miniMaxSum(intArray.ToList());  
		}

        public static void miniMaxSum(List<int> arr)
        {
            var minItems = new List<int>();
            var maxItems = new List<int>();
            var tempItems = new List<int>(arr);

            StringBuilder str = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                var min = tempItems.Min();
                minItems.Add(min);
                tempItems.Remove(min);
            }

            var sumMin = (long)minItems.Aggregate((x, y) => x + y);
            str.Append(sumMin + " ");

            tempItems = arr;
            for (int i = 0; i < 4; i++)
            {
                var max = tempItems.Max();
                maxItems.Add(max);
                tempItems.Remove(max);
            }

            var sumMax = (long)maxItems.Sum(x =>(long)x);
            str.Append(sumMax);

            Console.WriteLine(str.ToString());
        }
    }
}
