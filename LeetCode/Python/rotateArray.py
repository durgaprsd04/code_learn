class Solution(object):
    def rotate(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :rtype: None Do not return anything, modify nums in-place instead.
        """
        l = len(nums)
        for i in  range(0,k):
            first = nums[l-1]
            for j in range(1,l):
                #print nums
                nums [l-j] = nums[l-j-1]
            nums[0]=first
        #print nums

sol =  Solution()
nums =[1,3,4,5,6]
k =1
v1 = sol.rotate(nums,k)

