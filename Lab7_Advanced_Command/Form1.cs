using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
	public partial class Form1 : Form
	{
		private DataTable foodTable;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.LoadCategory();
		}

		private void LoadCategory()
		{
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			//Mở kết nối
			conn.Open();

			//Lấy dữ liệu
			adapter.Fill(dt);

			//Đóng kết nối
			conn.Close();
			conn.Dispose();

			//Đưa dữ liệu vào combo box
			cbbCategory.DataSource = dt;
			// hiển thị tên nhóm sản phẩm
			cbbCategory.DisplayMember = "Name";

			//Nhưng khi lấy giá trị thì lấy id nhóm
			cbbCategory.ValueMember = "ID";

		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbCategory.SelectedIndex == -1) return;
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

			//Truyền tham số
			cmd.Parameters.Add("@categoryId", SqlDbType.Int);
			if(cbbCategory.SelectedValue is DataRowView)
			{
				DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
				cmd.Parameters["@categoryId"].Value = rowView["ID"];

			}
			else
			{
				cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
			}

			//Tạo bộ điều khiển dữ liệu
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			foodTable = new DataTable();

			//Mở kết nối
			conn.Open();

			//Lấy dữ liệu từ csdl đưa vào DAtatable
			adapter.Fill(foodTable);

			//Đóng kết nối 
			conn.Close();
			conn.Dispose();

			//Đưa dữ liệu vào gridview
			dgvFoodList.DataSource = foodTable;

			//Tính số lượng mẫu tin
			lblQuantity.Text = foodTable.Rows.Count.ToString();
			lblCatName.Text = cbbCategory.Text;
		}

		private void tsmCalculateQuantity_Click(object sender, EventArgs e)
		{
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

			// Lấy thông tin sản phẩm chọn
			if(dgvFoodList.SelectedRows.Count>0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				//Truyền tham số
				cmd.Parameters.Add("@foodId", SqlDbType.Int);
				cmd.Parameters["@foodId"].Value = rowView["ID"];

				cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
				cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

				//Mở kết nối
				conn.Open();

				//Thực thi truy vấn 
				cmd.ExecuteNonQuery();

				string result = cmd.Parameters["@numSaleFood"].Value.ToString();
				MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là : " + result + " " + rowView["Unit"]);

				//Đóng kết nối
				conn.Close();
			}
			cmd.Dispose();
			conn.Dispose();

		}

		private void tsmAddFood_Click(object sender, EventArgs e)
		{
			FoodInfForm foodfrm = new FoodInfForm();
			foodfrm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);

			foodfrm.Show(this);
		}

		void foodForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			int index = cbbCategory.SelectedIndex;
			cbbCategory.SelectedIndex = -1;
			cbbCategory.SelectedIndex = index;
		}

		private void tsmUpdateFood_Click(object sender, EventArgs e)
		{
			//Lấy thông tin sản phẩm được chọn
			if(dgvFoodList.SelectedRows.Count>0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				FoodInfForm foodfrm = new FoodInfForm();
				foodfrm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);
				foodfrm.Show(this);
				foodfrm.DisplayFoodInfo(rowView);
			}
		}

		private void txtSearchbyName_TextChanged(object sender, EventArgs e)
		{
			if (foodTable == null) return;
			{
				string fillterExpression = "Name like '%" + txtSearchbyName.Text + "%'";
				string sortExpression = "Price DESC";
				DataViewRowState rowStatefilter = DataViewRowState.OriginalRows;

				DataView foodview = new DataView(foodTable, fillterExpression, sortExpression, rowStatefilter);
				dgvFoodList.DataSource = foodview;
			}
		}
	}
}
