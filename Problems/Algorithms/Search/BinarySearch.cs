using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;
using CodingPractice.Problems.DataStructures;

namespace Algorithms
{
    public class BinarySearch : AbsProblem, IProblem
    {
        int[] _input = new int[] { };
        int _target;

        public BinarySearch() : base("Binary Search")
        {

        }

        //Example: { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 }
        public override void Begin()
        {
            int range = 100;
            int elementCount = 19;
            //Generate Random Numbers
            _input = RandomNumber.getRandomNumbers(range, elementCount);
            //Sort the Random Numbers 
            
            DisplayMessage("Binary Search needs a sorted array. Array that will be used:");            
            DisplayArray(_input);
            
            //Sort the array using merge sort
            MergeSort mergeSort = new MergeSort();
            mergeSort.BeginWithData(_input);

            _target = _input[RandomNumber.getRandomNumber(elementCount-1)];
            DisplayMessage($"Target Value: {_target}");

            DisplayMessage($"Index if target value: {GetIndexOfTarget()}");
        }

        /// <summary>
        /// Returns index of found Target. Returns -1 if not found
        /// </summary>
        /// <returns></returns>
        public int GetIndexOfTarget()
        {
            int leftIndex = 0;
            int rightIndex = _input.Length - 1;
            int iterations = 1;

            while(leftIndex <= rightIndex)
            {
                
                int midIndex = GetMidIndex(leftIndex, rightIndex);

                DisplayMessage($"Iteration: {iterations}. Current Values: Left - {leftIndex}, Right - {rightIndex}, Mid - {midIndex}");
                int value = _input[midIndex];

                if (value == _target)
                {
                    return midIndex;
                }
                else if (value < _target)
                {
                    leftIndex = midIndex + 1;
                }
                else
                {
                    rightIndex = midIndex - 1;
                }
                iterations++;
            }

            return -1;
        }

        private int GetMidIndex(int left, int right)
        {
            return left + ((right - left) / 2);
        }
    }
}
