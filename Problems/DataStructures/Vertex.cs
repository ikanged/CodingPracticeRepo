using System;
using System.Collections.Generic;

namespace CodingPractice.Problems.DataStructures
{
    class Vertex : IEquatable<Vertex>
    {
        /*
         *  This class will be used to represent graph nodes 
         *  Each Node will contain UNIQUE value. It will be used 
         *  to identify individual node.
         */

        public Vertex(int value)
        {
            _value = value;
            _neighbors = new List<Vertex>();
        }

        //Public Properties

        /// <summary>
        /// Total number of Neighbors
        /// </summary>
        public int Count { get { return _neighbors.Count; } }

        public int Value { get { return _value; } }
        public List<Vertex> Neighbors { get { return _neighbors; } }

        //Private Properties

        /// <summary>
        /// Unique value of vertex
        /// </summary>
        private int _value;

        /// <summary>
        /// Neighboring vertices 
        /// </summary>
        private List<Vertex> _neighbors;

        //Public Methods
        public bool AddNeighbor(Vertex vertex)
        {
            if (_neighbors.Exists(x => x == vertex))
            {
                return false;
            }
            else
            {
                _neighbors.Add(vertex);
            }
            return true;
        }

        public bool RemoveNeighbor(Vertex vertex)
        {
            if (!_neighbors.Exists(x => x == vertex))
            {
                return false;
            }
            else
            {
                _neighbors.Remove(vertex);
                return true;
            }
        }

        public bool RemoveAllNeighbors()
        {
            if (_neighbors.Count > 0)
            {
                _neighbors.Clear();
                return true;
            }

            return false;
        }

        //Operator Override
        public override bool Equals(object obj)
        {
            return Equals(obj as Vertex);
        }

        public bool Equals(Vertex vertex)
        {
            if (vertex == null)
            {
                return false;
            }

            if (ReferenceEquals(this, vertex))
            {
                return true;
            }

            if (GetType() != vertex.GetType())
            {
                return false;
            }

            return vertex.Value == _value;
        }

        public static bool operator == (Vertex v1, Vertex v2)
		{
            return Equals(v1, v2);
		}

        public static bool operator != (Vertex v1, Vertex v2)
		{
            return !Equals(v1, v2);
		}

        public override int GetHashCode()
        {
            return _value.GetHashCode() ^ _neighbors.GetHashCode();
        }
        //Private Methods

    }

}
