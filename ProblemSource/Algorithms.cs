using System.Linq;
﻿using System;
using System.Collections.Generic;
using CodingPractice;
using CodingPractice.Enums;
using CodingPractice.Helpers;
using CodingPractice.Problems.Algorithms.SlidingWindow;
using CodingProblem;

namespace Algorithms
{
    public class AlgorithmProblems : AbsDomain
    {
        private Dictionary<int, AbsProblem> algoritms = new Dictionary<int, AbsProblem>();

        public AlgorithmProblems()
        {
        }

        public override bool BeginProblem(int iUserInput)
        {
            AbsProblem problem;
            ProblemChoices choices = ProblemChoices.SameProblem;
            do
            {
                if (algoritms.TryGetValue(iUserInput, out problem))
                {
                    DisplayMessage("*-----------------------*");
                    problem.Begin();
                }
                else
                {
                    DisplayMessage("*-----------------------*");
                    DisplayMessage("Problem Not Found. Enter Valid Problem");
                }

                choices = problem.RunAgain();
            } while (choices == ProblemChoices.SameProblem);

            return choices == ProblemChoices.Domain;
        }

        public override void DisplayProblems()
        {
            for (int i = 1; i <= algoritms.Count; i++)
            {
                Console.WriteLine($"{i}. {algoritms[i]}");
            }
        }

        public override void InitializeProblems()
        {
            if (algoritms.Count == 0)
            {
                algoritms.Add(1, new MaxSumFixedWindow());
                algoritms.Add(2, new SmallestWindowWithSum());
                algoritms.Add(3, new LongSubstringWithKDistCharacter());
                algoritms.Add(4, new BinarySearch());
                algoritms.Add(5, new MergeSort());
            }
        }

        public override IReadOnlyDictionary<int, string> GetProblems()
        {
            InitializeProblems();
            return algoritms.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Name);
        }
    }
}

