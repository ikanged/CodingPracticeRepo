using System;
using System.Collections.Generic;
using CodingPractice.Enums;

namespace CodingPractice
{
    public abstract class AbsProblem : IProblem
    {
        private string mProblemName;
        private UserInput mUserInput = new UserInput();

        public AbsProblem(string strProblemName)
        {
            mProblemName = strProblemName;
        }

        public void DisplayMessage(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        public void DisplayArray<T>(IEnumerable<T> items)
		{
            var line = string.Join(",", items);

            Console.WriteLine(line);
		}

        public string Name
		{
            get
			{
                return mProblemName;
			}
		}

        public void DisplayQuestionToUser(string msg)
        {
            DisplayMessage(msg);
            DisplayMessage("*-----------------------*");
        }

        public ProblemChoices RunAgain()
        {
            //New Line
            DisplayMessage("");
            DisplayMessage("*-----------------------*");
            DisplayMessage("Choose: ");
            DisplayChoices();

            ProblemChoices bRunAgain = ProblemChoices.SameProblem;
            UserInput input = new UserInput();

            bRunAgain = (ProblemChoices)input.intUserInput();
           
                       
            return bRunAgain;
        }

        private void DisplayChoices()
        {
            foreach(var choice in Enum.GetValues(typeof(ProblemChoices)))
            {
                Console.WriteLine($"{(int)choice}. {choice} ");
            }
        }

        public int GetUserIntInput()
        {
            return mUserInput.intUserInput();
        }

        public int[] GetUserAryIntInput(int iSize)
        {
            return mUserInput.intAryUserInput();
        }

        public string[] GetUserAryStringInput()
        {
            string strInput = mUserInput.strUserInput();
            string[] straryReturn = strInput.Split(' ');

            return straryReturn;
        }

        public string GetUserStringInput()
        {
            return GetUserStringInput();
        }

		public override string ToString()
		{
            return mProblemName;
		}

		public abstract void Begin();
    }
}