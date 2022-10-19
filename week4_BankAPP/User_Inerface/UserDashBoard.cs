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
using week4_BankAPP.Logics;
using week4_BankAPP.User_Inerface;

namespace week4_BankAPP.User_Inerface
{
    public partial class UserDashBoard : Form
    {
        //fmWlc fmWlc1 = new fmWlc();
        
        public UserDashBoard()
        {
            
            InitializeComponent();
            
        }

        //passing the user email to another page
        public UserDashBoard(string UserEmail)
        {
            userEmail = UserEmail;
            InitializeComponent();

        }
        public static List<UserModel> Customer = new List<UserModel>();

        //Declaring the User Email public
        public static string userEmail;

        private void UserDashBoard_Load(object sender, EventArgs e)
        {          
            

            var customer = File.ReadAllText(@"Customer.Json");
            var result = JsonConvert.DeserializeObject<List<UserModel>>(customer);
            
            var loggedin_user = result.FirstOrDefault(x=>x.Email==userEmail);
            lblWelcomeUser.Text = ($"{loggedin_user.FirstName} {loggedin_user.LastName}");
            lblaccountnumberDisplay.Text = ($"ACC NO: {loggedin_user.AccountNumber}");
            lblAccountType.Text = ($"{loggedin_user.AccountType}");
            lblAmountDisplay.Text = ($"ACC BAL: {loggedin_user.Balance.ToString()}");
                       



        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }


        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }       

        DepositForm depositForm = new DepositForm();
        private void lblDeposit_Click(object sender, EventArgs e)
        {
            
            depositForm.MdiParent = this;
            depositForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void picCloase_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            //this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        WithdrawalForm withdrawalForm = new WithdrawalForm();
        private void label2_Click(object sender, EventArgs e)
        {
            
            withdrawalForm.MdiParent=this;
            withdrawalForm.Show();


        }

        private void lblTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.MdiParent = this;
            transferForm.Show();
        }

        private void lblCheckBalance_Click(object sender, EventArgs e)
        {
            CheckBalanceForm checkBalanceForm = new CheckBalanceForm();
            checkBalanceForm.MdiParent = this;
            checkBalanceForm.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            fmWlc fmWlc = new fmWlc();
            this.Hide();
            fmWlc.Show();
        }
    }
}
