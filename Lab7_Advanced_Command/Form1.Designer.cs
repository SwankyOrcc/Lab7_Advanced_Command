
namespace Lab7_Advanced_Command
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.dgvFoodList = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSeperator = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblCatName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSearchbyName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(120, 40);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(275, 21);
			this.cbbCategory.TabIndex = 0;
			this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
			// 
			// dgvFoodList
			// 
			this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvFoodList.Location = new System.Drawing.Point(12, 78);
			this.dgvFoodList.MultiSelect = false;
			this.dgvFoodList.Name = "dgvFoodList";
			this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFoodList.Size = new System.Drawing.Size(776, 289);
			this.dgvFoodList.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmSeperator,
            this.tsmAddFood,
            this.tsmUpdateFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(214, 92);
			// 
			// tsmCalculateQuantity
			// 
			this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
			this.tsmCalculateQuantity.Size = new System.Drawing.Size(213, 22);
			this.tsmCalculateQuantity.Text = "Tính tổng số lượng đã bán";
			this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
			// 
			// tsmSeperator
			// 
			this.tsmSeperator.Name = "tsmSeperator";
			this.tsmSeperator.Size = new System.Drawing.Size(213, 22);
			this.tsmSeperator.Text = "toolStripMenuItem1";
			// 
			// tsmAddFood
			// 
			this.tsmAddFood.Name = "tsmAddFood";
			this.tsmAddFood.Size = new System.Drawing.Size(213, 22);
			this.tsmAddFood.Text = "Thêm món ăn";
			this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
			// 
			// tsmUpdateFood
			// 
			this.tsmUpdateFood.Name = "tsmUpdateFood";
			this.tsmUpdateFood.Size = new System.Drawing.Size(213, 22);
			this.tsmUpdateFood.Text = "Cập nhật món ăn";
			this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Chọn nhóm món ăn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 397);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Chọn nhóm món ăn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(177, 397);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Món ăn thuộc nhóm";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(117, 397);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(19, 13);
			this.lblQuantity.TabIndex = 5;
			this.lblQuantity.Text = "....";
			// 
			// lblCatName
			// 
			this.lblCatName.AutoSize = true;
			this.lblCatName.Location = new System.Drawing.Point(282, 397);
			this.lblCatName.Name = "lblCatName";
			this.lblCatName.Size = new System.Drawing.Size(25, 13);
			this.lblCatName.TabIndex = 6;
			this.lblCatName.Text = "......";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(468, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tìm kiếm theo tên món ăn";
			// 
			// txtSearchbyName
			// 
			this.txtSearchbyName.Location = new System.Drawing.Point(603, 40);
			this.txtSearchbyName.Name = "txtSearchbyName";
			this.txtSearchbyName.Size = new System.Drawing.Size(185, 20);
			this.txtSearchbyName.TabIndex = 8;
			this.txtSearchbyName.TextChanged += new System.EventHandler(this.txtSearchbyName_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtSearchbyName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblCatName);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvFoodList);
			this.Controls.Add(this.cbbCategory);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.DataGridView dgvFoodList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblCatName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
		private System.Windows.Forms.ToolStripMenuItem tsmSeperator;
		private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
		private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSearchbyName;
	}
}

