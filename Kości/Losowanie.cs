using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kości
{
    class Losowanie
    {
        private Random rzut = new Random();
        private Gra gra;
        private int[] kosc = new int[5];


        public Losowanie(Gra gra)
        {
            this.gra = gra;
        }




        public int[] Kosc
        {
            get { return this.kosc; }
            set { this.kosc = value; }
        }




        public void Losuj()
        {
            for (int i = 0; i < kosc.Count(); i++)
                if (gra.Kość[i])
                    kosc[i] = rzut.Next(1, 7);
        }
    }
}
