public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }

        var left = 1 + MaxDepth(root.left);
        var right = 1 + MaxDepth(root.right);

        return Math.Max(left, right);
    }
}