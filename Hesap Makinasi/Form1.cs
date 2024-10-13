using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinasi
{
    public partial class HesapMakinesi : Form
    {

        double memory = 0;

        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void lbl_7_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_7.Text;
        }

        private void lbl_8_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_8.Text;
        }

        private void lbl_9_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_9.Text;
        }

        private void lbl_4_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_4.Text;
        }

        private void lbl_5_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_5.Text;
        }

        private void lbl_6_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_6.Text;
        }

        private void lbl_1_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_1.Text;
        }

        private void lbl_2_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_2.Text;
        }

        private void lbl_3_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_3.Text;
        }

        private void lbl_0_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_0.Text;
        }

        private void lbl_Percent_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text += lbl_Percent.Text;
        }

        private void lbl_1_bol_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text="1"+"/"+txtScreen.Text;
        }

        private void lbl_Karesi_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text = KareAl(txtScreen.Text);
        }

       

        private void lbl_KareKokAl_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text = KareKokAl(txtScreen.Text);
        }

        #region Karesini Al
        public string KareAl(string x)
        {
            double y = Convert.ToDouble(x);
            y = y * y;
            return y.ToString();
        }
        #endregion

        #region Karekok Hesapla
        public string KareKokAl(string x)
        {
            double y = Convert.ToDouble(x);
            y = Math.Sqrt(y);
            return y.ToString();
        }
        #endregion

        private void lbl_Nokta_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (!txtScreen.Text.Contains("."))
            {
               
                    txtScreen.Text += lbl_Nokta.Text;
                
            }

          
           
        }

        private void lbl_IsaretDegistir_MouseClick(object sender, MouseEventArgs e)
        {
            string eksiArtı = txtScreen.Text;
            if (txtScreen.Text.StartsWith("-"))
            {
                txtScreen.Text = txtScreen.Text.Replace("-", "");
            }
            else
            {
                txtScreen.Text = "-" + eksiArtı;
            }

        }

        private void lbl_KompleSil_MouseClick(object sender, MouseEventArgs e)
        {
            memory = 0.0;
        }

        private void lbl_EkraniSil_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text = "";

        }

        private void lbl_GeriAl_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtScreen.Text != "")
            {
                txtScreen.Text = txtScreen.Text.Remove(txtScreen.Text.Length - 1);
            }
        }

        private void lbl_Bol_MouseClick(object sender, MouseEventArgs e)
        {
            if (Kontrol(txtScreen.Text) && txtScreen.Text != "")
            {
                txtScreen.Text += lbl_Bol.Text;
            }
        }

        private void lbl_Carp_MouseClick(object sender, MouseEventArgs e)
        {
            if (Kontrol(txtScreen.Text) && txtScreen.Text != "")
            {
                txtScreen.Text += lbl_Carp.Text;
            }
        }

        private void lbl_Cikar_MouseClick(object sender, MouseEventArgs e)
        {
            if (Kontrol(txtScreen.Text))
            {
                txtScreen.Text += lbl_Cikar.Text;
            }
        }

        private void lbl_Topla_MouseClick(object sender, MouseEventArgs e)
        {
            if  (Kontrol(txtScreen.Text)&&txtScreen.Text!="")
            {
                txtScreen.Text += lbl_Topla.Text;
            }
        }

        private void lbl_Esittir_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtScreen.Text = Hesapla(txtScreen.Text).ToString();
            }
            catch
            {
                txtScreen.Text = "ERROR";
            }
        }

        static double Hesapla(string x)
        {
            DataTable table = new DataTable();
            var result = table.Compute(x, "");
            return Convert.ToDouble(result);
        }

        private void lblMC_MouseClick(object sender, MouseEventArgs e)
        {
            memory = 0;
        }

        private void lblMR_MouseClick(object sender, MouseEventArgs e)
        {
            txtScreen.Text=memory.ToString();
        }

        private void lblM_arti_MouseClick(object sender, MouseEventArgs e)
        {
            memory+= double.Parse(txtScreen.Text);
        }

        private void lblM_eksi_MouseClick(object sender, MouseEventArgs e)
        {
            memory -= double.Parse(txtScreen.Text);
        }

        public bool Kontrol(string kontrolMetin)
        {
            if (kontrolMetin.EndsWith("+")|| kontrolMetin.EndsWith("-")|| kontrolMetin.EndsWith("*")|| kontrolMetin.EndsWith("/"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RenkDegistir(string renkDegistir)
        {

        }

        private void HesapMakinesi_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
