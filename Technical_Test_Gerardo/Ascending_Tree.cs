using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Technical_Test_Gerardo
{
    public class Ascending_Tree
    {
        List<Node> NodesAdd = new List<Node>();
        public class Node
        {
            public int weight;
            public Node left;
            public Node right;

            public Node()
            {
                weight = 0;
                left = null;
                right = null;
            }
        }

        private Node root;

        public Ascending_Tree()
        {
            root = null;
        }

        public void AddNode(int weight)
        {
            root = AddNode(root, weight);

        }

        public Node AddNode(Node node, int weight)
        {
            if (node == null)
            {
                node = new Node();
                node.weight = weight;
            }
            else
            {
                if (node.left == null)
                {
                    node.left = AddNode(node.left, weight);

                }
                else
                {
                    node.right = AddNode(node.right, weight);
                }
            }
            return node;
        }
        public void PrintNodes()
        {
            SearchRecursives(root);
            Console.WriteLine();
        }
        private void SearchRecursives(Node print)
        {

            if (print != null)
            {
                NodesAdd.Add(print);
                //Console.Write(print.weight + " ");
                SearchRecursives(print.left);
                SearchRecursives(print.right);

            }
        }

        public void OrderWeigths()
        {
            List<int> weights = new List<int>();
            foreach (var nodes in NodesAdd)
            {

                weights.Add(nodes.weight);
            }
            Console.Write(string.Join(",", weights.OrderBy(num => num)));
        }



    }


}

