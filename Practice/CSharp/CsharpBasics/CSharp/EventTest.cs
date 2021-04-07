using System;
namespace CSharp
{
    
    public class EventTest{
            public Action<string> OnChange{get;set;}
            public void EventRaise(string name)
            {
                if(OnChange!=null)
                {
                    OnChange(name);
                }
            }
    }   
}