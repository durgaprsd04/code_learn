def size_of_subarray_with_max_sum(array):
    l = len(array)
    dp =0
    prev =[]
    j = 0
    k =0
    limit=0
    max1= -100000
    for i in range(1,l):
        dp += array[i]
        if dp>max1:
            max1=dp
            k = i
            j = limit
        if dp<0:
            limit=i;
    print j, k

def negative_numbers_subarray(array):
    l = len(array)
    dp =[]
    for j in range(0,l):
        dp.append(0)
    prev =[]
    j = 0
    k =0
    limit=0
    dp[0]= array[0]
    max1= -100000
    for i in range(1,l):
        dp[i] = max(array[i]+dp[i-1], array[i])
        if dp[i]>max1:
            max1=dp[i]
            k = i
            j = limit
        if dp[i]==array[i]:
            limit=i;
    print j, k



arr =[1, -2, 1, 1, -2, 1]
arr2 =[-2, -3, 4, -1, -2, 1, 5, -3]
size_of_subarray_with_max_sum(arr)
negative_numbers_subarray(arr2)

