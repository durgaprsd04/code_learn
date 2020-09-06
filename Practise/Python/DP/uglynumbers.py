import os
def ugly_numbers(n):
    #either multiples of 2,3 or 5
    l= [1]
    i2 = i3 = i5 = 1
    n2 = 2
    n3 = 3
    n5 = 5
    for i in range(1,n):
        if(min(n2,n3,n5) not in l):
            l.append(min(n2,n3,n5))

        if l[i] == n2:
            i2=i2+1;
            n2 = 2*i2;
        elif l[i]==n3:
            i3=i3+1;
            n3 = 3*i3
        elif l[i]==n5:
            i5= i5+1
            n5 = 5*i5
    return l
v = ugly_numbers(10)
print v

