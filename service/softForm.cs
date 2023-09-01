using System;
using System.Windows.Forms;

namespace service
{
    public partial class softForm : Form
    {
        private string[] names = new string[5];
        private int i, j = 0;
        Selects select = new Selects();
        public softForm()
        {
            InitializeComponent();
            MainForm.sqlBase.getTable(softShow, select.selectTable, "Software");
            updateText.Text = softShow.Rows[i].Cells[j].Value.ToString();
            names[0] = "Software";
            names[1] = softShow.Columns[0].Name;
            MainForm.sqlBase.getDistinct(destBox, "category", "Software");
            MainForm.sqlBase.getDistinct(typeBox, "typeLic", "Software");
            MainForm.sqlBase.getDistinct(date1, "dateBuy", "Software");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            names[4] = updateText.Text;
            try
            {
                MainForm.sqlBase.updateTable(names);
                softShow.Rows[i].Cells[j].Value = updateText.Text;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Введены неверный данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void softShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = e.RowIndex;
                j = e.ColumnIndex;
                names[2] = softShow.Columns[j].Name;
                names[3] = softShow.Rows[i].Cells[0].Value.ToString();
                updateText.Text = softShow.Rows[i].Cells[j].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void date1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (date1.SelectedIndex > -1)
                MainForm.sqlBase.getDate2(date2, "dateEnd", date1.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addForm addForm = new addForm();
            addForm.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            destBox.SelectedIndex = -1;
            typeBox.SelectedIndex = -1;
            date1.SelectedIndex = -1;
            date2.SelectedIndex = -1;
        }

        private void repBtn_Click(object sender, EventArgs e)
        {
            showForm showForm = new showForm();
            if ((destBox.SelectedIndex > -1) && (typeBox.SelectedIndex > -1) && (date1.SelectedIndex > -1) )
            {
                MainForm.sqlBase.getAllSoft(showForm.showGrid, date1.Text, date2.Text, typeBox.Text, destBox.Text);
                showForm.Text = "Отчёт о всём программном обеспечении";
                showForm.Show();
            }
            else if (destBox.SelectedIndex > -1)
            {
                MainForm.sqlBase.getTable(showForm.showGrid, select.selectCatSoft, destBox.Text);
                showForm.Text = "Отчёт о программном обеспечении по типам лицензии";
                showForm.Show();
            }
            else if (typeBox.SelectedIndex > -1)
            {
                MainForm.sqlBase.getTable(showForm.showGrid, select.selectTypeSoft, typeBox.Text);
                showForm.Text = "Отчёт о программном обеспечении по назначению";
                showForm.Show();
            }
            else if (date1.SelectedIndex > -1)
            {
                MainForm.sqlBase.getDateSoft(showForm.showGrid, date1.Text, date2.Text);
                showForm.Text = "Отчёт о программном обеспечении по срокам действия";
                showForm.Show();
            }
            else
            {

            }

        }
    }
}
