namespace NMS_POS
{
    partial class Add_Vendor
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
            this.name_editText = new System.Windows.Forms.TextBox();
            this.mobileNo_editText = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile No";
            // 
            // name_editText
            // 
            this.name_editText.Location = new System.Drawing.Point(104, 24);
            this.name_editText.Name = "name_editText";
            this.name_editText.Size = new System.Drawing.Size(179, 20);
            this.name_editText.TabIndex = 2;
            // 
            // mobileNo_editText
            // 
            this.mobileNo_editText.Location = new System.Drawing.Point(104, 56);
            this.mobileNo_editText.Name = "mobileNo_editText";
            this.mobileNo_editText.Size = new System.Drawing.Size(179, 20);
            this.mobileNo_editText.TabIndex = 3;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(133, 129);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Add_Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 234);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.mobileNo_editText);
            this.Controls.Add(this.name_editText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Vendor";
            this.Text = "Add_Vendor";
            this.Load += new System.EventHandler(this.Add_Vendor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_editText;
        private System.Windows.Forms.TextBox mobileNo_editText;
        private System.Windows.Forms.Button add_btn;
    }
}