using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.DataStructures
{
	class DynamicArray : AbsProblem, IProblem
	{
		public DynamicArray() : base("Dynamic Array")
		{

		}

		public override void Begin()
		{
			/*
			 * This data structure will 
			 *  1. Initially ask for data to be inserted.
			 *  2. It can insert data into an given index - O(n)
			 *  3. It can delete data from given index - O(n)
			 *  4. Get data from given index - O(n)
			 *  5. It can append data at the end of the array - O(1), rarely does the array need to be resized.
			 * 
			 */

			//Get User Input
			DisplayMessage("Enter String to Array");
		}
	}
}
