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

        private void CancelPasswordChange_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.visiblePassword(showPass, ref NewPasswordInput);
        }

        private void ChangePasswordButton_Click_1(object sender, EventArgs e)
        {
            if ((!MainForm.UserRepositories[user].HasPasswordRestriction) && (PasswordManager.rePassword(NewPasswordInput.Text, ConfirmPasswordInput.Text)))
            {
                MainForm.UserRepositories[user].Password = PasswordManager.Encrypt(user, NewPasswordInput.Text);
                Close();
            }
            else
            {
                if (NewPasswordInput.Text.Contains(" "))
                {
                    MessageBox.Show("Пробелов не должно быть", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!PasswordManager.rePassword(NewPasswordInput.Text, ConfirmPasswordInput.Text))
                {
                    MessageBox.Show("Пароли должны совпадать", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (PasswordManager.CheckPassword(NewPasswordInput.Text))
                {
                    MainForm.UserRepositories[user].Password = PasswordManager.Encrypt(user, NewPasswordInput.Text);
                    Close();
                }
                else
                {
                    MessageBox.Show("В пароле должны быть цифры, кириллица и операции (+, -, *, /)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
