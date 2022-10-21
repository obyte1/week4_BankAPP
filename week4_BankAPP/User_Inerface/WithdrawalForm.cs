using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week4_BankAPP.Logics;
using week4_BankAPP.Model;

namespace week4_BankAPP.User_Inerface
{
    public partial class WithdrawalForm : Form
    {
        public WithdrawalForm()
        {            
            InitializeComponent();
        }
        public static string withdrawEmail;
        public WithdrawalForm(string WithdrawEmail)
        {
            withdrawEmail = WithdrawEmail;
            InitializeComponent();
        }
        public static List<UserModel> Customer = new List<UserModel>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAmountToWithdraw_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAmountToWithdraw.Text, "[^0-9]"))
            {
                lblErrorMsgWithdraw.Text = "Please enter only numbers.";
                txtAmountToWithdraw.Text = txtAmountToWithdraw.Text.Remove(txtAmountToWithdraw.Text.Length - 1);
            }
        }

        private void WithdrawalForm_Load(object sender, EventArgs e)
        {
            var customer = File.ReadAllText(@"Customer.Json");
            var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);

            var loggedin_user2 = result.Users.FirstOrDefault(x => x.Email == withdrawEmail);
            lblsucess.Text = loggedin_user2.FirstName;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var amount = Convert.ToInt32(txtAmountToWithdraw.Text);
            var customer = File.ReadAllText(@"Customer.Json");
            var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);
            var loggedin_user2 = result.Users.FirstOrDefault(x => x.Email == withdrawEmail);
            loggedin_user2.Balance = loggedin_user2.Balance - amount;

            var resultJson = JsonConvert.SerializeObject(result);
            //var fileinfo = new FileInfo(@"");
            File.WriteAllText(@"Customer.Json", resultJson);

            MessageBox.Show("Withdrawal Success");

        }
    }
}
