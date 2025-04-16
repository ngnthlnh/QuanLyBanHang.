namespace QuanLyBanHang
{
    partial class frmThemPXK
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
            this.lbSoPXK = new System.Windows.Forms.Label();
            this.txtSoPXK = new System.Windows.Forms.TextBox();
            this.lbXgayXuat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbMaKho = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSoPXK
            // 
            this.lbSoPXK.AutoSize = true;
            this.lbSoPXK.Location = new System.Drawing.Point(31, 27);
            this.lbSoPXK.Name = "lbSoPXK";
            this.lbSoPXK.Size = new System.Drawing.Size(68, 20);
            this.lbSoPXK.TabIndex = 0;
            this.lbSoPXK.Text = "Số PXK:";
            this.lbSoPXK.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoPXK
            // 
            this.txtSoPXK.Location = new System.Drawing.Point(35, 59);
            this.txtSoPXK.Name = "txtSoPXK";
            this.txtSoPXK.Size = new System.Drawing.Size(179, 26);
            this.txtSoPXK.TabIndex = 1;
            this.txtSoPXK.TextChanged += new System.EventHandler(this.txtSoPXK_TextChanged);
            // 
            // lbXgayXuat
            // 
            this.lbXgayXuat.AutoSize = true;
            this.lbXgayXuat.Location = new System.Drawing.Point(283, 27);
            this.lbXgayXuat.Name = "lbXgayXuat";
            this.lbXgayXuat.Size = new System.Drawing.Size(83, 20);
            this.lbXgayXuat.TabIndex = 2;
            this.lbXgayXuat.Text = "Ngày xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lý do:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(588, 61);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(136, 26);
            this.txtLyDo.TabIndex = 5;
            this.txtLyDo.TextChanged += new System.EventHandler(this.txtLyDo_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(31, 209);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(79, 20);
            this.lbTongTien.TabIndex = 7;
            this.lbTongTien.Text = "Tổng tiền:";
            this.lbTongTien.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(35, 246);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(179, 26);
            this.txtTongTien.TabIndex = 8;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // lbMaKho
            // 
            this.lbMaKho.AutoSize = true;
            this.lbMaKho.Location = new System.Drawing.Point(283, 209);
            this.lbMaKho.Name = "lbMaKho";
            this.lbMaKho.Size = new System.Drawing.Size(65, 20);
            this.lbMaKho.TabIndex = 9;
            this.lbMaKho.Text = "Mã kho:";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(287, 246);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(224, 26);
            this.txtMaKho.TabIndex = 10;
            this.txtMaKho.TextChanged += new System.EventHandler(this.txtMaKho_TextChanged);
            // 
            // bnCancel
            // 
            this.bnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnCancel.Location = new System.Drawing.Point(35, 330);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(108, 33);
            this.bnCancel.TabIndex = 11;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = false;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // bnSubmit
            // 
            this.bnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.bnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnSubmit.Location = new System.Drawing.Point(202, 330);
            this.bnSubmit.Name = "bnSubmit";
            this.bnSubmit.Size = new System.Drawing.Size(105, 33);
            this.bnSubmit.TabIndex = 12;
            this.bnSubmit.Text = "Submit";
            this.bnSubmit.UseVisualStyleBackColor = false;
            this.bnSubmit.Click += new System.EventHandler(this.bnSubmit_Click);
            // 
            // frmThemPXK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.bnSubmit);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.lbMaKho);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbXgayXuat);
            this.Controls.Add(this.txtSoPXK);
            this.Controls.Add(this.lbSoPXK);
            this.Name = "frmThemPXK";
            this.Text = "frmThemPXK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoPXK;
        private System.Windows.Forms.TextBox txtSoPXK;
        private System.Windows.Forms.Label lbXgayXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbMaKho;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnSubmit;
    }
}