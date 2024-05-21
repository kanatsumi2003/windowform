using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;
using TreasureOceanRepository;

namespace TreasureOceanService
{
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository iAccountRepository;
        public AccountService()
        { 
            if(iAccountRepository == null)
            {
                iAccountRepository = new AccountRepository();
            }
        }

        public Account GetAccount(string username, string password)
        {
            return iAccountRepository.GetAccount(username, password);
        }

        public bool isAccount(string username, string password)
        {
            return iAccountRepository.isAccount(username, password);
        }
    }
}
