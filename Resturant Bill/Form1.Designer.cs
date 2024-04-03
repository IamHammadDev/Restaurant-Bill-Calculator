namespace Resturant_Bill
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AppetizerscomboBox = new ComboBox();
            BeveragescomboBox = new ComboBox();
            DessertdcomboBox = new ComboBox();
            MaincoursecomboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Appetizers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(219, 30);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Beverages";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(412, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 1;
            label3.Text = "Desserts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(586, 30);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 1;
            label4.Text = "Main Courses";
            // 
            // AppetizerscomboBox
            // 
            AppetizerscomboBox.FormattingEnabled = true;
            AppetizerscomboBox.Items.AddRange(new object[] { "Buffalo Wings", "Buffalo Fingers", "Potato Skins", "Nachos", "Mushrooms Caps", "Shrimp Cocktail", "Chips and Salsa", "Garlic Bread Bites", "Mac 'N Cheez Bites" });
            AppetizerscomboBox.Location = new Point(12, 64);
            AppetizerscomboBox.Name = "AppetizerscomboBox";
            AppetizerscomboBox.Size = new Size(139, 23);
            AppetizerscomboBox.TabIndex = 2;
            AppetizerscomboBox.SelectedIndexChanged += AppetizerscomboBox_SelectedIndexChanged;
            // 
            // BeveragescomboBox
            // 
            BeveragescomboBox.FormattingEnabled = true;
            BeveragescomboBox.Items.AddRange(new object[] { "Soda", "Tea", "Coffee", "Mineral Water", "Juice", "Milk " });
            BeveragescomboBox.Location = new Point(219, 64);
            BeveragescomboBox.Name = "BeveragescomboBox";
            BeveragescomboBox.Size = new Size(137, 23);
            BeveragescomboBox.TabIndex = 2;
            BeveragescomboBox.SelectedIndexChanged += BeveragescomboBox_SelectedIndexChanged;
            // 
            // DessertdcomboBox
            // 
            DessertdcomboBox.FormattingEnabled = true;
            DessertdcomboBox.Items.AddRange(new object[] { "Apple Pie", "Sundea", "Carrot Cake", "Mud Pie", "Apple Crisp" });
            DessertdcomboBox.Location = new Point(412, 64);
            DessertdcomboBox.Name = "DessertdcomboBox";
            DessertdcomboBox.Size = new Size(136, 23);
            DessertdcomboBox.TabIndex = 2;
            DessertdcomboBox.SelectedIndexChanged += DessertdcomboBox_SelectedIndexChanged;
            // 
            // MaincoursecomboBox
            // 
            MaincoursecomboBox.FormattingEnabled = true;
            MaincoursecomboBox.Items.AddRange(new object[] { "Seafood Alfredo", "Chicken Alfredo", "Chicken Picatta", "Turkey Club", "Lobster Pie", "Prime Rib", "Shrimp Scampi", "Turkey Dinner", "Stuffed Chicken" });
            MaincoursecomboBox.Location = new Point(586, 64);
            MaincoursecomboBox.Name = "MaincoursecomboBox";
            MaincoursecomboBox.Size = new Size(136, 23);
            MaincoursecomboBox.TabIndex = 2;
            MaincoursecomboBox.SelectedIndexChanged += MaincoursecomboBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(344, 335);
            dataGridView1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(460, 120);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 1;
            label5.Text = "SubTotal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(460, 197);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 1;
            label6.Text = "Tax";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(460, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(460, 271);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 1;
            label7.Text = "Total";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(460, 294);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(460, 344);
            button1.Name = "button1";
            button1.Size = new Size(135, 27);
            button1.TabIndex = 5;
            button1.Text = "Clear Bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 467);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(MaincoursecomboBox);
            Controls.Add(DessertdcomboBox);
            Controls.Add(BeveragescomboBox);
            Controls.Add(AppetizerscomboBox);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bill Calculator";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox AppetizerscomboBox;
        private ComboBox BeveragescomboBox;
        private ComboBox DessertdcomboBox;
        private ComboBox MaincoursecomboBox;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Button button1;
    }
}
