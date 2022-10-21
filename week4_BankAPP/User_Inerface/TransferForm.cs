using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week4_BankAPP.Model;

namespace week4_BankAPP.User_Inerface
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }
        public static string userEmail;
        public TransferForm(string UserEmail)
        {
            userEmail = UserEmail;
            InitializeComponent();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            var customer = File.ReadAllText(@"Customer.Json");
            var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);
            

            var loggedin_user = result.Users.FirstOrDefault(x => x.Email == userEmail);            
            successMsgTransfer.Text = loggedin_user.FirstName;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var amount = Convert.ToInt32(txtAmountTrf.Text);
            if(amount > 0)
            {
                var customer = File.ReadAllText(@"Customer.Json");
                var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);
                var loggedin_user = result.Users.FirstOrDefault(x => x.Email == userEmail);
                var loggedin_user2 = result.Users.FirstOrDefault(x => x.AccountNumber == txtAccountTrf.Text);
                loggedin_user.Balance = loggedin_user.Balance - amount;
                loggedin_user2.Balance = loggedin_user2.Balance + amount;
                var resultJson = JsonConvert.SerializeObject(result);                
                File.WriteAllText(@"Customer.Json", resultJson);
                MessageBox.Show("Transfer Successfull");

            }
            else
            {
                MessageBox.Show("Dear Customer, Please input a valid Amount");
            }

            
        }
    }
}
