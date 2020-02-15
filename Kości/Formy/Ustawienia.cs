using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kości
{
    public partial class Ustawienia : Form
    {
        public static string tło = "LightSkyBlue";
        public static string kartka = "Wheat";
        public static bool dźwiękKości = true;
        public static bool dźwiękWpisania = true;




        public Ustawienia()
        {
            InitializeComponent();
        }



        private void btnZatwierdź_Click(object sender, EventArgs e)
        {
            UstawTło();
            UstawKartkę();

            this.Close();
        }



        public void SprawdźDźwięk()
        {
            if (checkBoxDźwiękKości.Checked)
            {
                checkBoxDźwiękKości.Checked = true;
                dźwiękKości = true;
            }
            else
            {
                checkBoxDźwiękKości.Checked = false;
                dźwiękKości = false;
            }


            if (checkBoxDźwiękWyniku.Checked)
            {
                checkBoxDźwiękWyniku.Checked = true;
                dźwiękWpisania = true;
            }
            else
            {
                checkBoxDźwiękWyniku.Checked = false;
                dźwiękWpisania = false;
            }
        }



        public void UstawTło()
        {
            if (cbTło.Text == "Błękitne")
                tło = "LightSkyBlue";
            if (cbTło.Text == "Turkusowe")
                tło = "PaleTurquoise";
            if (cbTło.Text == "Kremowe")
                tło = "Bisque";
            if (cbTło.Text == "Różowe")
                tło = "LightPink";
        }



        public void UstawKartkę()
        {
            if (cbKartka.Text == "Jasnobrązowa")
                kartka = "Wheat";
            if (cbKartka.Text == "Zielona")
                kartka = "LightGreen";
            if (cbKartka.Text == "Biała")
                kartka = "GhostWhite";
            if (cbKartka.Text == "Jasnożółta")
                kartka = "LightYellow";
        }

        private void Ustawienia_FormClosing(object sender, FormClosingEventArgs e)
        {
            SprawdźDźwięk();
        }
    }
}
