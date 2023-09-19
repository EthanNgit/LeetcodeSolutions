public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> check = new HashSet<int>(nums);

        if (check.Count != nums.Length) {
            return true;
        }
        return false;
    }
}
