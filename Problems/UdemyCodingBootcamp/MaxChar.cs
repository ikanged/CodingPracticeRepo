
using CodingPractice;

namespace UdemyCodingBootcamp
{
	class ReverseInt : AbsProblem, IProblem
	{
        /*
		 * Reverse the integer
		 *	- input: -10122 -> output: "-22101"
		 */

        public ReverseInt() : base("Reverse Integer")
		{

		}

		public override void Begin()
		{
            int input = -1000;

            DisplayMessage($"Reverse Integer of : {input} is {reverseNumber(input)}");

		}

        public int reverseNumber(int input)
        {
            bool isNeg = input < 0;
			int answer = 0;

            //Make it into a positive number
            if (isNeg)
            {
                input *= -1;
            }

            var inputToString = input.ToString().ToCharArray();
			var temp = input.ToString().ToCharArray();

            for (int i = 0; i < inputToString.Length/2; i++)
			{
				int endPoint = (inputToString.Length - 1) - i;
				char endChar = inputToString[endPoint];

				inputToString[endPoint] = temp[i];
				inputToString[i] = endChar;
            }

			//Convert the string to int
			int.TryParse(new string(inputToString), out answer);

			//Return the answer with the negation if required
			return isNeg ? answer *= -1 : answer;
        }        
	}
}

