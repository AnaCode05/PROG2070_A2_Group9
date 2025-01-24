using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_A2_Group9
{
    public class Product
    {
        // Product Attributes
        private int ProdID { get; set; }
        public string ProdName { get; set; }
        public double ItemPrice { get; set; }
        public int StockAmount { get; set; }

        /// <summary>
        /// Product Constructor with 4 attributes
        /// </summary>
        /// <param name="prodID"></param>
        /// <param name="prodName"></param>
        /// <param name="itemPrice"></param>
        /// <param name="stockAmount"></param>
        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public void IncreaseStock(int amount)
        {
            StockAmount += amount;
        }
        public void DecreaseStock(int amount)
        {
            StockAmount -= amount;
        }
    }
}
