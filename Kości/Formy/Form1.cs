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
    public partial class Form1 : Form
    {
        Gra gra;
        ZasadyGry zasadyGry;
        private string imie1, imie2;



        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void btnGraj_Click(object sender, EventArgs e)
        {
            Dzwiek();

            imie1 = Microsoft.VisualBasic.Interaction.InputBox("Podaj imię pierwszego gracza:");
            imie2 = Microsoft.VisualBasic.Interaction.InputBox("Podaj imię drugiego gracza:");

            if (imie1 == "" || imie2 == "" || imie1 == imie2)
            {
                MessageBox.Show("Imiona nie mogą być takie same lub puste!");
                return;
            }
            else
            {
                this.Visible = false;
                gra = new Gra(this);
                gra.ShowDialog();
            }
        }


        public string Imie1
        {
            get { return imie1; }
        }

        public string Imie2
        {
            get { return imie2; }
        }




        private void btnZasadyGry_Click(object sender, EventArgs e)
        {
            Dzwiek();

            this.Visible = false;
            zasadyGry = new ZasadyGry(this);
            zasadyGry.ShowDialog();
        }


        private void btnWyjście_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Dzwiek()
        {
            Stream str = Properties.Resources.buttonMenu;
            SoundPlayer dzwiek = new SoundPlayer(str);
            dzwiek.Play();
        }

    }
}
