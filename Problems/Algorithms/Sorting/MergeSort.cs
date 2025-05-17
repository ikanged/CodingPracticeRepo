using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using CodingPractice;

namespace Algorithms
{
	public class MergeSort : AbsProblem, IProblem
    {
        int[] _input;

		public MergeSort() : base("Merge Sort")
		{
            
		}

        public override void Begin()
        {
            DisplayMessage($"Unsorted Array:");
            _input = RandomNumber.getRandomNumbers(50, 9);
            
            DisplayArray(_input);            
            mergeSort(_input);
            
            DisplayMessage("Sorted Array: ");
            DisplayArray(_input);
        }

        public void BeginWithData(int[] data)
        {
            DisplayMessage($"Unsorted Array:");
            
            DisplayArray(data);            
            mergeSort(data);
            
            DisplayMessage("Sorted Array: ");
            DisplayArray(data);
        }

        public void mergeSort(int[] input)
        {
            int arrLength = input.Length;

            //Base case where all elements in the array are within its own array
            if(arrLength < 2)
            {
                return;
            }
            
            //1. Find Half the array
            //Find Middle index
            int middleIndex = input.Length / 2;

            int leftArrLength = middleIndex;
            int rightArrLength = input.Length - middleIndex;
            
            //Define the two arrays that will be used to store the divisions
            int[] leftArr = new int[leftArrLength];
            int[] rightArr = new int[rightArrLength];

            //2. Populate the two half of arrays
            for(int i = 0; i < leftArrLength; i++)
            {
                leftArr[i] = input[i];
            }

            for(int i = middleIndex; i < input.Length; i++)
            {
                rightArr[i - middleIndex] = input[i];
            }

            //3. Recursively divide the array
            mergeSort(leftArr);
            mergeSort(rightArr);

            //Merge the two halves
            merge(input, leftArr, rightArr);
        }

        private void merge(int[] array, int[] leftArr, int[] rightArr)
        {
            //Define the two arrays that will be used to store the divisions
            int leftArrLength = leftArr.Length;
            int rightArrLength = rightArr.Length;
            
            //Define index of each array
            int leftIndex = 0, rightIndex = 0, mergeIndex = 0;
        
            //This will be the main loop that will merge the two arrays
            while(leftIndex < leftArrLength && rightIndex < rightArrLength)
            {
                if(leftArr[leftIndex] <= rightArr[rightIndex])
                {
                    array[mergeIndex] = leftArr[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[mergeIndex] = rightArr[rightIndex];
                    rightIndex++;
                }

                mergeIndex++;
            }

            //Next two loops will merge any remaining elements in left or right array
            while (leftIndex < leftArrLength) 
            {
                array[mergeIndex] = leftArr[leftIndex];
                leftIndex++;
                mergeIndex++;
            }

            while (rightIndex < rightArrLength)
            {
                array[mergeIndex] = rightArr[rightIndex];
                rightIndex++;
                mergeIndex++;
            }
        }
    }
}

