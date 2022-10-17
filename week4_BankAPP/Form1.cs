using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week4_BankAPP.User_Inerface;
using System.IO;
using week4_BankAPP.Logics;
using Newtonsoft.Json;


namespace week4_BankAPP
{
    public partial class fmWlc : Form
    {
        public static string firstname;
        string lastname;
        string email;
        string phoneno;
        string password;
        string accounttype;
        public fmWlc()
        {
            InitializeComponent();
        }

        private static readonly List<UserModel> Customer = new List<UserModel>();
        //public List<UserModel> Customer = userModels;
        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmWlc_Load(object sender, EventArgs e)
        {
           // pnlLogin.Visible = false;
            txtPassword.PasswordChar = '*';
            txtCreatePassword.PasswordChar = '*';
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
            lblErrorMsg.Text = "";
           
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCreatAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.Visible = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.Visible=false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {  

            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            email = txtEmail.Text;
            phoneno = txtPhoneNo.Text;
            password = txtCreatePassword.Text;
            accounttype = txtFirstName.Text;

            try
            {
                var person = new UserModel(firstname, lastname, email, phoneno, accounttype, password);
                Customer.Add(person);
                

                var resultJson = JsonConvert.SerializeObject(Customer);
                File.WriteAllText(@"Customer.Json", resultJson);
                

                MessageBox.Show("Record Inserted Successfully, Please click Ok to Login");
                pnlRegister.Visible=false;
                pnlLogin.Visible=true;
                
            }
            catch
            {

            }

            //MessageBox.Show($"{firstname}, {lastname}, {email}, {phoneno}, {password}, {accounttype}");           

            



            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var customer=  File.ReadAllText(@"Customer.Json");
            var result = JsonConvert.DeserializeObject<List<UserModel>>(customer);
            foreach (var user in result)
            {
               if(user.Email == txtEmail.Text || user.password == txtPassword.Text)
                {
                    this.Hide();
                    UserDashBoard userDashBoard = new UserDashBoard();
                    userDashBoard.Show();
                }
                else
                {
                    lblErrorMsg.Text = "Invalid Username or Password, Please Try again";
                }
            }


        }
    }
}
