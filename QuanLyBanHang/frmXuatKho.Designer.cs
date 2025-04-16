using System;

namespace QuanLyBanHang
{
    partial class frmXuatKho
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.DSPhieuXK = new System.Windows.Forms.DataGridView();
            this.bnCreate = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.bnSearch = new System.Windows.Forms.Button();
            this.bnClear = new System.Windows.Forms.Button();
            this.cBPXK = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtKhoChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhieuXK)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DSPhieuXK
            // 
            this.DSPhieuXK.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DSPhieuXK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSPhieuXK.Location = new System.Drawing.Point(0, 96);
            this.DSPhieuXK.Name = "DSPhieuXK";
            this.DSPhieuXK.RowHeadersWidth = 62;
            this.DSPhieuXK.RowTemplate.Height = 28;
            this.DSPhieuXK.Size = new System.Drawing.Size(927, 417);
            this.DSPhieuXK.TabIndex = 0;
            // 
            // bnCreate
            // 
            this.bnCreate.BackColor = System.Drawing.Color.ForestGreen;
            this.bnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnCreate.Location = new System.Drawing.Point(51, 6);
            this.bnCreate.Name = "bnCreate";
            this.bnCreate.Size = new System.Drawing.Size(89, 34);
            this.bnCreate.TabIndex = 2;
            this.bnCreate.Text = "Create";
            this.bnCreate.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimKiem.Location = new System.Drawing.Point(210, 48);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(342, 26);
            this.txtTimKiem.TabIndex = 3;
            // 
            // bnSearch
            // 
            this.bnSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.bnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnSearch.Location = new System.Drawing.Point(659, 46);
            this.bnSearch.Name = "bnSearch";
            this.bnSearch.Size = new System.Drawing.Size(75, 32);
            this.bnSearch.TabIndex = 4;
            this.bnSearch.Text = "Search";
            this.bnSearch.UseVisualStyleBackColor = false;
            // 
            // bnClear
            // 
            this.bnClear.Location = new System.Drawing.Point(0, 0);
            this.bnClear.Name = "bnClear";
            this.bnClear.Size = new System.Drawing.Size(75, 23);
            this.bnClear.TabIndex = 7;
            // 
            // cBPXK
            // 
            this.cBPXK.Location = new System.Drawing.Point(51, 46);
            this.cBPXK.Name = "cBPXK";
            this.cBPXK.Size = new System.Drawing.Size(121, 28);
            this.cBPXK.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.cBPXK);
            this.panel1.Controls.Add(this.bnClear);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.bnSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 101);
            this.panel1.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(927, 34);
            this.toolStrip1.TabIndex = 6;
            // 
            // Menu
            // 
            this.Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýNhàCungCấpToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýKhoToolStripMenuItem,
            this.quảnLýNhậpKhoToolStripMenuItem,
            this.quảnLýXuấtKhoToolStripMenuItem,
            this.xuấtKhoChiTiếtToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(75, 29);
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            this.quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            this.quảnLýKhoToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            // 
            // quảnLýNhậpKhoToolStripMenuItem
            // 
            this.quảnLýNhậpKhoToolStripMenuItem.Name = "quảnLýNhậpKhoToolStripMenuItem";
            this.quảnLýNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.quảnLýNhậpKhoToolStripMenuItem.Text = "Quản lý nhập kho";
            // 
            // quảnLýXuấtKhoToolStripMenuItem
            // 
            this.quảnLýXuấtKhoToolStripMenuItem.Name = "quảnLýXuấtKhoToolStripMenuItem";
            this.quảnLýXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.quảnLýXuấtKhoToolStripMenuItem.Text = "Quản lý xuất kho";
            // 
            // xuấtKhoChiTiếtToolStripMenuItem
            // 
            this.xuấtKhoChiTiếtToolStripMenuItem.Name = "xuấtKhoChiTiếtToolStripMenuItem";
            this.xuấtKhoChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bnEdit);
            this.panel2.Controls.Add(this.bnCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 44);
            this.panel2.TabIndex = 8;
            // 
            // bnEdit
            // 
            this.bnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.bnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnEdit.Location = new System.Drawing.Point(167, 6);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(89, 34);
            this.bnEdit.TabIndex = 2;
            this.bnEdit.Text = "Edit";
            this.bnEdit.UseVisualStyleBackColor = false;
            // 
            // frmXuatKho
            // 
            this.ClientSize = new System.Drawing.Size(927, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DSPhieuXK);
            this.Name = "frmXuatKho";
            this.Text = "Phiếu xuất kho";
            ((System.ComponentModel.ISupportInitialize)(this.DSPhieuXK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView DSPhieuXK;
        private System.Windows.Forms.Button bnCreate;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button bnSearch;
        private System.Windows.Forms.Button bnClear;
        private System.Windows.Forms.ComboBox cBPXK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton Menu;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.Button bnEdit;
        private EventHandler bnCreate_Click;
        private EventHandler bnSearch_Click;
        private EventHandler quảnLýNhânViênToolStripMenuItem_Click;
        private EventHandler quảnLýNhàCungCấpToolStripMenuItem_Click;
        private EventHandler quảnLýKháchHàngToolStripMenuItem_Click;
        private EventHandler quảnLýKhoToolStripMenuItem_Click;
        private EventHandler quảnLýNhậpKhoToolStripMenuItem_Click;
        private EventHandler quảnLýXuấtKhoToolStripMenuItem_Click;
        private EventHandler bnEdit_Click;
        private System.Windows.Forms.ToolStripMenuItem xuấtKhoChiTiếtToolStripMenuItem;
    }
}
