﻿namespace qlchvlxd
{
    partial class LapHoaDonRPForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.LapHoaDonRP3 = new qlchvlxd.LapHoaDonRP();
            this.LapHoaDonRP1 = new qlchvlxd.LapHoaDonRP();
            this.LapHoaDonRP2 = new qlchvlxd.LapHoaDonRP();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.LapHoaDonRP3;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1280, 778);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // LapHoaDonRPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 778);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "LapHoaDonRPForm";
            this.Text = "Report demmo";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private LapHoaDonRP LapHoaDonRP3;
        private LapHoaDonRP LapHoaDonRP1;
        private LapHoaDonRP LapHoaDonRP2;

    }
}