using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	class SquareOfSortedArray : AbsProblem, IProblem
	{
		/*
		 *	Given an integer array nums sorted in non-decreasing order, 
		 *	return an array of the squares of each number sorted in non-decreasing order. 
		 * 
		 */

		public SquareOfSortedArray() : base("Square of Sorted Array")
		{

		}

		public override void Begin()
		{
			int[] input = { -4, -1, 0, 3, 10 };

			DisplayArray(SortedSquares(input));
		}

		private int[] SortedSquares(int[] input)
		{
			int min = 0;
			int max = input.Length - 1;
			int[] squared = new int[input.Length];

			for (int i = max; i >= 0; i--)
			{
				if(Math.Abs(input[min]) < Math.Abs(input[max]))
				{
					squared[i] = input[max] * input[max];
					max--;
				}
				else
				{
					squared[i] = input[min] * input[min];
					min++;
				}
			}

			return squared;
		}
	}
}
 
