from typing import List
class Solution:
    def solve(self):
        """
        Q88 question link: https://leetcode.com/problems/merge-sorted-array/    
        """
        return self.merge([1,2,3,0,0,0], 3, [2,5,6], 3)

    def merge(self,nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        if len(nums1) == 0:
            return nums2
        if len(nums2) == 0:
            return nums1   
        
        # two pointers
        ptr1 = m - 1
        ptr2 = n - 1
        while(ptr1 >= 0 or ptr2 >= 0):
            if(ptr1 < 0):
                # nums1 is empty
                nums1[ptr2] = nums2[ptr2]
                ptr2 -= 1
            elif(ptr2 < 0):
                # nums2 is empty
                nums1[ptr1] = nums1[ptr1]
                ptr1 -= 1
            else:   
                if(nums1[ptr1] > nums2[ptr2]):
                    nums1[ptr1 + ptr2 + 1] = nums1[ptr1]
                    ptr1 -= 1
                else:
                    nums1[ptr1 + ptr2 + 1] = nums2[ptr2]
                    ptr2 -= 1
        return nums1

        
        
        