using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Kości
{
    public partial class Gra : Form
    {
        private Form1 form;
        private Losowanie losowanie;
        private Figury figury;
        private Rozgrywka rozgrywka;
        private Ustawienia ustawienia;
        private Gracz gracz1;
        private Gracz gracz2;
        private Gracz aktualnyGracz;


        private bool[] kość = {true, true, true, true, true};

        private int licznik = 0;
        private List<Label> listaLabeliG1;
        private List<Label> listaLabeliG2;




        public Gra(Form1 form)
        {
            this.form = form;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size; 
            listaLabeliG1 = new List<Label>();
            listaLabeliG2 = new List<Label>();

            losowanie = new Losowanie(this);
            figury = new Figury(this, this.losowanie);
            gracz1 = new Gracz(form.Imie1);
            gracz2 = new Gracz(form.Imie2);
            rozgrywka = new Rozgrywka(this, this.losowanie, this.figury, this.gracz1, this.gracz2);

            this.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);

            rozgrywka.GrupowanieLabeliG1();
            rozgrywka.GrupowanieLabeliG2();

            labelGracz1.Text = gracz1.Imie;
            labelGracz2.Text = gracz2.Imie;


            aktualnyGracz = gracz1;
            labelG1aktywny.Text = "*";
        }





        //////////////////////////////////////////////////// WŁAŚCIWOŚCI ////////////////////////////////////////////////////        
        #region 

        public bool[] Kość { get { return this.kość; } set { this.kość = value; } }

        public int Licznik
        {
            get { return this.licznik; }
            set { this.licznik = value; }
        }

        
         // WŁAŚCIWOŚCI LABELE DLA GRACZA PIERWSZEGO

        public Label LabelJedynkiG1 //{ get; set; }         // ZAPYTAĆ !
        {
            get { return this.labelJedynkiG1; }
            set { labelJedynkiG1 = value; }
        }

        public Label LabelDwójkiG1
        {
            get { return this.labelDwójkiG1; }
            set { labelDwójkiG1 = value; }
        }

        public Label LabelTrójkiG1
        {
            get { return this.labelTrójkiG1; }
            set { labelTrójkiG1 = value; }
        }

        public Label LabelCzwórkiG1
        {
            get { return this.labelCzwórkiG1; }
            set { labelCzwórkiG1 = value; }
        }

        public Label LabelPiątkiG1
        {
            get { return this.labelPiątkiG1; }
            set { labelPiątkiG1 = value; }
        }

        public Label LabelSzóstkiG1
        {
            get { return this.labelSzóstkiG1; }
            set { labelSzóstkiG1 = value; }
        }

        public Label LabelTrójkaG1
        {
            get { return this.labelTrójkaG1; }
            set { labelTrójkaG1 = value; }
        }

        public Label LabelKaretaG1
        {
            get { return this.labelKaretaG1; }
            set { labelKaretaG1 = value; }
        }

        public Label LabelFullG1
        {
            get { return this.labelFullG1; }
            set { labelFullG1 = value; }
        }

        public Label LabelMałyStritG1
        {
            get { return this.labelMałyStritG1; }
            set { labelMałyStritG1 = value; }
        }

        public Label LabelDużyStritG1
        {
            get { return this.labelDużyStritG1; }
            set { labelDużyStritG1 = value; }
        }

        public Label LabelGenerałG1
        {
            get { return this.labelGenerałG1; }
            set { labelGenerałG1 = value; }
        }

        public Label LabelSzansaG1
        {
            get { return this.labelSzansaG1; }
            set { labelSzansaG1 = value; }
        }

        public Label LabelG1aktywny
        {
            get { return this.labelG1aktywny; }
            set { this.labelG1aktywny = value; }
        }

        public Label LabelWynikG1
        {
            get { return this.labelWynikG1; }
            set { this.labelWynikG1 = value; }
        }

        public Label LabelGracz1
        {
            get { return this.labelGracz1; }
            set { this.labelGracz1 = value; }
        }

        
        // WŁAŚCIWOŚCI LABELE DLA GRACZA DRUGIEGO
        
        public Label LabelJedynkiG2
        {
            get { return this.labelJedynkiG2; }
            set { labelJedynkiG2 = value; }
        }

        public Label LabelDwójkiG2
        {
            get { return this.labelDwójkiG2; }
            set { labelDwójkiG2 = value; }
        }

        public Label LabelTrójkiG2
        {
            get { return this.labelTrójkiG2; }
            set { labelTrójkiG2 = value; }
        }

        public Label LabelCzwórkiG2
        {
            get { return this.labelCzwórkiG2; }
            set { labelCzwórkiG2 = value; }
        }

        public Label LabelPiątkiG2
        {
            get { return this.labelPiątkiG2; }
            set { labelPiątkiG2 = value; }
        }

        public Label LabelSzóstkiG2
        {
            get { return this.labelSzóstkiG2; }
            set { labelSzóstkiG2 = value; }
        }

        public Label LabelTrójkaG2
        {
            get { return this.labelTrójkaG2; }
            set { labelTrójkaG2 = value; }
        }

        public Label LabelKaretaG2
        {
            get { return this.labelKaretaG2; }
            set { labelKaretaG2 = value; }
        }

        public Label LabelFullG2
        {
            get { return this.labelFullG2; }
            set { labelFullG2 = value; }
        }

        public Label LabelMałyStritG2
        {
            get { return this.labelMałyStritG2; }
            set { labelMałyStritG2 = value; }
        }

        public Label LabelDużyStritG2
        {
            get { return this.labelDużyStritG2; }
            set { labelDużyStritG2 = value; }
        }

        public Label LabelGenerałG2
        {
            get { return this.labelGenerałG2; }
            set { labelGenerałG2 = value; }
        }

        public Label LabelSzansaG2
        {
            get { return this.labelSzansaG2; }
            set { labelSzansaG2 = value; }
        }

        public Label LabelG2aktywny
        {
            get { return this.labelG2aktywny; }
            set { this.labelG2aktywny = value; }
        }

        public Label LabelWynikG2
        {
            get { return this.labelWynikG2; }
            set { this.labelWynikG2 = value; }
        }

        public Label LabelGracz2
        {
            get { return this.labelGracz2; }
            set { this.labelGracz2 = value; }
        }


        // WŁAŚCIWOŚCI LISTY LABELI

        public List<Label> ListaLabeliG1
        {
            get { return this.listaLabeliG1; }
        }

        public List<Label> ListaLabeliG2
        {
            get { return this.listaLabeliG2; }
        }

        public Button BtnRzut
        {
            get { return this.btnRzut; }
        }

        public Gracz AktualnyGracz
        {
            get { return this.aktualnyGracz; }
            set { this.aktualnyGracz = value; }
        }

        public Label LabelKoniecGry
        {
            get { return this.labelKoniecGry; }
            set { this.labelKoniecGry = value; }
        }

        public Label LabelKoniecGry2
        {
            get { return this.labelKoniecGry2; }
            set { this.labelKoniecGry2 = value; }
        }

        

        // WŁAŚCIWOŚCI PICTUREBOX'ów

        public PictureBox PbKosc1
        {
            get { return this.pbKosc1; }
        }

        public PictureBox PbKosc2
        {
            get { return this.pbKosc2; }
        }

        public PictureBox PbKosc3
        {
            get { return this.pbKosc3; }
        }

        public PictureBox PbKosc4
        {
            get { return this.pbKosc4; }
        }

        public PictureBox PbKosc5
        {
            get { return this.pbKosc5; }
        }

        public PictureBox PbKość1Aktywna
        {
            get { return this.pbKość1Aktywna; }
            set { this.pbKość1Aktywna = value; }
        }

        public PictureBox PbKość2Aktywna
        {
            get { return this.pbKość2Aktywna; }
            set { this.pbKość2Aktywna = value; }
        }

        public PictureBox PbKość3Aktywna
        {
            get { return this.pbKość3Aktywna; }
            set { this.pbKość3Aktywna = value; }
        }

        public PictureBox PbKość4Aktywna
        {
            get { return this.pbKość4Aktywna; }
            set { this.pbKość4Aktywna = value; }
        }

        public PictureBox PbKość5Aktywna
        {
            get { return this.pbKość5Aktywna; }
            set { this.pbKość5Aktywna = value; }
        }

        public PictureBox PbRzut1
        {
            get { return this.pbRzut1; }
            set { this.pbRzut1 = value; }
        }

        public PictureBox PbRzut2
        {
            get { return this.pbRzut2; }
            set { this.pbRzut2 = value; }
        }

        public PictureBox PbRzut3
        {
            get { return this.pbRzut3; }
            set { this.pbRzut3 = value; }
        }

        #endregion






        //////////////////////////////////////////////////// BUTTON "RZUĆ" ////////////////////////////////////////////////////

        private void Rzut_Click(object sender, EventArgs e)
        {
            DźwiękKości(Ustawienia.dźwiękKości);
            losowanie.Losuj();
            licznik++;
            pbKosc1.Image = Properties.Resources.ResourceManager.GetObject(losowanie.Kosc[0].ToString()) as Image;
            pbKosc2.Image = Properties.Resources.ResourceManager.GetObject(losowanie.Kosc[1].ToString()) as Image;
            pbKosc3.Image = Properties.Resources.ResourceManager.GetObject(losowanie.Kosc[2].ToString()) as Image;
            pbKosc4.Image = Properties.Resources.ResourceManager.GetObject(losowanie.Kosc[3].ToString()) as Image;
            pbKosc5.Image = Properties.Resources.ResourceManager.GetObject(losowanie.Kosc[4].ToString()) as Image;

            rozgrywka.WyświetlWyniki(aktualnyGracz);
            rozgrywka.IlośćRzutów();


            if (licznik == 3)
                (sender as Button).Enabled = false;     // wyłącza button po trzecim rzucie tego samego gracza
        }





        //////////////////////////////////////////////////// EVENTY ODPOWIADAJĄCE ZA ZAZNACZANIE KOSTEK ////////////////////////////////////////////////////
        #region

        private void pbKosc1_MouseClick(object sender, MouseEventArgs e)
        {
            if (kość[0])
            {
                rozgrywka.ZaznaczKość(pbKosc1, pbKość1Aktywna);
                kość[0] = false;
            }
            else
            {
                rozgrywka.OdznaczKość(PbKosc1, pbKość1Aktywna);
                kość[0] = true;
            }
        }

        private void pbKosc2_MouseClick(object sender, MouseEventArgs e)
        {
            if (kość[1])
            {
                rozgrywka.ZaznaczKość(pbKosc2, pbKość2Aktywna);
                kość[1] = false;
            }
            else
            {
                rozgrywka.OdznaczKość(PbKosc2, pbKość2Aktywna);
                kość[1] = true;
            }
        }

        private void pbKosc3_MouseClick(object sender, MouseEventArgs e)
        {
            if (kość[2])
            {
                rozgrywka.ZaznaczKość(pbKosc3, pbKość3Aktywna);
                kość[2] = false;
            }
            else
            {
                rozgrywka.OdznaczKość(PbKosc3, pbKość3Aktywna);
                kość[2] = true;
            }
        }

        private void pbKosc4_MouseClick(object sender, MouseEventArgs e)
        {
            if (kość[3])
            {
                rozgrywka.ZaznaczKość(pbKosc4, pbKość4Aktywna);
                kość[3] = false;
            }
            else
            {
                rozgrywka.OdznaczKość(PbKosc4, pbKość4Aktywna);
                kość[3] = true;
            }
        }

        private void pbKosc5_MouseClick(object sender, MouseEventArgs e)
        {
            if (kość[4])
            {
                rozgrywka.ZaznaczKość(pbKosc5, pbKość5Aktywna);
                kość[4] = false;
            }
            else
            {
                rozgrywka.OdznaczKość(PbKosc5, pbKość5Aktywna);
                kość[4] = true;
            }
        }

        #endregion



        //////////////////////////////////////////////////// EVENTY ODPOWIADAJĄCE ZA UZYSKANIE WYNIKÓW ////////////////////////////////////////////////////
        #region
        private void labelJedynkiG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelJedynkiG1.ForeColor = Color.Red;
            labelJedynkiG1.Text = LabelJedynkiG1.Text;
            labelJedynkiG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelDwójkiG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelDwójkiG1.ForeColor = Color.Red;
            labelDwójkiG1.Text = LabelDwójkiG1.Text;
            labelDwójkiG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelTrójkiG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelTrójkiG1.ForeColor = Color.Red;
            labelTrójkiG1.Text = LabelTrójkiG1.Text;
            labelTrójkiG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelCzwórkiG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelCzwórkiG1.ForeColor = Color.Red;
            labelCzwórkiG1.Text = LabelCzwórkiG1.Text;
            labelCzwórkiG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelPiątkiG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelPiątkiG1.ForeColor = Color.Red;
            labelPiątkiG1.Text = LabelPiątkiG1.Text;
            labelPiątkiG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelSzóstkiG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelSzóstkiG1.ForeColor = Color.Red;
            labelSzóstkiG1.Text = LabelSzóstkiG1.Text;
            labelSzóstkiG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelTrójkaG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelTrójkaG1.ForeColor = Color.Red;
            labelTrójkaG1.Text = LabelTrójkaG1.Text;
            labelTrójkaG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelKaretaG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelKaretaG1.ForeColor = Color.Red;
            labelKaretaG1.Text = LabelKaretaG1.Text;
            labelKaretaG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelFullG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelFullG1.ForeColor = Color.Red;
            labelFullG1.Text = LabelFullG1.Text;
            labelFullG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelMałyStritG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelMałyStritG1.ForeColor = Color.Red;
            labelMałyStritG1.Text = LabelMałyStritG1.Text;
            labelMałyStritG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelDużyStritG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelDużyStritG1.ForeColor = Color.Red;
            labelDużyStritG1.Text = LabelDużyStritG1.Text;
            labelDużyStritG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelGenerałG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelGenerałG1.ForeColor = Color.Red;
            labelGenerałG1.Text = LabelGenerałG1.Text;
            labelGenerałG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelSzansaG1_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelSzansaG1.ForeColor = Color.Red;
            labelSzansaG1.Text = LabelSzansaG1.Text;
            labelSzansaG1.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelJedynkiG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelJedynkiG2.ForeColor = Color.Red;
            labelJedynkiG2.Text = LabelJedynkiG2.Text;
            labelJedynkiG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelDwójkiG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelDwójkiG2.ForeColor = Color.Red;
            labelDwójkiG2.Text = LabelDwójkiG2.Text;
            labelDwójkiG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelTrójkiG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelTrójkiG2.ForeColor = Color.Red;
            labelTrójkiG2.Text = LabelTrójkiG2.Text;
            labelTrójkiG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelCzwórkiG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelCzwórkiG2.ForeColor = Color.Red;
            labelCzwórkiG2.Text = LabelCzwórkiG2.Text;
            labelCzwórkiG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelPiątkiG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelPiątkiG2.ForeColor = Color.Red;
            labelPiątkiG2.Text = LabelPiątkiG2.Text;
            labelPiątkiG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelSzóstkiG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelSzóstkiG2.ForeColor = Color.Red;
            labelSzóstkiG2.Text = LabelSzóstkiG2.Text;
            labelSzóstkiG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelTrójkaG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelTrójkaG2.ForeColor = Color.Red;
            labelTrójkaG2.Text = LabelTrójkaG2.Text;
            labelTrójkaG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelKaretaG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelKaretaG2.ForeColor = Color.Red;
            labelKaretaG2.Text = LabelKaretaG2.Text;
            labelKaretaG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelFullG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelFullG2.ForeColor = Color.Red;
            labelFullG2.Text = LabelFullG2.Text;
            labelFullG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelMałyStritG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelMałyStritG2.ForeColor = Color.Red;
            labelMałyStritG2.Text = LabelMałyStritG2.Text;
            labelMałyStritG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelDużyStritG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelDużyStritG2.ForeColor = Color.Red;
            labelDużyStritG2.Text = LabelDużyStritG2.Text;
            labelDużyStritG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelGenerałG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelGenerałG2.ForeColor = Color.Red;
            labelGenerałG2.Text = LabelGenerałG2.Text;
            labelGenerałG2.Enabled = false; 
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        private void labelSzansaG2_MouseClick(object sender, MouseEventArgs e)
        {
            DźwiękWpisania(Ustawienia.dźwiękWpisania);
            labelSzansaG2.ForeColor = Color.Red;
            labelSzansaG2.Text = LabelSzansaG2.Text;
            labelSzansaG2.Enabled = false;
            licznik = 0;
            rozgrywka.ZmianaGracza(aktualnyGracz);
            BtnRzut.Enabled = true;
        }

        #endregion



        //////////////////////////////////////////////////// EVENT DLA TOOLSTRIP'a ////////////////////////////////////////////////////

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ustawienia = new Ustawienia();
            ustawienia.ShowDialog();
            this.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            panel1.BackColor = System.Drawing.Color.FromName(Ustawienia.kartka);

            if (kość[0])
                pbKość1Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            if (kość[1])
                pbKość2Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            if (kość[2])
                pbKość3Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            if (kość[3])
                pbKość4Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
            if (kość[4])
                pbKość5Aktywna.BackColor = System.Drawing.Color.FromName(Ustawienia.tło);
        }





        private void jakGraćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JakGrać jakGrać = new JakGrać();
            jakGrać.ShowDialog();
        }



        private void Gra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wyjść z gry?", "Pytanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }



        private void DźwiękKości(bool opcja)
        {
            if (opcja)
            {
                Stream str = Properties.Resources.rzutKośćmi;
                SoundPlayer dzwiek = new SoundPlayer(str);
                dzwiek.Play();
            }
        }



        private void DźwiękWpisania(bool opcja)
        {
            if (opcja)
            {
                Stream str = Properties.Resources.wpisanieWyniku;
                SoundPlayer dzwiek = new SoundPlayer(str);
                dzwiek.Play();
            }
        }



        private void Gra_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Visible = true;
        }
    }
}
