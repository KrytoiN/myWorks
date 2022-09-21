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

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (MainForm.UserRepositories[user].Password != OldPasswordInput.Text)
            {
                MessageBox.Show("Введён неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NewPasswordInput.Text == OldPasswordInput.Text)
            {
                MessageBox.Show("Новый пароль должен отличаться от старого", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((!MainForm.UserRepositories[user].HasPasswordRestriction) && (MainForm.rePassword(NewPasswordInput.Text, ConfirmPasswordInput.Text)))
            {
                MainForm.UserRepositories[user].Password = NewPasswordInput.Text;
                Close();
            }
            else
            {
                if (MainForm.CheckPassword(NewPasswordInput.Text) && (MainForm.rePassword(NewPasswordInput.Text, ConfirmPasswordInput.Text)))
                {
                    MainForm.UserRepositories[user].Password = NewPasswordInput.Text;
                    Close();
                }
                else
                    MessageBox.Show("В пароле должны быть цифры и операции (+, -, *, /)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelPasswordChange_Click(object sender, EventArgs e)
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
