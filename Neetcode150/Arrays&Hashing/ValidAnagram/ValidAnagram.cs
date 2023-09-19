public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        if (s == t) return true;

        Dictionary<Char, int> counterS = new Dictionary<Char, int>();
        Dictionary<Char, int> counterT = new Dictionary<Char, int>();

        for (int i = 0; i < s.Length; i ++) {
            counterS[s[i]] = 1 + (counterS.ContainsKey(s[i]) ? counterS[s[i]] : 0);
            counterT[t[i]] = 1 + (counterT.ContainsKey(t[i]) ? counterT[t[i]] : 0);
        }

        foreach(char c in counterS.Keys) {
            int tSection = counterT.ContainsKey(c) ? counterT[c] : 0;
            if (counterS[c] != tSection) {
                return false;
            }
        }
        return true;
    }
}
