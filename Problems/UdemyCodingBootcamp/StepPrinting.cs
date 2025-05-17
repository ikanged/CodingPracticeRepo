
using System;
using System.Collections.Generic;
using CodingPractice;

namespace UdemyCodingBootcamp
{
	class StepPrinting : AbsProblem, IProblem
	{
        /*
		 * Write a function that takes in a positive number N. 
		 * The funciton should log step shape with N levels using the # character
		 *	- input: 4
		 *	- output: 
		 *		"#   "
		 *		"##  "
		 *		"### "
		 *		"####"
		 */

        public StepPrinting() : base("Step Printing")
		{

		}

		public override void Begin()
		{		
			var spaces = 10;

			//Iterative solution
			//ConstructSteps(spaces);

			//Recursive Solution
			ConstructRecursiveSteps(spaces);
        }

		public void ConstructRecursiveSteps(int totalChar, int block = 1)
		{
			//base case
			if(block == totalChar)
			{
				return;
			}

			DisplayMessage(GetLine(block, totalChar));
			ConstructRecursiveSteps(totalChar, ++block);
		}

        public void ConstructSteps(int steps)
        {
			for(int i = 1; i <= steps; i++)
			{
				DisplayMessage(GetLine(i, steps));
			}
        }

		private string GetLine(int i, int steps)
		{
			string line = "";

			for(int pound = 0; pound < i; pound++)
			{
				line += "#";
			}
            for (int space = 0; space < steps - i; space++)
            {
                line += "*";
            }
            return line;
		}
	}
}

