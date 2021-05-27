using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using Lab._4.NORTHWIND;

namespace Lab._4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ctx = new Model1();
            foreach(var item in ctx.Customers)
            {
                Console.WriteLine(item.CustomerID);
            }

            Console.Read();
        }
    }
}