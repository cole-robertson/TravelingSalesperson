/* Author: Cole Robertson
 * Homework 6
 * UndirectedGraph.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TravelingSalesperson
{
    class UndirectedGraph
    {
        /// <summary>
        /// a two dimensional array to store the adjacency matrix representing the graph
        /// </summary>
        private int[,] _adjMatrix;

        /// <summary>
        /// the string representation of each node.  
        /// The index in the list corresponds to a node in the adjacency matrix
        /// </summary>
        private List<string> _nodes = new List<string>();

        /// <summary>
        /// the number of nodes in the graph
        /// </summary>
        private int _size;

        /// <summary>
        /// This method sets the _size field and initializes the adjacency matrix 
        /// to a new two-dimensional array with _size as the number of rows and columns
        /// </summary>
        /// <param name="size"></param>
        public UndirectedGraph(int size)
        {
            _size = size;
            _adjMatrix = new int[_size, _size];
        }

        /// <summary>
        /// This function adds a corresponding string representation of a node to the node list _nodes
        /// </summary>
        /// <param name="data"></param>
        private void AddNode(string data)
        {
            if(_size == _nodes.Count)
            {
                throw new InvalidOperationException("The graph is full");
            }
            else
            {
                _nodes.Add(data);
            }
        }

        /// <summary>
        /// This function simply returns the string representation of a node at the given index
        /// </summary>
        /// <param name="index">
        /// The given index to return
        /// </param>
        /// <returns>
        /// returns the string represenation at the index
        /// </returns>
        public string GetNode(int index)
        {
            return _nodes[index];
        }

        /// <summary>
        /// adds the edge to the matrix
        /// </summary>
        /// <param name="source">
        /// the source to add
        /// </param>
        /// <param name="destination">
        /// the destination to add
        /// </param>
        /// <param name="weight">
        /// the weight to add
        /// </param>
        public void AddEdge(string source, string destination, int weight)
        {
            if (!_nodes.Contains(source)){
                AddNode(source);
            }

            if (!_nodes.Contains(destination))
            {
                AddNode(destination);
            }

            _adjMatrix[_nodes.IndexOf(source), _nodes.IndexOf(destination)] = weight;
            _adjMatrix[_nodes.IndexOf(destination), _nodes.IndexOf(source)] = weight;
        }

        /// <summary>
        /// calculates the minimum cost spanning tree of the graph by using Prim’s algorithm
        /// </summary>
        /// <returns>
        /// returns the root of the tree
        /// </returns>
        public MSTNode GetMinSpanningTree()
        {
            MSTNode[] tree = new MSTNode[_size];
            bool[] added = new bool[_size];

            for (int i = 1; i < tree.Length; i++)
            {
                tree[i] = new MSTNode(Int32.MaxValue, 0, _nodes[i]);
            }

            tree[0] = new MSTNode(0, -1, _nodes[0]);

            for (int s = 0; s < _size; s++)
            {
                int minIndex = -1;
                int minData = Int32.MaxValue;

                for (int j = 0; j < tree.Length; j++)
                {
                    if (tree[j].Data < minData && added[j] == false)
                    {
                        minData = tree[j].Data;
                        minIndex = j;
                    }
                }

                added[minIndex] = true;

                if (s != 0)
                {
                    tree[tree[minIndex].Parent].AddChild(tree[minIndex]);
                }

                for (int k = 0; k < _size; k++)
                {
                    if (_adjMatrix[minIndex, k] != 0 && !added[k] && _adjMatrix[minIndex, k] < tree[k].Data)
                    {
                        tree[k].Data = _adjMatrix[minIndex, k];
                        tree[k].Parent = minIndex;
                    }
                }
            }

            return tree[0];
        }
    }
}
