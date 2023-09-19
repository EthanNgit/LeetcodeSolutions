public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> check = new Dictionary<string,List<string>>();

        foreach(string str in strs) {
            // Sort string
            Char[] strArr = str.ToCharArray();
            Array.Sort(strArr);
            string sortedStr = new string(strArr);

            if (!check.ContainsKey(sortedStr)) {
                check[sortedStr] = new List<string>();
            }

            check[sortedStr].Add(str);
        }

        return new List<IList<string>>(check.Values);
    }
}
