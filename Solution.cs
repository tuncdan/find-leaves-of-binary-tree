using System;
using System.Collections.Generic;

namespace FindLeavesOfBinaryTree
{
    class Solution
    {
        private List<List<int>> result;

        public List<List<int>> FindLeaves(TreeNode root)
        {
            result = new List<List<int>>();
            CalculateNodeLevelHeight(root);
            return result;
        }

        private int CalculateNodeLevelHeight(TreeNode root)
        {
            //Return 0 when reach the end of the tree
            if (root == null)
                return 0;

            int leftHeight = CalculateNodeLevelHeight(root.left) + 1;
            int rightHeight = CalculateNodeLevelHeight(root.right) + 1;

            int level = Math.Max(leftHeight, rightHeight);

            if (result.Count < level)
                result.Add(new List<int>());

            result[level - 1].Add(root.val);

            return level;
        } //Time Complexity: O(n), Space complexity: O(n)
    }
}
