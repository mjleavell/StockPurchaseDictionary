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
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("NKE", "Nike");
            stocks.Add("AAPL", "Apple");
            stocks.Add("TWTR", "Twitter");
            stocks.Add("SNAP", "Snapchat");
            stocks.Add("GOOGL", "Google");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "NKE", shares: 50, price:86.87));
            purchases.Add((ticker: "NKE", shares: 123, price: 86.87));
            purchases.Add((ticker: "NKE", shares: 13, price: 86.87));
            purchases.Add((ticker: "AAPL", shares: 414, price: 183.73));
            purchases.Add((ticker: "AAPL", shares: 63, price: 183.73));
            purchases.Add((ticker: "AAPL", shares: 27, price: 183.73));
            purchases.Add((ticker: "TWTR", shares: 223, price: 31.03));
            purchases.Add((ticker: "TWTR", shares: 77, price: 31.03));
            purchases.Add((ticker: "SNAP", shares: 90, price: 11.28));
            purchases.Add((ticker: "SNAP", shares: 303, price: 11.28));
            purchases.Add((ticker: "GOOGL", shares: 19, price: 1192.53));
            purchases.Add((ticker: "GOOGL", shares: 36, price: 1192.53));
        }
    }
}
