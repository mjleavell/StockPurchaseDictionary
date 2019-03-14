using System;
using System.Collections.Generic;

namespace StockPurchaseDictionary
{
    class Program
    {
        /* ***************INSTRUCTIONS***************
        Create a total ownership report that computes the total value of each stock that you have purchased. This is the basic relational database
        join algorithm between two tables.

        Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name. - 
        The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
        Iterate over the purchases and update the valuation for each stock
        foreach ((string ticker, int shares, double price) purchase in purchases)
        {Does the company name key already exist in the report dictionary? 
        If it does, update the total valuation 
        If not, add the new key and set its value
        }
        */

        static void Main(string[] args)
        {
            Dictionary<string, string> Stocks = new Dictionary<string, string>();
            Stocks.Add("NKE", "Nike");
            Stocks.Add("AAPL", "Apple");
            Stocks.Add("GS", "Goldman Sachs");
            Stocks.Add("TWTR", "Twitter");
            Stocks.Add("SBUX", "Starbucks");
            Stocks.Add("XOM", "Exxon");
            Stocks.Add("SNAP", "Snapchat");
            Stocks.Add("GOOGL", "Google");
            Stocks.Add("TSLA", "Tesla");

        }
    }
}
