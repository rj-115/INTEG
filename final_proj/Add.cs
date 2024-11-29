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

namespace final_proj
{
    public partial class Add : Form
    {

        OleDbConnection connection = new OleDbConnection();
        OleDbCommand cmd;
        public Add()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rpfja\source\repos\final_proj\PROJ.accdb";

        }

        private void save()
        {
            string insertQuery = "INSERT INTO [PRODUCT] ([PRODUCT_NAME], [PRICE], [QUANTITY]) VALUES (?, ?, ?)";

            try
            {
                connection.Open();

                using (OleDbCommand cmd = new OleDbCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("?", textBox1.Text);
                    cmd.Parameters.AddWithValue("?", Convert.ToDecimal(textBox2.Text));
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(textBox3.Text)); 
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added successfully!", "Success");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product. Please try again.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
