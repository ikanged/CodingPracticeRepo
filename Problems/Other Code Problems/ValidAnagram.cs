using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.Other_Code_Problems
{
    class ValidAnagram : AbsProblem, IProblem
    {
        public ValidAnagram() : base("NeetCode 150")
        {
        }

        public override void Begin()
        {
            var input1 = "racecar";
            var input2 = "carrace";

            isAnagram(input1, input2);
        }

        private bool isAnagram(string input1, string input2)
        {
            return true;
        }   
	}
}