using System;
using System.Windows.Forms;

namespace service
{
    public partial class pcForm : Form
    {
        private string[] names = new string[5];
        private int i, j = 0;
        Selects select = new Selects();
        public pcForm()
        {
            InitializeComponent();
            MainForm.sqlBase.getTable(pcShow,select.selectTable, "PC");
            MainForm.sqlBase.getDistinct(numberChk, "numberPC", "PC");
            MainForm.sqlBase.getDistinct(statusChk, "statusPC", "PC");
            updateText.Text = pcShow.Rows[i].Cells[j].Value.ToString();
            names[0] = "PC";
            names[1] = pcShow.Columns[0].Name;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            names[4] = updateText.Text;
            try
            {
                MainForm.sqlBase.updateTable(names);
                pcShow.Rows[i].Cells[j].Value = updateText.Text;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Введены неверный данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcShow_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = e.RowIndex;
                j = e.ColumnIndex;
                names[2] = pcShow.Columns[j].Name;
                names[3] = pcShow.Rows[i].Cells[0].Value.ToString();
                updateText.Text = pcShow.Rows[i].Cells[j].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void softBtn_Click(object sender, EventArgs e)
        {
            showForm form = new showForm();
            MainForm.sqlBase.getinstalSoft(form.showGrid, numberChk.Text);
            form.Text = "Отчет ПО установленного на ПК";
            form.Show();
        }

        private void pcBtn_Click(object sender, EventArgs e)
        {
            showForm form = new showForm();
            MainForm.sqlBase.getTable(form.showGrid,select.selectStatusPC, statusChk.Text);
            form.Text = "Отчет о состоянии ПК";
            form.Show();
        }

    }
}
