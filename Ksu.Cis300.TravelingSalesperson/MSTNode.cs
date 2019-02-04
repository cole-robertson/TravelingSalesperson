/* Author: Cole Robertson
 * Homework 6
 * MSTNode.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.TravelingSalesperson
{
    class MSTNode: ITree
    {
        /// <summary>
        /// the weight of the graph edge that took us to this node.
        /// </summary>
        private int _data;

        /// <summary>
        /// the array index from the adjacency matrix of the parent node 
        /// </summary>
        private int _parent;

        /// <summary>
        /// the string representation of the node
        /// </summary>
        private string _label;

        /// <summary>
        /// the children of this node
        /// </summary>
        private List<MSTNode> _children = new List<MSTNode>();

        /// <summary>
        /// public property to get and set the private _data field
        /// </summary>
        public int Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        /// <summary>
        /// public property to get and set the private _parent field
        /// </summary>
        public int Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        /// <summary>
        /// public property for the ITree interface to retrieve the representation of the node. 
        /// This should return a string that has the label of the node combined with the data in parentheses
        /// </summary>
        public object Root
        {
            get
            {
                string s = _label + " (" + _data + ")";
                return s;
            }

        }

        /// <summary>
        /// property for the ITree interface to return the children of this node
        /// </summary>
        ITree[] ITree.Children
        {
            get
            {
                return _children.ToArray();
            }
        }

        /// <summary>
        /// public property that returns whether or not the node is empty.  
        /// For this project, it should just return false since we never have any empty nodes.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return false;
            }
            
        }
        /// <summary>
        /// This is the public constructor for the class.  It sets the corresponding private fields using the parameters
        /// </summary>
        /// <param name="data">
        /// sets the _data
        /// </param>
        /// <param name="parent">
        /// sets the _parent
        /// </param>
        /// <param name="label">
        /// sets the _label
        /// </param>
        public MSTNode(int data, int parent, string label)
        {
            _data = data;
            _parent = parent;
            _label = label;
        }

        /// <summary>
        /// This method adds the given child to the _children list
        /// </summary>
        /// <param name="child"></param>
        public void AddChild(MSTNode child)
        {
            _children.Add(child);
        }

        /// <summary>
        /// recursive helper function to do a pre-order depth-first walk on the children of the MST
        /// </summary>
        /// <param name="sb">
        /// the stringbuilder to append to
        /// </param>
        private void Walk(StringBuilder sb)
        {
            sb.Append(" to ").Append(_label).Append(Environment.NewLine);
            sb.Append(_label);

            for (int i = 0; i < _children.Count; i++)
            {
                _children[i].Walk(sb);
            }
        }

        /// <summary>
        /// initiates the pre-order walk of the MST tree
        /// </summary>
        /// <returns>
        /// string that has the path to walk
        /// </returns>
        public string Walk()
        {
            StringBuilder walk = new StringBuilder();
            walk.Append(_label);

            for (int i = 0; i < _children.Count; i++)
            {
                _children[i].Walk(walk);
            }

            walk.Append(" to ").Append(_label);

            return walk.ToString();
        }
    }
}

