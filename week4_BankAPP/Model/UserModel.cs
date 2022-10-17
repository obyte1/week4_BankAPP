using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace week4_BankAPP.Logics
{
    internal class UserModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string AccountName
        {
            get { return FirstName + ", " + LastName; }
        }

        public string Email { get; set; }

        public string password { get; set; }

        public string AccountNumber { get; set; }

        public string AccountType { get; set; }

        public decimal? Balance { get; set; }

        public List<TransactionModel> TransactionList { get; set; }

        public UserModel(string firstName, string lastName, string email, string password, string accountNumber, string accountType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            this.password = password;
            AccountNumber = accountNumber;
            AccountType = accountType;
           // Balance = balance;
           // TransactionList = transactionList;
        }
    }
}
