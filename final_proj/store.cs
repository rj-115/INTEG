using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_proj
{
    public partial class store : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public store()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rpfja\source\repos\final_proj\PROJ.accdb";

        }

        private void store_Load(object sender, EventArgs e)
        {
            addButtoms();
            cartAdd();
            UpdateTotalCost();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearCart();
            UpdateTotalCost();
        }

        private void RefreshCart()
        {
            try
            {
                using (OleDbConnection newConnection = new OleDbConnection(connection.ConnectionString))
                {
                    newConnection.Open();

                    using (OleDbCommand command = new OleDbCommand(
                        "SELECT ITEM, COST FROM CART", newConnection))
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        cart.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void cartAdd()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(
                    "SELECT ITEM, COST FROM CART", connection);

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cart.DataSource = table;
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

        private void addButtoms()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(
                    "SELECT PRODUCT_ID, PRODUCT_NAME, PRICE, QUANTITY FROM PRODUCT", connection);

                OleDbDataReader reader = command.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    string productId = reader["PRODUCT_ID"].ToString();
                    string productName = reader["PRODUCT_NAME"].ToString();
                    string price = reader["PRICE"].ToString();
                    string quantity = reader["QUANTITY"].ToString();

                    Button productButton = new Button();
                    productButton.Text = $"{productName}\nPrice: {price}\nQty: {quantity}";
                    productButton.Tag = productId;
                    productButton.Width = 150;
                    productButton.Height = 100;
                    productButton.Margin = new Padding(10);

                    productButton.Click += (s, args) =>
                    {
                        try
                        {
                            using (OleDbConnection newConnection = new OleDbConnection(connection.ConnectionString))
                            {
                                newConnection.Open();

                                using (OleDbCommand insertCommand = new OleDbCommand(
                                    "INSERT INTO CART (ITEM, COST) VALUES (?, ?)", newConnection))
                                {
                                    insertCommand.Parameters.AddWithValue("@ITEM", productName);
                                    insertCommand.Parameters.AddWithValue("@COST", price);

                                    int rowsInserted = insertCommand.ExecuteNonQuery();
                                   
                                }
                            }

                            RefreshCart();
                            UpdateTotalCost();
                            addButtoms();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };




                    flowLayoutPanel1.Controls.Add(productButton);
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

        public void clearCart()
        {
            try
            {

                connection.Open();

                OleDbCommand command = new OleDbCommand("DELETE FROM CART", connection);

                int rowsAffected = command.ExecuteNonQuery();

                OleDbCommand refreshCommand = new OleDbCommand(
                    "SELECT ITEM, COST FROM CART", connection);

                OleDbDataAdapter adapter = new OleDbDataAdapter(refreshCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cart.DataSource = table;


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
            addButtoms();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateTotalCost()
        {
            try
            {
                using (OleDbConnection newConnection = new OleDbConnection(connection.ConnectionString))
                {
                    newConnection.Open();

                    using (OleDbCommand command = new OleDbCommand(
                        "SELECT SUM(COST) FROM CART", newConnection))
                    {
                        object result = command.ExecuteScalar();
                        decimal totalCost = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                        total.Text = $"Total Cost: {totalCost:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection newConnection = new OleDbConnection(connection.ConnectionString))
                {
                    newConnection.Open();

                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    Dictionary<string, int> cartItems = new Dictionary<string, int>();
                    using (OleDbCommand itemsCommand = new OleDbCommand("SELECT ITEM, COUNT(ITEM) AS Quantity FROM CART GROUP BY ITEM", newConnection))
                    using (OleDbDataReader reader = itemsCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ITEM"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            cartItems[itemName] = quantity;
                        }
                    }

                    foreach (var cartItem in cartItems)
                    {
                        string itemName = cartItem.Key;
                        int requiredQuantity = cartItem.Value;

                        using (OleDbCommand stockCommand = new OleDbCommand("SELECT QUANTITY FROM PRODUCT WHERE PRODUCT_NAME = ?", newConnection))
                        {
                            stockCommand.Parameters.AddWithValue("@PRODUCT_NAME", itemName);
                            object result = stockCommand.ExecuteScalar();
                            if (result == null)
                            {
                                MessageBox.Show($"'{itemName}' is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            int currentStock = Convert.ToInt32(result);
                            if (currentStock < requiredQuantity)
                            {
                                MessageBox.Show($"Insufficient stock for '{itemName}'! Available: {currentStock}, Required: {requiredQuantity}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    foreach (var cartItem in cartItems)
                    {
                        string itemName = cartItem.Key;
                        int quantity = cartItem.Value;

                        using (OleDbCommand updateStockCommand = new OleDbCommand("UPDATE PRODUCT SET QUANTITY = QUANTITY - ? WHERE PRODUCT_NAME = ?", newConnection))
                        {
                            updateStockCommand.Parameters.AddWithValue("@QUANTITY", quantity);
                            updateStockCommand.Parameters.AddWithValue("@PRODUCT_NAME", itemName);
                            updateStockCommand.ExecuteNonQuery();
                        }
                    }

                    decimal totalCost = 0;
                    using (OleDbCommand costCommand = new OleDbCommand("SELECT SUM(COST) FROM CART", newConnection))
                    {
                        object result = costCommand.ExecuteScalar();
                        totalCost = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }

                    string itemsList = string.Join(", ", cartItems.Select(kvp => $"{kvp.Key} x{kvp.Value}"));

                    using (OleDbCommand insertCommand = new OleDbCommand(
                        "INSERT INTO SALES ([DATES], [ITEMS], [COST]) VALUES (?, ?, ?)", newConnection))
                    {
                        insertCommand.Parameters.AddWithValue("@DATES", currentDate);
                        insertCommand.Parameters.AddWithValue("@ITEMS", itemsList);
                        insertCommand.Parameters.AddWithValue("@COST", totalCost);

                        int rowsInserted = insertCommand.ExecuteNonQuery();
                        
                    }

                    clearCart();
                    addButtoms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
