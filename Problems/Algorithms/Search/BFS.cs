using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice.Problems.DataStructures;

namespace Algorithms
{
    internal static class BFS
    {
        public static void BreadthFirstSearchAll(Graph graph, Vertex startNode)
        {
            Queue<Vertex> vertices = new Queue<Vertex>();
            List<Vertex> processed = new List<Vertex>();

            Console.WriteLine("--------- Breadth First Search. All Nodes ---------");
            StringBuilder sb = new StringBuilder();

            //Find the starting vertex in the graph 
            var startVertex = graph.Vertices.Find(node => node == startNode);

            if (startVertex != null)
            {
                vertices.Enqueue(startVertex);


                while (vertices.Count > 0)
                {
                    var vertex = vertices.Dequeue();

                    //Add it to the processed list
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
                                vertices.Enqueue(neighbor);
                            }
                        }
                    }
                    Console.WriteLine(sb.ToString());
                    sb.Clear();
                };

            }
        }
    }
}
