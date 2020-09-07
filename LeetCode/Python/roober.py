class Solution(object):
    def rob(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        n  = len(nums)
        l2=[]
        a=0
        l2.append(nums[0])
        l2.append(nums[1])
        for i in range(2, n):
            a = max(l2[i-2] +nums[i],l2[i-1])
            l2.append(a)
        return max(l2)

v = [8,1,1,1,1,8]
solution = Solution()
res = solution.rob(v)
print res
