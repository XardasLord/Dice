using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kości
{
    public class Gracz
    {
        private string imie;


        public Gracz() { }


        public Gracz(string imie)
        {
            this.imie = imie;
        }



        public string Imie
        {
            get { return this.imie; }
        }
    }
}
