#generate questioon 125

# Given a string s, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

# Example 1:
# Input: s = "A man, a plan, a canal: Panama"
# Output: true
# generate solution

class Solution:
    def solve(self):
        return self.isPalindrome("A man, a plan, a canal: Panama")

    def isPalindrome(self, s: str) -> bool:
        """
        Check if the string is a palindrome, considering only alphanumeric characters and ignoring cases
        """
        s = s.lower().strip()
        if(len(s) == 0):
            return True
        ptrA = 0
        ptrB = len(s) - 1
        if(ptrA == ptrB):
            return True
        while(ptrA < ptrB):
            asciiA = ord(s[ptrA])
            asciiB = ord(s[ptrB])
            if((asciiA < 97 or asciiA > 122) and (asciiA < 48 or asciiA > 57)):
                ptrA += 1
                continue
            if((asciiB < 97 or asciiB > 122) and (asciiB < 48 or asciiB > 57)):
                ptrB -= 1
                continue
            
            if(s[ptrA] == s[ptrB]):
                ptrA += 1
                ptrB -= 1
            else:
                return False
        
        return True 
