import java.util.*;

class QuickStart {
    public static void main(String[] args) {
        System.out.println("Hello, World.");
        QuickStart q = new QuickStart();
        var l =q.Fibonacci(5);
        for (Integer integer : l) {
            System.out.println(integer+", ");
        }
       
    }
    public  List<Integer> Fibonacci(int n)
    {
        int a=0,b=0,c=1;
        List<Integer> l1
        = new ArrayList<Integer>();
        l1.add(b);
        for(int i=0;i<n;i++)
        {
            a = b+c;
            b=c;
            c=a;
            l1.add(b);
        }
        return l1;
    }
}