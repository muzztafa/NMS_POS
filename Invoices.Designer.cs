namespace NMS_POS
{
    partial class Invoices
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoice_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_btn = new System.Windows.Forms.Button();
            this.newInvoice_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Invoices";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoice_no,
            this.invoice_date,
            this.invoice_total});
            this.dataGridView1.Location = new System.Drawing.Point(45, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 406);
            this.dataGridView1.TabIndex = 8;
            // 
            // invoice_no
            // 
            this.invoice_no.HeaderText = "Invoice #";
            this.invoice_no.Name = "invoice_no";
            this.invoice_no.ReadOnly = true;
            this.invoice_no.Width = 150;
            // 
            // invoice_date
            // 
            this.invoice_date.HeaderText = "Invoice Date";
            this.invoice_date.Name = "invoice_date";
            this.invoice_date.ReadOnly = true;
            this.invoice_date.Width = 150;
            // 
            // invoice_total
            // 
            this.invoice_total.HeaderText = "Invoice Total";
            this.invoice_total.Name = "invoice_total";
            this.invoice_total.ReadOnly = true;
            this.invoice_total.Width = 150;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(45, 18);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 9;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // newInvoice_btn
            // 
            this.newInvoice_btn.Location = new System.Drawing.Point(45, 81);
            this.newInvoice_btn.Name = "newInvoice_btn";
            this.newInvoice_btn.Size = new System.Drawing.Size(75, 23);
            this.newInvoice_btn.TabIndex = 7;
            this.newInvoice_btn.Text = "New Invoice";
            this.newInvoice_btn.UseVisualStyleBackColor = true;
            this.newInvoice_btn.Click += new System.EventHandler(this.newInvoice_btn_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 561);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newInvoice_btn);
            this.Controls.Add(this.label3);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button newInvoice_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_total;
    }
}