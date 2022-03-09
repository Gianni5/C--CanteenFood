namespace AssignmentCanteenFood
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bntClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.cmbCrust = new System.Windows.Forms.ComboBox();
            this.cmbSiz = new System.Windows.Forms.ComboBox();
            this.cmbTop = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bntTotal = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bntInvoice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(344, 316);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 4;
            this.bntClear.Text = "Clear Order";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 367);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(48, 69);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(75, 23);
            this.btnAddItems.TabIndex = 6;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // cmbCrust
            // 
            this.cmbCrust.FormattingEnabled = true;
            this.cmbCrust.Items.AddRange(new object[] {
            "",
            "Thin",
            "Thick",
            "Stuffed"});
            this.cmbCrust.Location = new System.Drawing.Point(72, 163);
            this.cmbCrust.Name = "cmbCrust";
            this.cmbCrust.Size = new System.Drawing.Size(111, 21);
            this.cmbCrust.TabIndex = 11;
            // 
            // cmbSiz
            // 
            this.cmbSiz.FormattingEnabled = true;
            this.cmbSiz.Items.AddRange(new object[] {
            "",
            "Small",
            "Medium",
            "Large"});
            this.cmbSiz.Location = new System.Drawing.Point(72, 267);
            this.cmbSiz.Name = "cmbSiz";
            this.cmbSiz.Size = new System.Drawing.Size(111, 21);
            this.cmbSiz.TabIndex = 12;
            // 
            // cmbTop
            // 
            this.cmbTop.FormattingEnabled = true;
            this.cmbTop.Items.AddRange(new object[] {
            "",
            "Mushrooms",
            "Mozzarella",
            "Cheese",
            "Bacon",
            "Tomato"});
            this.cmbTop.Location = new System.Drawing.Point(73, 218);
            this.cmbTop.Name = "cmbTop";
            this.cmbTop.Size = new System.Drawing.Size(111, 21);
            this.cmbTop.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(254, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 264);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bntTotal
            // 
            this.bntTotal.Location = new System.Drawing.Point(435, 316);
            this.bntTotal.Name = "bntTotal";
            this.bntTotal.Size = new System.Drawing.Size(75, 23);
            this.bntTotal.TabIndex = 15;
            this.bntTotal.Text = "Total";
            this.bntTotal.UseVisualStyleBackColor = true;
            this.bntTotal.Click += new System.EventHandler(this.bntTotal_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(535, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(42, 264);
            this.listBox2.TabIndex = 16;
            this.listBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Price";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Crust :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Topping :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Size :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Order";
            // 
            // bntInvoice
            // 
            this.bntInvoice.Location = new System.Drawing.Point(543, 365);
            this.bntInvoice.Name = "bntInvoice";
            this.bntInvoice.Size = new System.Drawing.Size(75, 23);
            this.bntInvoice.TabIndex = 23;
            this.bntInvoice.Text = "Invoice";
            this.bntInvoice.UseVisualStyleBackColor = true;
            this.bntInvoice.Click += new System.EventHandler(this.bntInvoice_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Remove Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntInvoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.bntTotal);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbTop);
            this.Controls.Add(this.cmbSiz);
            this.Controls.Add(this.cmbCrust);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.ComboBox cmbCrust;
        private System.Windows.Forms.ComboBox cmbSiz;
        private System.Windows.Forms.ComboBox cmbTop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bntTotal;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntInvoice;
        private System.Windows.Forms.Button button1;
    }
}

