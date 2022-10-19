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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace week4_BankAPP.User_Inerface
{
    public partial class DepositForm : Form
    {
        //private readonly string userEmail;

        public DepositForm()
        {
            InitializeComponent();
        }

        public DepositForm(string Useremail)
        {
            userEmail = Useremail;
            InitializeComponent();
        }

        public static List<UserModel> Customer = new List<UserModel>();

        //Declaring the User Email public
        public static string userEmail;


        private void DepositForm_Load(object sender, EventArgs e)
        {

            errorMsgDeposit.Text = "";
            //SuccessMsgDeposit.Text = "It worked";

            var customer = File.ReadAllText(@"Customer.Json");
            var result = JsonConvert.DeserializeObject<List<UserModel>>(customer);

            var loggedin_user1 = result.FirstOrDefault(x => x.Email == userEmail);
            SuccessMsgDeposit.Text = loggedin_user1.FirstName;
        }

        private void txtAmountToDeposit_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAmountToDeposit.Text, "[^0-9]"))
            {
                errorMsgDeposit.Text = "Please enter only numbers.";
                txtAmountToDeposit.Text = txtAmountToDeposit.Text.Remove(txtAmountToDeposit.Text.Length - 1);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }
    }
}
