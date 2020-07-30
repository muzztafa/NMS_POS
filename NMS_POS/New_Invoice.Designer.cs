namespace NMS_POS
{
    partial class New_Invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.cashier_editText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceNo_editText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceDate_editText = new System.Windows.Forms.TextBox();
            this.products_list = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.products_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cashier_editText
            // 
            this.cashier_editText.Location = new System.Drawing.Point(119, 40);
            this.cashier_editText.Name = "cashier_editText";
            this.cashier_editText.Size = new System.Drawing.Size(106, 20);
            this.cashier_editText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice #";
            // 
            // invoiceNo_editText
            // 
            this.invoiceNo_editText.Location = new System.Drawing.Point(586, 40);
            this.invoiceNo_editText.Name = "invoiceNo_editText";
            this.invoiceNo_editText.Size = new System.Drawing.Size(106, 20);
            this.invoiceNo_editText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Invoice Date";
            // 
            // invoiceDate_editText
            // 
            this.invoiceDate_editText.Location = new System.Drawing.Point(586, 78);
            this.invoiceDate_editText.Name = "invoiceDate_editText";
            this.invoiceDate_editText.Size = new System.Drawing.Size(106, 20);
            this.invoiceDate_editText.TabIndex = 5;
            // 
            // products_list
            // 
            this.products_list.FormattingEnabled = true;
            this.products_list.Location = new System.Drawing.Point(119, 86);
            this.products_list.Name = "products_list";
            this.products_list.Size = new System.Drawing.Size(151, 30);
            this.products_list.Sorted = true;
            this.products_list.TabIndex = 6;
            this.products_list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(304, 85);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product";
            // 
            // products_grid
            // 
            this.products_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_grid.Location = new System.Drawing.Point(119, 183);
            this.products_grid.Name = "products_grid";
            this.products_grid.ReadOnly = true;
            this.products_grid.Size = new System.Drawing.Size(545, 334);
            this.products_grid.TabIndex = 9;
            this.products_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_grid_CellContentClick);
            // 
            // New_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.products_grid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.products_list);
            this.Controls.Add(this.invoiceDate_editText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invoiceNo_editText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cashier_editText);
            this.Controls.Add(this.label1);
            this.Name = "New_Invoice";
            this.Text = "New_Invoice";
            this.Load += new System.EventHandler(this.New_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cashier_editText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoiceNo_editText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox invoiceDate_editText;
        private System.Windows.Forms.ListBox products_list;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView products_grid;
    }
}