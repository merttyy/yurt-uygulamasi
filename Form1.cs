using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tulpep.NotificationWindow;
using Microsoft.EntityFrameworkCore.Query;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;

namespace yurt_uygulaması
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(@"YOUR_SQL_CONNECTION");
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;
        }
        DateTime taksittarih;
        DateTime bugun;
        TimeSpan fark, fark2;
        DateTime tempDate;
        int kactaksit;
        string ograd, ogrsoyad;
        int bulundumu = 0;


        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "admin" && txtSifre.Text == "0000")
            {
                KullaniciEkrani kullaniciEkrani1 = new KullaniciEkrani();
                kullaniciEkrani1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Giriş bilgileri yanlış, tekrar deneyin");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand listele = new SqlCommand("select * from ogrenciKayit", connection);
            SqlDataReader read = listele.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["id"].ToString();
                add.SubItems.Add(read["ad"].ToString());
                add.SubItems.Add(read["soyad"].ToString());
                add.SubItems.Add(read["tc"].ToString());
                add.SubItems.Add(read["dogumTarihi"].ToString());
                add.SubItems.Add(read["baslangicTarihi"].ToString());
                add.SubItems.Add(read["odenecekTutar"].ToString());
                add.SubItems.Add(read["taksitSayisi"].ToString());
                add.SubItems.Add(read["taksitTutari"].ToString());
                add.SubItems.Add(read["telefon"].ToString());
                add.SubItems.Add(read["mail"].ToString());
                add.SubItems.Add(read["adres"].ToString());
                add.SubItems.Add(read["toplamTaksit"].ToString());
                add.SubItems.Add(read["sonOdemeTarihi"].ToString());

                if (read["sonOdemeTarihi"].ToString() == DateTime.MinValue.ToString())
                {
                    taksittarih = Convert.ToDateTime(read["baslangicTarihi"]);
                    bugun = DateTime.Today;
                    fark = bugun - taksittarih;
                    kactaksit = Convert.ToInt32(fark.TotalDays) / 30;
                    ograd = read["ad"].ToString();
                    ogrsoyad = read["soyad"].ToString();

                }
                else
                {
                    taksittarih = Convert.ToDateTime(read["sonOdemeTarihi"]);
                    bugun = DateTime.Today;
                    fark = bugun - taksittarih;
                    kactaksit = Convert.ToInt32(fark.TotalDays) / 30;
                    ograd = read["ad"].ToString();
                    ogrsoyad = read["soyad"].ToString();

                }

                if (Convert.ToInt32(fark.TotalDays) > 30)
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.ContentText = ograd.ToString() + " " + ogrsoyad.ToString() + " adlı öğrencinin taksit ödeme tarihi geçmiştir";
                    popup.BodyColor = Color.FromArgb(76, 76, 76);
                    popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);
                    popup.ContentColor = Color.White;
                    popup.TitleText = "Hatırlatma";
                    popup.TitleColor = Color.White;
                    popup.TitleFont = new Font("Segoe UI", 9, FontStyle.Bold);
                    popup.Size = new Size(450, 250);
                    popup.Scroll = true;
                    popup.TitlePadding = new Padding(10);
                    popup.AnimationDuration = 1000;
                    popup.Popup();

                }
            }
            connection.Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}
