using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	class SearchInsertPosition : AbsProblem, IProblem
	{
		public SearchInsertPosition() : base("Search Insert Position")
		{

		}

		public override void Begin()
		{
			int[] input = { 1, 3, 5, 6 };

			int target = 7;

			DisplayMessage($"{ SearchInsert(input, target ) }");
		}

		private int SearchInsert(int[] input, int target)
		{
			int index = 0 ;

			int left = 0;
			int right = input.Length - 1;

			while(left <= right)
			{
				DisplayMessage($"Iteration: {index}");
				index = left + ((right - left) / 2);

				if(input[index] < target)
				{
					left = index + 1;
				}
				else if(input[index] > target)
				{
					right = index - 1;
				}
				else
				{
					return index;
				}
			}

			return left;
		}
	}
}
