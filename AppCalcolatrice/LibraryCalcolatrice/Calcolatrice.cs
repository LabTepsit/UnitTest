using System;

namespace LibraryCalcolatrice
{
    public class Calcolatrice
    {
        public double Risultato { get; set; }
        public double Divisione(double v)
        {
            if(v==0)
           { throw new System.Exception("valoe non valido"); }
            Risultato /= v;
            return Risultato;
        }
    }
}
