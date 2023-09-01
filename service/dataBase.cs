using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace service
{
    public class dataBase
    {
        private string connect = "server=localhost;user=root;database=service;password=Ifhfvsuf2001;";
        private MySqlConnection connection;
        private Selects select = new Selects();

        public dataBase()
        {
            connection = new MySqlConnection(connect);
        }

        public delegate string selectString1(string x);

        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        private string update(string[] names)
        {
            bool b = false;
            if (!bool.TryParse(names[4],out b))
                return "update " + names[0] + " set " + names[2] + " = " + "'" + names[4] + "'" + " where " + names[1] + " = " + names[3];
            else
                return "update " + names[0] + " set " + names[2] + " = " + b.ToString() + " where " + names[1] + " = " + names[3];
        }

        private void load(MySqlCommand cmd, DataGridView sqlData)
        {
            DataTable schema = new DataTable();
            MySqlDataReader reader = cmd.ExecuteReader();
            schema.Load(reader);
            sqlData.DataSource = schema;
            sqlData.Update();
            reader.Close();
        }

        private void loadCombo(MySqlCommand cmd, string name, System.Windows.Forms.ComboBox combo)
        {
            DataTable schema = new DataTable();
            MySqlDataReader reader = cmd.ExecuteReader();
            schema.Load(reader);
            combo.DisplayMember = name;
            combo.DataSource = schema;
        }

        public void getAppControl(DataGridView dataGrid, bool status)
        {
            string query = select.selectAppControl(status);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            load(cmd, dataGrid);
        }

        public void getReport(DataGridView dataGrid, bool status, string executor)
        {
            string query = select.selectStatusExecutors(status, executor);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            load(cmd, dataGrid);
        }

        public void getinstalSoft(DataGridView dataGrid, string numberPC)
        {
            string query = select.selectInstalSoft(numberPC);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            load(cmd, dataGrid);
        }
        
        public void updateTable(string[] names)
        {
            string query = update(names);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public void getTable(DataGridView dataGrid, selectString1 a, string table)
        {
            string query = a(table);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            load(cmd, dataGrid);
        }

        public void getDistinct(System.Windows.Forms.ComboBox box, string name, string table)
        {
            string query = select.selectDistinct(name, table);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            loadCombo(cmd, name, box);
        }

        public void getDate2(System.Windows.Forms.ComboBox box, string name, string date1)
        {
            string query = select.selectDate2(date1);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            loadCombo(cmd, name, box);
        }

        public void getDateSoft(DataGridView dataGrid, string date1, string date2)
        {
            string query = select.selectDateSoft(date1, date2);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            load(cmd, dataGrid);
        } 

        public void getAllSoft(DataGridView dataGrid, string date1, string date2, string type, string cat)
        {
            string query = select.selectAllSoft(date1, date2, type, cat);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            load(cmd, dataGrid);
        }

    }
}
