class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        if (nums.size() <= 1) return false;

        sort(nums.begin(), nums.end());

        for (int i = 1; i < nums.size(); i++) {
            int last = nums[i - 1];
            int cur = nums[i];
            
            if (last == cur) {
                return true;
            }
        }

        return false;
    }
};
