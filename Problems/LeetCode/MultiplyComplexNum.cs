using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
    public class MultiplyComplexNum : AbsProblem, IProblem
    {
        public MultiplyComplexNum() : base("Multiply Complex Numbers")
        {

        }

        public override void Begin()
        {
            string num1 = "1+-1i";
            string num2 = "1+-1i";

            var sum = sumOfComplexNum(num1, num2);
            DisplayMessage(sum);
        }

        private static string sumOfComplexNum(string num1, string num2)
        {
            StringBuilder answer = new StringBuilder();

            List<int> normNum1 = extractNumbers(num1);
            List<int> normNum2 = extractNumbers(num2);

            //normNum1[0] = a1
            //normNum1[1] = a2
            //normNum2[0] = b1
            //normNum2[1] = b2
            Console.WriteLine($"{normNum1[0]}, {normNum1[1]}");
            Console.WriteLine($"{normNum2[0]}, {normNum2[1]}");

            int realSum = (normNum1[0] * normNum2[0]) + (normNum1[1] * normNum2[1] * -1);
            int imagSum = (normNum1[0] * normNum2[1]) + (normNum1[1] * normNum2[0]);

            Console.WriteLine($"{realSum}, {imagSum}");

            //Put together the complex number
            // (real) + ([-](imaginary) i )
            answer.Append($"{realSum}+{imagSum}i");

            return answer.ToString();
        }

        private static List<int> extractNumbers(string num)
        {
            List<int> answer = new List<int>();
            if (!string.IsNullOrWhiteSpace(num))
            {
                var parts = num.Split('+'); //O(N)
                int realNum;
                int.TryParse(parts[0], out realNum); //Number can only be from -100 to 100

                var imaginaryPart = parts[1].Split('i'); // O(N)
                int imagNum;
                int.TryParse(imaginaryPart[0], out imagNum);

                answer.Add(realNum);
                answer.Add(imagNum);
            }

            return answer;
        }
    }
}
