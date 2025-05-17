using System;
using System.Collections.Generic;
using CodingPractice;
using CodingPractice.Problems.DataStructures;

namespace Algorithms
{
	public class TopologicalSort : AbsProblem, IProblem
    {
        private Graph _graph = new Graph();

		public TopologicalSort() : base("Topological Sort")
		{
            
		}

        public override void Begin()
        {
            //_graph.AddVertex();
        }
    }
}

