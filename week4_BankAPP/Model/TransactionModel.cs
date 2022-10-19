using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_BankAPP.Logics
{
    public class TransactionModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string AccountNumber { get; set; }

        public string TransactionId { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;  

        public string Description { get; set; }

        public decimal OutAmount { get; set; }

        public decimal Balance { get; set; }



    }

    

    
}
