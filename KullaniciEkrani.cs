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

namespace yurt_uygulaması
{

    public partial class KullaniciEkrani : Form
    {
        DateTime taksittarih;
        DateTime bugun;
        TimeSpan fark, fark2;
        DateTime tempDate;
        int kactaksit;
        string ograd, ogrsoyad;
        int bulundumu = 0;
        public KullaniciEkrani()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"YOUR_SQL_CONNECTION");
        private void KullaniciEkrani_Load(object sender, EventArgs e)
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

        string ad, soyad, tc;
        int tutar, taksitsayisi;
        float taksittutari;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdemeEkrani odemeEkrani1 = new OdemeEkrani();
            odemeEkrani1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(taksittutari.ToString());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            tutar = Convert.ToInt32(textBox5.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text != "" && Convert.ToInt32(textBox4.Text) != 0)
            {
                taksitsayisi = Convert.ToInt32(textBox4.Text);
                taksittutari = tutar / taksitsayisi;
                //label8.Text = taksittutari.ToString();
            }
            else
            {
                MessageBox.Show("Geçerli bir taksit sayısı giriniz");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && maskedTextBox1.Text != "" && textBox5.Text != "" && textBox4.Text != "" && maskedTextBox2.Text != "" && textBox6.Text != "" && textBox2.Text != "")
            {
                connection.Open();
                SqlCommand ekle = new SqlCommand("insert into ogrenciKayit (ad,soyad,tc,dogumTarihi,baslangicTarihi,odenecekTutar,taksitSayisi,taksitTutari,telefon,mail,adres,toplamTaksit,sonOdemeTarihi) values ('" + textBox1.Text + "' ,'" + textBox3.Text + "', '" + maskedTextBox1.Text + "', '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + taksittutari + "','" + maskedTextBox2.Text + "', '" + textBox6.Text + "', '" + textBox2.Text + "','" + textBox4.Text + "', '" + DateTime.MinValue + "')", connection);
                ekle.ExecuteNonQuery();
                SqlCommand ekleMakbuz = new SqlCommand("insert into borcCetveli (taksitNo,kalanBorc,odenenMiktar,TC,ToplamTaksit,KalanTaksit) values ('" + 0 + "' ,'" + textBox5.Text + "', '" + 0 + "', '" + maskedTextBox1.Text + "','" + textBox4.Text + "','" + textBox4.Text + "')", connection);
                ekleMakbuz.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt başarılı");
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz, bilgileri kontrol edin");
            }





        }


    }
}
