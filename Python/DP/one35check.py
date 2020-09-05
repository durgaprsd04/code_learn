import os
l = [1,2,2]
def one3five(n):
    for i in range(3,n):
        n1 = l[i-3]
        n2 = l[i-1]
        n3= 0 if (i-5)<0 else l[i-5]
        l.append(n1+n2+n3)

    return l

v = one3five(7)
print v
