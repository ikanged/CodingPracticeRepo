using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace HackerRank
{
	public class CloudJumpInit : AbsProblem, IProblem
	{
		public CloudJumpInit() : base("Minimum Cloud Jumping Problem")
		{

		}

		public override void Begin()
		{
			/*
			 * For each game, Emma will get an array of cloads numbered 0 if they are safe 
			 * or 1 if they must be avoided. For example c=[0,1,0,0,0,1,0] indexed from 0...6
			 * The number on each cloud is its index in the list so she must avoid the clouds at 
			 * indexes 1 and 5. She could follow the following two paths: 0, 2, 4, 6 or 0, 2, 3, 4, 6
			 * The first path takes 3 jumpes while the second takes 4. 
			 * 
			 * Determine the minimum number of jumps it will take Emma to jump from her
			 * starting positon to the last cloud
			 * 
			 * Input:
			 *	n: Total number of clouds 
			 *	n space seperated binary integers
			 *	
			 * 
			 */


			DisplayQuestionToUser("Enter Number of clouds:");
			int n = Convert.ToInt32(Console.ReadLine());

			DisplayQuestionToUser("Enter cloud Numbers:");
			int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

			int minimumCloudJumps = jumpingOnClouds(c);

			DisplayQuestionToUser("Minimum Jumps: ");
			Console.WriteLine(minimumCloudJumps);
		}

		public int jumpingOnClouds(int [] clouds)
		{
			int answer = 0;



			return answer;
		}
	}
}
