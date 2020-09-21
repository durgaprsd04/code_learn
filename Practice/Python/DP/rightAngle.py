def right_angle(array):
    l = len(array)
    next_max = max(array[l-1])
    max_index = array[l-1].index(next_max)
    dp =[]
    print next_max
    for i in range(0, l):
        dp.append(0)
    for i in range(l-2,-1, -1):
        max1 = array[i][max_index] if max_index<len(array[i]) and (max_index>=0) else 0
        max2 = array[i][max_index-1] if ((max_index-1) < len(array[i]) and (max_index-1)>=0) else 0
        next_max1 = max(max1, max2)
        max_index = array[i].index(next_max1)
        print max1, max2, next_max1, max_index
        next_max+=next_max1
    return next_max

l = [[1],
     [1,2],
     [4,1,2],
     [2,3,1,1]]
l2 =[[2],
     [4,1],
     [1,2,7]]
v1 = right_angle(l)
print v1

v2 = right_angle(l2)
print v2


