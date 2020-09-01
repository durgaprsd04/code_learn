using System;
using System.Collections.Generic;
namespace DesignPatterns_Structural
{
    public abstract class Twig
    {
        protected string _name;
        public Twig(string name)
        {
            this._name=name;
        }
        public abstract void RemoveTwig(Twig twig);
        public abstract void AddTwig(Twig twig);
        public abstract void DisplayTwig(int indent);
    }
    public class SmallBranch:Twig
    {
        public SmallBranch(string name):base(name)
        {

        }
       public override void RemoveTwig(Twig twig)
       {
           Console.WriteLine("Cannnot remove from Smallbranch");
       }
       public override void AddTwig(Twig twig)
       {
           Console.WriteLine("Cannot add twig to smallbranch");
       }
       public override void DisplayTwig(int depth)
       {
           Console.WriteLine(new String('-',depth)+_name);
       }
    }
    
    public class LargeBranch:Twig
    {
        public LargeBranch(string name):base(name)
        {

        }
       private  List<Twig> _listoftwigs = new List<Twig>();

        public  override void AddTwig(Twig twig)
        {
            _listoftwigs.Add(twig);
        }
        public override void RemoveTwig(Twig twig)
        {
            _listoftwigs.Remove(twig);
        }
        public override void DisplayTwig(int indent)
        {
            Console.WriteLine(new String('-', indent)+ _name);
            foreach(Twig twig in _listoftwigs)
            {
                twig.DisplayTwig(indent+2);
            }
        }
    }

}