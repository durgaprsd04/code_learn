using System;
using System.Collections;
using System.Collections.Generic;
namespace DesignPatterns_Behavioral
{
    public class Stock
    {
        private string _name;
        public string Name{get{return _name;}}
        private double _price;
        public double Price{
            get{
                return _price;
            }
            set{
                _price=value;
                Notify();
            }
        }
        public Stock(string stockName, double stockValue)
        {
            this._name=stockName;
            this._price=stockValue;
        }
        public List<Investors> _listOfInvestors = new List<Investors>();
        public void AddInvestor(Investors Investor)
        {
            if(Investor!=null)
            {
                _listOfInvestors.Add(Investor);
            }
        }
        public void Notify()
        {
            foreach(var investor in _listOfInvestors)
            {
                investor.Notify(this);
            }
        }
    }
    public class IBM:Stock
    {
        public IBM(string stockName, double price):
        base(stockName, price)
        {
            
        }
    }
    public class Investors
    {
        private string _name;
        public Investors(string name)
        {
            _name=name;
        }
        public void Notify(Stock stockName)
        {
            Console.WriteLine("{0} notified with {1} stock value changed to {2}",_name, stockName.Name, stockName.Price);
        }
    }
}