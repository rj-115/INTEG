using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace final_proj
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        private void ResetButtonColors()
        {
            button1.BackColor = SystemColors.Control; 
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
        }

        private void HighlightButton(Button clickedButton)
        {
            clickedButton.BackColor = SystemColors.MenuHighlight;
        }

        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;

            if (f != null)
            {
                f.FormBorderStyle = FormBorderStyle.None;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                this.mainpanel.Tag = f;
                f.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HighlightButton(button5);
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit?", 
            "Exit Confirmation",             
            MessageBoxButtons.YesNo,         
            MessageBoxIcon.Question          
        );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HighlightButton(button1);
            loadform(new store());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HighlightButton(button2);
            loadform(new inventory());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HighlightButton(button3);
            loadform(new history());
        }

    }
}
