class TowerOfHanoi:
    def tower_of_hanoi(self, n):
        # n is height of tower.
        tower =[]
        stick1=[]
        stick2=[]
        for n in range(n, 0,-1):
            tower.append(n)
        #moving to stick1
        whilei(len(tower)>0):
            if len(stick1)==0:
                if(len(tower)>0):
                    stick1.append(tower.pop())
            if len(stick2)==0:
               if(len(tower)>0):
                    stick2.append(tower.pop())
            if 1>2:
                pass

