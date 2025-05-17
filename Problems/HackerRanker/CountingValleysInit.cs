using System;
using CodingPractice;

namespace HackerRank
{
    public class CountingValleysInit : AbsProblem, IProblem
    {
        public CountingValleysInit() : base("Counting Valleys Problem")
        {
        }

        public override void Begin()
        {
            /*
             * Count the number of valleys 
             * that was walked acrossed
             * 
             * Valleys are step down from sea
             * level and then back to sea level
             * 
             */
            DisplayQuestionToUser("Enter number of Seteps to Take");
            int n = Convert.ToInt32(Console.ReadLine());

            DisplayQuestionToUser("Enter String of Path");
            string s = Console.ReadLine();

            DisplayMessage($"{CountingValleys(n, s)}");
        }

        private int CountingValleys(int n, string s)
        {
            bool sealevel = true;
            int mountain = 0;
            int valley = 0;
            int valleyCount = 0;

            /*
             *           /\
             * _/\      /  \_
                  \    /
                   \/\/
             * 
             */

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    if (sealevel)
                    {
                        mountain++;
                        sealevel = false;
                    }
                    else
                    {
                        if (valley > 0)
                        {
                            valley--;
                        }
                        else
                        {
                            mountain++;
                        }
                    }
                }
                else if (s[i] == 'D')
                {
                    if (sealevel)
                    {
                        valley++;
                        sealevel = false;
                    }
                    else
                    {
                        if (mountain > 0)
                        {
                            mountain--;
                        }
                        else
                        {
                            valley++;
                        }
                    }
                }

                if (mountain == 0 &&
                    valley == 0)
                {
                    if (s[i] == 'U')
                    {
                        valleyCount++;
                    }

                    sealevel = true;
                }
            }

            return valleyCount;
        }
    }
}
