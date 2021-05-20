using System.Collections.Generic;
using System;

namespace WiseSplit.Interfaces
{   
    public interface IGroup
    {
        public IGroup AddExpense(double expense, IList<IUser> userList);
    }
}