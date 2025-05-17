using System;
using System.Collections.Generic;
using CodingPractice.Helpers;
using CodingPractice.Enums;
using CodingPractice;

namespace DesignPatterns
{
    class HeadFirstDesignPatterns : AbsDomain
    {
        private Dictionary<int, AbsProblem> sections = new Dictionary<int, AbsProblem>();

        public HeadFirstDesignPatterns()
        {

        }

        public override bool BeginProblem(int input)
        {
            AbsProblem problem = null;
            ProblemChoices choices = ProblemChoices.SameProblem;
            
            do
            {
                if (sections.TryGetValue(input, out problem))
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
            for (int i = 1; i <= sections.Count; i++)
            {
                Console.WriteLine($"{i}. {sections[i].Name}");
            }
        }

        public override void InitializeProblems()
        {
            foreach (var section in Enum.GetValues(typeof(HF_DesignPatterns)))
            {
                sections.Add(Convert.ToInt32(section), getSection(section));
            }
        }

        private AbsProblem getSection(object section)
        {
            AbsProblem problem = null;
            string sectionName = Enum.GetName(typeof(HF_DesignPatterns), section);

            if (sectionName != null)
            {
                if (HF_DesignPatterns.Intro.ToString() == sectionName)
                {
                    problem = new DesignPatternIntro();
                }
                if (HF_DesignPatterns.ObserverPattern.ToString() == sectionName)
                {
                    problem = new ObservablePattern();
                }
                if (HF_DesignPatterns.DecoratorPattern.ToString() == sectionName)
                {
                    problem = new DecoratorPattern();
                }
            }

            return problem;
        }
    }
}
