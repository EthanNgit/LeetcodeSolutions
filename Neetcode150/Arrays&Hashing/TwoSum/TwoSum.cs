public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> check = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i ++) {
            var tSum = target - nums[i];
            if (check.ContainsKey(tSum)) {
                return new int[] {check[tSum], i};
            }
            check[nums[i]] = i;
        }
        return null;
    }
}
