#generate solution for question 383

class Solution:
    # solve method with test data
    def solve(self):
        return self.canConstruct("a", "b")

    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        str_count = {}
        for char in magazine:
            if char not in str_count:
                str_count[char] = 0
            str_count[char] += 1
        for char in ransomNote:
            if char not in str_count or str_count[char] == 0:
                return False
            str_count[char] -= 1
        return True
