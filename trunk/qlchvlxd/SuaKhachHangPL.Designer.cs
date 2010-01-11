namespace qlchvlxd
{
    partial class SuaKhachHangPL
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
            this.textBox_dienThoai = new System.Windows.Forms.TextBox();
            this.textBox_diaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(181, 107);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(75, 23);
            this.button_Huy.TabIndex = 19;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_DongY
            // 
            this.button_DongY.Location = new System.Drawing.Point(79, 107);
            this.button_DongY.Name = "button_DongY";
            this.button_DongY.Size = new System.Drawing.Size(75, 23);
            this.button_DongY.TabIndex = 18;
            this.button_DongY.Text = "Đồng ý";
            this.button_DongY.UseVisualStyleBackColor = true;
            this.button_DongY.Click += new System.EventHandler(this.button_DongY_Click);
            // 
            // textBox_dienThoai
            // 
            this.textBox_dienThoai.Location = new System.Drawing.Point(79, 49);
            this.textBox_dienThoai.Name = "textBox_dienThoai";
            this.textBox_dienThoai.ShortcutsEnabled = false;
            this.textBox_dienThoai.Size = new System.Drawing.Size(177, 20);
            this.textBox_dienThoai.TabIndex = 17;
            // 
            // textBox_diaChi
            // 
            this.textBox_diaChi.Location = new System.Drawing.Point(79, 22);
            this.textBox_diaChi.Name = "textBox_diaChi";
            this.textBox_diaChi.Size = new System.Drawing.Size(177, 20);
            this.textBox_diaChi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa chỉ";
            // 
            // SuaKhachHangPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 183);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_DongY);
            this.Controls.Add(this.textBox_dienThoai);
            this.Controls.Add(this.textBox_diaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "SuaKhachHangPL";
            this.Text = "Sửa thông tin khách hàng";
            this.Load += new System.EventHandler(this.SuaKhachHangPL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_DongY;
        private System.Windows.Forms.TextBox textBox_dienThoai;
        private System.Windows.Forms.TextBox textBox_diaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}