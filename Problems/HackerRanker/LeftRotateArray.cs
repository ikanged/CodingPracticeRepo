using System;
using System.Collections.Generic;
using CodingPractice;

namespace HackerRank
{
    public class LeftRotateArray : AbsProblem, IProblem
    {
        public LeftRotateArray() : base("Left Rotate Array")
        {
        }

        public override void Begin()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            int numRotate = 2;

            var rotatedArray = leftRotate(input, numRotate);

            DisplayArray(rotatedArray);
        }

        private int[] leftRotate(List<int> source, int numRotate)
        {
            int[] dest = new int[source.Count];
            int rotate = numRotate % source.Count;

            if (rotate > 0)
            {
                Array.Copy(source.ToArray(), rotate, dest, 0, source.Count - rotate);

                int destStart = source.Count - rotate;
                int destTo =rotate;

                Array.Copy(source.ToArray(), 0, dest, destStart, destTo);
            }
            else if (rotate <= 0)
            {
                dest = source.ToArray();
            }

            return dest;
        }
    }
}
