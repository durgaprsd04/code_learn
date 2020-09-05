import os
def largest_sub_set(array):
    array.sort()
    l  = len(array)
    l3=[]
    l2=[]
    for i in range(0, l):
        p = array[i]
        for j in range(i,l):
            if array[j]%p == 0:
                l2.append(array[j])
        l3.append(l2)
        l2=[]
    return l3

res = largest_sub_set([3,6,13,17,18])
print res
