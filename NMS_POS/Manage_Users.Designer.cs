namespace NMS_POS
{
    partial class Manage_Users
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_editText = new System.Windows.Forms.TextBox();
            this.password_editText = new System.Windows.Forms.TextBox();
            this.role_list = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.users_datagrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.users_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role";
            // 
            // name_editText
            // 
            this.name_editText.Location = new System.Drawing.Point(314, 37);
            this.name_editText.Name = "name_editText";
            this.name_editText.Size = new System.Drawing.Size(120, 20);
            this.name_editText.TabIndex = 3;
            // 
            // password_editText
            // 
            this.password_editText.Location = new System.Drawing.Point(314, 76);
            this.password_editText.Name = "password_editText";
            this.password_editText.Size = new System.Drawing.Size(120, 20);
            this.password_editText.TabIndex = 4;
            // 
            // role_list
            // 
            this.role_list.FormattingEnabled = true;
            this.role_list.Location = new System.Drawing.Point(314, 109);
            this.role_list.Name = "role_list";
            this.role_list.Size = new System.Drawing.Size(120, 30);
            this.role_list.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(474, 116);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // users_datagrid
            // 
            this.users_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_datagrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.users_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_datagrid.Location = new System.Drawing.Point(57, 191);
            this.users_datagrid.Name = "users_datagrid";
            this.users_datagrid.ReadOnly = true;
            this.users_datagrid.Size = new System.Drawing.Size(574, 315);
            this.users_datagrid.TabIndex = 7;
            this.users_datagrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_datagrid_CellContentDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "List of Users";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(57, 526);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 15;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(556, 526);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 16;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 561);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.users_datagrid);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.role_list);
            this.Controls.Add(this.password_editText);
            this.Controls.Add(this.name_editText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Users";
            this.Text = "Manage_Users";
            this.Load += new System.EventHandler(this.Manage_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_editText;
        private System.Windows.Forms.TextBox password_editText;
        private System.Windows.Forms.ListBox role_list;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView users_datagrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}