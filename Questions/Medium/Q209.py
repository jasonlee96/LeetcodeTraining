# generate solution
from typing import List
class Solution:
    def solve(self):
        return self.minSubArrayLen(7, [2,3,1,2,4,3])
        
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        """
        Find the minimal length of a contiguous subarray of which the sum is at least target
        """
        if(len(nums) == 0):
            return 0
        # sliding window approach
        left = 0
        curr_sum = 0
        min_length = float('inf')
        
        for right in range(len(nums)):
            curr_sum += nums[right]
            
            while curr_sum >= target:
                min_length = min(min_length, right - left + 1)
                curr_sum -= nums[left]
                left += 1
                
        return min_length if min_length != float('inf') else 0
        
            
