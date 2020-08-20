namespace NMS_POS
{
    partial class New_Purchase
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
            System.Windows.Forms.Label label4;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderNo_editText = new System.Windows.Forms.TextBox();
            this.orderDate_editText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vendor_list = new System.Windows.Forms.ListBox();
            this.addToOrder_btn = new System.Windows.Forms.Button();
            this.addVendor_btn = new System.Windows.Forms.Button();
            this.products_grid = new System.Windows.Forms.DataGridView();
            this.createOrder_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.totalBill_label = new System.Windows.Forms.Label();
            this.prescription_list = new System.Windows.Forms.ListBox();
            this.featured_list = new System.Windows.Forms.ListBox();
            this.discount_editText = new System.Windows.Forms.TextBox();
            this.image_editText = new System.Windows.Forms.TextBox();
            this.quantity_editText = new System.Windows.Forms.TextBox();
            this.description_editText = new System.Windows.Forms.TextBox();
            this.price_editText = new System.Windows.Forms.TextBox();
            this.name_editText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.product_list = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 196);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 13);
            label4.TabIndex = 48;
            label4.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Order #";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Order Date";
            // 
            // orderNo_editText
            // 
            this.orderNo_editText.Location = new System.Drawing.Point(715, 52);
            this.orderNo_editText.Name = "orderNo_editText";
            this.orderNo_editText.Size = new System.Drawing.Size(151, 20);
            this.orderNo_editText.TabIndex = 17;
            // 
            // orderDate_editText
            // 
            this.orderDate_editText.Location = new System.Drawing.Point(715, 85);
            this.orderDate_editText.Name = "orderDate_editText";
            this.orderDate_editText.Size = new System.Drawing.Size(151, 20);
            this.orderDate_editText.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Vendor";
            // 
            // vendor_list
            // 
            this.vendor_list.FormattingEnabled = true;
            this.vendor_list.Location = new System.Drawing.Point(715, 121);
            this.vendor_list.Name = "vendor_list";
            this.vendor_list.Size = new System.Drawing.Size(151, 30);
            this.vendor_list.Sorted = true;
            this.vendor_list.TabIndex = 21;
            this.vendor_list.SelectedIndexChanged += new System.EventHandler(this.vendor_list_SelectedIndexChanged);
            // 
            // addToOrder_btn
            // 
            this.addToOrder_btn.Location = new System.Drawing.Point(120, 531);
            this.addToOrder_btn.Name = "addToOrder_btn";
            this.addToOrder_btn.Size = new System.Drawing.Size(75, 23);
            this.addToOrder_btn.TabIndex = 22;
            this.addToOrder_btn.Text = "Add to Order";
            this.addToOrder_btn.UseVisualStyleBackColor = true;
            this.addToOrder_btn.Click += new System.EventHandler(this.addToOrder_btn_Click);
            // 
            // addVendor_btn
            // 
            this.addVendor_btn.Location = new System.Drawing.Point(791, 165);
            this.addVendor_btn.Name = "addVendor_btn";
            this.addVendor_btn.Size = new System.Drawing.Size(75, 23);
            this.addVendor_btn.TabIndex = 23;
            this.addVendor_btn.Text = "Add Vendor";
            this.addVendor_btn.UseVisualStyleBackColor = true;
            this.addVendor_btn.Click += new System.EventHandler(this.addVendor_btn_Click);
            // 
            // products_grid
            // 
            this.products_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_grid.Location = new System.Drawing.Point(265, 230);
            this.products_grid.Name = "products_grid";
            this.products_grid.ReadOnly = true;
            this.products_grid.Size = new System.Drawing.Size(601, 307);
            this.products_grid.TabIndex = 24;
            this.products_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_grid_CellContentClick);
            // 
            // createOrder_btn
            // 
            this.createOrder_btn.Location = new System.Drawing.Point(773, 609);
            this.createOrder_btn.Name = "createOrder_btn";
            this.createOrder_btn.Size = new System.Drawing.Size(75, 23);
            this.createOrder_btn.TabIndex = 25;
            this.createOrder_btn.Text = "Create Order";
            this.createOrder_btn.UseVisualStyleBackColor = true;
            this.createOrder_btn.Click += new System.EventHandler(this.createOrder_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(298, 609);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 27;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total Bill:";
            // 
            // totalBill_label
            // 
            this.totalBill_label.AutoSize = true;
            this.totalBill_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalBill_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBill_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalBill_label.Location = new System.Drawing.Point(796, 563);
            this.totalBill_label.Name = "totalBill_label";
            this.totalBill_label.Size = new System.Drawing.Size(52, 31);
            this.totalBill_label.TabIndex = 29;
            this.totalBill_label.Text = "0.0";
            // 
            // prescription_list
            // 
            this.prescription_list.FormattingEnabled = true;
            this.prescription_list.Location = new System.Drawing.Point(350, 155);
            this.prescription_list.Name = "prescription_list";
            this.prescription_list.Size = new System.Drawing.Size(202, 30);
            this.prescription_list.Sorted = true;
            this.prescription_list.TabIndex = 45;
            // 
            // featured_list
            // 
            this.featured_list.FormattingEnabled = true;
            this.featured_list.Location = new System.Drawing.Point(350, 118);
            this.featured_list.Name = "featured_list";
            this.featured_list.Size = new System.Drawing.Size(202, 30);
            this.featured_list.Sorted = true;
            this.featured_list.TabIndex = 44;
            // 
            // discount_editText
            // 
            this.discount_editText.Location = new System.Drawing.Point(350, 86);
            this.discount_editText.Name = "discount_editText";
            this.discount_editText.Size = new System.Drawing.Size(202, 20);
            this.discount_editText.TabIndex = 43;
            // 
            // image_editText
            // 
            this.image_editText.Location = new System.Drawing.Point(350, 53);
            this.image_editText.Name = "image_editText";
            this.image_editText.Size = new System.Drawing.Size(202, 20);
            this.image_editText.TabIndex = 42;
            // 
            // quantity_editText
            // 
            this.quantity_editText.Location = new System.Drawing.Point(89, 152);
            this.quantity_editText.Name = "quantity_editText";
            this.quantity_editText.Size = new System.Drawing.Size(172, 20);
            this.quantity_editText.TabIndex = 41;
            // 
            // description_editText
            // 
            this.description_editText.Location = new System.Drawing.Point(89, 122);
            this.description_editText.Name = "description_editText";
            this.description_editText.Size = new System.Drawing.Size(172, 20);
            this.description_editText.TabIndex = 40;
            // 
            // price_editText
            // 
            this.price_editText.Location = new System.Drawing.Point(89, 90);
            this.price_editText.Name = "price_editText";
            this.price_editText.Size = new System.Drawing.Size(172, 20);
            this.price_editText.TabIndex = 39;
            // 
            // name_editText
            // 
            this.name_editText.Location = new System.Drawing.Point(89, 56);
            this.name_editText.Name = "name_editText";
            this.name_editText.Size = new System.Drawing.Size(172, 20);
            this.name_editText.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Image";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Featured";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Discount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Prescription";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Description";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Add a Product";
            // 
            // product_list
            // 
            this.product_list.FormattingEnabled = true;
            this.product_list.Location = new System.Drawing.Point(89, 185);
            this.product_list.Name = "product_list";
            this.product_list.Size = new System.Drawing.Size(172, 329);
            this.product_list.TabIndex = 47;
            this.product_list.SelectedIndexChanged += new System.EventHandler(this.product_list_SelectedIndexChanged);
            // 
            // New_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(label4);
            this.Controls.Add(this.product_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prescription_list);
            this.Controls.Add(this.featured_list);
            this.Controls.Add(this.discount_editText);
            this.Controls.Add(this.image_editText);
            this.Controls.Add(this.quantity_editText);
            this.Controls.Add(this.description_editText);
            this.Controls.Add(this.price_editText);
            this.Controls.Add(this.name_editText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.totalBill_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.createOrder_btn);
            this.Controls.Add(this.products_grid);
            this.Controls.Add(this.addVendor_btn);
            this.Controls.Add(this.addToOrder_btn);
            this.Controls.Add(this.vendor_list);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderDate_editText);
            this.Controls.Add(this.orderNo_editText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "New_Purchase";
            this.Text = "New_Purchase";
            this.Load += new System.EventHandler(this.New_Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderNo_editText;
        private System.Windows.Forms.TextBox orderDate_editText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addToOrder_btn;
        private System.Windows.Forms.Button addVendor_btn;
        public System.Windows.Forms.ListBox vendor_list;
        private System.Windows.Forms.DataGridView products_grid;
        private System.Windows.Forms.Button createOrder_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalBill_label;
        private System.Windows.Forms.ListBox prescription_list;
        private System.Windows.Forms.ListBox featured_list;
        private System.Windows.Forms.TextBox discount_editText;
        private System.Windows.Forms.TextBox image_editText;
        private System.Windows.Forms.TextBox quantity_editText;
        private System.Windows.Forms.TextBox description_editText;
        private System.Windows.Forms.TextBox price_editText;
        private System.Windows.Forms.TextBox name_editText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox product_list;
    }
}