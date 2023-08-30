class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        check = defaultdict(list)

        for s in strs:
            check[str(sorted(s))].append(s)
        
        return list(check.values())
            
