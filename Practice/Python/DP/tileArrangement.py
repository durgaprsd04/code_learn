import os
def tile_arragement(n):
    l=[0,1,2,3,5]
    #f(n)  = f(n-1) + f(n-2)
    for i in range(5,n):
        l.append(l[i-1] + l[i-2])
    return l

v = tile_arragement(7)
print v

