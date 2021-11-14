using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class Table
	{
		public Table(int id,string name, int status,int capacity)
		{
			this.ID = id;
			this.Name = name;
			this.Status = status;
			this.Capacity = capacity;
		}
		public Table(DataRow row)
		{
			this.ID = (int)row["id"];
			this.Name = row["name"].ToString();
			this.Status = (int)row["status"];
			this.Capacity = (int)row["capacity"];
		}
		private int status;
		private string name;
		private int capacity;
		private int iD;
		

		public int Status { get => status; set => status = value; }
		public string Name { get => name; set => name = value; }
		public int Capacity { get => capacity; set => capacity = value; }
		public int ID { get => iD; set => iD = value; }
	}
}
