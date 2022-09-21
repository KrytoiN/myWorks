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
    public partial class LoginForm : Form
    {
        private int wrongInputCount = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.visiblePassword(Showpass, ref PasswordInput);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var login = LoginInput.Text;
            var password = PasswordInput.Text;

            if (!MainForm.UserRepositories.ContainsKey(login))
            {
                MessageBox.Show("Пользователь не найден!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MainForm.UserRepositories[login].IsBlocked)
            {
                MessageBox.Show("Пользователь заблокирован!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((PasswordInput.Text == "") && (MainForm.UserRepositories[login].Password == " "))
            {
                Hide();
                MessageBox.Show("Для первого входа вам необходимо ввести пароль", "Ввод пароля", MessageBoxButtons.OK,MessageBoxIcon.Information);
                AddPassword ad = new AddPassword(login);
                if (ad.ShowDialog() != DialogResult.OK)
                {
                    Show();
                    return;
                }
            }

            if (!MainForm.UserRepositories[login].Password.Equals(password))
            {
                ++wrongInputCount;
                AttemptLabel.Text = "Attempts left: " + (3 - wrongInputCount);
                if (wrongInputCount == 3)
                {
                    MessageBox.Show("Количество попыток ввода пароля исчерпано", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }

                MessageBox.Show("Пароль не верен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordInput.Text = "";
                return;
            }

            MainForm.CurrentUser = login;
            MainForm main = new MainForm();
            wrongInputCount = 0;
            AttemptLabel.Text = "Attempts left: 3";
            Hide();
            if (main.ShowDialog() != DialogResult.OK)
            {
                Show();
                return;
            }

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.f.FromMapToFile(MainForm.UserRepositories);
        }


    }
}
