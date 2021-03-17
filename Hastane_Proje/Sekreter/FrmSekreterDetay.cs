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

namespace Hastane_Proje.Doktor
{
    public partial class FrmSekreterDetay : Form
    {
        private object frmrandevular;

        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDoktorEkle frmDoktorEkle = new FrmDoktorEkle();
            frmDoktorEkle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBransEkle frmBransEkle = new FrmBransEkle();
            frmBransEkle.Show();
        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmRandevular frmRandevular = new FrmRandevular();
            frmRandevular.Show();
        }
    }
}
