using WiseSplit.Interfaces;
using System.Collections.Generic;
namespace WiseSplit
{
    class User:IUser
   {
       private string name;
       public Dictionary<string,double> expenses ;
       public User(string name)
       {
           this.name = name;
           this.expenses = new Dictionary<string, double>();
       }
       public User(string name, Dictionary<string, double> expenses)
       {
           this.name = name;
           this.expenses = new Dictionary<string, double>(expenses);
       }
      
        public IGroup CreateGroup(string name, IList<IUser> users)
        {
            return new Group(users);
        }

        public IUser AddExpense(string groupId, double share)
        {
            var tempExpenses = new Dictionary<string,double>( expenses);
            if(tempExpenses.ContainsKey(groupId))
                tempExpenses.Add(groupId, 0);
            tempExpenses[groupId]+=share;            
            return new User(this.name, tempExpenses);
        }
    }
}