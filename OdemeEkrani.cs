using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Identity.Client;

namespace yurt_uygulaması
{
    public partial class OdemeEkrani : Form
    {
        public OdemeEkrani()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"YOUR_SQL_CONNECTION");
        private void label2_Click(object sender, EventArgs e)
        {
            KullaniciEkrani kullaniciEkrani1 = new KullaniciEkrani();
            kullaniciEkrani1.Show();
            this.Hide();

        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciEkrani kullaniciEkrani0 = new KullaniciEkrani();
            kullaniciEkrani0.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakbuzEkranı makbuzEkranı1 = new MakbuzEkranı();
            makbuzEkranı1.Show();
            this.Hide();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

                listView1.Items.Add(add);
            }
            connection.Close();

        }

        int id = 0;
        int tutar, taksitsayisi, taksittutari, taksitToplam, xx;
        int taksitNo;
        public static string tc;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tutar = Convert.ToInt32(listView1.SelectedItems[0].SubItems[6].Text);
                taksitsayisi = Convert.ToInt32(listView1.SelectedItems[0].SubItems[7].Text);
                taksittutari = Convert.ToInt32(listView1.SelectedItems[0].SubItems[8].Text);
                taksitToplam = Convert.ToInt32(listView1.SelectedItems[0].SubItems[12].Text);
                tc = maskedTextBox1.Text;
                taksitsayisi--;
                tutar = tutar - taksittutari;
                textBox5.Text = tutar.ToString();
                textBox6.Text = taksitsayisi.ToString();
                connection.Open();
                SqlCommand update = new SqlCommand("update ogrenciKayit set odenecekTutar = '" + tutar + "', taksitSayisi = '" + taksitsayisi + "', sonOdemeTarihi = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' where id = " + id + "", connection);
                update.ExecuteNonQuery();
                xx = Convert.ToInt32(textBox6.Text);
                taksitNo = taksitToplam - xx;
                SqlCommand ekleOdeme = new SqlCommand("insert into borcCetveli (taksitNo,kalanBorc,odenenMiktar,odemeTarihi,TC,ToplamTaksit,KalanTaksit) values ('" + taksitNo + "' ,'" + textBox5.Text + "', '" + taksittutari + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + tc + "', '" + taksitToplam + "', '" + xx + "')", connection);
                ekleOdeme.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ödeme kaydedildi");
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[2].Text;
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            maskedTextBox2.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox11.Text = listView1.SelectedItems[0].SubItems[10].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[11].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[5].Text;
            tutar = Convert.ToInt32(listView1.SelectedItems[0].SubItems[6].Text);
            taksitsayisi = Convert.ToInt32(listView1.SelectedItems[0].SubItems[7].Text);
            taksittutari = Convert.ToInt32(listView1.SelectedItems[0].SubItems[8].Text);
            textBox5.Text = tutar.ToString();
            textBox6.Text = taksitsayisi.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
