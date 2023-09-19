public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var l = 0;
        var r = numbers.Length - 1;

        while (l <= r) {
            var curSum = numbers[l] + numbers[r];
            
            if (curSum > target) {
                r--;
                continue;
            } else if (curSum < target) {
                l++;
                continue;
            } else {
                return new int[] {l + 1, r + 1};
            }
        }
        return null;
    }
}
