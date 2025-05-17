using System;
using System.Collections.Generic;

namespace CodingPractice.Problems.Algorithms.SlidingWindow
{
	public class LongSubstringWithKDistCharacter : AbsProblem, IProblem
	{
		public LongSubstringWithKDistCharacter() : base("Longest Substring with K Distinct characters")
		{
			/*
			 * 
			 * Problem: Find the longest substring length with K Distint Characters
			 * Input: [A,A,A,H,H,I,B,C]
			 * Target Length: 2 
			 * Output: 5
			 * Explaination: A,A,A,H,H contains 2 distinct characters and is the longest
			 */
		}

        public override void Begin()
        {
			string input = "AAAHHIBC";
			int distintLimit = 2;

			DisplayMessage($"Longest substring Length: {longestSubString(input, distintLimit)}");
        }

		public int longestSubString(string input, int limit)
		{
			int length, maxLength, startCursor, currentLimit;
		    length = maxLength = startCursor = currentLimit = 0;

			Dictionary<char, int> characterList = new Dictionary<char, int>();

			//Loop through each character 
			for(int endCursor = 0; endCursor < input.Length; endCursor++)
			{								
				//Check if the character is in the collection
				if (characterList.ContainsKey(input[endCursor]))
				{
					//True: Increment the count
					characterList[input[endCursor]]++;
				}
                else
				{
					//False: Add to collection
					characterList.Add(input[endCursor], 1);
                }

                //Check if there more than limited number of distinct characters in collection
                while (characterList.Keys.Count > limit)
                {
                    //True:
                    //	Decrement the count thats in the startCursor
                    characterList[input[startCursor]]--;

                    // if there are 0 count, remove from collection
                    if (characterList[input[startCursor]] == 0)
                    {
                        characterList.Remove(input[startCursor]);
                    }

                    //	Increment the startCursor
                    startCursor++;                    

                    //	Set the maxLength
                    maxLength = Math.Max(length, maxLength);

					//Decrement the current length of substring
                    length--;                    
                }

                //Increment the length of subset
                length++;
            }

			return maxLength;
		}
    }
}

