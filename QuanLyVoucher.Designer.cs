namespace QLHoaChat
{
    partial class QuanLyVoucher
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

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddVoucher = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            this.cbTypeFilter = new System.Windows.Forms.ComboBox();
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1626, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // btnAddVoucher
            // 
            this.btnAddVoucher.Location = new System.Drawing.Point(18, 77);
            this.btnAddVoucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddVoucher.Name = "btnAddVoucher";
            this.btnAddVoucher.Size = new System.Drawing.Size(225, 46);
            this.btnAddVoucher.TabIndex = 1;
            this.btnAddVoucher.Text = "Tạo Voucher Mới";
            this.btnAddVoucher.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 143);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 20);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(116, 138);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Mã, tên...";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(424, 135);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 38);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(524, 143);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 20);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Lọc:";
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Còn",
            "Hết"});
            this.cbStatusFilter.Location = new System.Drawing.Point(582, 138);
            this.cbStatusFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(148, 28);
            this.cbStatusFilter.TabIndex = 6;
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeFilter.Items.AddRange(new object[] {
            "Tất cả",
            "%",
            "VNĐ"});
            this.cbTypeFilter.Location = new System.Drawing.Point(741, 138);
            this.cbTypeFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(148, 28);
            this.cbTypeFilter.TabIndex = 7;
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVouchers.Location = new System.Drawing.Point(18, 198);
            this.dgvVouchers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.RowHeadersWidth = 62;
            this.dgvVouchers.Size = new System.Drawing.Size(1590, 615);
            this.dgvVouchers.TabIndex = 8;
            this.dgvVouchers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVouchers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(502, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản Lý Voucher";
            // 
            // QuanLyVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 863);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVouchers);
            this.Controls.Add(this.cbTypeFilter);
            this.Controls.Add(this.cbStatusFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnAddVoucher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLyVoucher";
            this.Text = "Admin Hóa Chất - Quản Lý Voucher";
            this.Load += new System.EventHandler(this.VoucherManagementForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.Button btnAddVoucher;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.ComboBox cbTypeFilter;
        private System.Windows.Forms.DataGridView dgvVouchers;
        private System.Windows.Forms.Label label1;
    }
}