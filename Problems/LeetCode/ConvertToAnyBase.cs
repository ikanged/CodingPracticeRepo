using System;
namespace CodingPractice.Problems.LeetCode
{
	public class ConvertToAnyBase : AbsProblem, IProblem
    {
		public ConvertToAnyBase() : base("Convert To Any Base")
		{
		}

        public override void Begin()
        {
            var ui = new UserInput();

            DisplayMessage("Enter number to convert");
            var inputString = ui.strUserInput();

            DisplayMessage("Enter base");
            var inputBase = ui.intUserInput();

            var answer = convertedBaseNumber(inputString, inputBase);

        }

        public int convertedBaseNumber(string input, int baseNumber)
        {
            int answer = 0;
            int length = input.Length;
            int power = 1;

            //start from the Right most character
            for(int i = length - 1; i >= 0; i--)
            {
                //character should not be greater than the base number
                if (convertToBaseTen(input[i]) > baseNumber)
                {
                    return -1;
                }
                else
                {
                    answer += convertToBaseTen(input[i]) * power;
                    power = power * baseNumber;
                }
            }

            return answer;
        }

        public int convertToBaseTen(char c)
        {
            //check if char is between 0 and 9
            if(c >= '0' && c <= '9')
            {
                //Return the number that will be 
                return (int)c - '0';
            }
            else
            {
                return (int)c - 'A' + 10;
            }
        }
    }
}

