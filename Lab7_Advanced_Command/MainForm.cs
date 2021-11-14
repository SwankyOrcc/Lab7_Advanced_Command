using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			LoadTable();
			LoadCategory();
			
		}

		private void quanLyDanhSachMonĂnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.ShowDialog();
		}

	

		void LoadCategory()
		{
			List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
			cbbCategory.DataSource = listCategory;
			cbbCategory.DisplayMember = "Name";
		}
		void LoadFoodListByCategoryID(int id)
		{
			List<Food> listfood = FoodDAO.Instance.GetFoodbyCategoryID(id);
			cbbFood.DataSource = listfood;
			cbbFood.DisplayMember = "Name";
		}
		void LoadTable()
		{
			List<Table> tableList = TableDAO.Instance.LoadTableList();
			foreach(Table item in tableList)
			{
				Button btn = new Button { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
				btn.Text = item.Name + Environment.NewLine + item.Status;
				btn.Click += btn_Click;
				btn.Tag = item;
				switch(item.Status)
				{
					case 0:
						btn.BackColor = Color.Aqua;
						break;

					default:
						btn.BackColor = Color.LightPink;
						break;
				}
				flpTable.Controls.Add(btn);
			}
		}
		void showBill(int id)
		{
			lvBills.Items.Clear();
			List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
			float totalPrice = 0;
			foreach(Menu item in listBillInfo)
			{
				ListViewItem lvitem = new ListViewItem(item.FoodName.ToString());
				lvitem.SubItems.Add(item.Quantity.ToString());
				lvitem.SubItems.Add(item.Price.ToString());
				lvitem.SubItems.Add(item.Totalprice.ToString());
				totalPrice += item.Totalprice;
				lvBills.Items.Add(lvitem);
			}
			CultureInfo culture = new CultureInfo("vi-VN");
			txtTotalPrice.Text = totalPrice.ToString("c",culture);
		}
		private void btn_Click(object sender, EventArgs e)
		{
			int tableID = ((sender as Button).Tag as Table).ID;
			lvBills.Tag = (sender as Button).Tag;
			showBill(tableID);
		}

		
		

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;
			ComboBox cb = sender as ComboBox;

			if (cb.SelectedItem == null)
				return;
			Category selected = cb.SelectedItem as Category;
			id = selected.Id;
			LoadFoodListByCategoryID(id);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Table table = lvBills.Tag as Table;
			int idBill = BillDAO.Instance.GetuncheckBillIDByTableID(table.ID);

			if(idBill == -1)
			{
				BillDAO.Instance.InsertBill(table.ID);

			
			}
		}
	}
}
