namespace QLHoaChat
{
    partial class QuanLyThanhToan
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
            this.quanLyPhuongThucThanhToanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPaymentMethod = new System.Windows.Forms.Button();
            this.dgvPaymentMethods = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentMethods)).BeginInit();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.dashboardToolStripMenuItem,
                this.quanLyPhuongThucThanhToanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // dashboardToolStripMenuItem
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";

            // quanLyPhuongThucThanhToanToolStripMenuItem
            this.quanLyPhuongThucThanhToanToolStripMenuItem.Name = "quanLyPhuongThucThanhToanToolStripMenuItem";
            this.quanLyPhuongThucThanhToanToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.quanLyPhuongThucThanhToanToolStripMenuItem.Text = "Quản Lý Phương Thức Thanh Toán";

            // btnAddPaymentMethod
            this.btnAddPaymentMethod.Location = new System.Drawing.Point(12, 50);
            this.btnAddPaymentMethod.Name = "btnAddPaymentMethod";
            this.btnAddPaymentMethod.Size = new System.Drawing.Size(150, 30);
            this.btnAddPaymentMethod.TabIndex = 1;
            this.btnAddPaymentMethod.Text = "Thêm Phương Thức Mới";
            this.btnAddPaymentMethod.UseVisualStyleBackColor = true;

            // dgvPaymentMethods
            this.dgvPaymentMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentMethods.Location = new System.Drawing.Point(12, 90);
            this.dgvPaymentMethods.Name = "dgvPaymentMethods";
            this.dgvPaymentMethods.Size = new System.Drawing.Size(860, 400);
            this.dgvPaymentMethods.TabIndex = 2;
            this.dgvPaymentMethods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPaymentMethods_CellContentClick);

            // Form chính
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dgvPaymentMethods);
            this.Controls.Add(this.btnAddPaymentMethod);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaymentMethodManagementForm";
            this.Text = "Admin Hóa Chất - Quản Lý Phương Thức Thanh Toán";
            this.Load += new System.EventHandler(this.PaymentMethodManagementForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentMethods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyPhuongThucThanhToanToolStripMenuItem;
        private System.Windows.Forms.Button btnAddPaymentMethod;
        private System.Windows.Forms.DataGridView dgvPaymentMethods;
    }
}