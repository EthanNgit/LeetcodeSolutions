class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        checked = {}
        mCommon = 0
        l = 0

        for r in range(len(s)):
            checked[s[r]] = 1 + checked.get(s[r], 0)
            mCommon = max(checked[s[r]], mCommon)
            while (r - l + 1) - mCommon > k:
                checked[s[l]] -= 1
                l += 1
        
        return (r - l + 1)
                