using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Kości
{
    public partial class ZasadyGry : Form
    {
        Form form;


        public ZasadyGry() 
        {
            InitializeComponent();
        }


        public ZasadyGry(Form form)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.IsMdiContainer = true;
            this.form = form;
        }



        public Panel PanelZasadyGry
        {
            get { return this.panelZasadyGry; }
            set { this.panelZasadyGry = value; }
        }



        ////////////////////////////////////////////// ZASADY GRY - POSZCZEGÓLNE UKŁADY KOŚCI //////////////////////////////////////////////
        #region

        private void btnJedynki_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Jedynki jedynki = new Jedynki();
            jedynki.MdiParent = this;
            jedynki.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            jedynki.Dock = DockStyle.Fill;
        }

        private void btnDwójki_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Dwójki dwójki = new Dwójki();
            dwójki.MdiParent = this;
            dwójki.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            dwójki.Dock = DockStyle.Fill;
        }

        private void btnTrójki_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Trójki trójki = new Trójki();
            trójki.MdiParent = this;
            trójki.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            trójki.Dock = DockStyle.Fill;
        }

        private void btnCzwórki_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Czwórki czwórki = new Czwórki();
            czwórki.MdiParent = this;
            czwórki.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            czwórki.Dock = DockStyle.Fill;
        }

        private void btnPiątki_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Piątki piątki = new Piątki();
            piątki.MdiParent = this;
            piątki.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            piątki.Dock = DockStyle.Fill;
        }

        private void btnSzóstki_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Szóstki szóstki = new Szóstki();
            szóstki.MdiParent = this;
            szóstki.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            szóstki.Dock = DockStyle.Fill;
        }

        private void btnTrójka_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Trójka trójka = new Trójka();
            trójka.MdiParent = this;
            trójka.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            trójka.Dock = DockStyle.Fill;
        }

        private void btnKareta_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Kareta kareta = new Kareta();
            kareta.MdiParent = this;
            kareta.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            kareta.Dock = DockStyle.Fill;
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Full full = new Full();
            full.MdiParent = this;
            full.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            full.Dock = DockStyle.Fill;
        }

        private void btnMałyStrit_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            MałyStrit małyStrit = new MałyStrit();
            małyStrit.MdiParent = this;
            małyStrit.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            małyStrit.Dock = DockStyle.Fill;
        }

        private void btnDużyStrit_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            DużyStrit dużyStrit = new DużyStrit();
            dużyStrit.MdiParent = this;
            dużyStrit.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            dużyStrit.Dock = DockStyle.Fill;
        }

        private void btnGenerał_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Generał generał = new Generał();
            generał.MdiParent = this;
            generał.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            generał.Dock = DockStyle.Fill;
        }

        private void btnSzansa_Click(object sender, EventArgs e)
        {
            Dzwiek();
            PanelZasadyGry.Visible = false;
            Szansa szansa = new Szansa();
            szansa.MdiParent = this;
            szansa.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            szansa.Dock = DockStyle.Fill;
        }
        #endregion




        private void Dzwiek()
        {
            Stream str = Properties.Resources.buttonMenu;
            SoundPlayer dzwiek = new SoundPlayer(str);
            dzwiek.Play();
        }



        private void ZasadyGry_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Visible = true;
        }
    }
}
