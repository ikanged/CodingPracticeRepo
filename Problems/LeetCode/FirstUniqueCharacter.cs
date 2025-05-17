using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class FirstUniqueCharacter : AbsProblem, IProblem
	{
		public FirstUniqueCharacter() : base("First Unique Character")
		{
            /*
             *  
             *  Given a string s, find the first non-repeating 
             *  character in it and return its index. 
             *  If it does not exist, return -1.
             *  
             *  Input: s = "leetcode"
             *  Output: 0
             *  
             *  Input: s = "loveleetcode"
             *  Output: 2
             *  
             *  Input: s = "aabb"
             *  Output: -1
             *
             */
        }

        public override void Begin()
        {
            string input = "ttttyuuu";

            DisplayMessage($"First Non-Repeating Character: {FirstNoneRepeatingChar(input)}");            
        }

        public int FirstNoneRepeatingChar(string input)
        {
            Dictionary<char, int> data = new Dictionary<char, int>();

            //Initialize to non found
            int index = 0;
            string temp = input;

            if(input.Length == 1)
            {
                return -1;
            }

            //Loop through each character 
            while(temp.Length > 0)
            {
                //Save the first letter in the temp string
                var letter = temp[0];

                //Remove the character from the string
                temp = temp.Remove(0, 1);

                //Check if there are any other characters of
                //the same in the string
                if (!temp.Contains(letter))
                {
                    //Return the index if non is found;
                    return input.IndexOf(letter);
                }
                else
                {
                    //Replace all the occurance of the repeating letter
                    //to be empty letter
                    temp = temp.Replace(letter.ToString(), string.Empty);                   
                }

                index++;
            }
            
            return -1;
        }
    }
}

