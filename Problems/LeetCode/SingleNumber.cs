using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class SingleNumber : AbsProblem, IProblem
	{
		public SingleNumber() : base("Single Number")
		{
            /*
             *  
             *   Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
             *   You must implement a solution with a linear runtime complexity and use only constant extra space.
             *  
             *  Example 1:
             *   Input: nums = [2,2,1]
             *   Output: 1
             *   
             *   Example 2:
             *   Input: nums = [4,1,2,1,2]
             *   Output: 4
             *   
             *   Example 3:
             *   Input: nums = [1]
             *   Output: 1
             *
             */
        }

        public override void Begin()
        {
            int[] input1 = new int[] { 4, 1, 2, 1, 2, 9, 202, 9, 202 };

            //Should [1]
            DisplayMessage($"{findSingleNumber(input1)}");            
        }

        public int findSingleNumber(int[] input1)
        {
            if(input1.Length == 1)
            {
                return input1[0];
            }
            int xor = 0;
            foreach(int num in input1)
            {
                //XORing an int will give you the unique number in the array
                DisplayMessage($"xor: {xor} ^ num: {num} = {xor ^= num}");
            }

            return xor;
        }
    }
}

