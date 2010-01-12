namespace qlchvlxd
{
    partial class TimKiemNCCPL
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
            this.textBox_Tim = new System.Windows.Forms.TextBox();
            this.button_Tim = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_SuaNCC = new System.Windows.Forms.Button();
            this.listView_NCC = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Tim
            // 
            this.textBox_Tim.Location = new System.Drawing.Point(113, 12);
            this.textBox_Tim.Name = "textBox_Tim";
            this.textBox_Tim.Size = new System.Drawing.Size(199, 20);
            this.textBox_Tim.TabIndex = 1;
            // 
            // button_Tim
            // 
            this.button_Tim.Location = new System.Drawing.Point(361, 13);
            this.button_Tim.Name = "button_Tim";
            this.button_Tim.Size = new System.Drawing.Size(75, 23);
            this.button_Tim.TabIndex = 2;
            this.button_Tim.Text = "Tìm";
            this.button_Tim.UseVisualStyleBackColor = true;
            this.button_Tim.Click += new System.EventHandler(this.button_Tim_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(482, 106);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 4;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_SuaNCC
            // 
            this.button_SuaNCC.Location = new System.Drawing.Point(482, 158);
            this.button_SuaNCC.Name = "button_SuaNCC";
            this.button_SuaNCC.Size = new System.Drawing.Size(75, 23);
            this.button_SuaNCC.TabIndex = 5;
            this.button_SuaNCC.Text = "Sửa";
            this.button_SuaNCC.UseVisualStyleBackColor = true;
            this.button_SuaNCC.Click += new System.EventHandler(this.button_SuaNCC_Click);
            // 
            // listView_NCC
            // 
            this.listView_NCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_NCC.FullRowSelect = true;
            this.listView_NCC.Location = new System.Drawing.Point(12, 77);
            this.listView_NCC.MultiSelect = false;
            this.listView_NCC.Name = "listView_NCC";
            this.listView_NCC.Size = new System.Drawing.Size(444, 159);
            this.listView_NCC.TabIndex = 6;
            this.listView_NCC.UseCompatibleStateImageBehavior = false;
            this.listView_NCC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã nhà cung cấp";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhà cung cấp";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điện thoại";
            this.columnHeader4.Width = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // TimKiemNCCPL
            // 
            this.AcceptButton = this.button_Tim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_NCC);
            this.Controls.Add(this.button_SuaNCC);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Tim);
            this.Controls.Add(this.textBox_Tim);
            this.Name = "TimKiemNCCPL";
            this.Text = "Tìm kiếm Nhà cung cấp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Tim;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_SuaNCC;
        private System.Windows.Forms.ListView listView_NCC;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
    }
}