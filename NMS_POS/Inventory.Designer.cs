namespace NMS_POS
{
    partial class Inventory
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
            this.inventory_datagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name_editText = new System.Windows.Forms.TextBox();
            this.price_editText = new System.Windows.Forms.TextBox();
            this.description_editText = new System.Windows.Forms.TextBox();
            this.quantity_editText = new System.Windows.Forms.TextBox();
            this.image_editText = new System.Windows.Forms.TextBox();
            this.discount_editText = new System.Windows.Forms.TextBox();
            this.featured_list = new System.Windows.Forms.ListBox();
            this.prescription_list = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inventory_datagrid
            // 
            this.inventory_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_datagrid.Location = new System.Drawing.Point(12, 206);
            this.inventory_datagrid.Name = "inventory_datagrid";
            this.inventory_datagrid.Size = new System.Drawing.Size(845, 423);
            this.inventory_datagrid.TabIndex = 0;
            this.inventory_datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_datagrid_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prescription";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Featured";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Image";
            // 
            // name_editText
            // 
            this.name_editText.Location = new System.Drawing.Point(114, 18);
            this.name_editText.Name = "name_editText";
            this.name_editText.Size = new System.Drawing.Size(172, 20);
            this.name_editText.TabIndex = 9;
            // 
            // price_editText
            // 
            this.price_editText.Location = new System.Drawing.Point(114, 52);
            this.price_editText.Name = "price_editText";
            this.price_editText.Size = new System.Drawing.Size(172, 20);
            this.price_editText.TabIndex = 10;
            // 
            // description_editText
            // 
            this.description_editText.Location = new System.Drawing.Point(114, 84);
            this.description_editText.Name = "description_editText";
            this.description_editText.Size = new System.Drawing.Size(172, 20);
            this.description_editText.TabIndex = 11;
            // 
            // quantity_editText
            // 
            this.quantity_editText.Location = new System.Drawing.Point(114, 114);
            this.quantity_editText.Name = "quantity_editText";
            this.quantity_editText.Size = new System.Drawing.Size(172, 20);
            this.quantity_editText.TabIndex = 12;
            // 
            // image_editText
            // 
            this.image_editText.Location = new System.Drawing.Point(607, 18);
            this.image_editText.Name = "image_editText";
            this.image_editText.Size = new System.Drawing.Size(202, 20);
            this.image_editText.TabIndex = 13;
            // 
            // discount_editText
            // 
            this.discount_editText.Location = new System.Drawing.Point(607, 52);
            this.discount_editText.Name = "discount_editText";
            this.discount_editText.Size = new System.Drawing.Size(202, 20);
            this.discount_editText.TabIndex = 14;
            // 
            // featured_list
            // 
            this.featured_list.FormattingEnabled = true;
            this.featured_list.Location = new System.Drawing.Point(607, 84);
            this.featured_list.Name = "featured_list";
            this.featured_list.Size = new System.Drawing.Size(202, 30);
            this.featured_list.Sorted = true;
            this.featured_list.TabIndex = 15;
            // 
            // prescription_list
            // 
            this.prescription_list.FormattingEnabled = true;
            this.prescription_list.Location = new System.Drawing.Point(607, 121);
            this.prescription_list.Name = "prescription_list";
            this.prescription_list.Size = new System.Drawing.Size(202, 30);
            this.prescription_list.Sorted = true;
            this.prescription_list.TabIndex = 16;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(734, 177);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 17;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(734, 653);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(114, 177);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 19;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 703);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventory_datagrid);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventory_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name_editText;
        private System.Windows.Forms.TextBox price_editText;
        private System.Windows.Forms.TextBox description_editText;
        private System.Windows.Forms.TextBox quantity_editText;
        private System.Windows.Forms.TextBox image_editText;
        private System.Windows.Forms.TextBox discount_editText;
        private System.Windows.Forms.ListBox featured_list;
        private System.Windows.Forms.ListBox prescription_list;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
    }
}