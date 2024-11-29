namespace final_proj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            user = new TextBox();
            password = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 60);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 451);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 60);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 104);
            label1.Name = "label1";
            label1.Size = new Size(197, 46);
            label1.TabIndex = 2;
            label1.Text = "APP NAME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 171);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "USER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 265);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "PASSWORD";
            // 
            // user
            // 
            user.Location = new Point(269, 207);
            user.Name = "user";
            user.Size = new Size(363, 27);
            user.TabIndex = 5;
            user.TextChanged += user_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(269, 303);
            password.Name = "password";
            password.Size = new Size(363, 27);
            password.TabIndex = 6;
            password.TextChanged += password_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(400, 358);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 511);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox user;
        private TextBox password;
        private Button button1;
    }
}
