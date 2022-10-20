using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_BankAPP.Model;

namespace week4_BankAPP.Logics
{
    public class UserModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }

        public string LastName { get; set; }
        //public string AccountName
        //{
        //    get { return FirstName + ", " + LastName; }
        //}

        public string Email { get; set; }

        public string password { get; set; }

        public string AccountNumber { get; set; }

        public string AccountType { get; set; }

        public double Balance { get; set; }

        public string PhoneNumber { get; set; }


        public List<AccountModel> AccountList { get; set; }

        public UserModel(string firstName, string lastName, string email, string password, string accountNumber, string accountType, string PhoneNo, double Balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            this.password = password;
            AccountNumber = accountNumber;
            AccountType = accountType;
            this.Balance = Balance;
            PhoneNumber = PhoneNo;


           // TransactionList = transactionList;
        }
    }
}
