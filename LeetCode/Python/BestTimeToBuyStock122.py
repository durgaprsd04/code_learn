class Solution(object):
    def maxProfit(self, prices):
        """
        :type prices: List[int]
        :rtype: int
        """
        l = len(prices)
        if l<=1:
            return 0
        min1 = prices[0]
        max1 = 0
        maxSum = 0
        index=0
        for i in range(1,l):
            #print prices[i]
            if prices[i]<min1 :
                min1=prices[i]
            if max1 < prices[i]-min1:
                print prices[i], min1
                max1 = prices[i]-min1
                maxSum +=max1
                max1=0;
                min1=prices[i]
        return maxSum


sol = Solution()
#array =[7,1,5,3,6,4]
#array = [1,2,3,4,5]
#array = [7,6,4,3,1]
array =[1,4,2,6]
v= sol.maxProfit(array)
print v

