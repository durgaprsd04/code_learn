def myFun(func):
    def newDecorator():
        print('this Fucntion provides wrapper')
        func()
        print('this function finished func')
    return newDecorator

@myFun
def mainFun():
    print("another print function")

#Testing the same for class
class House():
    def __init__(self, price):
        self._price = price

    @property
    def price(self):
        return self._price
    
    @price.setter
    def price(self, new_price):
        if new_price > 0 and isinstance(new_price, float):
            self._price = new_price
        else:
            print("Please enter a valid price")
    
    @price.deleter
    def price(self):
        del self._price
    
    def print(self):
        if(hasattr(self, '_price')):
            print("house price "+ str(self._price))
        else:
            print ("No attribute for price")

#mainFun()
house = House(50000.0)
house.print()
house.price=40000.0
house.print()
house.price = -50
house.print()
del house.price
house.print()