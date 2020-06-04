using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionare
{
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
            buttonOK.Enabled = false;
        }
        #region ILoginView Implementation

        public string UserName
        {
            set { textBoxUserName.Text = value; }
            get { return textBoxUserName.Text.Trim(); }
        }

        public string Password
        {
            set { textBoxPassword.Text = value; }
            get { return textBoxPassword.Text.Trim(); }
        }

        public event EventHandler<EventArgs> Login;

        public void LetUserLogin()
        {
            DialogResult = DialogResult.OK;
        }

        public void DontLetUserLogin()
        {
            MessageBox.Show("Неправильный логин или пароль!", "Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {            
            buttonOK.Enabled = UserName.Length >= 3 && Password.Length >= 5;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Login?.Invoke(this, EventArgs.Empty);
        }
       
    }
}
