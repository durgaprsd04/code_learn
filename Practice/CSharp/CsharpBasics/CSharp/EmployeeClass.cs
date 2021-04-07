using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading;
namespace CSharp
{
     public class EmployeeClass
    {
        public delegate void TickHandler(IEnumerable<EmployeeEvent> events);
        private event TickHandler tick;
        private int id;
        public int Id {
           get { return id;}
        }
        
        public bool WorkAnniversary;
        private string Name;
        private DateTime dob;
        private IEnumerable<EmployeeEvent> EmployeeEvents = new List<EmployeeEvent>();
        public EmployeeClass(int id, string name, DateTime dob, TickHandler action)
        {
            this.id =id;
            this.Name = name;
            this.dob = dob;
            tick = action;
        }
        public void AddEvent(EmployeeEvent employeeEvent)
        {
            EmployeeEvents.Append(employeeEvent);
            tick(EmployeeEvents);
        }
    }
    public class EmployeeEvent
    {
        public EmployeeEvent(int id, EventType eventType)
        {
            this.Id = id;
            this.eventType = eventType;
        }
        public int Id;
        public EventType eventType;
        public DateTime dateEvent;
    }
    public enum  EventType
    {
        Birthday,
        WorkAnniversary
    }
}