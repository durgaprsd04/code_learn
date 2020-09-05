import os

def gold_mine(array, n, m):
    max1=0;
    l=[]
    for j in range(n-2,-1,-1):
        for i in range(1, m-1):
            max1 = max(max(array[i+1][j+1], array[i][j+1]), max(max1, array[i-1][j+1]))
            l.append(max1)
    return l

l1 =[[1,3,3],[2,1,4],[0,6,4]]
v = gold_mine(l1, 3,3)
print v

