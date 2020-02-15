using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Kości
{
    class Rozgrywka
    {
        Gra gra;
        Losowanie losowanie;
        Figury figury;
        Gracz gracz1;
        Gracz gracz2;

        private int pozostałeG1, pozostałeG2, wynikG1 = 0, wynikG2 = 0;



        public Rozgrywka(Gra gra, Losowanie losowanie, Figury figury, Gracz gracz1, Gracz gracz2)
        {
            this.gra = gra;
            this.losowanie = losowanie;
            this.figury = figury;
            this.gracz1 = gracz1;
            this.gracz2 = gracz2;
        }




        public void WyświetlWyniki(Gracz gracz)
        {
            if (gracz.Imie == gracz1.Imie)
            {
                if (gra.LabelJedynkiG1.Enabled)                                         // każdy label ma inną nazwę dlatego nie użyłem pętli
                    gra.LabelJedynkiG1.Text = figury.SprawdzPodstawowe(1).ToString();

                if (gra.LabelDwójkiG1.Enabled)
                    gra.LabelDwójkiG1.Text = figury.SprawdzPodstawowe(2).ToString();

                if (gra.LabelTrójkiG1.Enabled)
                    gra.LabelTrójkiG1.Text = figury.SprawdzPodstawowe(3).ToString();

                if (gra.LabelCzwórkiG1.Enabled)
                    gra.LabelCzwórkiG1.Text = figury.SprawdzPodstawowe(4).ToString();

                if (gra.LabelPiątkiG1.Enabled)
                    gra.LabelPiątkiG1.Text = figury.SprawdzPodstawowe(5).ToString();

                if (gra.LabelSzóstkiG1.Enabled)
                    gra.LabelSzóstkiG1.Text = figury.SprawdzPodstawowe(6).ToString();

                if (gra.LabelTrójkaG1.Enabled)
                    gra.LabelTrójkaG1.Text = figury.Trójka().ToString();

                if (gra.LabelKaretaG1.Enabled)
                    gra.LabelKaretaG1.Text = figury.Kareta().ToString();

                if (gra.LabelFullG1.Enabled)
                    gra.LabelFullG1.Text = figury.Full().ToString();

                if (gra.LabelMałyStritG1.Enabled)
                    gra.LabelMałyStritG1.Text = figury.MałyStrit().ToString();

                if (gra.LabelDużyStritG1.Enabled)
                    gra.LabelDużyStritG1.Text = figury.DużyStrit().ToString();

                if (gra.LabelGenerałG1.Enabled)
                    gra.LabelGenerałG1.Text = figury.Generał().ToString();

                if (gra.LabelSzansaG1.Enabled)
                    gra.LabelSzansaG1.Text = figury.Szansa().ToString();

            }
            else
            {
                if (gra.LabelJedynkiG2.Enabled)
                    gra.LabelJedynkiG2.Text = figury.SprawdzPodstawowe(1).ToString();

                if (gra.LabelDwójkiG2.Enabled)
                    gra.LabelDwójkiG2.Text = figury.SprawdzPodstawowe(2).ToString();

                if (gra.LabelTrójkiG2.Enabled)
                    gra.LabelTrójkiG2.Text = figury.SprawdzPodstawowe(3).ToString();

                if (gra.LabelCzwórkiG2.Enabled)
                    gra.LabelCzwórkiG2.Text = figury.SprawdzPodstawowe(4).ToString();

                if (gra.LabelPiątkiG2.Enabled)
                    gra.LabelPiątkiG2.Text = figury.SprawdzPodstawowe(5).ToString();

                if (gra.LabelSzóstkiG2.Enabled)
                    gra.LabelSzóstkiG2.Text = figury.SprawdzPodstawowe(6).ToString();

                if (gra.LabelTrójkaG2.Enabled)
                    gra.LabelTrójkaG2.Text = figury.Trójka().ToString();

                if (gra.LabelKaretaG2.Enabled)
                    gra.LabelKaretaG2.Text = figury.Kareta().ToString();

                if (gra.LabelFullG2.Enabled)
                    gra.LabelFullG2.Text = figury.Full().ToString();

                if (gra.LabelMałyStritG2.Enabled)
                    gra.LabelMałyStritG2.Text = figury.MałyStrit().ToString();

                if (gra.LabelDużyStritG2.Enabled)
                    gra.LabelDużyStritG2.Text = figury.DużyStrit().ToString();

                if (gra.LabelGenerałG2.Enabled)
                    gra.LabelGenerałG2.Text = figury.Generał().ToString();

                if (gra.LabelSzansaG2.Enabled)
                    gra.LabelSzansaG2.Text = figury.Szansa().ToString();
            }
        }



        public void GrupowanieLabeliG1()        // Grupowanie labeli w liście dla gracza pierwszego
        {
            gra.ListaLabeliG1.Add(gra.LabelJedynkiG1);
            gra.ListaLabeliG1.Add(gra.LabelDwójkiG1);
            gra.ListaLabeliG1.Add(gra.LabelTrójkiG1);
            gra.ListaLabeliG1.Add(gra.LabelCzwórkiG1);
            gra.ListaLabeliG1.Add(gra.LabelPiątkiG1);
            gra.ListaLabeliG1.Add(gra.LabelSzóstkiG1);
            gra.ListaLabeliG1.Add(gra.LabelTrójkaG1);
            gra.ListaLabeliG1.Add(gra.LabelKaretaG1);
            gra.ListaLabeliG1.Add(gra.LabelFullG1);
            gra.ListaLabeliG1.Add(gra.LabelMałyStritG1);
            gra.ListaLabeliG1.Add(gra.LabelDużyStritG1);
            gra.ListaLabeliG1.Add(gra.LabelGenerałG1);
            gra.ListaLabeliG1.Add(gra.LabelSzansaG1);
        }


        public void GrupowanieLabeliG2()        // Grupowanie labeli w liście dla gracza drugiego
        {
            gra.ListaLabeliG2.Add(gra.LabelJedynkiG2);
            gra.ListaLabeliG2.Add(gra.LabelDwójkiG2);
            gra.ListaLabeliG2.Add(gra.LabelTrójkiG2);
            gra.ListaLabeliG2.Add(gra.LabelCzwórkiG2);
            gra.ListaLabeliG2.Add(gra.LabelPiątkiG2);
            gra.ListaLabeliG2.Add(gra.LabelSzóstkiG2);
            gra.ListaLabeliG2.Add(gra.LabelTrójkaG2);
            gra.ListaLabeliG2.Add(gra.LabelKaretaG2);
            gra.ListaLabeliG2.Add(gra.LabelFullG2);
            gra.ListaLabeliG2.Add(gra.LabelMałyStritG2);
            gra.ListaLabeliG2.Add(gra.LabelDużyStritG2);
            gra.ListaLabeliG2.Add(gra.LabelGenerałG2);
            gra.ListaLabeliG2.Add(gra.LabelSzansaG2);
        }



        public void ZaznaczKość(PictureBox pbKość, PictureBox pbKośćAktywna)
        {
            pbKość.BorderStyle = BorderStyle.Fixed3D;
            pbKośćAktywna.BackColor = System.Drawing.Color.Lime;
        }




        public void OdznaczKość(PictureBox pbKość, PictureBox pbKośćAktywna)
        {
            pbKość.BorderStyle = BorderStyle.None;
            pbKośćAktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
        }




        public bool SprawdźKoniec()
        {
            pozostałeG1 = 0;
            pozostałeG2 = 0;

            foreach (Label lpom in gra.ListaLabeliG1)
                if (lpom.Enabled)
                    pozostałeG1++;

            foreach (Label lpom in gra.ListaLabeliG2)
                if (lpom.Enabled)
                    pozostałeG2++;

            if (pozostałeG1 == 0 && pozostałeG2 == 0)
                return true;
            else
                return false;
        }




        public void ResetujKości()
        {
            for (int i = 0; i < gra.Kość.Count(); i++)
                gra.Kość[i] = true;

            gra.PbKosc1.BorderStyle = BorderStyle.None;
            gra.PbKosc2.BorderStyle = BorderStyle.None;
            gra.PbKosc3.BorderStyle = BorderStyle.None;
            gra.PbKosc4.BorderStyle = BorderStyle.None;
            gra.PbKosc5.BorderStyle = BorderStyle.None;

            gra.PbKosc1.Image = null;
            gra.PbKosc2.Image = null;
            gra.PbKosc3.Image = null;
            gra.PbKosc4.Image = null;
            gra.PbKosc5.Image = null;

            gra.PbKość1Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            gra.PbKość2Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            gra.PbKość3Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            gra.PbKość4Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            gra.PbKość5Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);

            gra.PbRzut1.BackColor = System.Drawing.Color.Lime;
            gra.PbRzut2.BackColor = System.Drawing.Color.Lime;
            gra.PbRzut3.BackColor = System.Drawing.Color.Lime;

            foreach (Label lpom in gra.ListaLabeliG1)       // usuwanie podglądu wyników z poprzedniego rzutu
                if (lpom.Enabled == true)
                    lpom.Text = "";

            foreach (Label lpom in gra.ListaLabeliG2)       
                if (lpom.Enabled == true)
                    lpom.Text = "";
        }
        


        public void ZmianaGracza(Gracz gracz)
        {
            SumujWynik();
            ResetujKości();

            if (SprawdźKoniec())
            {
                KoniecGry();
                gra.Licznik = 3;
            }
            else
            {
                if (gracz.Imie == gracz1.Imie)
                {
                    gra.LabelG1aktywny.Text = "";
                    gra.LabelG2aktywny.Text = "*";
                    gra.LabelGracz2.ForeColor = Color.Red;
                    gra.LabelGracz1.ForeColor = Color.Black;
                    gra.AktualnyGracz = gracz2;
                }
                else
                {
                    gra.LabelG2aktywny.Text = "";
                    gra.LabelG1aktywny.Text = "*";
                    gra.LabelGracz1.ForeColor = Color.Red;
                    gra.LabelGracz2.ForeColor = Color.Black;
                    gra.AktualnyGracz = gracz1;
                }

                ZmianaPunktów(gracz);
            }
        }




        public void ZmianaPunktów(Gracz gracz)
        {
            if (gra.AktualnyGracz == gracz1)
            {
                foreach (Label lpom in gra.ListaLabeliG2)       // Jeśli ruch ma gracz pierwszy to podgląd wyników przeciwnika znika
                    if (lpom.Enabled == true)
                        lpom.Visible = false;

                foreach (Label lpom in gra.ListaLabeliG1)       // Przy ponownym ruchu gracza pierwszego podgląd jego wyników powraca
                    if (lpom.Enabled == true)
                        lpom.Visible = true;
            }
            else
            {
                foreach (Label lpom in gra.ListaLabeliG1)       // Jeśli ruch ma gracz drugi to podgląd wyników przeciwnika znika
                    if (lpom.Enabled == true)
                        lpom.Visible = false;

                foreach (Label lpom in gra.ListaLabeliG2)       // Przy ponownym ruchu gracza drugiego podgląd jego wyników powraca
                    if (lpom.Enabled == true)
                        lpom.Visible = true;
            }
        }





        public void KoniecGry()
        {
            gra.LabelKoniecGry.Text = "KONIEC GRY!";

            if (wynikG1 > wynikG2)
                gra.LabelKoniecGry2.Text = "Wygrał(a) " + gracz1.Imie + " !";
            else
                if (wynikG1 < wynikG2)
                    gra.LabelKoniecGry2.Text = "Wygrał(a) " + gracz2.Imie + " !";
                else
                    gra.LabelKoniecGry2.Text = "REMIS !";

            gra.BtnRzut.Visible = false;
            gra.PbKosc1.Visible = false;
            gra.PbKosc2.Visible = false;
            gra.PbKosc3.Visible = false;
            gra.PbKosc4.Visible = false;
            gra.PbKosc5.Visible = false;
        }





        public void IlośćRzutów()
        {
            if (gra.Licznik == 0)
            {
                gra.PbRzut1.BackColor = System.Drawing.Color.Lime;
                gra.PbRzut2.BackColor = System.Drawing.Color.Lime;
                gra.PbRzut3.BackColor = System.Drawing.Color.Lime;
            }

            if (gra.Licznik == 1)
                gra.PbRzut1.BackColor = System.Drawing.Color.Red;

            if (gra.Licznik == 2)
                gra.PbRzut2.BackColor = System.Drawing.Color.Red;

            if (gra.Licznik == 3)
                gra.PbRzut3.BackColor = System.Drawing.Color.Red;

        }




        public void SumujWynik()
        {
            wynikG1 = 0;
            wynikG2 = 0;

            foreach (Label lpom in gra.ListaLabeliG1)
                if (!(lpom.Enabled))
                {
                    wynikG1 += Convert.ToInt32(lpom.Text);
                    gra.LabelWynikG1.Text = wynikG1.ToString();
                }

            foreach (Label lpom in gra.ListaLabeliG2)
                if (!(lpom.Enabled))
                {
                    wynikG2 += Convert.ToInt32(lpom.Text);
                    gra.LabelWynikG2.Text = wynikG2.ToString();
                }
        }


    }
}
