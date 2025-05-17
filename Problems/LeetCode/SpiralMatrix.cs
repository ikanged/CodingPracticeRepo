using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPractice.Problems.LeetCode
{
	internal class SpiralMatrix : AbsProblem, IProblem
	{
		public SpiralMatrix() : base("Sprial Matrix")
		{
		}

		public override void Begin()
		{
			//Initialize input array 3 x 3
			int[,] inputArray = new int[3,4] { { 1, 2, 3,4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

			DisplayArray(displayArraySpiral(inputArray));
		}

		private int[] displayArraySpiral(int[,] inputArray)
		{
			int numCount = inputArray.GetLength(0) * inputArray.GetLength(1);
			int[] output = new int[numCount];
			//Direction of the output
			int direction = 0;
			int counter = 0;
			//Pointers 
			int top =0, bottom =inputArray.GetLength(0) -1, left =0, right = inputArray.GetLength(1) -1;

			while(numCount != 0)
			{
				//start with left to right
				if(direction == 0)
				{
					for (int i = left; i <= right; i++)
					{
						output[counter] = inputArray[top, i];
						counter++;
						numCount--;
					}

					top++;
				}
				//Top To bottom
				else if(direction == 1)
				{
					for (int i = top; i <= bottom; i++)
					{
						output[counter] = inputArray[i, right];
						counter++;
						numCount--;
					}

					right--;
				}
				//right to left
				else if (direction == 2)
				{
					for (int i = right; i >= left; i--)
					{
						output[counter] = inputArray[bottom, i];
						counter++;
						numCount--;
					}

					bottom--;
				}
				//Bottom to top
				else if (direction == 3)
				{
					for (int i = bottom; i >= top; i--)
					{
						output[counter] = inputArray[i, left];
						counter++;
						numCount--;
					}

					left++;
				}

				direction++;
				//Reset to going from left to right after it has made a full spiral
				direction = direction % 4;
			}

			return output;
		}
	}
}
