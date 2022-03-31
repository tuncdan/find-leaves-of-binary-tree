using System;
using System.Collections.Generic;

namespace FindLeavesOfBinaryTree
{
    class Helper
    {
        public static TreeNode GenerateBinaryTree(int totalNodeCount)
        {
            var jumpCounterToChildNodes = 1;

            var nodes = new TreeNode[totalNodeCount];

            for (int i = 0; i < totalNodeCount / 2; ++i)
            {
                if (nodes[i] == null)
                    nodes[i] = new TreeNode(i + 1);

                nodes[i].Left = nodes[i + jumpCounterToChildNodes] = new TreeNode(i + 1 + jumpCounterToChildNodes++);
                nodes[i].Right = nodes[i + jumpCounterToChildNodes] = new TreeNode(i + 1 + jumpCounterToChildNodes);
            }

            return nodes[0];
        }

        internal static void PrintResults(List<List<int>> items)
        {
            Console.WriteLine("Results: ");

            items.ForEach(item =>
            {
                Console.Write("[ ");
                item.ForEach(sub => Console.Write($"{sub}, "));
                Console.WriteLine("]");
            });

            Console.WriteLine("--------------------------------------");
        }
    }
}
