using System;
using System.Linq;
using Lab._3.ScaffoldModel;
using System.Collections.Generic;

namespace Lab._3
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new NORTHWNDContext();

            db.Add(new MyUser() { });

            db.SaveChanges();
        }
    }
}