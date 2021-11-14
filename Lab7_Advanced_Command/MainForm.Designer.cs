
namespace Lab7_Advanced_Command
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quanLyDanhSachMonĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lvBills = new System.Windows.Forms.ListView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbbFood = new System.Windows.Forms.ComboBox();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyDanhSachMonĂnToolStripMenuItem});
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "Admin";
			// 
			// quanLyDanhSachMonĂnToolStripMenuItem
			// 
			this.quanLyDanhSachMonĂnToolStripMenuItem.Name = "quanLyDanhSachMonĂnToolStripMenuItem";
			this.quanLyDanhSachMonĂnToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.quanLyDanhSachMonĂnToolStripMenuItem.Text = "Quản lý Danh sách món ăn";
			this.quanLyDanhSachMonĂnToolStripMenuItem.Click += new System.EventHandler(this.quanLyDanhSachMonĂnToolStripMenuItem_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lvBills);
			this.panel2.Location = new System.Drawing.Point(555, 121);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(515, 464);
			this.panel2.TabIndex = 2;
			// 
			// lvBills
			// 
			this.lvBills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvBills.GridLines = true;
			this.lvBills.HideSelection = false;
			this.lvBills.Location = new System.Drawing.Point(3, 3);
			this.lvBills.Name = "lvBills";
			this.lvBills.Size = new System.Drawing.Size(509, 458);
			this.lvBills.TabIndex = 0;
			this.lvBills.UseCompatibleStateImageBehavior = false;
			this.lvBills.View = System.Windows.Forms.View.Details;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtTotalPrice);
			this.panel3.Controls.Add(this.btnCheckout);
			this.panel3.Location = new System.Drawing.Point(555, 591);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(515, 50);
			this.panel3.TabIndex = 3;
			// 
			// btnCheckout
			// 
			this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckout.Location = new System.Drawing.Point(397, 3);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(115, 44);
			this.btnCheckout.TabIndex = 4;
			this.btnCheckout.Text = "Thanh toán";
			this.btnCheckout.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nmFoodCount);
			this.panel4.Controls.Add(this.btnAdd);
			this.panel4.Controls.Add(this.cbbFood);
			this.panel4.Controls.Add(this.cbbCategory);
			this.panel4.Location = new System.Drawing.Point(558, 27);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(512, 88);
			this.panel4.TabIndex = 4;
			// 
			// nmFoodCount
			// 
			this.nmFoodCount.Location = new System.Drawing.Point(408, 36);
			this.nmFoodCount.Name = "nmFoodCount";
			this.nmFoodCount.Size = new System.Drawing.Size(84, 20);
			this.nmFoodCount.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(304, 16);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(98, 57);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm món";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cbbFood
			// 
			this.cbbFood.FormattingEnabled = true;
			this.cbbFood.Location = new System.Drawing.Point(20, 52);
			this.cbbFood.Name = "cbbFood";
			this.cbbFood.Size = new System.Drawing.Size(265, 21);
			this.cbbFood.TabIndex = 1;
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(20, 16);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(265, 21);
			this.cbbCategory.TabIndex = 0;
			this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
			// 
			// flpTable
			// 
			this.flpTable.Location = new System.Drawing.Point(12, 27);
			this.flpTable.Name = "flpTable";
			this.flpTable.Size = new System.Drawing.Size(537, 614);
			this.flpTable.TabIndex = 5;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên món";
			this.columnHeader1.Width = 151;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số lượng";
			this.columnHeader2.Width = 69;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Số lượng";
			this.columnHeader3.Width = 91;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Đơn giá";
			this.columnHeader4.Width = 94;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Thành tiền";
			this.columnHeader5.Width = 261;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPrice.ForeColor = System.Drawing.Color.Red;
			this.txtTotalPrice.Location = new System.Drawing.Point(253, 15);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.ReadOnly = true;
			this.txtTotalPrice.Size = new System.Drawing.Size(138, 25);
			this.txtTotalPrice.TabIndex = 5;
			this.txtTotalPrice.Text = "0";
			this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1082, 653);
			this.Controls.Add(this.flpTable);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lvBills;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.NumericUpDown nmFoodCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbbFood;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.ToolStripMenuItem quanLyDanhSachMonĂnToolStripMenuItem;
		private System.Windows.Forms.Button btnCheckout;
		private System.Windows.Forms.FlowLayoutPanel flpTable;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.TextBox txtTotalPrice;
	}
}