namespace QuanLyBanHang
{
    partial class frmEditPXK
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
            this.bnSubmit = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.lbMaKho = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbXgayXuat = new System.Windows.Forms.Label();
            this.txtSoPXK = new System.Windows.Forms.TextBox();
            this.lbSoPXK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnSubmit
            // 
            this.bnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.bnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnSubmit.Location = new System.Drawing.Point(225, 360);
            this.bnSubmit.Name = "bnSubmit";
            this.bnSubmit.Size = new System.Drawing.Size(105, 33);
            this.bnSubmit.TabIndex = 24;
            this.bnSubmit.Text = "Submit";
            this.bnSubmit.UseVisualStyleBackColor = false;
            this.bnSubmit.Click += new System.EventHandler(this.bnSubmit_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnCancel.Location = new System.Drawing.Point(58, 360);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(108, 33);
            this.bnCancel.TabIndex = 23;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = false;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(310, 276);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(224, 26);
            this.txtMaKho.TabIndex = 22;
            // 
            // lbMaKho
            // 
            this.lbMaKho.AutoSize = true;
            this.lbMaKho.Location = new System.Drawing.Point(306, 239);
            this.lbMaKho.Name = "lbMaKho";
            this.lbMaKho.Size = new System.Drawing.Size(65, 20);
            this.lbMaKho.TabIndex = 21;
            this.lbMaKho.Text = "Mã kho:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(58, 276);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(179, 26);
            this.txtTongTien.TabIndex = 20;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(54, 239);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(79, 20);
            this.lbTongTien.TabIndex = 19;
            this.lbTongTien.Text = "Tổng tiền:";
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Location = new System.Drawing.Point(310, 89);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(224, 26);
            this.dtpNgayXuat.TabIndex = 18;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(611, 91);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(136, 26);
            this.txtLyDo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lý do:";
            // 
            // lbXgayXuat
            // 
            this.lbXgayXuat.AutoSize = true;
            this.lbXgayXuat.Location = new System.Drawing.Point(306, 57);
            this.lbXgayXuat.Name = "lbXgayXuat";
            this.lbXgayXuat.Size = new System.Drawing.Size(83, 20);
            this.lbXgayXuat.TabIndex = 15;
            this.lbXgayXuat.Text = "Ngày xuất:";
            // 
            // txtSoPXK
            // 
            this.txtSoPXK.Location = new System.Drawing.Point(58, 89);
            this.txtSoPXK.Name = "txtSoPXK";
            this.txtSoPXK.Size = new System.Drawing.Size(179, 26);
            this.txtSoPXK.TabIndex = 14;
            // 
            // lbSoPXK
            // 
            this.lbSoPXK.AutoSize = true;
            this.lbSoPXK.Location = new System.Drawing.Point(54, 57);
            this.lbSoPXK.Name = "lbSoPXK";
            this.lbSoPXK.Size = new System.Drawing.Size(68, 20);
            this.lbSoPXK.TabIndex = 13;
            this.lbSoPXK.Text = "Số PXK:";
            // 
            // frmEditPXK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnSubmit);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.lbMaKho);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbXgayXuat);
            this.Controls.Add(this.txtSoPXK);
            this.Controls.Add(this.lbSoPXK);
            this.Name = "frmEditPXK";
            this.Text = "frmEditPXK";
            this.Load += new System.EventHandler(this.frmEditPXK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnSubmit;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label lbMaKho;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbXgayXuat;
        private System.Windows.Forms.TextBox txtSoPXK;
        private System.Windows.Forms.Label lbSoPXK;
    }
}