using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace final_proj
{
    public partial class inventory : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public inventory()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rpfja\source\repos\final_proj\PROJ.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.FormClosed += (s, args) => RefreshDataGrid();
            a.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update a = new Update();
            a.FormClosed += (s, args) => RefreshDataGrid();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int productID = Convert.ToInt32(selectedRow.Cells["Product_ID"].Value);

                    string deleteQuery = "DELETE FROM PRODUCT WHERE Product_ID = @ProductID";

                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to DELETE this item?",
                        "DELETE Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Open();
                            OleDbCommand command = new OleDbCommand(deleteQuery, connection);
                            command.Parameters.AddWithValue("@ProductID", productID);
                            command.ExecuteNonQuery();
                            connection.Close();

                            RefreshDataGrid();

                            MessageBox.Show("Item deleted and table reloaded successfully.", "Success");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to delete item: " + ex.Message, "Error");
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
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Error");
                }
            

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            connection.Open();

            OleDbCommand command = new OleDbCommand("SELECT PRODUCT_ID, PRODUCT_NAME, PRICE, QUANTITY FROM PRODUCT", connection);

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command; 

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            connection.Close();

        }

        private void RefreshDataGrid()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT PRODUCT_ID, PRODUCT_NAME, PRICE, QUANTITY FROM PRODUCT", connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

