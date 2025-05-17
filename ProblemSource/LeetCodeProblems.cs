using System;
using System.Collections.Generic;
using CodingPractice;
using CodingPractice.Problems.LeetCode;
using CodingPractice.Helpers;
using CodingPractice.Enums;

namespace LeetCode
{
    class LeetCodeProblems : AbsDomain
    {
        private Dictionary<int, AbsProblem> lcProblems = new Dictionary<int, AbsProblem>();
        private List<AbsProblem> problems = new List<AbsProblem>(); 
        private int nextIndex = 0;

        public LeetCodeProblems()
        {
        }

        public override void InitializeProblems()
        {
            InitProblemStore();

            if (lcProblems.Count == 0)
            {
                foreach(var problem in problems)
                {
                    AddProblem(problem);
                }
                //lcProblems.Add(1, new AddTwoNumbers());
                //lcProblems.Add(2, new BinarySearch());
                //lcProblems.Add(3, new FirstBadVersion());
                //lcProblems.Add(4, new SearchInsertPosition());
                //lcProblems.Add(5, new SquareOfSortedArray());
                //lcProblems.Add(6, new SpiralMatrix());
                //lcProblems.Add(7, new MultiplyComplexNum());
                //lcProblems.Add(8, new NumToRoman());
                //lcProblems.Add(9, new FlipMonotoneIncrease());
                //lcProblems.Add(10, new TwoSum());
                //lcProblems.Add(11, new ConvertToAnyBase());
                //lcProblems.Add(12, new LongestSubstringNoRepeat());
                //lcProblems.Add(13, new BuySellStockBestTime());
                //lcProblems.Add(14, new ValidParentheses());
                //lcProblems.Add(15, new LongestCommonPrefix());
                //lcProblems.Add(16, new FirstUniqueCharacter());
                //lcProblems.Add(17, new MoveZeroes());
                //lcProblems.Add(18, new PowerOfThree());
                //lcProblems.Add(19, new ReverseAString());
            }
        }

        private void InitProblemStore()
        {
            problems.Add(new AddTwoNumbers());
            problems.Add(new BinarySearch());
            problems.Add(new FirstBadVersion());
            problems.Add(new SearchInsertPosition());
            problems.Add(new SquareOfSortedArray());
            problems.Add(new SpiralMatrix());
            problems.Add(new MultiplyComplexNum());
            problems.Add(new NumToRoman());
            problems.Add(new FlipMonotoneIncrease());
            problems.Add(new TwoSum());
            problems.Add(new ConvertToAnyBase());
            problems.Add(new LongestSubstringNoRepeat());
            problems.Add(new BuySellStockBestTime());
            problems.Add(new ValidParentheses());
            problems.Add(new LongestCommonPrefix());
            problems.Add(new FirstUniqueCharacter());
            problems.Add(new MoveZeroes());
            problems.Add(new PowerOfThree());
            problems.Add(new ReverseAString());
            problems.Add(new IntersectTwoArrays());
            problems.Add(new SingleNumber());
        }

        private void AddProblem(AbsProblem absProblem)
        {
            lcProblems.Add(nextIndex, absProblem);
            nextIndex++;
        }

        public override bool BeginProblem(int iUserInput)
        {
            AbsProblem problem;
            ProblemChoices choices = ProblemChoices.SameProblem;

            do
            {
                if (lcProblems.TryGetValue(iUserInput, out problem))
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
            for (int i = 0; i < lcProblems.Count; i++)
            {
                Console.WriteLine($"{i}. {lcProblems[i]}");
            }
        }
    }
}
