using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class BillInfoDAO
	{
		private static BillInfoDAO instance;
		public static BillInfoDAO Instance
		{
			get { if (instance == null) instance = new BillInfoDAO();return BillInfoDAO.instance; }
			private set { BillInfoDAO.instance = value; }
		}

		private BillInfoDAO() { }
		public List<BillInFo> GetlistBillInfo(int id)
		{
			List<BillInFo> listBillInfo = new List<BillInFo>();
			DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.BillDetails where BillID = "+id);
			foreach(DataRow item in data.Rows)
			{
				BillInFo info = new BillInFo(item);
				listBillInfo.Add(info);
			}

			return listBillInfo;
		}

		public void InsertBillInfo(int id)
		{
			DataProvider.Instance.ExecuteQuery("exec USP_InsertBillDetails");
		}
	}
}
