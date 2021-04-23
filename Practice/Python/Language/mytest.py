import inheritanc as sh 
import ast


circle = sh.Circle(5.0)
print("Circle Area "+ str(circle.CalculateArea()))
print("Circle Perimiter"+ str(circle.CalculatePerimeter()))

print ("Is sub class "+str(issubclass(sh.Circle, sh.Shape)))
print  (sh.Circle.__mro__)
for j in ast.literal_eval("[1,3,3,4,5]"):
    print(j)