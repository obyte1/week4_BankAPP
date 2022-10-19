using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_BankAPP.Logics;

namespace week4_BankAPP.Model
{
    public class AccountModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserID { get; set; }
        public string AccountNumber { get; set; }
        public AccountType Type { get; set; }
        public string Balance { get; set; }

        public List<TransactionModel> TransactionList { get; set; }

    }

    public enum AccountType 
    {
        Savings, 
        Current

    }
}
