using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace ProjectEuler
{
	public class MultiplesOf3Or5 : AbsProblem, IProblem
	{
		/*
		 *	Find the sum of all multiples that are less than 1000 
		 *  Multiples being 3 and 5
		 * 
		 */
		public MultiplesOf3Or5() : base("Multiples of 3 or 5")
		{

		}

		public override void Begin()
		{
			var multiThree = 3;
			var multiFive = 5;
			var sum = 0;
			var max = 1000;

			//Brute force
			for (int i = 1; i < max; i++)
			{
				multiThree = 3 * i;
				if(multiThree < max)
				{
					sum += multiThree;
					DisplayMessage($"Current Sum 3: {sum}, i: {i}, multi: {multiThree}");
				}

				multiFive = 5 * i;
				if (multiFive < max)
				{
					sum += multiFive;
					DisplayMessage($"Current Sum 5: {sum}, i: {i}, multi: {multiFive}");
				}
			}

			DisplayMessage($"Sum of all multiples: {sum}");
		}
	}
}
