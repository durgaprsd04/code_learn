class Solution(object):
    def singleNumber(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        d ={}
        res = 0
        for i in nums:
            if d.has_key(i):
                d[i] = d[i]+1
            else:
                d[i]=1
        for k in d.keys():
            if d[k]==1:
                res =k
                break
        return res

sol = Solution()
nums = [4,1,2,1,2]
v = sol.singleNumber(nums)
print v


#Xoring is avalid solution
