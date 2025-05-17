using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice.Problems.DataStructures;
namespace Algorithms
{
    internal static class DFS
    {
        public static object DepthFirstSearchAll(Graph graph, Vertex startNode)
        {
            Stack<Vertex> vertices = new Stack<Vertex>();
            List<Vertex> processed = new List<Vertex>();

            Console.WriteLine("--------- Depth First Search. All Nodes ---------");
            StringBuilder sb = new StringBuilder();

            //Find the starting vertex in the graph
            var startingVertex = graph.Vertices.Find(node => node == startNode);

            if (startingVertex != null)
            {
                vertices.Push(startingVertex);

                while (vertices.Count > 0)
                {
                    var vertex = vertices.Pop();

                    processed.Add(vertex);

                    sb.Append($"Vertex [{vertex.Value}]");

                    if (vertex.Neighbors.Count > 0)
                    {
                        sb.Append(": Neighbors - ");
                        foreach (var neighbor in vertex.Neighbors)
                        {
                            sb.Append($"{neighbor.Value} -> ");
                            if (!vertices.Contains(neighbor) && processed.Find(vert => vert == neighbor) == null)
                            {
                                vertices.Push(neighbor);
                            }
                        }
                    }

                    Console.WriteLine(sb.ToString());
                    sb.Clear();
                }
            }

            return null;
        }
    }
}
