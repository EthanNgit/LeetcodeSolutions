public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> check = new HashSet<char>();
        int longest = 0, l = 0, r = 0;

        while (r < s.Length) {
            if (!check.Contains(s[r])) {
                check.Add(s[r]);
                longest = Math.Max(longest, (r-l+1));
                r++;
            } else {
                check.Remove(s[l]);
                l++;
            }
        }
        return longest;
    }
}
