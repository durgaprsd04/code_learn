def longest_common_subsequence(s1, s2):
    l1 = len(s1)
    l2 = len(s2)
    lcs=[]
    for i in range(0,l1):
        l = []
        for j in range(0,l2):
            l.append(0)
        lcs.append(l)
    print(lcs)
    i = l1-1;
    j = l2 -1
    prev=0
    while(i>=0):
        j =l2-1
        while(j>=0):
            #print(s1[i], s2[j])
            if(s1[i]==s2[j]):
                print(s1[i], s2[j])
                lcs[i][j] = max(lcs[i][j], prev)+ 1
            else:
                lcs[i][j] = max(lcs[i][j], prev)
            prev = lcs[i][j]
            j=j-1
        i=i-1
        
    print(lcs)
    return lcs[0][0]


res = longest_common_subsequence("ACEDF", "ACEFG")
print(res)
res = longest_common_subsequence("ACEDF", "ACEFG")
print(res)