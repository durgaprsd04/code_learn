import os
#sub array recursive
def sub_set_sum(array, n):
    print 'searching for '+str(n) +' in '+ str(array)
    result =False
    if(n<0):
        return False
    if len(array)==0:
        return False
    if n in array:
        return True;
    for i in range(0, len(array)):
        prev = array[i]
        print 'i '+str(i) + 'a '+str(array[(i+1):]) +' ' +str(n-prev)
        result = result or sub_set_sum(array[(i+1):], n-prev)
    return result

# continous array not subset
def sub_set_array_dp(array, n):
    dp =[]
    len1 = len(array)
    for i in range(0, len1):
        dp.append(0)
    dp[0]=array[0]
    flag =False
    j =0
    for i in range(1, len1):
        dp[i] = array[i]+dp[i-1]
        if(dp[i]>n):
            #print i
            for k in range(i, j-1, -1):
                dp[k] =dp[k]- dp[j]
            j=j+1
        #print dp
        if(dp[i]==n):
            flag=True
            break
    return flag

# non continous sub array
def subset_array_non_continous(array, target):
    l = len(array)
    dp =[]
    for i in range(0,l):
        l1 =[]
        for j in range(0,l):
            l1.append(0)
        dp.append(l1)
    prev = False
    for i in range(l-1,-1, -1):
        for j in range(l-1,-1,-1):
            if(array[i]+array[j] == target):
                dp[i][j]=True
            else:
                dp[i][j] = False or prev
            prev = dp[i][j]

    return dp[0][0]
# non continous sub array
def subset_array_non_continous_space(array, target):
    l = len(array)
    returnVal=False
    prev = False
    for i in range(0,l):
        for j in range(0,l):
            if(array[i]+array[j] == target):
                returnVal =True
            else:
                returnVal = False or prev
            prev = returnVal
    return returnVal



array =[3,34,4,9]
array2= [4,5,2,5,6,3]
array3 = [3, 34, 4, 12, 5, 2]
array4 =[1,3,2]
n=9
v = sub_set_sum(array, n)
print v
v2 = sub_set_array_dp(array2,n)
print v2
v3 = subset_array_non_continous(array3, n)
print v3

v4 = subset_array_non_continous(array4, n)
print v4

v5 = subset_array_non_continous_space(array3, n)
print v5

v6 = subset_array_non_continous_space(array4, n)
print v6

