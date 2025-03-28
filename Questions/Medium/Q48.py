# generate question 48
from typing import List
class Solution:
    def solve(self):
        """
        Q48 question link: https://leetcode.com/problems/rotate-image/
        """
        return self.rotate([[1,2,3],[4,5,6],[7,8,9]])

    def rotate(self, matrix: List[List[int]]) -> None:
        """
        Do not return anything, modify matrix in-place instead.
        """
        for i in range(len(matrix)):
            for j in range(i, len(matrix[i])):
                matrix[i][j], matrix[j][i] = matrix[j][i], matrix[i][j]

        for i in range(len(matrix)):
            matrix[i].reverse()

        return matrix
        
    
