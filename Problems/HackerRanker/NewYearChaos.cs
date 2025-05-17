using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace HackerRank
{
	internal class NewYearChaos : AbsProblem, IProblem
	{
		public NewYearChaos() : base("New Year Chaos")
		{
		}

		public override void Begin()
		{
			var input = new List<int> { 2, 1, 5, 3, 4 };

			minimumBribes(input);
			
		}

		private void minimumBribes(List<int> queue)
		{
			int bribes = 0;
			List<int> bribedPositions = new List<int>();

			for (int pos = 0; pos < queue.Count; pos++)
			{
				if(bribedPositions.Contains(pos))
				{
					continue;
				}

				if(queue[pos] != pos+1)
				{
					int bribed = queue[pos] - (pos + 1);
					bribes += bribed;

					if(bribed >= 2)
					{
						for (int i = bribed; i >= 0; i--)
						{
							bribedPositions.Add(pos + (bribed - i));
						}
					}
					else
					{
						bribedPositions.Add(pos + bribed);
					}
				}

				if(bribes >= 3)
				{
					DisplayMessage("Too Chaotic");
					break;
				}
			}

			DisplayMessage(bribes.ToString());
		}
	}
}
