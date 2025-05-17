using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class IndexOfFirstOccurence : AbsProblem, IProblem
	{
		public IndexOfFirstOccurence() : base("Index Of First Occurence")
		{
            /*
             *  
             *  Given two strings needle and haystack, return the index of the 
             *  first occurrence of needle in haystack, or -1 if needle is not part of haystack.
             *  
             *  
             *   Input: haystack = "sadbutsad", needle = "sad"
             *   Output: 0
             *   Explanation: "sad" occurs at index 0 and 6.
             *   The first occurrence is at index 0, so we return 0.
             *  
             *  
             *
             */
        }

        public override void Begin()
        {
            string input1 = "sadbutsad";
            string input2 = "sad";
            //Should Return false
            DisplayMessage(findFirstOccurence(input1, input2).ToString());            
        }

        public int findFirstOccurence(string haystack, string needle)
        {
            int firstOccurrenceIndex = 0;
            bool firstTimePass = false;
            string stackOfChar = "";

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i] == needle[j])
                    {
                        stackOfChar += haystack[i];
                        Console.WriteLine($"j:{i}, %: {i % needle.Length}, needle.Length: {needle.Length}, stackOfChar: {stackOfChar}");
                        if (firstTimePass)
                        {
                            firstOccurrenceIndex = i;
                            Console.WriteLine($"Index: {firstOccurrenceIndex}");
                            firstTimePass = false;
                        }
                        break;
                    }
                    else
                    {
                        firstTimePass = true;
                        break;
                    }
                }
                if (stackOfChar == needle)
                {
                    break;
                }
            }

            return firstOccurrenceIndex;
        }
    }
}

