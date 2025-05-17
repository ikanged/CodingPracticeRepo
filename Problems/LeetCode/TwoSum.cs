using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPractice.Problems.LeetCode
{
	public class TwoSum : AbsProblem, IProblem
	{
        Dictionary<int, int> memo = new Dictionary<int, int>();

		public TwoSum() : base("Two Sum")
		{
            /*
             *  Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
             *  You may assume that each input would have exactly one solution, and you may not use the same element twice.
             *  You can return the answer in any order.
             *  
             *  Example:
             *      Input: nums = [2,7,11,15], target = 9
             *      Output: [0,1]
             *
             *      Input: nums = [3,2,4], target = 6
             *      Output: [1,2]
             *
             *      Input: nums = [3,3], target = 6
             *      Output: [0,1]
             * 
             */
        }

        public override void Begin()
        {
            UserInput ui = new UserInput();
            
            DisplayMessage("Enter Input Numbers.");
            var inputArray = ui.intAryUserInput();
            inputArray = new int[]{ 3, 2, 4};

            DisplayMessage("Enter Target Number.");
            var targetNumber = ui.intUserInput();
            targetNumber = 6;

            var answer = getTwoSum(inputArray, targetNumber);
            DisplayArray<int>(answer);
        }

        public int[] getTwoSum(int[] nums, int target)
        {
            //Clear Memoization storage
            memo.Clear();

            var compliment = 0;

            //get the complement of target with the element in array
            for (int i = 0; i < nums.Length; i++)
            {
                if (!memo.ContainsValue(nums[i]))
                {
                    memo.Add(i, nums[i]);
                }

                //get the compliment of the first number
                compliment = target - nums[i];                    
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (compliment <= 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (!memo.ContainsValue(nums[j]))
                        {
                            memo.Add(j, nums[j]);
                        }

                        if (compliment == nums[j])
                        {
                            if(memo.ContainsValue(compliment))
                            {
                                //Don't account for itself!
                                if(memo.FirstOrDefault(value => value.Value == compliment).Key == i)
                                {
                                    continue;
                                }
                                return new int[] { memo.FirstOrDefault(value => value.Value == nums[i]).Key, j };
                            }
                        }
                    }
                }
            }

            return new int[] { };
        }
    }
}

