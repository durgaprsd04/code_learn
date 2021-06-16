using System;
using System.Timers;
using System.Collections.Generic;
namespace interview9
{
    public class CachingSystem<T1, T2> 
    {
        private object locker = new object();
        private Dictionary<T1, T2> dictionary;
        private Queue<Tuple<T1,DateTime>> timeQueue;
        
        private static  Timer expiryTimer = new System.Timers.Timer();
        private  int timeout;
        public CachingSystem(int timeout)
        {
            dictionary = new Dictionary<T1, T2>();
            timeQueue = new Queue<Tuple<T1, DateTime>>();
            this.timeout = timeout;
            expiryTimer.AutoReset =false;
        }
        public void Add(T1 key, T2 value, TimeSpan expiry)
        {
            if(dictionary.ContainsKey(key))
            {
                lock(locker)
                {
                    dictionary.Add(key, value);
                    timeQueue.Enqueue( new Tuple<T1,DateTime>(key, DateTime.Now+new TimeSpan(0,0,timeout)));
                    expiryTimer.Elapsed += (sender, e ) => OnTimeOut(sender, e, key);
                    expiryTimer.Interval = timeout;
                    expiryTimer.Enabled=true;
                }
            }
        }
        public T2 Get(T1 key)
        {
           if(dictionary.ContainsKey(key))
            {

                return dictionary[key];
            }
            else 
                return default(T2);
        }
        public void OnTimeOut(object sender, EventArgs e, T1 key)
        {
            if(dictionary.ContainsKey(key))
            {
                dictionary.Remove(key);
                if(timeQueue.Peek().Item2 > DateTime.Now)
                {
                    expiryTimer.Interval = (DateTime.Now - timeQueue.Dequeue().Item2).Seconds;
                    expiryTimer.Enabled=true;
                }
            }
        }
    }
}

//a->b -> c 

//a -> b, e , d 
//c  