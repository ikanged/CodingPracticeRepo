
using System;
using System.Collections.Generic;
using CodingPractice;

namespace UdemyCodingBootcamp
{
	class ChunkArray : AbsProblem, IProblem
	{
        /*
		 * Given an array of ints, return set of arrays that are divided up to 
		 * the chunk size
		 *	- input: [1,2,3,4,5,6], Chunk Size: 2 -> output: [[1,2], [3,4], [5,6]]
		 */

        public ChunkArray() : base("Chunk Array")
		{

		}

		public override void Begin()
		{
			var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8,9};
			var chunkSize = 4;

			DisplayMessage($"Array Split in to chuncks size: {chunkSize} is ");
			foreach(var item in getChunckSize(input, chunkSize))
			{
				DisplayArray(item);
			}
		}

        public int[][] getChunckSize(int[] input, int chunkSize)
        {
			int outputSize = input.Length % chunkSize != 0 ? ((input.Length / chunkSize) + 1) : (input.Length / chunkSize);
			int[][] arrayAnswer = new int[outputSize][];
			int startIndex = 0;

			//Divide the input array into chunk size
			for(int i = 0; i < outputSize; i++)
			{
				if(startIndex + chunkSize <= input.Length)
				{
					arrayAnswer[i] = new ArraySegment<int>(input, startIndex, chunkSize).ToArray();
                    startIndex += chunkSize;
                }
				else
				{
					arrayAnswer[i] = new ArraySegment<int>(input, startIndex, input.Length - startIndex).ToArray();
                }
			}

			return arrayAnswer;
        }
	}
}

