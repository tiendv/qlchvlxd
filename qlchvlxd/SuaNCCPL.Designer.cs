namespace qlchvlxd
{
    partial class SuaNCCPL
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
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_DongY = new System.Windows.Forms.Button();
            this.textBox_DienThoai = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(234, 153);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(75, 23);
            this.button_Huy.TabIndex = 15;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_DongY
            // 
            this.button_DongY.Location = new System.Drawing.Point(130, 153);
            this.button_DongY.Name = "button_DongY";
            this.button_DongY.Size = new System.Drawing.Size(75, 23);
            this.button_DongY.TabIndex = 14;
            this.button_DongY.Text = "Đồng ý";
            this.button_DongY.UseVisualStyleBackColor = true;
            this.button_DongY.Click += new System.EventHandler(this.button_DongY_Click);
            // 
            // textBox_DienThoai
            // 
            this.textBox_DienThoai.Location = new System.Drawing.Point(130, 77);
            this.textBox_DienThoai.Name = "textBox_DienThoai";
            this.textBox_DienThoai.Size = new System.Drawing.Size(179, 20);
            this.textBox_DienThoai.TabIndex = 13;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(130, 50);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(179, 20);
            this.textBox_DiaChi.TabIndex = 12;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(130, 20);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(179, 20);
            this.textBoxTen.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // SuaNCCPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 242);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_DongY);
            this.Controls.Add(this.textBox_DienThoai);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuaNCCPL";
            this.Text = "Sửa thông tin nhà cung cấp";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_DongY;
        private System.Windows.Forms.TextBox textBox_DienThoai;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}