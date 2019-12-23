using System;

public abstract class State
{
    public Account account;
    public double balance;
    public double interest;
    public double minLimit;
    public double maxLimit;
    public string Status;
    public bool isFrozen;
    public bool isAboveGold;
    public abstract void Deposit(double amount);
    public abstract void PayInterest();
    public abstract void Withdraw(double amount);
}

public class RedState:State
{
    public RedState(double balance, Account account)
    {
        this.balance=balance;
        this.account=account;
        Initialize();
    }
    public void Initialize()
    {
        this.Status="RedState";
        this.interest=.04;
        this.minLimit=-100;
        this.maxLimit=10000;
    }
    public override void Deposit(double amount)
    {
        this.balance+=amount;
        isStateChanged();
    }
    public override void Withdraw(double amount)
    {
        this.balance-=amount;
        isStateChanged();
    }
    public override void PayInterest()
    {
        this.balance*=interest;
        isStateChanged();
    }
    public void isStateChanged()
    {
        if(balance>=maxLimit)
        {
            if(isFrozen==true)
            isFrozen=false;
            account.State = new SilverState(this);
        }
        if(balance<=minLimit)
        {
            isFrozen=true;
        }
    }
}
 
public class SilverState:State
{
    public SilverState(State state):
    this(state.balance, state.account)
    {

    }
    public SilverState(double balance, Account account)
    {
        this.balance=balance;
        this.account=account;
        Initialize();
    }
    public  void Initialize()
    {
        Console.WriteLine("Init for silverstatte");
        this.Status="SilverState";
        this.minLimit=-1000;
        this.maxLimit=15000;
    }
    public override void Deposit(double amount)
    {
        this.balance+=amount;
        isStateChanged();
    }
    public override void Withdraw(double amount)
    {
        this.balance-=amount;
        isStateChanged();
    }
    public override void PayInterest()
    {
        this.balance*=interest;
        isStateChanged();
    }
    public void isStateChanged()
    {
        if(balance>=maxLimit)
        {
            if(isFrozen)
            isFrozen=false;
            account.State = new GoldState(this);
        }
        if(balance<=minLimit)
        {
            account.State = new RedState(this.balance, this.account);
        }
    }

}
public class GoldState :State
{
    public GoldState(State state):
    this(state.balance, state.account)
    {

    }
    public GoldState(double balance, Account account)
    {
        this.balance=balance;
        this.account=account;
        Initialize();
    }
     public  void Initialize()
    {
        this.Status="GoldState";
        this.minLimit=-1500;
        this.maxLimit=20000;
    }
    public override void Deposit(double amount)
    {
        this.balance+=amount;
        isStateChanged();
    }
    public override void Withdraw(double amount)
    {
        this.balance-=amount;
        isStateChanged();
    }
    public override void PayInterest()
    {
        this.balance*=interest;
        isStateChanged();
    }
    public void isStateChanged()
    {
        if(balance>=maxLimit)
        {
            this.isAboveGold=true;
        }
        if(balance<=minLimit)    
        {
            this.account.State= new SilverState(this);
            if(this.isAboveGold)
            this.isAboveGold=false;
        }
    }

}
public class Account 
{
    private State _state;
    private string _name;

    public State State
    {
        get{return this._state;}
        set{this._state=value;}
    }
    public string Name
    {
        get{return this._name;}
        set{this._name=value;}
    }
    public Account (string name)
    {
        this._state=new SilverState(0, this);
        this._name=name;
    }
    public double Balance
    {
        get{return _state.balance;}
    }   
    public void Deposit(double depositAmount)
    {
        this._state.Deposit(depositAmount);
        Console.WriteLine("Amount deposited {0} in {1}'s account ",depositAmount,_name);
        Console.WriteLine("Balance after deposit{0} ",_state.balance);
        Console.WriteLine("Status after depost {0} ",_state.Status);

    }
    public void Withdraw(double withdrawAmount)
    {
        this._state.Withdraw(withdrawAmount);
        Console.WriteLine("Amount withdraw {0} in {1}'s account ",withdrawAmount,_name);
        Console.WriteLine("Balance after withdrawal {0}",_state.balance);
        Console.WriteLine("Status after withdrawal {0} ",_state.Status);
    }
}
