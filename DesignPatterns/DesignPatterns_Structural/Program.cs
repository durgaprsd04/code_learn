using System;

namespace DesignPatterns_Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adaptor Pattern");
            Compound c1 = new Compound("Unknown");
            Compound c2 = new ChemicalCompound("water");
            Compound c3 = new ChemicalCompound("methane");
            Compound c4 = new ChemicalCompound("ethanol");
            c1.Display();
            c2.Display();
            c3.Display();
            c4.Display();
            Console.WriteLine("Bridge Pattern");
            AbstractAreaCalculator aac = new AreaCalculator();
            aac.Shape = new Circle(10);
            Console.WriteLine("Area thus calcualated for Circle "+aac.CalculateShapeArea());
            aac.Shape = new Square(10);
            Console.WriteLine("Area thus calcualated for Circle "+aac.CalculateShapeArea());
            Console.WriteLine("Composite Pattern");
            Twig trunk = new SmallBranch("branch1");
            Twig trunk1 = new SmallBranch("branch2");
            Twig trunk2 = new LargeBranch("branchA");
            trunk2.AddTwig(trunk1);
            trunk2.AddTwig(trunk);
            Twig trunk3 = new LargeBranch("branchAA");
            trunk3.AddTwig(trunk2);
            Twig trunka = new SmallBranch("branch3");
            Twig trunkb = new SmallBranch("branch4");
            Twig trunkc = new LargeBranch("branch"); 
            trunkc.AddTwig(trunka);
            trunkc.AddTwig(trunkb);
            trunk2.AddTwig(trunkc);
            trunk3.DisplayTwig(2);
            Console.WriteLine("Decorator pattern");
            Book bk1 = new Book(10, "Amitav Ghosh","Sea of poppies");
            Video v1 = new Video(2, "Spileberg","jaws","1:30 hr");
            Borrower b1 = new Borrower( bk1);
            b1.Borrow("cust1");
            Borrower b2 = new Borrower(v1);
            b1.Display();
            b1.Return("cust1");
            b1.Display();
            b2.Borrow("cust2");
            b2.Display();
            b2.Return("cust2");
            b2.Display();
            Console.WriteLine("FacadePattern");
            Customer cust1 = new Customer(10,"ram", 200002, 200, false);
            Customer cust2 = new Customer(11,"laxman", 500002, 700, false);
            Mortgage mortgage = new Mortgage(cust1);
            if(mortgage.Eligible())
            {
                Console.WriteLine(cust1.UName+" is eligible");
            }
            mortgage = new Mortgage(cust2);
            if(mortgage.Eligible())
            {
                Console.WriteLine(cust2.UName+" is eligible");
            }
            Console.WriteLine("Flyweight Pattern");
            CharacterFactory cf = new CharacterFactory();
            Character char1 = cf.GetCharacter('A');
            char1.Display(10);
            Character char2=cf.GetCharacter('B');
            char2.Display(10);
             Character char3=cf.GetCharacter('B');
            char2.Display(10);
            Console.WriteLine("Proxy Pattern");
            MathProxy mp = new MathProxy();
            Console.WriteLine("Add "+mp.Add(34,43));
            Console.WriteLine("Mul "+mp.Mul(34,43));
            Console.WriteLine("Sub "+mp.Sub(34,43));
            Console.WriteLine("Div "+mp.Div(34,43));
        }
    }
}
