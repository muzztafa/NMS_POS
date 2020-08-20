namespace NMS_POS
{
    partial class Reports
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
            this.selection_list = new System.Windows.Forms.ListBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.totalBill_label = new System.Windows.Forms.Label();
            this.searchBy_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.customSearch_checkbox = new System.Windows.Forms.CheckBox();
            this.fromDate_label = new System.Windows.Forms.Label();
            this.toDate_label = new System.Windows.Forms.Label();
            this.fromDate_editText = new System.Windows.Forms.TextBox();
            this.toDate_editText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noOfRecords_label = new System.Windows.Forms.Label();
            this.format_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // selection_list
            // 
            this.selection_list.FormattingEnabled = true;
            this.selection_list.Location = new System.Drawing.Point(529, 29);
            this.selection_list.Name = "selection_list";
            this.selection_list.Size = new System.Drawing.Size(244, 30);
            this.selection_list.TabIndex = 0;
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(12, 153);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.Size = new System.Drawing.Size(776, 285);
            this.datagrid.TabIndex = 1;
            this.datagrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total:";
            // 
            // totalBill_label
            // 
            this.totalBill_label.AutoSize = true;
            this.totalBill_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalBill_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBill_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalBill_label.Location = new System.Drawing.Point(677, 483);
            this.totalBill_label.Name = "totalBill_label";
            this.totalBill_label.Size = new System.Drawing.Size(52, 31);
            this.totalBill_label.TabIndex = 15;
            this.totalBill_label.Text = "0.0";
            // 
            // searchBy_list
            // 
            this.searchBy_list.FormattingEnabled = true;
            this.searchBy_list.Location = new System.Drawing.Point(126, 29);
            this.searchBy_list.Name = "searchBy_list";
            this.searchBy_list.Size = new System.Drawing.Size(178, 56);
            this.searchBy_list.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search Reports For";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(229, 112);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 18;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // customSearch_checkbox
            // 
            this.customSearch_checkbox.AutoSize = true;
            this.customSearch_checkbox.Location = new System.Drawing.Point(683, 112);
            this.customSearch_checkbox.Name = "customSearch_checkbox";
            this.customSearch_checkbox.Size = new System.Drawing.Size(98, 17);
            this.customSearch_checkbox.TabIndex = 19;
            this.customSearch_checkbox.Text = "Custom Search";
            this.customSearch_checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customSearch_checkbox.UseVisualStyleBackColor = true;
            this.customSearch_checkbox.CheckedChanged += new System.EventHandler(this.customSearch_checkbox_CheckedChanged);
            // 
            // fromDate_label
            // 
            this.fromDate_label.AutoSize = true;
            this.fromDate_label.Location = new System.Drawing.Point(467, 80);
            this.fromDate_label.Name = "fromDate_label";
            this.fromDate_label.Size = new System.Drawing.Size(56, 13);
            this.fromDate_label.TabIndex = 20;
            this.fromDate_label.Text = "From Date";
            // 
            // toDate_label
            // 
            this.toDate_label.AutoSize = true;
            this.toDate_label.Location = new System.Drawing.Point(635, 80);
            this.toDate_label.Name = "toDate_label";
            this.toDate_label.Size = new System.Drawing.Size(46, 13);
            this.toDate_label.TabIndex = 21;
            this.toDate_label.Text = "To Date";
            // 
            // fromDate_editText
            // 
            this.fromDate_editText.Location = new System.Drawing.Point(529, 77);
            this.fromDate_editText.Name = "fromDate_editText";
            this.fromDate_editText.Size = new System.Drawing.Size(89, 20);
            this.fromDate_editText.TabIndex = 22;
            // 
            // toDate_editText
            // 
            this.toDate_editText.Location = new System.Drawing.Point(683, 77);
            this.toDate_editText.Name = "toDate_editText";
            this.toDate_editText.Size = new System.Drawing.Size(90, 20);
            this.toDate_editText.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Report Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "No of Records Found:";
            // 
            // noOfRecords_label
            // 
            this.noOfRecords_label.AutoSize = true;
            this.noOfRecords_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfRecords_label.Location = new System.Drawing.Point(139, 442);
            this.noOfRecords_label.Name = "noOfRecords_label";
            this.noOfRecords_label.Size = new System.Drawing.Size(26, 29);
            this.noOfRecords_label.TabIndex = 27;
            this.noOfRecords_label.Text = "0";
            // 
            // format_label
            // 
            this.format_label.AutoSize = true;
            this.format_label.Location = new System.Drawing.Point(526, 112);
            this.format_label.Name = "format_label";
            this.format_label.Size = new System.Drawing.Size(117, 13);
            this.format_label.TabIndex = 28;
            this.format_label.Text = "Format: MM/DD/YYYY";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.format_label);
            this.Controls.Add(this.noOfRecords_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toDate_editText);
            this.Controls.Add(this.fromDate_editText);
            this.Controls.Add(this.toDate_label);
            this.Controls.Add(this.fromDate_label);
            this.Controls.Add(this.customSearch_checkbox);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBy_list);
            this.Controls.Add(this.totalBill_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.selection_list);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selection_list;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalBill_label;
        private System.Windows.Forms.ListBox searchBy_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.CheckBox customSearch_checkbox;
        private System.Windows.Forms.Label fromDate_label;
        private System.Windows.Forms.Label toDate_label;
        private System.Windows.Forms.TextBox fromDate_editText;
        private System.Windows.Forms.TextBox toDate_editText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label noOfRecords_label;
        private System.Windows.Forms.Label format_label;
    }
}