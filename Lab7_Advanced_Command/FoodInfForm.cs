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
	public partial class FoodInfForm : Form
	{
		public FoodInfForm()
		{
			InitializeComponent();
		}

		private void FoodInfForm_Load(object sender, EventArgs e)
		{
			this.InitValue();
		}

		private void InitValue()
		{
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();

			//Mở kết nối
			conn.Open();

			//Lấy dữ liệu csdl
			adapter.Fill(ds, "Category");

			//Hiển thị danh sách nhóm món ăn
			cbbCategoryName.DataSource = ds.Tables["Category"];
			cbbCategoryName.DisplayMember = "Name";
			cbbCategoryName.ValueMember = "ID";

			conn.Close();
			conn.Dispose();
		}

		private void ResetText()
		{
			txtFoodID.ResetText();
			txtName.ResetText();
			txtNotes.ResetText();
			txtUnit.ResetText();
			cbbCategoryName.ResetText();
			nudPrice.ResetText();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				//Tạo đối tượng kết nối
				string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXEC [InsertFood] @id ,@Name ,@Unit ,@FoodCategoryID ,@Price ,@Notes ";

				//thêm tham số vào đối tượng command
				cmd.Parameters.Add("@id", SqlDbType.Int);
				cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
				cmd.Parameters.Add("@price", SqlDbType.Int);
				cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				cmd.Parameters["@id"].Direction = ParameterDirection.Output;

				//Truyền giá trị vào thủ tục
				cmd.Parameters["@name"].Value = txtName.Text;
				cmd.Parameters["@unit"].Value = txtUnit.Text;
				cmd.Parameters["@foodCategoryId"].Value = cbbCategoryName.SelectedValue;
				cmd.Parameters["@price"].Value = nudPrice.Value;
				cmd.Parameters["@notes"].Value = txtNotes.Text;
				//mở kết nối
				conn.Open();
				int numRowAffected = cmd.ExecuteNonQuery();

				//Thông báo kết quả
				if (numRowAffected > 0)
				{
					string foodID = cmd.Parameters["@id"].Value.ToString();
					MessageBox.Show("Successfully adding new food, foodID = "+foodID, "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Adding food failed");
				}

				//đóng kết nối
				conn.Close();
				conn.Dispose();
			}
			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}

		public void DisplayFoodInfo(DataRowView rowView)
		{
			try
			{
				txtFoodID.Text = rowView["ID"].ToString();
				txtName.Text = rowView["Name"].ToString();
				txtUnit.Text = rowView["Unit"].ToString();
				txtNotes.Text = rowView["Notes"].ToString();
				//nudPrice. = rowView["Price"]

				cbbCategoryName.SelectedIndex = -1;

				//Chọn nhóm món ăn tương ứng 
				for(int index = 0;index<cbbCategoryName.Items.Count;index++)
				{
					DataRowView cat = cbbCategoryName.Items[index] as DataRowView;
					if(cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
					{
						cbbCategoryName.SelectedIndex = index;
						break;
					}
				}
			}
			catch(Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
				this.Close();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				//Tạo đối tượng kết nối
				string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
				SqlConnection conn = new SqlConnection(connectionString);
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXEC [UpdateFood] @id ,@Name ,@Unit ,@FoodCategoryID ,@Price ,@Notes ";

				//thêm tham số vào đối tượng command
				cmd.Parameters.Add("@id", SqlDbType.Int);
				cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
				cmd.Parameters.Add("@price", SqlDbType.Int);
				cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				// Truyền giá trị vào thủ tục tham số
				cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
				cmd.Parameters["@name"].Value = txtName.Text;
				cmd.Parameters["@unit"].Value = txtUnit.Text;
				cmd.Parameters["@foodCategoryId"].Value = cbbCategoryName.SelectedValue;
				cmd.Parameters["@price"].Value = nudPrice.Value;
				cmd.Parameters["@notes"].Value = txtNotes.Text;
				
				//mở kết nối
				conn.Open();
				int numRowAffected = cmd.ExecuteNonQuery();

				//Thông báo kết quả
				if (numRowAffected > 0)
				{
					
					MessageBox.Show("Successfully updating food", "Message");

					this.ResetText();
				}
				else
				{
					MessageBox.Show("Updating food failed");
				}

				//đóng kết nối
				conn.Close();
				conn.Dispose();
			}
			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			AddNewCategoryFood addNewFC = new AddNewCategoryFood();
			addNewFC.ShowDialog();
			if(addNewFC.DialogResult == DialogResult.OK)
			{
				InitValue();
			}
		}
	}
}
