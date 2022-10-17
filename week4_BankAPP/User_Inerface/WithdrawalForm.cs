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
    public partial class WithdrawalForm : Form
    {
        public WithdrawalForm()
        {
            InitializeComponent();
        }

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
    }
}
