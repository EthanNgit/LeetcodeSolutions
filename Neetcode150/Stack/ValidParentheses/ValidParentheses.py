class Solution:
    def isValid(self, s: str) -> bool:
        check = { ")" : "(", "]" : "[", "}" : "{" }
        stack = []

        for p in s:
            if p not in check:
                stack.append(p)
                continue
            if not stack or stack[-1] != check[p]:
                return False
            
            stack.pop()
        
        return len(stack) == 0