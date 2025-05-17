using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	class FirstBadVersion : AbsProblem, IProblem
	{
		private int badNumber = 4;

		public FirstBadVersion() : base("First Bad Version")
		{

		}

		public override void Begin()
		{
			DisplayMessage($"First BadNumber is {getFirstBadVersionNumber()}");
		}

		private bool IsBadNumber(int num)
		{
			return badNumber <= num;
		}

		private int getFirstBadVersionNumber()
		{
			int maxValue = 100;

			int left = 1;
			int right = maxValue;
			int mid = 0;

			while (left < right)
			{
				//This formula to calculate the mid, is better because 
				//Overflow of int value is considered 
				mid = left + ((right - left) / 2);
				if (IsBadNumber(mid))
				{
					right = mid;
				}
				else
				{
					left = mid + 1;
				}
			}

			return left;
		}
	}
}
