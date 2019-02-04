/* Author: Cole Robertson
 * Homework 6
 * UserInterface.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KansasStateUniversity.TreeViewer2;
using System.IO;

namespace Ksu.Cis300.TravelingSalesperson
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method should create and return an UndirectedGraph from the given graph text file
        /// </summary>
        /// <param name="fileName">
        /// the filename to read
        /// </param>
        /// <returns>
        /// returns the constructed graph
        /// </returns>
        private UndirectedGraph ReadGraph(string fileName)
        {
            using(StreamReader sr = new StreamReader(fileName))
            {
                int vertices = Convert.ToInt32(sr.ReadLine());
                UndirectedGraph graph = new UndirectedGraph(vertices);
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(',');
                    string source = temp[0];
                    string destination = temp[1];
                    int distance = Convert.ToInt32(temp[2]);

                    graph.AddEdge(source, destination, distance);

                }
                return graph;
            }
        }
        /// <summary>
        /// button click to diplay tour
        /// </summary>
        /// <param name="sender">
        /// default sender object
        /// </param>
        /// <param name="e">
        /// default eventargs e
        /// </param>
        private void uxOpenButton_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    UndirectedGraph graph = ReadGraph(uxOpenDialog.FileName);
                    MSTNode node = graph.GetMinSpanningTree();
                    TreeForm tree = new TreeForm(node, 100);

                    tree.Show();
                    uxTour.Text = node.Walk();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
