using System;
namespace DesignPatterns_Behavioral
{
    public abstract class Employee
    {
        protected Employee _manager;
        public void SetManager(Employee employee)
        {
            this._manager=employee;
        }
        public abstract bool  ApproveSum(double d);
    }
    public class Manager:Employee
    {
        public override bool ApproveSum(double d)
        {
            if(d>0 && d<10000)
            {
                Console.WriteLine("Sum of {0} approved by Manager",d);
                return true;
            }
            else
            {
                if(_manager!=null)
                {
                    Console.WriteLine("Sum of {0} cannot be approved by Manager",d);
                    Console.WriteLine("Escalating to next level AVP");
                    return _manager.ApproveSum(d);
                }
                else
                {
                    return false;
                }
            }
        }
    }
    public class AVP:Employee
    {
        public override bool ApproveSum(double d)
        {
            if(d>10000 && d<50000)
            {
                Console.WriteLine("Sum of {0} approved by AVP",d);
                return true;
            }
            else
            {
                if(_manager!=null)
                {
                    Console.WriteLine("Sum of {0} cannot be approved by AVP",d);
                    Console.WriteLine("Escalating to next level VP");
                    return _manager.ApproveSum(d);
                }
                else
                {
                    return false;
                }
            }
        }
    }
    public class VP:Employee
    {
        public override bool ApproveSum(double d)
        {
            if(d>50000 && d<100000)
            {
                Console.WriteLine("Sum of {0} approved by VP",d);
                return true;
            }
            else
            {
                if(_manager!=null)
                {
                    Console.WriteLine("Not approved by VP. Escalating....");
                    return _manager.ApproveSum(d);

                }
                else
                {   Console.WriteLine("Not approved by VP.");
                    return false;
                }
            }
        }
    }
}