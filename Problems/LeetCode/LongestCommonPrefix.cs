using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class LongestCommonPrefix : AbsProblem, IProblem
	{
        Dictionary<int, int> memo = new Dictionary<int, int>();

		public LongestCommonPrefix() : base("Longest Common Prefix")
		{
            /*
             *  
             *  Write a function to find the longest common prefix string amongst an array of strings.
             *
             *  If there is no common prefix, return an empty string "".
             *  
             *  Input: strs = ["flower","flow","flight"]
             *  Output: "fl"
             *  
             *  Input: strs = ["dog","racecar","car"]
             *  Output: ""
             *  Explanation: There is no common prefix among the input strings.
             *
             *  Constraints:
             *   1 <= strs.length <= 200
             *   0 <= strs[i].length <= 200
             *   strs[i] consists of only lowercase English letters.
             *
             */
        }

        public override void Begin()
        {
            string[] input = new string[] { "flower", "flow", "flight" };


            DisplayMessage($"Longest Prefix: {GetLongestPrefix(input)}");
            
        }

        public string GetLongestPrefix(string[] input)
        {
            int minLength = int.MaxValue;

            foreach(string str in input)
            {
                //Get the shortest string
                minLength = Math.Min(minLength, input.Length);
            }

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < minLength; i++)
            {
                //Get the first character
                char curr = input[0][i];

                foreach(string str in input)
                {
                    if (str[i] != curr)
                    {
                        return strBuilder.ToString();
                    }
                }

                strBuilder.Append(curr);
            }

            return strBuilder.ToString();
        }
    }
}

