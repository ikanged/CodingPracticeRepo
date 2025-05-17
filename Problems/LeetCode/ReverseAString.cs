using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class ReverseAString : AbsProblem, IProblem
	{
		public ReverseAString() : base("Reverse A String")
		{
            /*
             *  
             *  Write a function that reverses a string. The input string is given as an array of characters s.
             *  
             *  
             *  Input: s = ["h","e","l","l","o"]
             *  Output: ["o","l","l","e","h"]
             *  
             *
             */
        }

        public override void Begin()
        {
            char[] input = new char[] { 'h', 'e', 'l', 'l', 'o'};

            //Should Return false
            DisplayArray(reverseString(input));            
        }

        public char[] reverseString(char[] input)
        {
            int left = 0;
            int right = input.Length - 1;

            while( left < right)
            {
                char temp = input[left];
                input[left] = input[right];
                input[right] = temp;

                left++;
                right--;
            }
            return input;
        }
    }
}

