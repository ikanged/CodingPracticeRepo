using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;
using System.Linq;

namespace HackerRank
{
	internal class LonleyInteger : AbsProblem, IProblem
	{
		public LonleyInteger() : base("Lonley Integer")
		{

		}

		public override void Begin()
		{
			var userInput = new UserInput();

			var intArray = userInput.intAryUserInput();

			DisplayMessage(lonelyInteger(new List<int>(intArray)).ToString());
		}

		private int lonelyInteger(List<int> arr)
		{
			Dictionary<int, int> map = new Dictionary<int, int>();
			foreach(var item in arr)
			{
				if(map.ContainsKey(item))
				{
					map[item]++;
				}
				else { map[item] = 1; }
			}

			return map.Where(p => p.Value == 1).First().Key;
		}
	}
}
