using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace ProjectEuler
{
    public class EvenFibonacciNumbers : AbsProblem, IProblem
    {
        /*
		 * Find the sum of even valued sequences 
		 * where the sequence is less than 4M
		 * 
		 */
        public EvenFibonacciNumbers() : base("Even Fibonacci Numbers")
        {
        }

        private int maxNum = 4000000; //4000000;
        private int sum = 0;

        public override void Begin()
        {
            sum = 0;
            fibinacciEvenNumSum(maxNum);
        }

        //1, 1, 2, 3, 5, 8, 13, 21....   
        private void fibinacciEvenNumSum(int num)
        {
            int a = 0, b = 1, c = 0;

            while(c <= num)
            {
				if (isEven(c))
				{
					sum += c;
				}

				c = a + b;
                a = b;
                b = c;
			}

            Console.WriteLine($"{sum}");

            
        }

        private bool isEven(int num)
        {
            return num % 2 == 0;
        }

    }
}
