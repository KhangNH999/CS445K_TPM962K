using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Menu
    {
        private string food;
        private int count;
        private double price;
        private double totalprice;
        public string Food { get => food; set => food = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
        public double Totalprice { get => totalprice; set => totalprice = value; }
        public Menu(string food, int count, double price, double total)
        {
            this.Food = food;
            this.Count = count;
            this.Price = price;
            this.Totalprice = total;
        }
        public Menu(DataRow row)
        {
            this.Food = row["tendouong"].ToString();
            this.Count = (int)row["soluong"];
            this.Price = (double)row["giatien"];
            this.Totalprice = (double)row["totalPrice"];
        }
    }
}
