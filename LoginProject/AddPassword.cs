using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataProtectionLab1
{
    public partial class AddPassword : Form
    {
        private string user;
        public AddPassword(string userName)
        {
            user = userName;
            InitializeComponent();
        }

        private void CancelPasswordChange_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if ((!MainForm.UserRepositories[user].HasPasswordRestriction) && (MainForm.rePassword(NewPasswordInput.Text, ConfirmPasswordInput.Text)) )
                MainForm.UserRepositories[user].Password = NewPasswordInput.Text.ToString();
            else
            {
                if (!MainForm.rePassword(NewPasswordInput.Text, ConfirmPasswordInput.Text))
                {
                    MessageBox.Show("Пароли должны совпадать", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MainForm.CheckPassword(NewPasswordInput.Text))
                    MainForm.UserRepositories[user].Password = NewPasswordInput.Text;
                else
                {
                    MessageBox.Show("В пароле должны быть цифры и операции (+, -, *, /)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.visiblePassword(showPass, ref NewPasswordInput);
        }

    }
}
