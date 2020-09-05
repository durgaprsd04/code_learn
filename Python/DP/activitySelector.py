import os
def activity_selector(start, finish):
    l = len(start)
    i=j=0
    res =[]
    res.append((start[0],finish[0]))
    for i in range(1,l):
        if start[i]>finish[j]:
            res.append((start[i], finish[i]))
            j=i
    return res

start =[1, 3, 0, 5, 8, 5]
finish= [2, 4, 6, 7, 9, 9]
v = activity_selector(start, finish)
print v
