using System;
using System.Collections.Generic;

namespace WiseSplit.Interfaces
{   
    public interface IUser
    {
        public IGroup CreateGroup(string name, IList<IUser> users);
        public IUser AddExpense(string groupId, double share);
    }
}