
using CodingPractice;
using System.Collections.Generic;
using System.Linq;

namespace UdemyCodingBootcamp
{
	class MaxChar : AbsProblem, IProblem
	{
        /*
		 * Given a string, return the char that appears the most i the string
		 *	- input: Hi, My Name is Inwoooooook -> output: "o"
		 */

        public MaxChar() : base("Max Char")
		{

		}

		public override void Begin()
		{
            string input = "Hi, My Name is Inwoooooook";

            DisplayMessage($"Max Char : {FindMaxChar(input)}");
		}

        public char FindMaxChar(string input)
        {
			var letterList = new Dictionary<char, int>();

            foreach(var letter in input)
			{
				if(letterList.ContainsKey(letter))
				{
					letterList[letter]++;
				}
				else
				{
					letterList.Add(letter, 1);
				}
            }

			return letterList.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }        
	}
}

