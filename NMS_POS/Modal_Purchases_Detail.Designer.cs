namespace NMS_POS
{
    partial class Modal_Purchases_Detail
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
            this.totalBill_editText = new System.Windows.Forms.TextBox();
            this.orderDate_editText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderNo_editText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invoicesDetails_grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vendorName_editText = new System.Windows.Forms.TextBox();
            this.vendorMobileNo_editText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDetails_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // totalBill_editText
            // 
            this.totalBill_editText.Location = new System.Drawing.Point(79, 114);
            this.totalBill_editText.Name = "totalBill_editText";
            this.totalBill_editText.ReadOnly = true;
            this.totalBill_editText.Size = new System.Drawing.Size(100, 20);
            this.totalBill_editText.TabIndex = 13;
            // 
            // orderDate_editText
            // 
            this.orderDate_editText.Location = new System.Drawing.Point(79, 78);
            this.orderDate_editText.Name = "orderDate_editText";
            this.orderDate_editText.ReadOnly = true;
            this.orderDate_editText.Size = new System.Drawing.Size(100, 20);
            this.orderDate_editText.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Order Date";
            // 
            // orderNo_editText
            // 
            this.orderNo_editText.Location = new System.Drawing.Point(79, 42);
            this.orderNo_editText.Name = "orderNo_editText";
            this.orderNo_editText.ReadOnly = true;
            this.orderNo_editText.Size = new System.Drawing.Size(100, 20);
            this.orderNo_editText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order #";
            // 
            // invoicesDetails_grid
            // 
            this.invoicesDetails_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDetails_grid.Location = new System.Drawing.Point(12, 146);
            this.invoicesDetails_grid.Name = "invoicesDetails_grid";
            this.invoicesDetails_grid.ReadOnly = true;
            this.invoicesDetails_grid.Size = new System.Drawing.Size(776, 359);
            this.invoicesDetails_grid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vendor\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vendor\'s Mobile No";
            // 
            // vendorName_editText
            // 
            this.vendorName_editText.Location = new System.Drawing.Point(655, 39);
            this.vendorName_editText.Name = "vendorName_editText";
            this.vendorName_editText.ReadOnly = true;
            this.vendorName_editText.Size = new System.Drawing.Size(100, 20);
            this.vendorName_editText.TabIndex = 16;
            // 
            // vendorMobileNo_editText
            // 
            this.vendorMobileNo_editText.Location = new System.Drawing.Point(655, 78);
            this.vendorMobileNo_editText.Name = "vendorMobileNo_editText";
            this.vendorMobileNo_editText.ReadOnly = true;
            this.vendorMobileNo_editText.Size = new System.Drawing.Size(100, 20);
            this.vendorMobileNo_editText.TabIndex = 17;
            // 
            // Modal_Purchases_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.vendorMobileNo_editText);
            this.Controls.Add(this.vendorName_editText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalBill_editText);
            this.Controls.Add(this.orderDate_editText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderNo_editText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoicesDetails_grid);
            this.Name = "Modal_Purchases_Detail";
            this.Text = "Modal_Purchases_Detail";
            this.Load += new System.EventHandler(this.Modal_Purchases_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDetails_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalBill_editText;
        private System.Windows.Forms.TextBox orderDate_editText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderNo_editText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView invoicesDetails_grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vendorName_editText;
        private System.Windows.Forms.TextBox vendorMobileNo_editText;
    }
}