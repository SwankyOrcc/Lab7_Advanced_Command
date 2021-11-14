using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class BillInFo
	{
		public BillInFo(int id,int invoiceID,int billID, int foodID, int quantity)
		{
			this.ID = id;
			this.InvoiceID = invoiceID;
			this.BillID = billID;
			this.FoodID = foodID;
			this.Quantity = quantity;
		}

		public BillInFo(DataRow row)
		{
			this.ID = (int)row["ID"];
			this.InvoiceID = (int)row["InvoiceID"];
			this.BillID = (int)row["BillID"];
			this.FoodID = (int)row["FoodID"];
			this.Quantity = (int)row["Quantity"];
		}
		private int quantity;
		private int foodID;
		private int billID;
		private int invoiceID;
		private int iD;

		public int ID { get => iD; set => iD = value; }
		public int InvoiceID { get => invoiceID; set => invoiceID = value; }
		public int BillID { get => billID; set => billID = value; }
		public int FoodID { get => foodID; set => foodID = value; }
		public int Quantity { get => quantity; set => quantity = value; }
	}
}
