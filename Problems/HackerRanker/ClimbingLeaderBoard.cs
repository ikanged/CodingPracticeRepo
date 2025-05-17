using System;
using System.Collections.Generic;
using CodingPractice;
using System.Linq;
using System.Collections;

namespace HackerRank
{
    public class ClimbingLeaderBoard : AbsProblem, IProblem
    {
        public ClimbingLeaderBoard() : base("Climbing Leader Board")
        {

        }

        /// <summary>
        /// For example, the four players on the leaderboard have high scores of 100, 90, 90, and 80.
        /// Those players will have ranks 1, 2, 2, and 3, respectively. 
        /// If Alice's scores are 70, 80 and 105, her rankings after each game are 4, 3 and 1. 
        /// </summary>
        public override void Begin()
        {
            //DisplayQuestionToUser("Enter Number of Players of LeaderBoard");
            //int scoresCount = Convert.ToInt32(Console.ReadLine());

            //DisplayQuestionToUser("Enter LeaderBoard Scores");
            //int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

            //DisplayQuestionToUser("Enter Number of Alice's Scores");
            //int aliceCount = Convert.ToInt32(Console.ReadLine());

            //DisplayQuestionToUser("Enter Alice's Scores");
            //int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));

            //Test
            var scores = new int[] { 100, 90, 90, 80 };
            var alice = new int[] { 70, 80, 105 };
            //Answer
            int[] result = climbingLeaderboard(scores, alice);

            foreach (var i in result)
            {
                DisplayMessage($"{i}");
            }
        }

        private int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int[] rank = new int[scores.Length + alice.Length];
            int rankIndex = 1;
            ArrayList mergedScores = new ArrayList(scores.Concat(alice).ToArray());

            mergedScores.Sort();
            mergedScores.Reverse();

            rank[0] = rankIndex;
            for (int i = 0; i < mergedScores.Count; i++)
            {
                for (int j = i + 1; j < mergedScores.Count; j++)
                {
                    //Not Working
                    if (mergedScores[i] == mergedScores[j])
                    {
                        rank[j] = rankIndex;
                    }
                    else
                    {
                        rankIndex++;
                        rank[j] = rankIndex;
                    }

                    break;
                }
            }

            return rank;
        }

    }
}
