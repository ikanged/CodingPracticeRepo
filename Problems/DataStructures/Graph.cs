using System;
using System.Collections.Generic;
using System.Text;
using Algorithms;

namespace CodingPractice.Problems.DataStructures
{
    class Graph: AbsProblem, IProblem
    {
        Graph graph;
        List<Vertex> _vertices;
        public Graph() : base("Graph Data Structure")
        {
            _vertices = new List<Vertex>();
        }

        public List<Vertex> Vertices { get { return _vertices; } }

        //Public Methods
        public override void Begin()
        {
            UserInput ui = new UserInput();

            //Initialize Graph with Vertices and connect them
            graph = new Graph();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);
            graph.AddVertex(7);
            graph.AddVertex(8);

            graph.AddUDEdge(1, 4);
            graph.AddUDEdge(1, 5);
            graph.AddUDEdge(1, 3);
            graph.AddUDEdge(1, 7);
            graph.AddUDEdge(2, 5);
            graph.AddUDEdge(2, 8);
            graph.AddUDEdge(2, 4);
            graph.AddUDEdge(2, 6);
            graph.AddUDEdge(5, 6);

            //Perform BFS
            BFS.BreadthFirstSearchAll(graph, new Vertex(6));

            DisplayQuestionToUser("Start Depth First Search Algo? Y/N");
            var display = ui.charUserInput();

            //Perfrom DFS
            var execute = display.ToString().ToLower() == "y" ? DFS.DepthFirstSearchAll(graph, new Vertex(6)) : null;			
        }

        public bool AddVertex(int value)
        {
            var newVertex = new Vertex(value);
            if (_vertices.Contains(newVertex))
            {
                return false;
            }
            else
            {
                _vertices.Add(newVertex);
                return true;
            }
        }

        public bool AddUDEdge(int nodeValueStart, int nodeValueEnd)
        {
            var startVertex = Vertices.Find(vert => vert == new Vertex(nodeValueStart));
            var endVertex = Vertices.Find(vert => vert == new Vertex(nodeValueEnd));

            if (endVertex != null && startVertex != null)
            {
                //undirected graph - start and end vertex are neighbors of each other
                startVertex.AddNeighbor(endVertex);
                endVertex.AddNeighbor(startVertex);
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool AddDirectedEdge(int nodeValueStart, int nodeValueEnd)
        {
            var startVertex = Vertices.Find(vert => vert == new Vertex(nodeValueStart));
            var endVertex = Vertices.Find(vert => vert == new Vertex(nodeValueEnd));

            if(endVertex != null && startVertex != null)
            {
                startVertex.AddNeighbor(endVertex);
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
