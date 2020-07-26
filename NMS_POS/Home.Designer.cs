namespace NMS_POS
{
    partial class Home
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
            this.invoices_btn = new System.Windows.Forms.Button();
            this.reports_btn = new System.Windows.Forms.Button();
            this.purchase_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invoices_btn
            // 
            this.invoices_btn.Location = new System.Drawing.Point(137, 46);
            this.invoices_btn.Name = "invoices_btn";
            this.invoices_btn.Size = new System.Drawing.Size(189, 133);
            this.invoices_btn.TabIndex = 0;
            this.invoices_btn.Text = "Invoices";
            this.invoices_btn.UseVisualStyleBackColor = true;
            this.invoices_btn.Click += new System.EventHandler(this.invoices_btn_Click);
            // 
            // reports_btn
            // 
            this.reports_btn.Location = new System.Drawing.Point(457, 46);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Size = new System.Drawing.Size(189, 133);
            this.reports_btn.TabIndex = 1;
            this.reports_btn.Text = "Reports";
            this.reports_btn.UseVisualStyleBackColor = true;
            // 
            // purchase_btn
            // 
            this.purchase_btn.Location = new System.Drawing.Point(137, 231);
            this.purchase_btn.Name = "purchase_btn";
            this.purchase_btn.Size = new System.Drawing.Size(189, 133);
            this.purchase_btn.TabIndex = 2;
            this.purchase_btn.Text = "Purchase";
            this.purchase_btn.UseVisualStyleBackColor = true;
            // 
            // inventory_btn
            // 
            this.inventory_btn.Location = new System.Drawing.Point(457, 231);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(189, 133);
            this.inventory_btn.TabIndex = 3;
            this.inventory_btn.Text = "Inventory";
            this.inventory_btn.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventory_btn);
            this.Controls.Add(this.purchase_btn);
            this.Controls.Add(this.reports_btn);
            this.Controls.Add(this.invoices_btn);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button invoices_btn;
        private System.Windows.Forms.Button reports_btn;
        private System.Windows.Forms.Button purchase_btn;
        private System.Windows.Forms.Button inventory_btn;
    }
}