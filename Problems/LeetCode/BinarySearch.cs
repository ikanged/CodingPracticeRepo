using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice.Helpers;

namespace CodingPractice.Problems.LeetCode
{
	class BinarySearch : AbsProblem, IProblem
	{
		public BinarySearch() : base("Binary Search")
		{

		}

		public override void Begin()
		{
			int[] nums = {1,2};
			int target = 2;

			Console.WriteLine($"Index: {Search(nums, target)}");
		}

		private int Search(int[] nums, int target)
		{
			int min = 0;
			int max = nums.Length - 1;

			while (min <= max)
			{
				int curr = (max + min) / 2;
				int value = nums[curr];

				if (value > target)
				{
					max = curr - 1;
				}
				else if (value < target)
				{
					min = curr + 1;
				}
				else
				{
					return curr;
				}
			}

			return -1;
		}
	}
}
