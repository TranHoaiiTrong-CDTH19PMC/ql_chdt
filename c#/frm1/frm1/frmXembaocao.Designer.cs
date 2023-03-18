namespace frm1
{
    partial class frmXembaocao
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
            this.rbvxembaocaonhanvien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbvxembaocaonhanvien
            // 
            this.rbvxembaocaonhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbvxembaocaonhanvien.Location = new System.Drawing.Point(0, 0);
            this.rbvxembaocaonhanvien.Name = "rbvxembaocaonhanvien";
            this.rbvxembaocaonhanvien.Size = new System.Drawing.Size(739, 368);
            this.rbvxembaocaonhanvien.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::frm1.Properties.Resources.BTNBACK2;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(664, 328);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmXembaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rbvxembaocaonhanvien);
            this.Name = "frmXembaocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmXembaocao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rbvxembaocaonhanvien;
        private System.Windows.Forms.Button btnThoat;
    }
}