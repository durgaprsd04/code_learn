class Solution(object):
    def isPalindrome1(self, s):
        """
        :type s: str
        :rtype: bool
        """
        s1 = s.lower()
        s2 =""
        for c in s1:
            if c.isalpha():
                s2=s2+c
        l = len(s2)
        if l==0:
            return True
        #print s2
        flag=False
        for i in range(0, l):
            if s2[i]!=s2[l-i-1]:
                flag=False
                break
            else:
                flag=True
        return flag

sol = Solution()
#str1 ="A man, a plan a canal: panama")
#str1 ="abcced"
#str1=""
str1 ="race a car"
v = sol.isPalindrome1(str1)
print v
