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
    public partial class ChangePassword : Form
    {
        private string user;
        public ChangePassword(string userName)
        {
            InitializeComponent();
            user = userName;
        }

        private void ChangePasswordButton_Click_1(object sender, EventArgs e)
        {
            if (!(PasswordManager.rePassword(OldPasswordInput.Text, MainForm.UserRepositories[user].Password)))
            {
                MessageBox.Show("Введён неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PasswordManager.rePassword(NewPasswordInput.Text, MainForm.UserRepositories[user].Password))
            {
                MessageBox.Show("Новый пароль должен отличаться от старого", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((!MainForm.UserRepositories[user].HasPasswordRestriction) && (PasswordManager.rePassword(NewPasswordInput.Text, ConfirmPasswordInput.Text)))
            {
                MainForm.UserRepositories[user].Password = PasswordManager.Encrypt(user, NewPasswordInput.Text);
                Close();
            }
            else
            {
                if (PasswordManager.CheckPassword(NewPasswordInput.Text) && (PasswordManager.rePassword(NewPasswordInput.Text, ConfirmPasswordInput.Text)))
                {
                    MainForm.UserRepositories[user].Password = PasswordManager.Encrypt(user, NewPasswordInput.Text);
                    Close();
                }
                else
                    MessageBox.Show("В пароле должны быть цифры, кириллица и операции (+, -, *, /)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelPasswordChange_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void oldCheck_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.visiblePassword(oldCheck, ref OldPasswordInput);
        }

        private void newCheck_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.visiblePassword(newCheck, ref NewPasswordInput);
        }
    }
}
