namespace final_proj
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            mainpanel = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 670);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 40);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 40);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(2, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 646);
            panel3.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 394);
            button5.Name = "button5";
            button5.Size = new Size(178, 101);
            button5.TabIndex = 4;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 275);
            button3.Name = "button3";
            button3.Size = new Size(178, 101);
            button3.TabIndex = 2;
            button3.Text = "TRANSACTION\r\nHISTORY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 151);
            button2.Name = "button2";
            button2.Size = new Size(178, 101);
            button2.TabIndex = 1;
            button2.Text = "INVENTORY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 32);
            button1.Name = "button1";
            button1.Size = new Size(178, 101);
            button1.TabIndex = 0;
            button1.Text = "STORE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(214, 57);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(919, 591);
            mainpanel.TabIndex = 5;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 710);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "main";
            Text = "main";
            Load += main_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel mainpanel;
        private Button button5;
    }
}