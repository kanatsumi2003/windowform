using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;

namespace TreasureOceanDAO
{
    public class AccountDAO
    {
        public AccountDAO() { }
        public Account GetAccount(string username, string password)
        {
            Account account = new Account();
            account.UserName = "123";
            account.Password = "123";
            if(account.UserName.Equals(username) && account.Password.Equals(password)) 
            {
                return account;
            }
            return null;
        } 
    }
}
