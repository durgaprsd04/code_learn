import os
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
v = sub_set_sum([3,34,4,9], 9)
print v

