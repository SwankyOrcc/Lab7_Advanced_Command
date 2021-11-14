using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class Bill
	{
		public Bill(int id,string name,int tableid,int amount,float discount,float tax,DateTime? dateCheckOut,int status,string account)
		{
			this.Id = id;
			this.Name = name;
			this.TableID = tableid;
			this.Amount = amount;
			this.Discount = discount;
			this.Tax = tax;
			this.DateCheckOut = dateCheckOut;
			this.status = status;
			this.Account = account;
		}

		public Bill(DataRow row)
		{
			this.Id = (int)row["id"];
			this.Name = row["Name"].ToString();
			this.TableID = (int)row["TableId"];
			this.Amount = (int)row["Amount"];
			this.Discount = (int)row["Discount"];
			this.Tax = (int)row["Tax"];

			var dateCheckoutTemp = row["DateCheckOut"];
			if(dateCheckoutTemp.ToString() != "")
			this.DateCheckOut = (DateTime?)dateCheckoutTemp;

			this.status = (int)row["Status"];
			this.Account = row["Account"].ToString();
		}
		private string account;
		private float tax;
		private float discount;
		private int amount;
		private int tableID;
		private string name;
		private int status;
		private DateTime? dateCheckOut;
		private DateTime? dateCheckIn;
		private int id;

		public int Id { get => id; set => id = value; }
		public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
		public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
		public int Status { get => status; set => status = value; }
		public string Name { get => name; set => name = value; }
		public int TableID { get => tableID; set => tableID = value; }
		public int Amount { get => amount; set => amount = value; }
		public float Discount { get => discount; set => discount = value; }
		public float Tax { get => tax; set => tax = value; }
		public string Account { get => account; set => account = value; }
	}
}
