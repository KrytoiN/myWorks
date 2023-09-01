using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace service
{
    public partial class MainForm : Form
    {
        private MySqlConnection connection;
        public static dataBase sqlBase;

        public MainForm()
        {
            InitializeComponent();
            sqlBase = new dataBase();
            sqlBase.OpenConnection();
            connection = sqlBase.getConnection();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pcbtn_Click(object sender, EventArgs e)
        {
            pcForm pc = new pcForm();
            pc.Show();
        }

        private void appbtn_Click(object sender, EventArgs e)
        {
            appForm appForm = new appForm();
            appForm.Show();
        }

        private void softbtn_Click(object sender, EventArgs e)
        {
            softForm soft = new softForm();
            soft.Show();
        }
    }
}
