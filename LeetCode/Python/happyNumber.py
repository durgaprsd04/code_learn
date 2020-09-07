class Solution(object):
    def isHappy(self, n):
        """
        :type n: int
        :rtype: bool
        """
        l =[]
        l2 =[]
        flag = False
        v = 0
        while(n>0):
            r= n%10
            n= n/10
            v= v+ r*r
            if n==0:
                print v
                if v in l2 or v==1:
                    if v==1:
                        flag=True
                    break
                n = v
                l2.append(v)
                v=0
                r=0
        return flag

sol = Solution()
v1 = sol.isHappy(234)
print v1
