using ManagementSystem.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if (verifier("frontendLogins".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
            {
                this.WrongUser.Text = "";
                Frontend newfrontend = new();
                this.Hide();
                newfrontend.Show();
            }
            else if (verifier("kitchenLogins".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
            {
                this.WrongUser.Text = "";
                Kitchen newkit = new();
                this.Hide();
                newkit.Show();
            }
            else
                this.WrongUser.Text = "Oh Wrong UserName or Password, Try Again!";
        }
        public bool verifier(string tablename, string username, string password)
        {
            using LoginContext MyContext = new LoginContext();
            if (tablename == "frontendLogins")
                return MyContext.frontendLogins.Any(u => u.user_name == username && u.pass_word == password);
            else if (tablename == "kitchenLogins")
                return MyContext.kitchenLogins.Any(u => u.user_name == username && u.pass_word == password);
            return false;

        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            this.UserNameLabel.ForeColor = Color.FromArgb(255, 64, 129);
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            this.UserNameLabel.ForeColor = Color.Black;
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            this.PasswordLabel.ForeColor = Color.FromArgb(255, 64, 129);

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            this.PasswordLabel.ForeColor = Color.Black;
        }
    }
}
