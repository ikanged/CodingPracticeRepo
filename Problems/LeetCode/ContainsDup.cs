using System;
using System.Collections.Generic;

namespace CodingPractice.Problems.LeetCode
{
    public class ContainsDup : AbsProblem, IProblem
    {
        public ContainsDup() : base("Contains Duplicate")
        {
            
        }

        public override void Begin()
        {
            var input = new int[] { 1, 2, 3, 1 };
            DisplayMessage($"Contains Dup: {isDup(input)}");
        }

        public bool isDup(int[] inputs)
        {
            bool answer = false;
            Dictionary<int, int> collection = new Dictionary<int, int>();

            foreach(var num in inputs) {
                if(collection.ContainsKey(num))
                {
                    collection[num]++;
                    if (collection[num] >= 2)
                    {
                        answer = true;
                        break;
                    }
                }
                else
                {
                    collection[num] = 1;
                }
            }

            return answer;
        }
    }
}

