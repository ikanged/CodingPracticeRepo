using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace UdemyCodingBootcamp
{
	class Palindromes : AbsProblem, IProblem
	{
        /*
		 * Reverse the string
		 *	- input: "apple" -> output: "elppa"
		 *	- input: "coffee" -> output: "eeffoc"
		 */

        public Palindromes() : base("Palindromes")
		{

		}

		public override void Begin()
		{
			var stringToReverse = "coffee";

            DisplayMessage($"String: {stringToReverse} is {(isPalindromes(stringToReverse) ? "" : "NOT")} a Palindromes");

		}

        public bool isPalindromes(string input)
        {
            var output = input.ToCharArray();
            var isPal = true;

            //Reverse the string by getting swapping the first pointer
            // and second pointer
            for (int index = 0; index <= input.Length / 2; index++)
            {
                int oppositePointer = (input.Length - 1) - index;

                if (output[oppositePointer] != input[index])
                {
                    isPal = false;
                }
            }

            return isPal;
        }        
	}
}

