class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        curSet = set()
        longest = 0
        l = 0

        for r in range(len(s)):
            while s[r] in curSet:
                curSet.remove(s[l])
                l += 1
            curSet.add(s[r])
            longest = max(longest, len(curSet))
        
        return longest

                