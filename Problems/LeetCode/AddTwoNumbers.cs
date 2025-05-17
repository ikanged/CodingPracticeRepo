using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace CodingPractice.Problems.LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class AddTwoNumbers : AbsProblem, IProblem
    {
        public AddTwoNumbers() : base("Add Two Numbers")
        {
        }

        public override void Begin()
        {
            UserInput userInput = new UserInput();

            DisplayQuestionToUser("Enter First Set of Numbers:");
            var input1 = userInput.intAryUserInput();

            DisplayQuestionToUser("Enter Second Set of Numbers: ");
            var input2 = userInput.intAryUserInput();

            //DisplayMessage($"Sum of the two numbers reversed is: {sumOfNumbers(input1, input2)}");
        }

        //private int[] sumOfNumbers(int[] i1, int[] i2)
        //{
        //	int[] answer;



        //	return answer;
        //}
    }
}
