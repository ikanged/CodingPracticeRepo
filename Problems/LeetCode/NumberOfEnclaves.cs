using System;
using System.Linq;

namespace CodingPractice.Problems.LeetCode
{
	public class NumberOfEnclaves : AbsProblem, IProblem
	{
		public NumberOfEnclaves() : base("Number Of Enclaves")
		{
		   /**
            * You are given an m x n binary matrix grid, 
            * where 0 represents a sea cell and 1 represents a land cell.
                A move consists of walking from one land cell to another adjacent 
                (4-directionally) land cell or walking off the boundary of the grid.
                Return the number of land cells in grid for which we cannot walk off 
                the boundary of the grid in any number of moves.
            * 
            **/
        }

        public override void Begin()
        {
			int[,] input = new int[,] { { 0, 0, 0, 0}, 
                                        { 1, 0, 1, 0 }, 
                                        { 0, 1, 1, 0 }, 
                                        { 0, 0, 0, 0 } };

			Console.WriteLine($"Number of Enclaves: {findEnclaves(input)}");
        }
		/// <summary>
		/// Returns most profit that can be earned for the set.
		/// </summary>
		/// <param name="prices"></param>
		/// <returns></returns>
		public int findEnclaves(int[,] input)
		{
            int enclaves  = 0;
            int x = input.GetLength(0);
            int y = input.GetLength(1);
            
            for(int row = 0; row < x; row++)
            {
                for(int col = 0; col < y; col++)
                {
					if (input[row, col] == 0)
					{
						continue;
					}
					else
					{
						dfs(row, 0, input);
					}
				}
            }


            return enclaves;
        }

        private bool dfs(int i, int j, int[,] grid)
        {


            return false;
        }
    }
}

