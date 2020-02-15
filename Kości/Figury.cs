using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kości
{
    class Figury
    {
        private Gra gra;
        private Losowanie losowanie;
        private int podstawowe, trójka, kareta, full, małyStrit, dużyStrit, generał, szansa;


        public Figury(Gra gra, Losowanie losowanie)
        {
            this.gra = gra;
            this.losowanie = losowanie;
        }




        public int SprawdzPodstawowe(int numer)
        {
            podstawowe = 0;

            for (int i = 0; i < losowanie.Kosc.Count(); i++)
                if (losowanie.Kosc[i] == numer)
                    podstawowe += numer;

            return podstawowe;
        }




        public int Trójka()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            trójka = 0;

            for (int i = 0; i < losowanie.Kosc.Count(); i++)
            {
                if (losowanie.Kosc[i] == 1)
                    a++;
                if (losowanie.Kosc[i] == 2)
                    b++;
                if (losowanie.Kosc[i] == 3)
                    c++;
                if (losowanie.Kosc[i] == 4)
                    d++;
                if (losowanie.Kosc[i] == 5)
                    e++;
                if (losowanie.Kosc[i] == 6)
                    f++;
            }

            if ((a >= 3) || (b >= 3) || (c >= 3) || (d >= 3) || (e >= 3) || (f >= 3))
            {
                for (int i = 0; i < losowanie.Kosc.Count(); i++)
                    trójka += losowanie.Kosc[i];
            }


            return trójka;
        }




        public int Kareta()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            kareta = 0;


            for (int i = 0; i < losowanie.Kosc.Count(); i++)
            {
                if (losowanie.Kosc[i] == 1)
                    a++;
                if (losowanie.Kosc[i] == 2)
                    b++;
                if (losowanie.Kosc[i] == 3)
                    c++;
                if (losowanie.Kosc[i] == 4)
                    d++;
                if (losowanie.Kosc[i] == 5)
                    e++;
                if (losowanie.Kosc[i] == 6)
                    f++;
            }


            if ((a >= 4) || (b >= 4) || (c >= 4) || (d >= 4) || (e >= 4) || (f >= 4))
            {
                for (int i = 0; i < losowanie.Kosc.Count(); i++)
                    kareta += losowanie.Kosc[i];
            }


            return kareta;
        }




        public int Full()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            full = 0;

            for (int i = 0; i < losowanie.Kosc.Count(); i++)
            {
                if (losowanie.Kosc[i] == 1)
                    a++;
                if (losowanie.Kosc[i] == 2)
                    b++;
                if (losowanie.Kosc[i] == 3)
                    c++;
                if (losowanie.Kosc[i] == 4)
                    d++;
                if (losowanie.Kosc[i] == 5)
                    e++;
                if (losowanie.Kosc[i] == 6)
                    f++;
            }


            if((a == 3) && (b == 2) ||
               (a == 3) && (c == 2) ||
               (a == 3) && (d == 2) ||
               (a == 3) && (e == 2) ||
               (a == 3) && (f == 2) ||
                
               (b == 3) && (a == 2) ||
               (b == 3) && (c == 2) ||
               (b == 3) && (d == 2) ||
               (b == 3) && (e == 2) ||
               (b == 3) && (f == 2) ||
                
               (c == 3) && (a == 2) ||
               (c == 3) && (b == 2) ||
               (c == 3) && (d == 2) ||
               (c == 3) && (e == 2) ||
               (c == 3) && (f == 2) ||
               
               (d == 3) && (a == 2) ||
               (d == 3) && (b == 2) ||
               (d == 3) && (c == 2) ||
               (d == 3) && (e == 2) ||
               (d == 3) && (f == 2) ||
               
               (e == 3) && (a == 2) ||
               (e == 3) && (b == 2) ||
               (e == 3) && (c == 2) ||
               (e == 3) && (d == 2) ||
               (e == 3) && (f == 2) ||
                
               (f == 3) && (a == 2) ||
               (f == 3) && (b == 2) ||
               (f == 3) && (c == 2) ||
               (f == 3) && (d == 2) ||
               (f == 3) && (e == 2))
            {
                full = 25;
            }



            return full;
        }




        public int MałyStrit()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            małyStrit = 0;


            for (int i = 0; i < losowanie.Kosc.Count(); i++)
            {
                if (losowanie.Kosc[i] == 1)
                    a = 0;
                if (losowanie.Kosc[i] == 2)
                    b = 1;
                if (losowanie.Kosc[i] == 3)
                    c = 2;
                if (losowanie.Kosc[i] == 4)
                    d = 3;
                if (losowanie.Kosc[i] == 5)
                    e = 4;
                if (losowanie.Kosc[i] == 6)
                    f = 5;
            }


            if (((a == 0) && (b == 1) && (c == 2) && (d == 3)) ||
               ((b == 1) && (c == 2) && (d == 3) && (e == 4)) ||
               ((c == 2) && (d == 3) && (e == 4) && (f == 5)))
            {
                małyStrit = 30;
            }


            return małyStrit;
        }




        public int DużyStrit()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            dużyStrit = 0;

            for (int i = 0; i < losowanie.Kosc.Count(); i++)
            {
                if (losowanie.Kosc[i] == 1)
                    a = 0;
                if (losowanie.Kosc[i] == 2)
                    b = 1;
                if (losowanie.Kosc[i] == 3)
                    c = 2;
                if (losowanie.Kosc[i] == 4)
                    d = 3;
                if (losowanie.Kosc[i] == 5)
                    e = 4;
                if (losowanie.Kosc[i] == 6)
                    f = 5;
            }


            if (((a == 0) && (b == 1) && (c == 2) && (d == 3) && (e == 4)) ||
               ((b == 1) && (c == 2) && (d == 3) && (e == 4) && (f == 5)))
            {
                dużyStrit = 40;
            }

            return dużyStrit;
        }




        public int Generał()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            generał = 0;

            for (int i = 0; i < losowanie.Kosc.Count(); i++)
            {
                if (losowanie.Kosc[i] == 1)
                    a++;
                if (losowanie.Kosc[i] == 2)
                    b++;
                if (losowanie.Kosc[i] == 3)
                    c++;
                if (losowanie.Kosc[i] == 4)
                    d++;
                if (losowanie.Kosc[i] == 5)
                    e++;
                if (losowanie.Kosc[i] == 6)
                    f++;
            }


            if ((a == 5) || (b == 5) || (c == 5) || (d == 5) || (e == 5) || (f == 5))
            {
                generał = 50;
            }
            return generał;
        }




        public int Szansa()
        {
            szansa = 0;

            for (int i = 0; i < losowanie.Kosc.Count(); i++)
                szansa += losowanie.Kosc[i];

            return szansa;
        }
    }
}
