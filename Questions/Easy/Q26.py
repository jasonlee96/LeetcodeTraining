# generate question 26
from typing import List
class Solution:
    def solve(self):
        """
        Q26 question link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        """
        return self.removeDuplicates([1,1,2])

    def removeDuplicates(self, nums: List[int]) -> int:
        """
        Remove duplicates from sorted array in-place
        """
        if(len(nums) == 0):
            return 0
        index = 1
        for i in range(1, len(nums)):
            if(nums[i - 1] != nums[i]):
                nums[index] = nums[i]
                index += 1
        return index    
        
