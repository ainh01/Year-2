using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelUpmost_Click(object sender, EventArgs e)
        {

        }

        private void UsernameInput_Enter(object sender, EventArgs e)
        {
            if (UsernameInput.Text == "Tên đăng nhập") { 
                UsernameInput.Text = string.Empty;
                UsernameInput.ForeColor = Color.Black;
            }
        }

        private void UsernameInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameInput.Text)) {
                UsernameInput.Text = "Tên đăng nhập";
                UsernameInput.ForeColor = Color.Gray;
            }
        }

        private void PasswordInput_Enter(object sender, EventArgs e)
        {
            if (PasswordInput.Text == "Mật khẩu")
            {
                PasswordInput.Text = string.Empty;
                PasswordInput.ForeColor = Color.Black;
                PasswordInput.PasswordChar = '*';
            }
        }

        private void PasswordInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordInput.Text))
            {
                PasswordInput.Text = "Mật khẩu";
                PasswordInput.ForeColor = Color.Gray;
                PasswordInput.PasswordChar = '\0';
            }
        }
    }
}
