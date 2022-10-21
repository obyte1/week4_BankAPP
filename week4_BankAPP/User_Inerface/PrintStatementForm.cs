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
    public partial class PrintStatementForm : Form
    {
        public PrintStatementForm()
        {
            InitializeComponent();
        }
        public static string userEmail;
        public PrintStatementForm(string UserEmail)
        {
            userEmail = UserEmail;
            InitializeComponent();
        }

        private void PrintStatementForm_Load(object sender, EventArgs e)
        {
            var customer = File.ReadAllText(@"Customer.Json");
            var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);
            var loggedin_user = result.Users.FirstOrDefault(x => x.Email == userEmail);
            //SuccessMsgDeposit.Text = loggedin_user.FirstName;

        }
    }
}
