using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems.UdemyMasterTheCodingInterview.Section13_Sorting
{
	/*
	 * 
	 * Sorting algorithm that is not efficent but can get the job done
	 * TIME: O(N^2), SPACE: O(1)
	 * 
	 * Uses two pointers. 1 pointer will always point to the least number
	 * Another pointer will be the lookup pointer. If the lookup number is 
	 * less than the current, swap
	 * 
	 * Swapping the numbers will cause the algorithm to be unstable 
	 * To make the algorithm stable
	 *	- Move the minimum element to the correct place and shift all the 
	 *		other elements to the right
	 *	- This way, any elements that are the same will remain in its original 
	 *		position
	 * 
	 */
	public static class SelectionSort
	{ 
		//public BeginSort()
		//{
		//}
	}
}
