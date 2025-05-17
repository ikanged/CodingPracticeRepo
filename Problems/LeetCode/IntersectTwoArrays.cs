using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class IntersectTwoArrays : AbsProblem, IProblem
	{
		public IntersectTwoArrays() : base("Intersect Two Arrays")
		{
            /*
             *  
             *  Given two integer arrays nums1 and nums2, return an array of their intersection. 
             *  Each element in the result must appear as many times as it shows in both 
             *  arrays and you may return the result in any order.
             *  
             *   Input: nums1 = [1,2,2,1], nums2 = [2,2]
             *   Output: [2,2]
             *  
             *
             */
        }

        public override void Begin()
        {
            int[] input1 = new int[] { 1,2 };
            int[] input2 = new int[] { 2,1};

            //Should [2,2]
            DisplayArray(findIntersect(input1, input2));            
        }

        public int[] findIntersect(int[] input1, int[] input2)
        {
            List<int> intersects = new List<int>();
            int[] collection = new int[1001];

            //Collections will hold the flag for each
            //element that is in both collections 
            for(int i = 0; i < input1.Length; i++)
            {
                collection[input1[i]]++;
            }

            //Each element in input1 will indicate
            //if the element has been encountered
            for(int i = 0; i < input2.Length; i++)
            {
                //For element that is greater than 0,
                //it means that the element is in input1
                if (collection[input2[i]] > 0)
                {
                    intersects.Add(input2[i]);
                    collection[input2[i]]--;
                }
            }

            return intersects.ToArray();

            //var smallerCollection = input1.Length < input2.Length ? input1 : input2;
            //var largerCollection = input1.Length >= input2.Length ? input1 : input2;

            //int indexSmall = 0;
            //int indexLarger = 0;
            //while(indexSmall <= smallerCollection.Length -1)
            //{
            //    while(indexLarger <= largerCollection.Length -1)
            //    {
            //        if (smallerCollection[indexSmall]  == largerCollection[indexLarger] )
            //        {
            //            if (intersects.Count > 0 && !intersects.Contains(largerCollection[indexLarger]))
            //            {

            //            }
            //            intersects.Add(largerCollection[indexLarger]);
            //            indexLarger++;
            //            break;
            //        }
            //        else
            //        {
            //            indexLarger++;
            //        }
            //    }

            //    indexSmall++;
            //}
            //return intersects.ToArray();
        }
    }
}

