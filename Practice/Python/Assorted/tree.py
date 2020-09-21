class Tree:
    def __init__(self, val, left, right):
        self.val = val
        self.left = left
        self.right = right

    def print_in_order1(self, t):
        if(t.left==None):
            print  t.val,
        else:
            self.print_in_order1(t.left)
            print t.val,
            self.print_in_order1(t.right)

    def print_in_order(self):
        print 'post order'
        if self.left!=None:
            self.print_in_order1(self.left)
            print self.val,
            self.print_in_order1(self.right)

    def print_pre_order1(self, t):
        if(t!=None):
            print t.val,
            self.print_pre_order1(t.left)
            self.print_pre_order1(t.right)

    def print_pre_order(self):
        print 'pre order'
        print self.val,
        self.print_pre_order1(self.left)
        self.print_pre_order1(self.right)

    def print_post_order1(self, t):
        if(t!=None):
            self.print_post_order1(t.left)
            self.print_post_order1(t.right)
            print t.val,

    def print_post_order(self):
        print 'post order'
        self.print_post_order1(self.left)
        self.print_post_order1(self.right)
        print self.val,

    def dfs1(self, t):
        if(t!=None):
            self.dfs1(t.left)
            print t.val,
            self.dfs1(t.right)
    def dfs(self):
        print 'dfs'
        self.dfs1(self.left)
        print self.val,
        self.dfs1(self.right)

    def level_order1(self, l):
        l1= []
        for t in l:
            if(t.left!=None):
                l1.append(t.left)
            if(t.right!=None):
                l1.append(t.right)
        return l1


    def level_order(self):
        print self.val
        l =[]
        l.append(self.left)
        l.append(self.right)
        while(len(l)>0):
            for v in l:
                print v.val,
            l = self.level_order1(l)
            print

def TestTree():
    v1 = Tree(1,None,None)
    v2 = Tree(2, None, None)
    v3 = Tree(6, None, None)
    v4 = Tree(8, None, None)
    nodeleft = Tree(3,v1, v2)
    noderight = Tree(7,v3, v4)
    tree = Tree(5, nodeleft, noderight)
    tree.print_in_order()
    tree.print_pre_order()
    tree.print_post_order()
    tree.dfs()
    tree.level_order()


TestTree()
