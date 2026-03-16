using System.Linq;
﻿using System.Collections.Generic;
using CodingPractice;
using CodingPractice.Helpers;
using CodingPractice.Problems.DataStructures;
using CodingPractice.Enums;

namespace DataStructure
{
    public class DataStructure : AbsDomain
    {
        private Dictionary<int, AbsProblem> dataStructures = new Dictionary<int, AbsProblem>();

        public DataStructure()
        {
        }

        public override void InitializeProblems()
        {
            if (dataStructures.Count == 0)
            {
                dataStructures.Add(1, new LinkedListDataStructure());
                dataStructures.Add(2, new DynamicArray());
                dataStructures.Add(3, new Graph());
            }
        }
        public override bool BeginProblem(int input)
        {
            AbsProblem problem;
            ProblemChoices choices = ProblemChoices.SameProblem;

            do
            {
                if (dataStructures.TryGetValue(input, out problem))
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
            for (int i = 1; i <= dataStructures.Count; i++)
            {
                DisplayMessage($"{i}. {dataStructures[i]}");
            }
        }

        public override IReadOnlyDictionary<int, string> GetProblems()
        {
            InitializeProblems();
            return dataStructures.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Name);
        }
    }
}
