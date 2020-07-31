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
            this.createInvoice_btn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.quantity_editText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalBill_label = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
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
            this.cashier_editText.Size = new System.Drawing.Size(151, 20);
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
            this.add_btn.Location = new System.Drawing.Point(296, 130);
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
            this.products_grid.Location = new System.Drawing.Point(77, 173);
            this.products_grid.Name = "products_grid";
            this.products_grid.ReadOnly = true;
            this.products_grid.Size = new System.Drawing.Size(615, 334);
            this.products_grid.TabIndex = 9;
            this.products_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_grid_CellContentClick);
            // 
            // createInvoice_btn
            // 
            this.createInvoice_btn.Location = new System.Drawing.Point(568, 609);
            this.createInvoice_btn.Name = "createInvoice_btn";
            this.createInvoice_btn.Size = new System.Drawing.Size(124, 23);
            this.createInvoice_btn.TabIndex = 10;
            this.createInvoice_btn.Text = "Create Invoice";
            this.createInvoice_btn.UseVisualStyleBackColor = true;
            this.createInvoice_btn.Click += new System.EventHandler(this.createInvoice_btn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 133);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Quantity";
            // 
            // quantity_editText
            // 
            this.quantity_editText.Location = new System.Drawing.Point(119, 130);
            this.quantity_editText.Name = "quantity_editText";
            this.quantity_editText.Size = new System.Drawing.Size(151, 20);
            this.quantity_editText.TabIndex = 12;
            this.quantity_editText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Bill:";
            // 
            // totalBill_label
            // 
            this.totalBill_label.AutoSize = true;
            this.totalBill_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalBill_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBill_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalBill_label.Location = new System.Drawing.Point(600, 544);
            this.totalBill_label.Name = "totalBill_label";
            this.totalBill_label.Size = new System.Drawing.Size(52, 31);
            this.totalBill_label.TabIndex = 14;
            this.totalBill_label.Text = "0.0";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(77, 609);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // New_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 644);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.totalBill_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantity_editText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.createInvoice_btn);
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
        private System.Windows.Forms.Button createInvoice_btn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox quantity_editText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalBill_label;
        private System.Windows.Forms.Button delete_btn;
    }
}