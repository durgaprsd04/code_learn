def friends_pairing(n):
    dp = []
    dp.append(0);
    for i in range(1,n+1):
        dp.append(n)
    dp[1]=1
    dp[2]= 2
    dp[3] = 2*dp[1] +2
    for i in range(4, n+1):
        dp[i] = dp[i-1] + (i-1)*dp[i-2]
    return dp[n]


res = friends_pairing(4)
print res
