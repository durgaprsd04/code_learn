class Solution(object):
    def trailingZeroes(self, n):
        """
        :type n: int
        :rtype: int
        """
        count =0
        while n>=5:
            n =n/5
            count = count+1
v =25;
sol = Solution()
result= sol.trailingZeroes(v)
print result

