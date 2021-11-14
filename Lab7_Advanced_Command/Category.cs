using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class Category
	{
		public Category(int id,string name)
		{
			this.Id = id;
			this.Name = name;
		}
		public Category(DataRow row)
		{
			this.Id = (int)row["ID"];
			this.Name = row["Name"].ToString();
		}
		private string name;
		private int id;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
	}
}
