import itertools


data =[1,2,3,4,5,5]
print("prefix sum using itertols "+str(list(itertools.accumulate(data))))

groups=[]
uniquekeys=[]
for k, g in itertools.groupby(data):
    groups.append(list(g))      # Store group iterator as a list
    uniquekeys.append(k)
print("group by using ")
print("group by   "+str(groups) )
print("unique keys "+ str(uniquekeys))
