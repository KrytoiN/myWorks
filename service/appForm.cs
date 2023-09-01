using System;
using System.Windows.Forms;

namespace service
{
    public partial class appForm : Form
    {
        Selects select = new Selects();
        public appForm()
        {
            InitializeComponent();
            appControl.SelectedIndex = 0;
            MainForm.sqlBase.getTable(sqlApp, select.selectTable, "Applications");
            MainForm.sqlBase.getDistinct(exCheck, "executor", "Applications");
        }

        private bool check(string x)
        {
            return x.Length == 9;
        }

        private void contrlBtn_Click(object sender, EventArgs e)
        {
            showForm form = new showForm();
            if ((appControl.SelectedIndex > -1) && (exCheck.SelectedIndex > -1))
            {
                MainForm.sqlBase.getReport(form.showGrid, check(appControl.Text), exCheck.Text);
                form.Text = "Отчет выполнения заявок по исполнителям";
                form.ShowDialog();
            }
            else if (appControl.SelectedIndex > -1)
            {
                MainForm.sqlBase.getAppControl(form.showGrid, check(appControl.Text));
                form.Text = "Контроль выполнения заявок по статусу";
                form.ShowDialog();
            }
            else
            {
                MainForm.sqlBase.getTable(form.showGrid, select.selectExecutor, exCheck.Text);
                form.Text = "Контроль выполнения заявок по исполнителю";
                form.ShowDialog();
            }
        }
    }
}
