using System;
using HackerRank;
using LeetCode;
using CodingProblem;
using CodingPractice;
using CodingPractice.Helpers;

namespace CodingPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			UserInput userInput = new UserInput();
			MainProgram program = new MainProgram(userInput);

			//Main Application Loop
			program.beginMainProgram();

			DisplayMessage("Program End.");
		}

		// static public bool RunAgain()
		// {
		// 	//New Line
		// 	DisplayMessage("");
		// 	DisplayMessage("Run Again? Enter 1 for Yes");

		// 	bool bRunAgain = false;
		// 	UserInput input = new UserInput();

		// 	if (input.intUserInput() == 1)
		// 	{
		// 		bRunAgain = true;
		// 	}

		// 	return bRunAgain;
		// }

		static public void DisplayMessage(string strMessage)
		{
			Console.WriteLine(strMessage);
		}
	}
}


