using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.LeetCode
{
    public class SudokuSolver
    {
        private IDisplayHandler _console;

        public SudokuSolver()
        {

        }

        public void SolveSudoku(char[,] board)
        {
            DFSSudoku(board, 0);
        }
        public bool DFSSudoku(char[,] board, int d)
        {
            if (d == 81) return true;
            int i = d / 9;
            int j = d % 9;
            if (board[i, j] != '.') return DFSSudoku(board, d + 1);

            bool[] isValid = ValidateSudoku(board, i, j);

            for (int k = 1; k <= 9; k++)
            {
                if (isValid[k])
                {
                    board[i, j] =  char.Parse(k.ToString());
                    bool result= DFSSudoku(board, d + 1);
                    if (!result)
                    {
                        board[i, j] = '.';
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool[] ValidateSudoku(char[,] board, int i, int j)
        {
            bool[] isValid = new bool[10];
            for (int k = 1; k <=9; k++)
            {
                isValid[k] = true;
            }
            for (int k = 0; k < 9; k++)
            {
                if (board[i, k] != '.') isValid[board[i, k] - '0'] = false;
                if (board[k, j] != '.') isValid[board[k, j] - '0'] = false;
                int r = (i / 3)*3 + k / 3;
                int h = (j / 3) *3+ k % 3;
                if (board[r, h] != '.') isValid[board[r, h] - '0'] = false;
            }

            return isValid;
        }

        //public void SolveSudoku(char[,] board)
        //{
        //    List<Node> nodes = new List<Node>();
        //    bool isFirstPass = true;
        //    int previousNodesCount = 0;
        //    do
        //    {
        //        previousNodesCount = nodes.Count();
        //        for (int i = 0; i < 9; i++)
        //        {
        //            List<char> knownValues = new List<char>();
        //            for (int j = 0; j < 9; j++)
        //            {
        //                if (board[i, j] != '.')
        //                {
        //                    knownValues.Add(board[i, j]);
        //                }
        //            }
        //            if (isFirstPass)
        //            {
        //                for (int j = 0; j < 9; j++)
        //                {
        //                    if (board[i, j] == '.')
        //                    {
        //                        Node node = new Node(i, j);
        //                        foreach (char c in knownValues)
        //                        {
        //                            node.RemoveValue(c);
        //                        }
        //                        nodes.Add(node);
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                IEnumerable<Node> rowNodes = nodes.Where(n => n.X == i);
        //                List<Node> nodesToRemove = EliminateKnownValues(board, knownValues, rowNodes);
        //                nodesToRemove.AddRange(EliminateUniqueNodes(board, rowNodes));
        //                nodesToRemove.AddRange(EliminateTwoCommonValues(board, rowNodes));
        //                RemoveNodes(nodes, nodesToRemove);
        //            }
        //        }

        //        isFirstPass = false;

        //        for (int i = 0; i < 9; i++)
        //        {
        //            List<char> knownValues = new List<char>();
        //            for (int j = 0; j < 9; j++)
        //            {
        //                if (board[j, i] != '.')
        //                {
        //                    knownValues.Add(board[j, i]);
        //                }
        //            }

        //            IEnumerable<Node> columnNodes = nodes.Where(n => n.Y == i);
        //            List<Node> nodesToRemove = EliminateKnownValues(board, knownValues, columnNodes);

        //            nodesToRemove.AddRange(EliminateUniqueNodes(board, columnNodes));

        //            nodesToRemove.AddRange(EliminateTwoCommonValues(board, columnNodes));

        //            RemoveNodes(nodes, nodesToRemove);
        //        }

        //        for (int w = 0; w < 9; w += 3)
        //        {
        //            for (int z = 0; z < 9; z += 3)
        //            {
        //                List<char> knownValues = new List<char>();
        //                for (int i = 0; i < 3; i++)
        //                {
        //                    for (int j = 0; j < 3; j++)
        //                    {
        //                        if (board[i + w, j + z] != '.')
        //                        {
        //                            knownValues.Add(board[i + w, j + z]);
        //                        }
        //                    }
        //                }
        //                IEnumerable<Node> squareNodes = nodes.Where(n => n.X >= w && n.X < (w + 3) && n.Y >= z && n.Y < (z + 3));
        //                List<Node> nodesToRemove = EliminateKnownValues(board, knownValues, squareNodes);
        //                nodesToRemove.AddRange(EliminateUniqueNodes(board, squareNodes));
        //                RemoveNodes(nodes, nodesToRemove);
        //            }
        //        }

        //        Console.WriteLine(nodes.Count() + " - " + previousNodesCount);
        //    } while (nodes.Count() != previousNodesCount);

        //    foreach (Node node in nodes)
        //    {
        //        String s = "(" + node.X + " - " + node.Y + ") ";
        //        foreach (char c in node.Values)
        //        {
        //            s += c + " - ";
        //        }
        //        Console.WriteLine(s);
        //    }
        //}

        private IEnumerable<Node> EliminateTwoCommonValues(char[,] board, IEnumerable<Node> blockNodes)
        {
            List<Node> nodesToRemove = new List<Node>();
            List<Node> twoValueNodes = blockNodes.Where(n => n.Values.Count() == 2).ToList();
            List<Node> commonNodes = new List<Node>();
            foreach (Node node in twoValueNodes)
            {
                Node commonNode = twoValueNodes.FirstOrDefault(n => (n.X != node.X || n.Y != node.Y) && n.IsNodeValuesEqual(node));
                if (commonNode != null)
                {
                    commonNodes.Add(commonNode);
                }
            }

            foreach (Node commonNode in commonNodes)
            {
                foreach (Node node in blockNodes)
                {
                    if (!commonNodes.Contains(node))
                    {
                        node.RemoveValues(commonNode.Values);
                        if (node.Values.Count() == 1)
                        {
                            board[node.X, node.Y] = node.Values[0];
                            nodesToRemove.Add(node);
                        }
                    }
                }
            }
            return nodesToRemove;
        }

        private List<Node> EliminateUniqueNodes(char[,] board, IEnumerable<Node> blockNodes)
        {
            List<Node> nodesToRemove = new List<Node>();
            foreach (Node node in blockNodes)
            {
                foreach (char value in node.Values)
                {
                    if (!blockNodes.Any(b => (b.X != node.X || b.Y != node.Y) && b.Values.Contains(value)))
                    {
                        board[node.X, node.Y] = value;
                        nodesToRemove.Add(node);
                    }
                }
            }
            return nodesToRemove;
        }

        private static List<Node> EliminateKnownValues(char[,] board, List<char> knownValues, IEnumerable<Node> blockNodes)
        {
            List<Node> nodesToRemove = new List<Node>();
            foreach (Node node in blockNodes)
            {
                foreach (char c in knownValues)
                {
                    node.RemoveValue(c);
                }
                if (node.Values.Count() == 1)
                {
                    board[node.X, node.Y] = node.Values[0];
                    nodesToRemove.Add(node);
                }
            }
            return nodesToRemove;
        }

        public void RemoveNodes(List<Node> nodes, List<Node> removedNodes)
        {
            foreach (Node node in removedNodes)
            {
                nodes.Remove(node);
            }
        }
    }

    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<char> Values { get; set; }
        public Node(int x, int y)
        {
            this.X = x;
            this.Y = y;

            String allValues = "123456789";
            Values = allValues.ToCharArray().ToList();
        }
        public void AddValue(char value)
        {
            Values.Add(value);
        }

        public void RemoveValue(char value)
        {
            Values.Remove(value);
        }

        public bool IsNodeValuesEqual(Node node)
        {
            if (node.Values.Count != this.Values.Count) return false;
            foreach (char c in this.Values)
            {
                if (!node.Values.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        internal void RemoveValues(List<char> values)
        {
            foreach (char c in values)
            {
                this.RemoveValue(c);
            }
        }
    }
}
