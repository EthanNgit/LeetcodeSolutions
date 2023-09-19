public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack();
        var check = new Dictionary<char, char>
        {
            { '}', '{' },
            { ')', '(' },
            { ']', '[' }
        };


        foreach (char p in s) {
            if (!check.ContainsKey(p)) {
                stack.Push(p);
                continue;
            } 
            while (stack.Count == 0 || (char)stack.Peek() != check[p]) {
                return false;
            }
            stack.Pop();
        }

        return stack.Count == 0;
    }
