class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        # sort a counter by values in reverse order and take from the first k elements
        return sorted(Counter(nums), key = Counter(nums).get, reverse=True)[:k]