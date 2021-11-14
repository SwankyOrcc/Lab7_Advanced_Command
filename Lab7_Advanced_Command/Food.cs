using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class Food
	{
		public Food(int id,string name,string unit,int foodcategoryID,int price,string notes)
		{
			this.Id = id;
			this.Name = name;
			this.Unit = unit;
			this.FoodCategoryID = foodcategoryID;
			this.Price = price;
			this.Notes = notes;
		}
		public Food(DataRow row)
		{
			this.Id = (int)row["ID"];
			this.Name = row["Name"].ToString();
			this.Unit = row["Unit"].ToString();
			this.FoodCategoryID = (int)row["FoodCategoryID"];
			this.Price = (int)row["Price"];
			this.Notes = row["Notes"].ToString();
		}
		private string notes;
		private int price;
		private int foodCategoryID;
		private string unit;
		private string name;
		private int id;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Unit { get => unit; set => unit = value; }
		public int FoodCategoryID { get => foodCategoryID; set => foodCategoryID = value; }
		public int Price { get => price; set => price = value; }
		public string Notes { get => notes; set => notes = value; }
	}
}
