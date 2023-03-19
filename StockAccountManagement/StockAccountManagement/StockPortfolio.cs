using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class StockPortfolio
    {
        public static List<Stock> StockList = new List<Stock>();//create a list of stock
        public static void AddStock()
        {
            Stock stock = new Stock(); //create stock object to initilise data
            Console.WriteLine("Enter Your StockName Name : ");
            stock.stockName = Console.ReadLine(); //take input for stock name
            Console.WriteLine("Enter Your Stock Quantity : ");
            stock.stockQuantity = Convert.ToInt32(Console.ReadLine()); //take input for stock quantity
            Console.WriteLine("Enter Your Stock Price : ");
            stock.stockPrice = Convert.ToDouble(Console.ReadLine()); //take input for stock price
            StockList.Add(stock); //add the object to stocklist

        }
        public static void Display()
        {
            //this method used for display the stock report with total amount of stock
            if (StockList.Count == 0)
            {
                Console.WriteLine("Sorry....!No Stock Present....!");
            }
            else
            {
                foreach (var stockllist in StockList) //iterate for each stock inserted in list
                {
                    Console.WriteLine("Stock Report Of {0}", stockllist.stockName);

                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("First Name : " + stockllist.stockName + "\nLast Name : " + stockllist.stockQuantity + "\naddress : " + stockllist.stockPrice);
                    double totalStockAmount = (stockllist.stockPrice) * (stockllist.stockQuantity);
                    Console.WriteLine("Total Amount For {0} Stock Is:-{1}", stockllist.stockName, totalStockAmount);
                    Console.WriteLine("-----------------------------");
                }
            }
            
        }
    }
}
