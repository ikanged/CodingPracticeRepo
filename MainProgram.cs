using System;
using System.Collections.Generic;
using CodingPractice.Helpers;
using HackerRank;
using LeetCode;
using CodingProblem;
using DesignPatterns;
using GeeksForGeeks;
using CodingPractice.Enums;
using DataStructure;
using ProjectEuler;
using Algorithms;
using UdemyAlgorithms;
using Interview;

namespace CodingPractice
{
    class MainProgram : ProblemFactory
    {
        private UserInput _userInput;
        private Dictionary<int, AbsDomain> domains = new Dictionary<int, AbsDomain>();
        public MainProgram(UserInput input)
        {
            _userInput = input;
        }

        public void beginMainProgram()
        {
            AbsDomain domain = null;
            
            if (domains.Count == 0)
            {
                InitializeDomains();
            }
           
            int iUserInput;
            bool runAgain = false;

            do
            {
                DisplayMessage("Choose Domain: ");
                DisplayMessage($"*-------------------*");
                DisplayDomains();
                iUserInput = _userInput.intUserInput();

                domains.TryGetValue(iUserInput, out domain);

                DisplayMessage($"*---------{ domain}---------*");

                if (domain == null)
                {
                    DisplayMessage("Invalid Domain Choice. Enter again");                    
                }
                else
                {
                   runAgain = ExecuteProblem(domain, runAgain);
                }

            } while (runAgain);
        }

        public override void InitializeDomains()
        {
            //Initialize collection of domains by domain name
            foreach (var domain in Enum.GetValues(typeof(Domains)))
            {
                domains.Add(Convert.ToInt32(domain), getDomain(domain.ToString()));
            }
        }

        public override void DisplayDomains()
        {
            foreach (var item in Enum.GetValues(typeof(Domains)))
            {
                DisplayMessage($"{Convert.ToInt32(item)}. {item}");
            }
        }

        public void DisplayMessage(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        private AbsDomain getDomain(string domainName)
        {
            AbsDomain domain = null;

            if (domainName == Domains.HackerRank.ToString())
            {
                domain = new HackerRankProblems();
            }
            else if (domainName == Domains.CodingProblems.ToString())
            {
                domain = new CodingProblems();
            }
            else if (domainName == Domains.LeetCode.ToString())
            {
                domain = new LeetCodeProblems();
            }
            else if (domainName == Domains.HeadFirstDesignPattern.ToString())
            {
                domain = new HeadFirstDesignPatterns();
            }
            else if (domainName == Domains.GeeksForGeeks.ToString())
            {
                domain = new GeeksForGeeksProblems();
            }
            else if (domainName == Domains.DataStructure.ToString())
            {
                domain = new DataStructure.DataStructure();
            }
            else if (domainName == Domains.ProjectEuler.ToString())
            {
                domain = new ProjectEulerProblems();
            }
            else if (domainName == Domains.Algorithms.ToString())
            {
                domain = new AlgorithmProblems();
            }
            else if (domainName == Domains.UdemyAlgorithms.ToString())
            {
                domain = new UdemyBibleOfAlgorithmsProblems();
            }
            else if(domainName == Domains.InterviewQuestions.ToString())
            {
                domain = new InterviewQuestions();
            }
            else if(domainName == Domains.UdemyCodingInterview.ToString())
            {
                domain = new UdemyCodingBootcampProblems();
            }

            return domain;
        }
    }
}
