using System;
namespace DesignPatterns_Structural
{
    public class Compound
    {
        private string _chemical;
        public Compound(string chemical)
        {
            this._chemical=chemical;
        }
        public virtual  void Display()
        {
            Console.WriteLine("compound name "+_chemical);
        }
    }
    public class ChemicalCompound : Compound
    {
        string _chemical;
        public ChemicalCompound(string chemical):
            base(chemical)
            {
                this._chemical=chemical;
        }
        private ChemicalDataBank _chemicaldatabank;
        public override void Display()
        {
            _chemicaldatabank = new ChemicalDataBank();
            base.Display();
            Console.WriteLine("compound metling point  "+_chemicaldatabank.GetMeltingPoint(_chemical));
            Console.WriteLine("compound boiling point  "+_chemicaldatabank.GetBoilingPoint(_chemical));
            Console.WriteLine("compound chemical name  "+_chemicaldatabank.GetChemicalName(_chemical));
        }

    }
    public class ChemicalDataBank
    {   
        public int GetMeltingPoint(string chemical){
            switch(chemical)
            {
                case "water":
                return 0;
                case "methane":
                return 10;
                case "ethanol":
                return 40;
                default:return 0;
            }
        }
        public double GetBoilingPoint(string chemical){
            switch(chemical)
            {
                case "water":
                return 100;
                case "methane":
                return 110;
                case "ethanol":
                return 140;
                default:return 0;
            }
        }
        public string GetChemicalName(string chemical){
            switch(chemical)
            {
                case "water":
                return "H20";
                case "methane":
                return "C2H2";
                case "ethanol":
                return "C2H6O";
                default:return "Undefined";
            }
        }
        
        
    }

    
}