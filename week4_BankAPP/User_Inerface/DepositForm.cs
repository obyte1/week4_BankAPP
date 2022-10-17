using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace week4_BankAPP.User_Inerface
{
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            errorMsgDeposit.Text = "";
            SuccessMsgDeposit.Text = "";
        }

        private void txtAmountToDeposit_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAmountToDeposit.Text, "[^0-9]"))
            {
                errorMsgDeposit.Text = "Please enter only numbers.";
                txtAmountToDeposit.Text = txtAmountToDeposit.Text.Remove(txtAmountToDeposit.Text.Length - 1);
            }
        }
    }
}
