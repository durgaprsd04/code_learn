using System;
namespace DesignPatterns_Behavioral
{
    public class Memento
    {
        private string _name;
        private string _phone;
        private double _budget;
        public Memento(string name, string phone, double budget)
        {
            this._name=name;
            this._phone=phone;
            this._budget=budget;
        }
        public string Name{
            get{return _name;}
            set{this._name=value;}
        }
        public string Phone{
            get{return _phone;}
            set{this._phone=value;}
        }
        public double Budget{
            get{return _budget;}
            set{this.Budget=value;}
        }
    }
    public class Orginator
    {
        public string Name{get;set;}
        public string Phone{get;set;}
        public double Budget{get;set;}

        public Memento SaveMomento()
        {
            return new Memento(Name,Phone,Budget);
        }
        public void RestoreMemento(Memento m)
        {
            this.Name=m.Name;
            this.Phone=m.Phone;
            this.Budget=m.Budget;
        }
        public void DisplayStuff()
        {
            Console.WriteLine("current State of {0} {1} {2} ",Name,Phone,Budget);
        }
    }
    public class ProspectiveMemory
    {
        private Memento _memento;
        public Memento memento
        {
            set{_memento=value;}
            get{return _memento;}
        }
    }

}