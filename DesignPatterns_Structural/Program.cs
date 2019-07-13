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
        }
    }
}
