using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Group 9: Ana Isakov, Chinmay Mashruwala, Jashandeep Singh
 * PROG2070 Assignment 2
 */

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
            if ((prodID >= 5 && prodID <= 50000) && (ItemPrice >= 5 && ItemPrice <= 5000) && (StockAmount >= 5 && StockAmount <= 500000))
            {
                ProdID = prodID;
                ProdName = prodName;
                ItemPrice = itemPrice;
                StockAmount = stockAmount;
            }
        }

        public void IncreaseStock(int amount)
        {
            if (StockAmount + amount <= 500000)
            {
                StockAmount += amount;
            }
        }
        public void DecreaseStock(int amount)
        {
            if (StockAmount - amount >= 5)
            {
                StockAmount -= amount;
            }
        }
    }
}
