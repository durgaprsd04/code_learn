using System;

namespace CSharp.Events
{
    public class EventTestWithDelegate
    {
        public string name;
        public EventTestWithDelegate(string name)
        {
            this.name=name;
        }   
        public event Action<string> OnChange = delegate{};
        public void Raise()
        {
            foreach(Delegate h in OnChange.GetInvocationList())
            {
                    
                    try{
                        h.DynamicInvoke(this.name);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }
                    
            }
            
        }
    }
}