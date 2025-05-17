
using System;
using System.Collections.Generic;
using CodingPractice;

namespace UdemyCodingBootcamp
{
	class PyramidSteps : AbsProblem, IProblem
	{
        /*
		 * Write a function that takes in a positive number N. 
		 * The funciton should log pyramid shape 
		 * with N levels using the # character. Make sure 
		 * the pyramid has spaces on both the left and right hand sides
		 *	- input: 5
		 *	- output: 
		 *		"    #    " 1
		 *		"   ###   " 3
		 *		"  #####  "	5
		 *		" ####### " 7
		 *		"#########" 9
		 */

        public PyramidSteps() : base("Pyramid Steps Printing")
		{

		}

		public override void Begin()
		{		
			var spaces = 10;

			//Iterative solution
			ConstructSteps(spaces);


			//Recursive Solution
			//ConstructRecursiveSteps(spaces);
        }

		public void ConstructRecursiveSteps(int totalChar)
		{            
           
		}

        public void ConstructSteps(int steps)
        {
			var baseLegnth = GetBaseLength(steps);


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

		private int GetBaseLength(int totalChar)
		{
			int answer = 1;

			for (int i = 1; i < totalChar; i++)
			{
				i += 2;
			}

			return answer;
		}
	}
}

