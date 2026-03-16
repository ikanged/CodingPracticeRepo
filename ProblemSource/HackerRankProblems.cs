using System.Linq;
﻿using System.Collections.Generic;
using System;
using CodingPractice;
using CodingPractice.Helpers;
using CodingPractice.Enums;

namespace HackerRank
{
    public class HackerRankProblems : AbsDomain
    {
        //Collection of all HackerRank Problems
        private Dictionary<int, AbsProblem> problems = new Dictionary<int, AbsProblem>();

        public HackerRankProblems()
        {
        }

        public override void InitializeProblems()
        {
            if (problems.Count == 0)
            {
                problems.Add(1, new RotateArray());
                problems.Add(2, new Anagrams());
                problems.Add(3, new RansomNoteGenerator());
                problems.Add(4, new DoubleyLinkedList());
                problems.Add(5, new BubbleSort());
                problems.Add(6, new TriesContactsApplication());
                problems.Add(7, new IceCreamParlor());
                problems.Add(8, new StackImp());
                problems.Add(9, new CommonChar());
                problems.Add(10, new SumOfDiagonalArray());
                problems.Add(11, new PlusMinus());
                problems.Add(12, new sumMinMax());
                problems.Add(13, new BirthdayCakeCandles());
                problems.Add(14, new TimeConversion());
                problems.Add(15, new GradingStudents());
                problems.Add(16, new ApplesAndOranges());
                problems.Add(17, new SaveThePrisioner());
                problems.Add(18, new ClimbingLeaderBoard());
                problems.Add(19, new SockMerchant());
                problems.Add(20, new BonAppetitInit());
                problems.Add(21, new DrawingBookInit());
                problems.Add(22, new CountingValleysInit());
                problems.Add(23, new ElectronicsShopInit());
                problems.Add(24, new ChocoFeastInit());
                problems.Add(25, new CloudJumpInit());
                problems.Add(26, new BiggerIsGreater());
                problems.Add(27, new SparseArrays());
                problems.Add(28, new LeftRotateArray());
                problems.Add(29, new NewYearChaos());
                problems.Add(30, new Mini_MaxSum());
                problems.Add(31, new LonleyInteger());
                //problems.Add(32, new MigratoryBirds());
            }
        }

        public override bool BeginProblem(int iUserInput)
        {
            AbsProblem problem = null;
            ProblemChoices choices = ProblemChoices.SameProblem;
            
            do
            {
                if (problems.TryGetValue(iUserInput, out problem))
                {
                    DisplayMessage("*-----------------------*");
                    problem?.Begin();
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
            for (int i = 1; i <= problems.Count; i++)
            {
                Console.WriteLine($"{i}. {problems[i]?.Name}");
            }
        }

        public override IReadOnlyDictionary<int, string> GetProblems()
        {
            InitializeProblems();
            return problems.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Name);
        }
    }
}
