namespace final_proj
{
    partial class Update
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
            button1 = new Button();
            cost = new TextBox();
            quantity = new TextBox();
            name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            id = new TextBox();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(300, 322);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 13;
            button1.Text = "UPDATE ITEM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // cost
            // 
            cost.Location = new Point(412, 215);
            cost.Name = "cost";
            cost.Size = new Size(277, 27);
            cost.TabIndex = 12;
            // 
            // quantity
            // 
            quantity.Location = new Point(412, 128);
            quantity.Name = "quantity";
            quantity.Size = new Size(277, 27);
            quantity.TabIndex = 11;
            // 
            // name
            // 
            name.Location = new Point(45, 215);
            name.Name = "name";
            name.Size = new Size(277, 27);
            name.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 173);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 9;
            label3.Text = "COST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 89);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "QUANTITY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 171);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 7;
            label1.Text = "ITEM NAME";
            // 
            // id
            // 
            id.Location = new Point(45, 128);
            id.Name = "id";
            id.Size = new Size(277, 27);
            id.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 84);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 14;
            label4.Text = "ITEM ID";
            // 
            // button2
            // 
            button2.Location = new Point(328, 128);
            button2.Name = "button2";
            button2.Size = new Size(54, 29);
            button2.TabIndex = 16;
            button2.Text = "FIND";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 424);
            Controls.Add(button2);
            Controls.Add(id);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cost);
            Controls.Add(quantity);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Update";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox cost;
        private TextBox quantity;
        private TextBox name;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox id;
        private Label label4;
        private Button button2;
    }
}