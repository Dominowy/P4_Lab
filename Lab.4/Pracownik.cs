using System;

namespace Lab._4
{
    public class Pracownik : Osoba
    {
        public DateTime DataZatrudnienia { get; set; }

        public DateTime? DataZwolnienia { get; set; }
    }
}