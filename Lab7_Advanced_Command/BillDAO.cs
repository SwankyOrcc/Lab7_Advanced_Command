using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class BillDAO
	{
		private static BillDAO instance;
		public static BillDAO Instance
		{
			get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
			private set { BillDAO.instance = value; }
		}

		private BillDAO()
		{

		}

		public int GetuncheckBillIDByTableID(int id)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery("select ID,[Name],TableID,Amount,Discount,Tax,[Status],CheckoutDate,Account from dbo.Bills where TableID = " + id + " and Status = 1");
			if(data.Rows.Count>0)
			{
				Bill bill = new Bill(data.Rows[0]);
				return bill.Id;
			}
			return -1;
		}

		public void InsertBill(int id)
		{
			DataProvider.Instance.ExecuteNonQuery("exec usp_insertBill @idTable",new object[] {id});
		}

		public int GetMaxIDBill()
		{
			try
			{
				return (int)DataProvider.Instance.ExecuteScalar("");
			}
			catch
			{
				return 1;
			}
		}
	}
}
