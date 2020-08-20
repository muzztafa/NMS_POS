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
            this.invoices_datagrid = new System.Windows.Forms.DataGridView();
            this.newInvoice_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoices_datagrid)).BeginInit();
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
            // invoices_datagrid
            // 
            this.invoices_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoices_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoices_datagrid.Location = new System.Drawing.Point(45, 128);
            this.invoices_datagrid.Name = "invoices_datagrid";
            this.invoices_datagrid.ReadOnly = true;
            this.invoices_datagrid.Size = new System.Drawing.Size(494, 406);
            this.invoices_datagrid.TabIndex = 8;
            this.invoices_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoices_datagrid_CellContentClick_1);
            this.invoices_datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoices_datagrid_CellContentClick);
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
            this.Controls.Add(this.invoices_datagrid);
            this.Controls.Add(this.newInvoice_btn);
            this.Controls.Add(this.label3);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoices_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView invoices_datagrid;
        private System.Windows.Forms.Button newInvoice_btn;
    }
}