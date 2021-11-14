using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Advanced_Command
{
	public class Menu
	{
		public Menu(string foodname, int quantity,float price,float totalprice = 0)
		{
			this.FoodName = foodname;
			this.Quantity = quantity;
			this.Price = price;
			this.Totalprice = totalprice;
		
		}
		public Menu(DataRow row)
		{
			this.FoodName = row["Name"].ToString();
			this.Quantity = (int)row["Quantity"];
			this.Price = (float)Convert.ToDouble(row["Price"].ToString());
			this.Totalprice = (float)Convert.ToDouble(row["totalPrice"].ToString());

		}
		private float totalprice;
		private float price;
		private int quantity;
		private string foodName;

		public string FoodName { get => foodName; set => foodName = value; }
		public int Quantity { get => quantity; set => quantity = value; }
		public float Price { get => price; set => price = value; }
		public float Totalprice { get => totalprice; set => totalprice = value; }
	}
}
