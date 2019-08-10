using System;
namespace DesignPatterns_Structural
{
    public class Customer
    {
        private int UserId;
        private string UserName;
        private double BankBalance, CreditScore;
        private bool hasLoans; 
        public Customer(int id, string name,double bb, double cs, bool hasloan)
        {
            UserId=id;
            UserName=name;
            BankBalance=bb;
            CreditScore=cs;
            hasLoans=hasloan;

        }
        public bool HasLoan{
        get { return hasLoans;}
        }
        public double BBalance{
            get {return this.BankBalance;}
        }
        public double CScore{
            get{return this.CreditScore;}
        }
        public string UName{
            get {return this.UserName;}
        }

    }
    public class Loan
    {
        public bool CheckLoanEligibility(Customer cust)
        {
            if(cust.HasLoan)
                return false;
            if(cust.BBalance>200000 && cust.CScore>500)
                return true;
            return false;

        }
    }
    public class CreditCard
    {
         public bool CheckCreditCardEligibility(Customer cust)
        {
            if(cust.CScore>600)
                return true;
            return false;
        }
    }
    public class Bank
    {
         public bool CheckDepositEligibility(Customer cust)
        {
            if(cust.CScore>400)
                return true;
            return false;
        }
    }
    public class Mortgage
    {
        private Bank _bank;
        private CreditCard  _card;
        private Loan _loan;
        private Customer _cust;
        public Mortgage(Customer cust)
        {
            _bank = new Bank();
            _card= new CreditCard();
            _loan = new Loan();
            _cust=cust;
        }        
        public bool Eligible()
        {
           if( _loan.CheckLoanEligibility(_cust)&&_bank.CheckDepositEligibility(_cust)&&_card.CheckCreditCardEligibility(_cust))
           {
               return true;
           }
           return false;
        }
    }
}