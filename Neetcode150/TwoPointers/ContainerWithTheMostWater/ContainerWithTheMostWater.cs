public class Solution {
    public int MaxArea(int[] height) {
        var l = 0;
        var r = height.Length - 1;
        var maxHeight = 0;

        while (l <= r) {
            maxHeight = Math.Max(maxHeight, (Math.Min(height[l], height[r]) * (r-l)));

            if (height[l] < height[r]) {
                l++;
            } else if (height[l] > height[r]) {
                r--;
            } else {
                l++;
                r--;
            }
        }

        return maxHeight;
    }
}
