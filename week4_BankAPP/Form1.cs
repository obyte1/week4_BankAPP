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
using week4_BankAPP.Model;

namespace week4_BankAPP
{
    public partial class fmWlc : Form
    {
        public static string firstname;
        public static string lastname;
        public static string email;
        public static string phoneno;
        public static string password;
        public static string accounttype;
        public static string AccountNumber = generateAccountnum();
        public static double Balance;
        public fmWlc()
        {
            InitializeComponent();
        }
        //public string Firstname;       

        public static readonly List<UserModel> Customer = new List<UserModel>();

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmWlc_Load(object sender, EventArgs e)
        {            
            txtPassword.PasswordChar = '*';
            txtCreatePassword.PasswordChar = '*';
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
            lblErrorMsg.Text = "";
            lblRegisterError.Text = "";

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
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
            pnlRegister.Visible = false;
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {

            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            email = txtEmail.Text;
            phoneno = txtPhoneNo.Text;
            password = txtCreatePassword.Text;
            accounttype = cmbAccType.Text;
            Balance = 0.00;

            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtPhoneNo.Text != "" && txtPhoneNo.Text != "" && txtCreatePassword.Text != "" && cmbAccType.Text != "")
            {
                try
                {
                    string path = @"C:\Users\Decagon\source\repos\week4_BankAPP\week4_BankAPP\bin\Debug\Customer.Json";
                    var customer = File.ReadAllText(path);
                    var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);

                    if (result == null)
                    {
                        result = new JsonFileModel();
                    }
                    UserModel getUser = null;

                    foreach (var user in result.Users)
                    {
                        if (user != null && user.Email == txtEmail.Text)
                        {
                            getUser = user;
                            break;
                        }
                        
                    }
                    if (getUser != null)
                    {
                        MessageBox.Show("Email already Exist");
                    }

                    var person = new UserModel(firstname, lastname, email, password, AccountNumber, accounttype, phoneno, Balance);
                    result.Users.Add(person);


                    var resultJson = JsonConvert.SerializeObject(result);                    
                    var fileinfo = new FileInfo(path);
                    using (var users = new StreamWriter(fileinfo.Open(FileMode.Truncate)))
                    {
                        
                        users.Write(resultJson);
                        
                    }


                    MessageBox.Show("Record Inserted Successfully, Please click Ok to Login");
                    pnlRegister.Visible = false;
                    pnlLogin.Visible = true;

                }
                catch (Exception ex)
                {
                    lblRegisterError.Text = (ex.Message);
                }

            }
            else
            {
                lblRegisterError.Text = "Please check that all fields are filled completely ";
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //emailDb = txtEmail.Text;
            //if (txtEmail.Text != "" && txtPassword.Text != "")
            //{
            string path = @"C:\Users\Decagon\source\repos\week4_BankAPP\week4_BankAPP\bin\Debug\Customer.Json";
            var customer = File.ReadAllText(path);

            //var result = JsonConvert.DeserializeObject<List<UserModel>>(customer);
            var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);



            if (result.Users.Any(x=>x.Email== txtUsername.Text && x.password==txtPassword.Text))
            {
                this.Hide();
                
                UserDashBoard userDashBoard = new UserDashBoard(txtUsername.Text);
                DepositForm depositForm = new DepositForm(txtUsername.Text);
                userDashBoard.Show();
            }
            else
            {
                lblErrorMsg.Text = "Invalid Username or Password, Please Try again";
            }

            //foreach (var user in result)
            //{


            //    if (user.Email == txtEmail.Text || user.password == txtPassword.Text)
            //    {
            //        this.Hide();
            //        //emailDb = txtEmail.Text;
            //        UserDashBoard userDashBoard = new UserDashBoard();
            //        userDashBoard.Show();
            //    }
            //    else
            //    {
            //        lblErrorMsg.Text = "Invalid Username or Password, Please Try again";
            //    }
            //}

            //}
            //else
            //{
            //    lblErrorMsg.Text = "Kindly fill your Username and Password to Login";
            //}



        }
        public static string generateAccountnum()
        {
            Random random = new Random();
            int accountNum = random.Next(10000000, 990000099);
            AccountNumber = ($"00{accountNum}");
            return AccountNumber.ToString();
        }


        private void generatAn_Click(object sender, EventArgs e)
        {
            generateAccountnum();
            MessageBox.Show(AccountNumber);
        }
    }
}
