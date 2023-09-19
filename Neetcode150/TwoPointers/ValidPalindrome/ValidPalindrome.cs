public class Solution {
    public bool IsPalindrome(string s) {
        var l = 0;
        var r = s.Length - 1;

        var sChars = s.ToLower().ToCharArray();
        while (l <= r) {
            if (!char.IsLetterOrDigit(sChars[l])) { 
                l++;
                continue;
            }
            if (!char.IsLetterOrDigit(sChars[r])) {
                r--;
                continue;
            }

            if (sChars[l] != sChars[r]) return false;

            l++;
            r--;
        }
        return true;
    }
}
