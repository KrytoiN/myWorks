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
    public partial class MainForm : Form
    {
        public static FileUsers f = new FileUsers();
        public static Dictionary<string, User> UserRepositories = new Dictionary<string, User>(f.UsersFromFile());
        public static string CurrentUser;

        public static void visiblePassword(CheckBox check, ref TextBox text)
        {
            if (check.Checked)
                text.PasswordChar = '\0';
            else
                text.PasswordChar = '*';
        }

        public MainForm()
        {
            InitializeComponent();
            if (CurrentUser == "ADMIN")
                MenuAdminPanel.Enabled = true;
            WelcomeLabel.Text += CurrentUser;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            WelcomeLabel.Text = "Hello";
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void MenuChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword chgPass = new ChangePassword(CurrentUser);
            chgPass.Show();
        }

        private void MenuAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel admPanel = new AdminPanel();
            admPanel.Show();
        }

    }
}
