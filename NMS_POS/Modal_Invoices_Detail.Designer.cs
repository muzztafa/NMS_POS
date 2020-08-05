namespace NMS_POS
{
    partial class Modal_Invoices_Detail
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
            this.invoicesDetails_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceNo_editText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cashier_editText = new System.Windows.Forms.TextBox();
            this.totalBill_editText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDetails_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesDetails_grid
            // 
            this.invoicesDetails_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDetails_grid.Location = new System.Drawing.Point(12, 117);
            this.invoicesDetails_grid.Name = "invoicesDetails_grid";
            this.invoicesDetails_grid.ReadOnly = true;
            this.invoicesDetails_grid.Size = new System.Drawing.Size(776, 359);
            this.invoicesDetails_grid.TabIndex = 0;
            this.invoicesDetails_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicesDetails_grid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice #";
            // 
            // invoiceNo_editText
            // 
            this.invoiceNo_editText.Location = new System.Drawing.Point(79, 13);
            this.invoiceNo_editText.Name = "invoiceNo_editText";
            this.invoiceNo_editText.ReadOnly = true;
            this.invoiceNo_editText.Size = new System.Drawing.Size(100, 20);
            this.invoiceNo_editText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cashier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Bill";
            // 
            // cashier_editText
            // 
            this.cashier_editText.Location = new System.Drawing.Point(79, 49);
            this.cashier_editText.Name = "cashier_editText";
            this.cashier_editText.ReadOnly = true;
            this.cashier_editText.Size = new System.Drawing.Size(100, 20);
            this.cashier_editText.TabIndex = 5;
            // 
            // totalBill_editText
            // 
            this.totalBill_editText.Location = new System.Drawing.Point(79, 85);
            this.totalBill_editText.Name = "totalBill_editText";
            this.totalBill_editText.ReadOnly = true;
            this.totalBill_editText.Size = new System.Drawing.Size(100, 20);
            this.totalBill_editText.TabIndex = 6;
            // 
            // Modal_Invoices_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.totalBill_editText);
            this.Controls.Add(this.cashier_editText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoiceNo_editText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoicesDetails_grid);
            this.Name = "Modal_Invoices_Detail";
            this.Text = "Modal_Invoices_Detail";
            this.Load += new System.EventHandler(this.Modal_Invoices_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDetails_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoicesDetails_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invoiceNo_editText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cashier_editText;
        private System.Windows.Forms.TextBox totalBill_editText;
    }
}