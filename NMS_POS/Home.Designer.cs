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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.invoices_btn = new System.Windows.Forms.Button();
            this.reports_btn = new System.Windows.Forms.Button();
            this.purchase_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addUsers_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoices_btn
            // 
            this.invoices_btn.AutoSize = true;
            this.invoices_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invoices_btn.BackgroundImage")));
            this.invoices_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invoices_btn.Location = new System.Drawing.Point(102, 224);
            this.invoices_btn.Name = "invoices_btn";
            this.invoices_btn.Size = new System.Drawing.Size(265, 137);
            this.invoices_btn.TabIndex = 0;
            this.invoices_btn.UseVisualStyleBackColor = true;
            this.invoices_btn.Click += new System.EventHandler(this.invoices_btn_Click);
            // 
            // reports_btn
            // 
            this.reports_btn.AutoSize = true;
            this.reports_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reports_btn.BackgroundImage")));
            this.reports_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reports_btn.Location = new System.Drawing.Point(427, 412);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Size = new System.Drawing.Size(265, 137);
            this.reports_btn.TabIndex = 1;
            this.reports_btn.UseVisualStyleBackColor = true;
            this.reports_btn.Click += new System.EventHandler(this.reports_btn_Click);
            this.reports_btn.MouseHover += new System.EventHandler(this.reports_btn_MouseHover);
            // 
            // purchase_btn
            // 
            this.purchase_btn.AutoSize = true;
            this.purchase_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchase_btn.BackgroundImage")));
            this.purchase_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purchase_btn.Location = new System.Drawing.Point(427, 224);
            this.purchase_btn.Name = "purchase_btn";
            this.purchase_btn.Size = new System.Drawing.Size(265, 137);
            this.purchase_btn.TabIndex = 2;
            this.purchase_btn.UseVisualStyleBackColor = true;
            this.purchase_btn.Click += new System.EventHandler(this.purchase_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.AutoSize = true;
            this.inventory_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventory_btn.BackgroundImage")));
            this.inventory_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventory_btn.Location = new System.Drawing.Point(744, 224);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(265, 137);
            this.inventory_btn.TabIndex = 3;
            this.inventory_btn.UseVisualStyleBackColor = true;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(70, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(80, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 120);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // addUsers_btn
            // 
            this.addUsers_btn.AutoSize = true;
            this.addUsers_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUsers_btn.Location = new System.Drawing.Point(834, 592);
            this.addUsers_btn.Name = "addUsers_btn";
            this.addUsers_btn.Size = new System.Drawing.Size(196, 30);
            this.addUsers_btn.TabIndex = 7;
            this.addUsers_btn.Text = "Manage Users";
            this.addUsers_btn.UseVisualStyleBackColor = true;
            this.addUsers_btn.Click += new System.EventHandler(this.addUsers_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 634);
            this.Controls.Add(this.addUsers_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventory_btn);
            this.Controls.Add(this.purchase_btn);
            this.Controls.Add(this.reports_btn);
            this.Controls.Add(this.invoices_btn);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button invoices_btn;
        private System.Windows.Forms.Button reports_btn;
        private System.Windows.Forms.Button purchase_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addUsers_btn;
    }
}