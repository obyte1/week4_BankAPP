using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_BankAPP.Logics
{
    public class TransactionModel
    {
        public string AccountNumber { get; set; }

        public string TransactionId { get; set; }

        public DateTime? DateTime { get; set; }

        public string Description { get; set; }

        public decimal? outAmount { get; set; }

        public decimal? Balance { get; set; }



    }

    

    
}
