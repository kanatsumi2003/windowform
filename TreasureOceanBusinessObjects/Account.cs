using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureOceanBusinessObjects
{
    public class Account
    {
        private string userName;
        private string password;
        private int roleId;
        private Boolean status;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int RoleId { get => roleId; set => roleId = value; }
        public bool Status { get => status; set => status = value; }
    }
}
