import os
def sequence(a):
    l = len(a)
    jobSequence = []
    for i in  range(0,l):
        for j in range(i,l):
            if a[i][2]<a[j][2]:
               swap = a[i]
               a[i]=a[j]
               a[j]=swap
    jobSequence.append(a[0])
    j=1
    #also have to check if count of sequences are more
    for i in range(1,l):
        if jobSequence[j-1][1] <= a[i][1] :
            jobSequence.append(a[i])
            j=j+1
    return jobSequence

l = [('c', 2,27 ),('a',2,100),('b',1,19),('d',1,25),('e',3,15)]
d = sequence(l)
print d
