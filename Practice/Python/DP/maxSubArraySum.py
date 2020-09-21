# incomplete.
def max_sub_array_sum(l):
    dp =[]
    for i in range(0,len(l)):
        dp.append(0)
    dp.append(l[0])
    for i in range(1,len(l)):
        dp[i]=max((dp[i-1]+l[1]), l[i])

