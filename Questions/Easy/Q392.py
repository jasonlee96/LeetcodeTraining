# generate solution
from typing import List
class Solution:
    def solve(self):
        return self.isSubsequence("abc", "ahbgdc")
        
    def isSubsequence(self, s: str, t: str) -> bool:
        """
        Check if s is a subsequence of t
        """
        if(len(s) == 0):
            return True
        ptrA = 0
        ptrB = 0
        while(ptrA < len(s) and ptrB < len(t)):
            if(s[ptrA] == t[ptrB]):
                ptrA += 1
            ptrB += 1
        return ptrA == len(s)
            
