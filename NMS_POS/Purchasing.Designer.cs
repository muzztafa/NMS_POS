namespace NMS_POS
{
    partial class Purchasing
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
            this.purchasing_datagrid = new System.Windows.Forms.DataGridView();
            this.newPurchase_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchasing_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // purchasing_datagrid
            // 
            this.purchasing_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasing_datagrid.Location = new System.Drawing.Point(48, 124);
            this.purchasing_datagrid.Name = "purchasing_datagrid";
            this.purchasing_datagrid.ReadOnly = true;
            this.purchasing_datagrid.Size = new System.Drawing.Size(494, 406);
            this.purchasing_datagrid.TabIndex = 9;
            this.purchasing_datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasing_datagrid_CellContentClick);
            // 
            // newPurchase_btn
            // 
            this.newPurchase_btn.Location = new System.Drawing.Point(48, 82);
            this.newPurchase_btn.Name = "newPurchase_btn";
            this.newPurchase_btn.Size = new System.Drawing.Size(112, 23);
            this.newPurchase_btn.TabIndex = 10;
            this.newPurchase_btn.Text = "New Purchase";
            this.newPurchase_btn.UseVisualStyleBackColor = true;
            this.newPurchase_btn.Click += new System.EventHandler(this.newPurchase_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Purchasing";
            // 
            // Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPurchase_btn);
            this.Controls.Add(this.purchasing_datagrid);
            this.Name = "Purchasing";
            this.Text = "Purchasing";
            this.Load += new System.EventHandler(this.Purchasing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchasing_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView purchasing_datagrid;
        private System.Windows.Forms.Button newPurchase_btn;
        private System.Windows.Forms.Label label3;
    }
}