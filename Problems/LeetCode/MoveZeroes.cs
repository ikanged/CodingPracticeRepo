using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class MoveZeroes : AbsProblem, IProblem
	{
		public MoveZeroes() : base("Move Zeroes")
		{
            /*
             *  
             *  Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
             *   
             *   Note that you must do this in-place without making a copy of the array.
             *  
             *  
             *  Input: nums = [0,1,0,3,12]
             *  Output: [1,3,12,0,0]
             *  
             *  Input: nums = [0]
             *  Output: [0]
             *
             */
        }

        public override void Begin()
        {
            int[] input = new int[] {0, 1, 0, 3, 12};

            //Should Return [1,3,12,0,0]
            DisplayArray($"{moveZeroesToEnd(input)}");            
        }

        public int[] moveZeroesToEnd(int[] input)
        {
            int index = 0;

            //Loop through each element
            //i = 4, index = 2
            //1, 3, 0, 0, 12
            for (int i = 0; i < input.Length; i++)
            {
                //Continue to next element if its 0
                if (input[i] == 0)
                {
                    continue;
                }

                //Move the current element to the position where it last left off
                input[index] = input[i];    //0, 12 -> 1, 3, 12, 3, 12

                //set the current element to 0 if the current position is not equal to
                //previously found non zero index
                if (index != i)
                {
                    input[i] = 0;   //1, 3, 12, 0, 0 
                }

                index++;    //2
            }

            return input;
        }
    }
}

