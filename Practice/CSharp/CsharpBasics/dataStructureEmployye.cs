using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading;
namespace CSharp
{
     public class EmployeeClass
    {
        private int id;
        private string Name;
        private DateTime dob;
        private IEnumerable<EmployeeEvent> EmployeeEvents;
        public EmployeeClass(int id, string name, DateTime dob, IEnumerable<EmployeeEvent> EmployeeEvents)
        {
            this.id =id;
            this.Name = name;
            this.dob = dob;
            this.EmployeeEvents = EmployeeEvents;
        }
        public void AddEvent(EmployeeEvent employeeEvent)
        {
            EmployeeEvents.Append(employeeEvent);
        }
    }



    public class EmployeeEvent
    {
        public EventType eventType;
        public DateTime dateEvent;
    }
    public enum  EventType
    {
        Birthday,
        WorkAnniversary
    }
}