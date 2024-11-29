namespace final_proj
{
    partial class store
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
            label1 = new Label();
            total = new Label();
            confirm = new Button();
            clear = new Button();
            cart = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)cart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 38);
            label1.TabIndex = 0;
            label1.Text = "STORE";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(783, 410);
            total.Name = "total";
            total.Size = new Size(0, 20);
            total.TabIndex = 27;
            total.Click += label15_Click;
            // 
            // confirm
            // 
            confirm.Location = new Point(636, 449);
            confirm.Name = "confirm";
            confirm.Size = new Size(288, 29);
            confirm.TabIndex = 28;
            confirm.Text = "CONFIRM PURCHASE";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // clear
            // 
            clear.Location = new Point(636, 484);
            clear.Name = "clear";
            clear.Size = new Size(288, 29);
            clear.TabIndex = 29;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // cart
            // 
            cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cart.Location = new Point(624, 52);
            cart.Name = "cart";
            cart.RowHeadersWidth = 51;
            cart.Size = new Size(319, 338);
            cart.TabIndex = 30;
            cart.CellContentClick += cart_CellContentClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 69);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(587, 461);
            flowLayoutPanel1.TabIndex = 31;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // store
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 569);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cart);
            Controls.Add(clear);
            Controls.Add(confirm);
            Controls.Add(total);
            Controls.Add(label1);
            Name = "store";
            Text = "store";
            Load += store_Load;
            ((System.ComponentModel.ISupportInitialize)cart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label total;
        private Button confirm;
        private Button clear;
        private DataGridView cart;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}