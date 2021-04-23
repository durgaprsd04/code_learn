def test_lambda(n):
    return lambda : n*n

def list_comprehension(n):
    c= [j for j in range(1,n) ]
    return c

def square_dict_comprehension(n):
    c= {j: j*j for j in range(1,n) }
    return c


t =test_lambda(5)
print("Squre "+ str(t()))

print("list "+str(list_comprehension(20)))

print("list "+str(square_dict_comprehension(20)))