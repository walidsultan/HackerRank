using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.GraphTheory
{
    public class EvenTree
    {
        private IDisplayHandler _console;

        public EvenTree(IDisplayHandler console)
        {
            _console = console;
        }

        public void Init()
        {
            List<Node> mainTree = new List<Node>();
            string[] inParams = _console.ReadLine().Split(' ');
            //int nodesCount = int.Parse(inParams[0]);
            int edgesCount = int.Parse(inParams[1]);

            //Build Main Tree
            for (int edge = 0; edge < edgesCount; edge++)
            {
                string[] nodes = _console.ReadLine().Split(' ');

                int firstNodeIndex = int.Parse(nodes[0]);
                int secondNodeIndex = int.Parse(nodes[1]);

                Node firstNode = AddNewNode(mainTree, firstNodeIndex);
                Node secondNode = AddNewNode(mainTree, secondNodeIndex);

                secondNode.AddNode(firstNode);
            }

            _TestStartTime = DateTime.Now;
            _TestIndex = 0;
            int removedEdges = SplitTree(mainTree, 0);
            _console.WriteLine(removedEdges.ToString());
        }
        public static decimal _TestIndex = 0;
        public static DateTime _TestStartTime;

        private static int SplitTree(List<Node> mainTree, int level)
        {
            int removedEdgesCount = 0;
            foreach (Node mainNode in mainTree)
            {
                if (mainNode.Degree > 1)
                {
                    List<Node> removedNodes = new List<Node>();
                    foreach (Node node in mainNode.ConnectedNodes)
                    {
                        int treeCount = node.CountConnectedNodes(null, (new int[] { mainNode.Index }).ToList());

                        if (treeCount % 2 == 0)
                        {
                            removedNodes.Add(node);

                            removedEdgesCount++;
                        }
                    }

                    //Remove edges
                    foreach (Node removedNode in removedNodes)
                    {
                        removedNode.ConnectedNodes.Remove(mainNode);
                        mainNode.ConnectedNodes.Remove(removedNode);
                    }
                }
            }
            return removedEdgesCount;
        }

        private static List<Node> CloneTree(List<Node> mainTree)
        {
            List<Node> clonedTree = new List<Node>();
            foreach (Node node in mainTree)
            {
                Node newNode = clonedTree.SingleOrDefault(n => n.Index == node.Index);
                if (newNode == null)
                {
                    newNode = new Node(node.Index);
                }
                foreach (Node connectedNode in node.ConnectedNodes)
                {
                    Node newConnectedNode = clonedTree.SingleOrDefault(n => n.Index == connectedNode.Index);
                    if (newConnectedNode == null)
                    {
                        newConnectedNode = new Node(connectedNode.Index);
                    }
                    if (newNode.ConnectedNodes.Count(n => n.Index == newConnectedNode.Index) == 0)
                    {
                        newNode.ConnectedNodes.Add(newConnectedNode);
                    }
                    if (newConnectedNode.ConnectedNodes.Count(n => n.Index == newNode.Index) == 0)
                    {
                        newConnectedNode.ConnectedNodes.Add(newNode);
                    }
                    if (clonedTree.Count(n => n.Index == newConnectedNode.Index) == 0)
                    {
                        clonedTree.Add(newConnectedNode);
                    }
                }
                if (clonedTree.Count(n => n.Index == newNode.Index) == 0)
                {
                    clonedTree.Add(newNode);
                }
            }
            return clonedTree;
        }

        private static List<Node> GetSubTree(Node node, int excludedIndex)
        {
            List<Node> subTree = new List<Node>();
            foreach (Node subNode in node.ConnectedNodes)
            {
                if (subNode.Index != excludedIndex)
                {
                    if (subNode.Degree > 1)
                    {
                        subTree.AddRange(GetSubTree(subNode, node.Index));
                    }
                    else
                    {
                        subTree.Add(subNode);
                    }
                }
            }
            subTree.Add(node);
            return subTree;
        }

        private static Node AddNewNode(List<Node> mainTree, int index)
        {
            Node node = mainTree.SingleOrDefault(n => n.Index == index);
            if (node == null)
            {
                node = new Node(index);
                mainTree.Add(node);
            }
            return node;
        }


    }

    public class Node
    {
        public Node(int index)
        {
            Index = index;
            ConnectedNodes = new List<Node>();
        }
        public int Index { get; set; }
        public List<Node> ConnectedNodes { get; set; }
        public int Degree
        {
            get
            {
                return ConnectedNodes.Count;
            }
        }

        public void AddNode(Node node)
        {
            this.ConnectedNodes.Add(node);
            node.ConnectedNodes.Add(this);
        }

        public int CountConnectedNodes(Node parentNode = null, List<int> excludedNodes = null)
        {
            int count = 1;
            if (excludedNodes == null)
            {
                excludedNodes = new List<int>();
            }
            if (parentNode == null)
            {
                parentNode = this;
            }
            foreach (Node node in parentNode.ConnectedNodes)
            {
                if (excludedNodes.Count(n => n == node.Index) == 0)
                {
                    if (node.Degree > 1)
                    {
                        excludedNodes.Add(parentNode.Index);
                        count += CountConnectedNodes(node, excludedNodes);
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            return count;
        }

    }
}
