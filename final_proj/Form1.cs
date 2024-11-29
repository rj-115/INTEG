using System.Data.OleDb;

namespace final_proj
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rpfja\source\repos\final_proj\PROJ.accdb";

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(user.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(
                    "SELECT COUNT(*) FROM [USER] WHERE USER_NAME = ? AND USER_PASS = ?", connection);
                command.Parameters.AddWithValue("@USER_NAME", user.Text);
                command.Parameters.AddWithValue("@USER_PASS", password.Text);

                int count = (int)command.ExecuteScalar();

                if (count == 1)
                {
                    MessageBox.Show("USERNAME AND PASSWORD ARE CORRECT", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main a = new main();
                    a.Show();
                    this.Hide();
                }
                else if (count > 1)
                {
                    MessageBox.Show("DUPLICATE USERNAME AND PASSWORD FOUND", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("USERNAME OR PASSWORD INCORRECT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            user.Text = user.Text.ToUpper();
            user.SelectionStart = user.Text.Length;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.Text = password.Text.ToUpper();
            password.SelectionStart = password.Text.Length;
        }
    }
}
