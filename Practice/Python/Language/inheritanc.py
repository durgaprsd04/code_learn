import  math
class Shape:
    def CalculateArea(self)-> float:
        pass
    
    def CalculatePerimeter(self)-> float:
        pass

class Circle(Shape):
    
    def __init__(self, radius : float):
        self.radius = radius

    def CalculateArea(self) -> float:
        return self.radius*self.radius*math.pi
    
    def CalculatePerimeter(self) -> float:        
        return self.radius*2*math.pi 
