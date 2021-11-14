using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class MenuDAO
	{
		private static MenuDAO instance;
		public static MenuDAO Instance
		{
			get { if (instance == null) instance = new MenuDAO();return MenuDAO.instance; }
			private set { MenuDAO.instance = value; }
		}

		private MenuDAO() { }
		public List<Menu> GetListMenuByTable(int id)
		{
			List<Menu> listMenu = new List<Menu>();

			string query = "select f.Name,bi.Quantity,f.Price,f.Price*bi.Quantity as totalPrice from dbo.BillDetails as bi, dbo.Bills as b, dbo.Food as f where bi.BillID = b.ID and bi.FoodID = f.ID and b.TableID = " + id;
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach(DataRow item in data.Rows)
			{
				Menu menu = new Menu(item);
				listMenu.Add(menu);
			}
			return listMenu;
		}
	}
}
