using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace final_proj
{
    public partial class Update : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Update()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rpfja\source\repos\final_proj\PROJ.accdb";

            id.ReadOnly = false;
            name.ReadOnly = true;
            quantity.ReadOnly = true;
            cost.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("Please enter a Product ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                string query = "SELECT PRODUCT_NAME, PRICE, QUANTITY FROM PRODUCT WHERE PRODUCT_ID = ?";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@PRODUCT_ID", id.Text);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    name.Text = reader["PRODUCT_NAME"].ToString();
                    quantity.Text = reader["PRICE"].ToString();
                    cost.Text = reader["QUANTITY"].ToString();

                    name.ReadOnly = false;
                    quantity.ReadOnly = false;
                    cost.ReadOnly = false;
                    id.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Item not found. Please check the Product ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    name.Text = string.Empty;
                    quantity.Text = string.Empty;
                    cost.Text = string.Empty;

                    name.ReadOnly = true;
                    quantity.ReadOnly = true;
                    cost.ReadOnly = true;
                }

                reader.Close();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(quantity.Text) || string.IsNullOrWhiteSpace(cost.Text))
            {
                MessageBox.Show("Please ensure all fields are filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                Console.WriteLine("Database connection opened successfully.");


                string updateQuery = "UPDATE PRODUCT SET PRODUCT_NAME = ?, PRICE = ?, QUANTITY = ? WHERE PRODUCT_ID = ?";
                OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);



                updateCommand.Parameters.AddWithValue("@PRODUCT_NAME", name.Text);
                updateCommand.Parameters.AddWithValue("@PRICE", Convert.ToDecimal(quantity.Text));
                updateCommand.Parameters.AddWithValue("@QUANTITY", Convert.ToInt32(cost.Text));
                updateCommand.Parameters.AddWithValue("@PRODUCT_ID", id.Text);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    name.ReadOnly = true;
                    quantity.ReadOnly = true;
                    cost.ReadOnly = true;
                    id.ReadOnly = false;

                    name.Text = string.Empty;
                    quantity.Text = string.Empty;
                    cost.Text = string.Empty;
                    id.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Failed to update the product. Please check the Product ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
