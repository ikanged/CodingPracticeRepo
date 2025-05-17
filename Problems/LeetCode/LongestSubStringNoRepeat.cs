using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	class LongestSubstringNoRepeat : AbsProblem, IProblem
	{
        /*
		 *	Given a string s, find the length of the 
		 *	longest substring without repeating characters
		 * 
		 * Example: 
		 *	Input s = "abcabcbb"
		 *	Output 3
		 *	
		 *	Output: 1
		 *	Input: s = "bbbbb"
		 *	
		 *	Input: s = "pwwkew"
		 *  Output: 3
		 */

        public LongestSubstringNoRepeat() : base("Longest Substring without Repeating Characters")
		{

		}

		public override void Begin()
		{
			string input = "abcabcbb";

			int answer = findLongestSubString(input);
			DisplayMessage($"Longest Substring length is: {answer}");
		}

		private int findLongestSubString(string input)
		{
			//Save the position of where the last point was at
			int length = 0;
			int position = 0;
			int longest = 0;
			Dictionary<char, int> positionKey = new Dictionary<char, int>();
			//Save the substring
			string subString = "";

			foreach(var sub in input)
			{
				//Console.WriteLine($"SubString: {subString} character: {sub}");
				position++;
                if (subString.Contains(sub))
				{
					//Console.WriteLine($"SubString: {subString} contains character: {sub}");
					// dvdf
					//Need to be able to handle dvdf in a way that the string needs to be spliced from the first found character
					//to the repeated character.
					string newstring = input.Substring(positionKey[sub]+1, position-1);
					//Update to the new position
					positionKey[sub] = position-1;

					subString = newstring;
                    length = newstring.Length;
                    longest = length > longest ? length : longest;					
				}
				else
				{
					//Console.WriteLine($"Longest: {longest}, subString: {subString}");
					positionKey.Add(sub, position-1);
                    subString = subString + sub;
					length++;
				}
			}

            return longest > length ? longest : length;
        }
    }
}
 
