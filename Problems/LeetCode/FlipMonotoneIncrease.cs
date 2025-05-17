using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace CodingPractice.Problems.LeetCode
{
	public class FlipMonotoneIncrease : AbsProblem, IProblem
	{
		/* 
		 *  You are given a binary string s. You can flip s[i] changing it from 0 to 1 or from 1 to 0.
		 *
		 *  Return the minimum number of flips to make s monotone increasing.
		 *  Input: s = "00110"
		 *	Output: 1
		 *	Explanation: We flip the last digit to get 00111.
		 * 
		 *	Input: s = "010110"
		 *	Output: 2
		 *	Explanation: We flip to get 011111, or alternatively 000111.
		 * 
		 *	Input: s = "00011000"
		 *	Output: 2
		 *	Explanation: We flip to get 00000000.
		 * 
		 *  Constraints
		 *		1 <= s.length <= 10^5
		 *		s[i] is either 0 or 1
		 */
		public FlipMonotoneIncrease() : base("Flip String to Monotone Increasing")
		{
		}

		public override void Begin()
		{
			UserInput ui = new UserInput();

			var input = ui.strUserInput();

		}

		public int MinFlipsMonoIncr(string input)
		{
			//00110
			int num_flips = 0;
			int num_ones = 0;

			foreach (var c in input)
			{
				if (c == '1')
				{
					num_ones++;
				}
				else if (num_ones > 0)
				{
					num_flips++;
					num_ones--;
				}
			}

			return num_flips;
		}
	}
}
