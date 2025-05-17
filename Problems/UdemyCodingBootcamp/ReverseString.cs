using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace UdemyCodingBootcamp
{
	class StringReversal : AbsProblem, IProblem
	{
        /*
		 * Reverse the string
		 *	- input: "apple" -> output: false
		 *	- input: "coffee" -> output: false
		 *	- input: "taat" -> output: true
		 */

        public StringReversal() : base("String Reversal")
		{

		}

		public override void Begin()
		{
			var stringToReverse = "coffee";
            DisplayMessage($"String: {stringToReverse}, Reversed string: {reverseString(stringToReverse)}");

        }

        public string reverseString(string input)
        {
            var output = input.ToCharArray();

            //Reverse the string by getting swapping the first pointer
            // and second pointer
            for (int index = 0; index <= input.Length / 2; index++)
            {
                int oppositePointer = (input.Length  - 1) - index;
                DisplayMessage($"CurrentPointer: {index} - {input[index]}, OppositePointer: {oppositePointer} - {input[oppositePointer]}");
                char tempChar = input[oppositePointer];

                output[oppositePointer] = input[index];
                output[index] = tempChar;


            }
            DisplayMessage(new String(output));
            return new String(output);
        }
    }
}

