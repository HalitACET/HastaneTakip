using Hastane_Proje.Hasta;
using Hastane_Proje.Sekreter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmHastaGirisPaneli FrmHasta = new FrmHastaGirisPaneli();
            this.Hide();
            FrmHasta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorGirisPaneli frmDoktorGirisPaneli = new FrmDoktorGirisPaneli();
            this.Hide();
            frmDoktorGirisPaneli.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSekreterGirisPaneli frmSekreterGirisPaneli = new FrmSekreterGirisPaneli();
            this.Hide();
            frmSekreterGirisPaneli.Show();
        }
    }
}
