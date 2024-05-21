using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;

namespace TreasureOceanRepository
{
    public interface IAccountRepository
    {
        public Account GetAccount(string username, string password);
        public bool isAccount(string username, string password);

    }
}
