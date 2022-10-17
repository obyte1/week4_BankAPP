using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace week4_BankAPP.User_Inerface
{
    public partial class UserDashBoard : Form
    {
        
        public UserDashBoard()
        {
            
            InitializeComponent();
            //lblWelcomeUser.Text = customer;
        }

        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            //lblWelcomeUser.Text =
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
            this.Close();
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
    }
}
