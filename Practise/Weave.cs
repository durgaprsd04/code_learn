using  System;
namespace Practise
{

    public class Weave
    {
        public MyQueue<string>  WeaveQueue(MyQueue<string>  m1 , MyQueue<string> m2)
        {
            MyQueue<string> s3= new MyQueue<string>();
            var e1 = m1.DeQueue();
            var e2 = m2.DeQueue();
            while(e2!=null || e1!=null)
            {
                if(e2!=null)
                    s3.Enqueue(e2);
                if(e1!=null)
                    s3.Enqueue(e1);
                    
                e1 = m1.DeQueue();
                e2 = m2.DeQueue();
            }
          return s3;
        }
    }
}
