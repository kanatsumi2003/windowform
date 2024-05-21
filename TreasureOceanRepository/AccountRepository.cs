using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;
using TreasureOceanDAO;

namespace TreasureOceanRepository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountDAO accountDAO;
        public AccountRepository() 
        {
            if(accountDAO == null)
            {
                accountDAO = new AccountDAO();
            }
        }
        public Account GetAccount(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool isAccount(string username, string password)
        {
            return accountDAO.GetAccount(username, password) != null;
        }
    }
}
