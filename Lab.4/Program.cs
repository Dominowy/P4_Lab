using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using Lab._4.NORTHWND;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Threading;
using System.Data.SqlClient;

namespace Lab._4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Osobas.Add(new Klient() {Imie = "Dominik", Nazwisko = "Katana", NrRejestracyjny = "SZY9V84", NrTelefonu = "765900300"});
            tph.Osobas.Add(new Pracownik() {Imie = "Paweł", Nazwisko = "Kowalski", DataZatrudnienia = DateTime.Now, DataZwolnienia = null});
            tph.SaveChanges();

            var tpt = new TPTContext();
            tpt.Osobas.Add(new Klient() {Imie = "Dominik", Nazwisko = "Katana", NrRejestracyjny = "SZY9V84", NrTelefonu = "765900300"});
            tpt.Osobas.Add(new Pracownik() {Imie = "Paweł", Nazwisko = "Kowalski", DataZatrudnienia = DateTime.Now, DataZwolnienia = null});
            tpt.SaveChanges();
            
            Console.Read();
        }
    }
}