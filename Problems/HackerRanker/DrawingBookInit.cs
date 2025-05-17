using System;
using CodingPractice;

namespace HackerRank
{
    public class DrawingBookInit : AbsProblem, IProblem
    {
        public DrawingBookInit() : base("Drawing Book Problem")
        {
        }

        public override void Begin()
        {
            /*
             * Find the Minimum number of pages that 
             * need to be turned to reach the Page Number
             * 
             * It can start from the end of book or at the beginning
             * 
             * */
            DisplayQuestionToUser("Enter Number of Pages in the Book:");
            int n = Convert.ToInt32(Console.ReadLine());

            DisplayQuestionToUser("Enter Page Number To Turn To");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Minimum Number of pages to Turn to get to page {p}: {getPageCount(n, p)}");
        }

        private int getPageCount(int n, int p)
        {
            //Example input
            //n = 2
            //p = 1
            //output = 0

            //Base Case
            if (n - p == 1)
            {
                if (n % 2 == 0)
                {
                    if (p == 1)
                    {
                        return p / 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 0;
                }
            }

            int pagesTurnedFromEnd = (n - p) / 2;
            int pagesTurnedFromBeginning = p / 2;

            if (pagesTurnedFromBeginning > pagesTurnedFromEnd)
            {
                return pagesTurnedFromEnd;
            }
            else
            {
                return pagesTurnedFromBeginning;
            }
        }
    }
}
