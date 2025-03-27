from typing import List
class Solution:
    def solve(self):
        """
        Q27 question link: https://leetcode.com/problems/remove-element/
        """
        return self.removeElement([3,3,2], 3)
    
    def removeElement(self, nums: List[int], val: int) -> int:
        """
        Remove all occurrences of val in nums in-place and return the number of elements remaining
        """
        if(len(nums) == 0):
            return 0
        ptr1 = 0
        ptr2 = len(nums) - 1
        if(ptr1 == ptr2):
            return 0 if nums[ptr1] == val else 1

        while(ptr1 < ptr2):
            print(ptr1, ptr2)
            if(nums[ptr2] == val):
                ptr2 -= 1
                continue
            if(nums[ptr1] == val):
                nums[ptr1], nums[ptr2] = nums[ptr2], nums[ptr1]
                ptr2 -= 1
            else:
                ptr1 += 1
        
        return 0 if ptr2 == 0 and nums[ptr2] == val else ptr2 + 1
