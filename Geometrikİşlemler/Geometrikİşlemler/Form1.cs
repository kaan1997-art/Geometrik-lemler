using Geometrikİşlemler.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrikİşlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bSonuc_Click(object sender, EventArgs e)
        {
            if (!(cbKare.Checked || cbDikdortgen.Checked || cbDikUcgen.Checked || cbEskenarUcgen.Checked || cbDaire.Checked))
            {
                MessageBox.Show("Lütfen yapılacak bir işlem seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbTaban.Text.Trim() == "" || tbYukseklik.Text.Trim() =="")
            {
                MessageBox.Show("Lütfen sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbKare.Checked)
                {
                    Dortkenarlilar dikdortgen = new Dortkenarlilar();
                    dikdortgen.Taban = Convert.ToDouble(tbTaban.Text);
                    dikdortgen.Yukseklik = Convert.ToDouble(tbYukseklik.Text);
                    lbAlan.Text = dikdortgen.AlanSonuc().ToString();
                    lbCevre.Text = dikdortgen.CevreSonuc().ToString();
                }
                
            }
            if (cbDikdortgen.Checked)
            {
                Dortkenarlilar dikdortgen = new Dortkenarlilar();
                dikdortgen.Taban = Convert.ToDouble(tbTaban.Text);
                dikdortgen.Yukseklik = Convert.ToDouble(tbYukseklik.Text);
                lbAlan.Text = dikdortgen.AlanSonuc().ToString();
                lbCevre.Text = dikdortgen.CevreSonuc().ToString();
            }
            if (cbEskenarUcgen.Checked)
            {
                Dortkenarlilar eskenarUcgen = new Dortkenarlilar();
                eskenarUcgen.Taban = Convert.ToDouble(tbTaban.Text);
                eskenarUcgen.Yukseklik = Convert.ToDouble(tbYukseklik.Text);
                lbAlan.Text = eskenarUcgen.AlanSonuc().ToString();
                lbCevre.Text = eskenarUcgen.CevreSonuc().ToString();
            }
            if (cbDikUcgen.Checked)
            {
                Dortkenarlilar dikUcgen = new Dortkenarlilar();
                dikUcgen.Taban = Convert.ToDouble(tbTaban.Text);
                dikUcgen.Yukseklik = Convert.ToDouble(tbYukseklik.Text);
                lbAlan.Text = dikUcgen.AlanSonuc().ToString();
                lbCevre.Text = dikUcgen.CevreSonuc().ToString();
            }
            if (cbDaire.Checked)
            {
                Daire daire = new Daire();
                daire.YariCap = Convert.ToDouble(tbYariCap.Text);
                lbAlan.Text = daire.AlanSonuc().ToString();
                lbCevre.Text = daire.CevreSonuc().ToString();
            }
        }

        private void cbDaire_CheckedChanged(object sender, EventArgs e)
        {
            cbKare.Checked = false;
            cbDikdortgen.Checked = false;
            cbEskenarUcgen.Checked = false;
            cbDikUcgen.Checked = false;
            lTaban.Visible = false;
            lYukseklik.Visible = false;
            tbTaban.Visible = false;
            tbYukseklik.Visible = false;
            lYariCap.Visible = true;
            tbYariCap.Visible = true;
        }

        private void cbKare_CheckedChanged(object sender, EventArgs e)
        {
            lTaban.Visible = true;
            lYukseklik.Visible = true;
            tbTaban.Visible = true;
            tbYukseklik.Visible = true;

            cbEskenarUcgen.Checked = false;
            cbDikdortgen.Checked = false;
            cbDaire.Checked = false;
            cbDikUcgen.Checked = false;
        }

        private void cbDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            lTaban.Visible = true;
            lYukseklik.Visible = true;
            tbTaban.Visible = true;
            tbYukseklik.Visible = true;

            cbEskenarUcgen.Checked = false;
            cbKare.Checked = false;
            cbDaire.Checked = false;
            cbDikUcgen.Checked = false;
        }

        private void cbEskenarUcgen_CheckedChanged(object sender, EventArgs e)
        {
            lTaban.Visible = true;
            lYukseklik.Visible = true;
            tbTaban.Visible = true;
            tbYukseklik.Visible = true;

            cbKare.Checked = false;
            cbDikdortgen.Checked = false;
            cbDaire.Checked = false;
            cbDikUcgen.Checked = false;
        }

        private void cbDikUcgen_CheckedChanged(object sender, EventArgs e)
        {
            lTaban.Visible = true;
            lYukseklik.Visible = true;
            tbTaban.Visible = true;
            tbYukseklik.Visible = true;

            cbEskenarUcgen.Checked = false;
            cbDikdortgen.Checked = false;
            cbDaire.Checked = false;
            cbKare.Checked = false;
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            cbDikUcgen.Checked = false;
            cbDikdortgen.Checked = false;
            cbEskenarUcgen.Checked = false;
            cbDaire.Checked = false;
            cbKare.Checked = false;
            tbYukseklik.Text = null;
            tbYariCap.Text = null;
            tbTaban.Text = null;
            lbAlan.Text = null;
            lbCevre.Text = null;
        }
    }
}
