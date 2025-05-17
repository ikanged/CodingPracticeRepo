using System;
namespace CodingPractice.Problems.Interview.BroadwayTech
{
	public class VirtualOnSiteinterview
	{
		public VirtualOnSiteinterview()
		{
            //Create a function that will return a bool
            // if it is one character off
            // "abc", "ab" => true
            // "ab", "abc" => true
            // "abc","axc" => true
            // "abc","xyz" => false
            //abbbc, abbzc -> true
        }

        public bool isOneOff(string input1, string input2)
        {
            bool answer = false;
            int misCounts = 0;
            int length1 = input1.Length;
            int length2 = input2.Length;

            if (input1.Length - 1 >= input2.Length ||
                input2.Length - 1 >= input1.Length)
            {
                return false;
            }

            //abc ab 
            //Loop through the Longest string
            for (var i = 0; i < length1; i++)
            {
                //"abc", "ab" => true
                if (i == length2 - 1 && misCounts == 0)
                {
                    answer = true;
                    break;
                }

                if (input1[i] != input2[i])
                {
                    misCounts++;
                }

                if (misCounts > 1)
                {
                    break;
                }
            }
            //Loop through the other string
            //check if the characters are the same
            //if characters are not the same, increment the misCount

            //if the misCount is greater than 1, break out of the loop and return false
            //otherwise return true

            if (misCounts <= 1)
            {
                answer = true;
            }

            return answer;
        }
    }
}

