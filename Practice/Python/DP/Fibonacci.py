import os
def fib(n):
    first = 0
    second =1
    l=[]
    for i in range(0,n):
        l.append(first)
        temp = second
        second = first + second
        first = temp

    return l

result = fib(12)
print result

