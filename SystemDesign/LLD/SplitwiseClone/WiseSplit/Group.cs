using System.Collections.Generic;
using WiseSplit.Interfaces;
using System;
namespace WiseSplit
{
    public class Group : IGroup
    {
        private string id;
        private IList<IUser> users;
        public Group(IList<IUser> users)
        {
            this.id = Guid.NewGuid().ToString();
            this.users = users;
        }
        public Group(string id, IList<IUser> users)
        {
            this.id = id;
            this.users = users;
        }

        public IGroup AddExpense(double expense, IList<IUser> userList)
        {
            if(userList.Count==0)
                return this;
            var share = expense/userList.Count;
            for(int i=0;i< userList.Count;i++)
                userList[i] = userList[i].AddExpense(this.id, share);
            
            for(int i=0;i<users.Count;i++)
                if(!userList.Contains(users[i]))
                    userList.Add(users[i]);
            return new Group(this.id, userList);
        }
    }
}