using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurt_uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblSaat.Parent = pictureBox1;
            lblSaat.BackColor = Color.Transparent;
            lblMarka.Parent = pictureBox1;
            lblMarka2.Parent = pictureBox1;
            lblMarka.BackColor = Color.Transparent;
            lblMarka2.BackColor = Color.Transparent;
            lblTarih.Parent = pictureBox1;
            lblTarih.BackColor = Color.Transparent;
            lblGun.Parent = pictureBox1;
            lblGun.BackColor = Color.Transparent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnGiris.FlatAppearance.BorderSize = 0;
            btnBirimler.FlatAppearance.BorderSize = 0;
            btnYonetici.FlatAppearance.BorderSize = 0;
            //btnOgrenci.FlatAppearance.BorderSize = 0;
            btnTesisler.FlatAppearance.BorderSize = 0;
            btnOdalar.FlatAppearance.BorderSize = 0;
            btnYemekhane.FlatAppearance.BorderSize = 0;
            btnHakkımızda.FlatAppearance.BorderSize = 0;
            btnKayıt.FlatAppearance.BorderSize = 0;
            btnIletisim.FlatAppearance.BorderSize = 0;
            btnVizyon.FlatAppearance.BorderSize = 0;
            btnMisyon.FlatAppearance.BorderSize = 0;
            pnlGirisMenu.Hide();
            btnTesisler.Hide();
            btnOdalar.Hide();
            btnYemekhane.Hide();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            pnlGirisMenu.Show();
            pnlNav.BackColor = Color.LightSteelBlue;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            pnlNav.BackColor = Color.SteelBlue;
            pnlGirisMenu.Hide();
        }

        private void pnlGiris_MouseHover(object sender, EventArgs e)
        {
            pnlGirisMenu.Show();
            pnlNav.BackColor = Color.LightSteelBlue;
        }

        private void btnYonetici_MouseHover(object sender, EventArgs e)
        {
            pnlGirisMenu.Show();
        }

        private void btnYonetici_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnBirimler_MouseHover(object sender, EventArgs e)
        {
            pnlNav2.BackColor = Color.LightSteelBlue;
        }

        private void btnHakkımızda_MouseHover(object sender, EventArgs e)
        {
            pnlNav3.BackColor = Color.LightSteelBlue;
        }

        private void btnKayıt_MouseHover(object sender, EventArgs e)
        {
            pnlNav4.BackColor = Color.LightSteelBlue;
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {

        }

        private void btnIletisim_MouseHover(object sender, EventArgs e)
        {
            pnlNav5.BackColor = Color.LightSteelBlue;
        }

        private void btnBirimler_MouseLeave(object sender, EventArgs e)
        {
            pnlNav2.BackColor = Color.SteelBlue;
        }

        private void btnHakkımızda_MouseLeave(object sender, EventArgs e)
        {
            pnlNav3.BackColor = Color.SteelBlue;
        }

        private void btnKayıt_MouseLeave(object sender, EventArgs e)
        {
            pnlNav4.BackColor = Color.SteelBlue;
        }

        private void btnIletisim_MouseLeave(object sender, EventArgs e)
        {
            pnlNav5.BackColor = Color.SteelBlue;
        }

        private void btnOgrenci_MouseLeave(object sender, EventArgs e)
        {
            pnlGirisMenu.Visible = false;
        }

        private void btnYonetici_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnGiris_MouseEnter(object sender, EventArgs e)
        {
            pnlGirisMenu.Visible = true;
            pnlNav.BackColor = Color.LightSteelBlue;
            pnlBirimlerMenu.Visible = false;
            pnlHakkımızda.Visible = false;
        }

        private void btnGiris_MouseLeave_1(object sender, EventArgs e)
        {
            pnlGirisMenu.Visible = false;
            pnlNav.BackColor = Color.SteelBlue;
        }

        private void btnYonetici_MouseEnter(object sender, EventArgs e)
        {
            pnlGirisMenu.Visible = true;
        }

        private void pnlGirisMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlGirisMenu.Visible = true;
        }

        private void pnlGirisMenu_MouseLeave(object sender, EventArgs e)
        {
            pnlGirisMenu.Visible = false;

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_MouseLeave_2(object sender, EventArgs e)
        {
            pnlNav.BackColor = Color.SteelBlue;
        }

        private void btnBirimler_MouseEnter(object sender, EventArgs e)
        {
            pnlGirisMenu.Visible = false;
            pnlNav2.BackColor = Color.LightSteelBlue;
            pnlBirimlerMenu.Visible = true;
            btnOdalar.Visible = true;
            btnYemekhane.Visible = true;
            btnTesisler.Visible = true;
            pnlHakkımızda.Visible = false;


        }

        private void btnBirimler_MouseLeave_1(object sender, EventArgs e)
        {
            pnlNav2.BackColor = Color.SteelBlue;
        }

        private void btnYonetici_MouseLeave_1(object sender, EventArgs e)
        {
            pnlGirisMenu.Visible = false;
        }

        private void btnHakkımızda_MouseEnter(object sender, EventArgs e)
        {
            pnlBirimlerMenu.Visible = false;
            pnlHakkımızda.Visible = true;
            pnlNav3.BackColor = Color.LightSteelBlue;
        }

        private void btnHakkımızda_MouseLeave_1(object sender, EventArgs e)
        {
            pnlNav3.BackColor = Color.SteelBlue;
        }

        private void btnKayıt_MouseLeave_1(object sender, EventArgs e)
        {
            pnlNav4.BackColor = Color.SteelBlue;
        }

        private void btnKayıt_MouseEnter(object sender, EventArgs e)
        {
            pnlNav4.BackColor = Color.LightSteelBlue;
            pnlGirisMenu.Visible = false;
            pnlBirimlerMenu.Visible = false;
            pnlHakkımızda.Visible = false;
        }

        private void btnIletisim_MouseEnter(object sender, EventArgs e)
        {
            pnlNav5.BackColor = Color.LightSteelBlue;
            pnlGirisMenu.Visible = false;
            pnlBirimlerMenu.Visible = false;
            pnlHakkımızda.Visible = false;
        }

        private void btnIletisim_MouseLeave_1(object sender, EventArgs e)
        {
            pnlNav5.BackColor = Color.SteelBlue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm");
            lblTarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblGun.Text = DateTime.Now.ToString("dddd");

        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            Form1 yoneticigiris = new Form1();
            yoneticigiris.Show();
            this.Hide();
        }
    }
}
