using System;

namespace FindLeavesOfBinaryTree
{
    class EntryPoint
    {
        static void Main()
        {
            var solution = new Solution();
            Helper.PrintResults(solution.FindLeaves(Helper.GenerateBinaryTree(5)));
            Helper.PrintResults(solution.FindLeaves(Helper.GenerateBinaryTree(7)));
            Helper.PrintResults(solution.FindLeaves(Helper.GenerateBinaryTree(11)));
        }
    }
}
