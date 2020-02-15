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
    public partial class UkładyPojedyńcze : Form
    {
        public UkładyPojedyńcze()
        {
            InitializeComponent();
        }

        private void UkładyPojedyńcze_FormClosed(object sender, FormClosedEventArgs e)
        {
            ZasadyGry zasady = (ZasadyGry)this.MdiParent;
            zasady.PanelZasadyGry.Visible = true;
        }
    }
}
