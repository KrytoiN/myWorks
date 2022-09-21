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
    public partial class AdminPanel : Form
    {
        private int FindUser(DataGridView grid, string user)
        {
            for (int i = 0; i < grid.Rows.Count; ++i)
            {
                if (grid.Rows[i].Cells[0].Value.ToString() == user)
                    return i;
            }
            return -1;
        }

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            foreach (User user in MainForm.UserRepositories.Values)
                usersView.Rows.Add(user.Name, user.Password, user.IsBlocked, user.HasPasswordRestriction);
            bool block = Convert.ToBoolean(usersView.SelectedRows[0].Cells[2].Value.ToString());
            bool restriction = Convert.ToBoolean(usersView.SelectedRows[0].Cells[3].Value.ToString());
            checkBox1.Checked = (block ? true : false);
            checkBox2.Checked = (restriction ? true : false);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (userAdd.Text == "")
            {
                MessageBox.Show("Имя пользователя не может быть пустным", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MainForm.UserRepositories.ContainsKey(userAdd.Text))
            {
                var user = User.CreateEmpty(userAdd.Text);
                MainForm.UserRepositories.Add(userAdd.Text, user);
                usersView.Rows.Add(user.Name, user.Password, user.IsBlocked, user.HasPasswordRestriction);
                userAdd.Text = "";
                usersView.Update();
            }
            else
                MessageBox.Show("Пользователь с таким именем уже есть", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int found = FindUser(usersView, userDel.Text);
            if (found > -1)
                usersView.Rows.RemoveAt(found);
            else
            {
                MessageBox.Show("Введите существующего пользователя", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MainForm.UserRepositories.Remove(userDel.Text);
            var user = usersView.SelectedRows[0].Cells[0].Value.ToString();
            userDel.Text = user;
        }

        private void usersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = usersView.SelectedRows[0].Cells[0].Value.ToString();
            userDel.Text = user;
            bool block = Convert.ToBoolean(usersView.SelectedRows[0].Cells[2].Value.ToString());
            bool restriction = Convert.ToBoolean(usersView.SelectedRows[0].Cells[3].Value.ToString());
            checkBox1.Checked = (block ? true : false);
            checkBox2.Checked = (restriction ? true : false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var user = usersView.SelectedRows[0].Cells[0].Value.ToString();
                usersView.SelectedRows[0].Cells[2].Value = true;
                MainForm.UserRepositories[user].IsBlocked = true;
            }
            else
            {
                var user = usersView.SelectedRows[0].Cells[0].Value.ToString();
                usersView.SelectedRows[0].Cells[2].Value = false;
                MainForm.UserRepositories[user].IsBlocked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                var user = usersView.SelectedRows[0].Cells[0].Value.ToString();
                usersView.SelectedRows[0].Cells[3].Value = true;
                MainForm.UserRepositories[user].HasPasswordRestriction = true;
            }
            else
            {
                var user = usersView.SelectedRows[0].Cells[0].Value.ToString();
                usersView.SelectedRows[0].Cells[3].Value = false;
                MainForm.UserRepositories[user].HasPasswordRestriction = false;
            }
        }
    }
}
