using System;
namespace DesignPatterns
{
    public class  Client
    {
        private AbstractProductA productA;
        private AbstractProductB productB;

        public Client(AbstractFactory product)
        {
            productA = product.GetProductA();
            productB = product.GetProductB();
        }
        public override string ToString()
        {
            return "Client init with "+productA.ToString()+" and "+productB.ToString();
        }
    }
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA GetProductA();
        public abstract AbstractProductB GetProductB();
    } 
    public class ConcreteFactory :AbstractFactory
    {
        public override AbstractProductA GetProductA()
        {
            return new ProductA();
        }
        public override AbstractProductB GetProductB()
        {
            return new ProductB();
        }
    }
    public abstract class  AbstractProductA
    {

    }
       public abstract class  AbstractProductB
    {

    }
    public class ProductA:AbstractProductA
    {
        public override string ToString(){
           return "Product A";
        }
    }
    public class ProductB:AbstractProductB
    {
        public override string ToString(){
           return "Product B";
        }
    }
}