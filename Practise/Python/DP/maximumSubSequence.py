import os
def max_sub_sequence(a, b):
    m = len(a)
    n = len(b)
    max1 = 0
    arr = [[0 for j in range(0,n)]  for i in range(0,m)]
    for  i in range(0,m):
        for j in range(i,n):
            if(a[i]==b[j]):
                arr[i][j]+=max1+1
                max1 = arr[i][j]
            else:
                pass
    return arr

v = max_sub_sequence("ABCDEFG","AxBbCxDdErFfG")
print v
