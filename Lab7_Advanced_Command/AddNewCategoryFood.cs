using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
	public partial class AddNewCategoryFood : Form
	{
		public AddNewCategoryFood()
		{
			InitializeComponent();
		}

		private void AddNewCategoryFood_Load(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn đối tượng cho command
			sqlCommand.CommandText = "INSERT INTO Category(Name,[Type])" + "VALUES (N'" + txtCategoryName.Text + "'," + txtType.Text + ")";

			//Mở kết nối tới dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương pháp ExcuteReader

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//Đóng kết nối 
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm nhóm món ăn thành công");

				FoodInfForm foodinf = new FoodInfForm();
				foodinf.ResetText();
				//Xoá các ô nhập
				txtCategoryName.Text = "";
				txtType.Text = "";
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn đối tượng command
			sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID = " + txtID.Text;

			//Mở kết nối tới cơ sở dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương pháp ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//Đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Xoá nhóm món ăn thành công");
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn cho đối tượng
			sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtCategoryName.Text + "', [Type] = " + txtType.Text + " WHERE ID = " + txtID.Text;

			//Mở kết nối tới cơ sở dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương thức ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//Đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				//Xoá các ô nhập
				txtID.Text = "";
				txtCategoryName.Text = "";
				txtType.Text = "";

				MessageBox.Show("Cập nhật món ăn thành công");
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
