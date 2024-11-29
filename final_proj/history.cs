using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace final_proj
{
    public partial class history : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public history()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rpfja\source\repos\final_proj\PROJ.accdb";
        }


        private void history_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(
                    "SELECT SALES_ID, DATES, ITEMS, COST FROM SALES", connection);

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
