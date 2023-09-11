class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        longest = 0
        check = set(nums)

        for n in check:
            if n - 1 not in check:
                curLen = 1
                while n + curLen in check:
                    curLen += 1
                longest = max(curLen, longest)
        
        return longest