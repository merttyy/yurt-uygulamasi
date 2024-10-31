using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace yurt_uygulaması
{
    partial class yurtprogrami : ServiceBase
    {
        public yurtprogrami()
        {
            InitializeComponent();
        }

        DateTime taksittarih;
        DateTime bugun;
        TimeSpan fark, fark2;
        DateTime tempDate;
        int kactaksit;
        string ograd, ogrsoyad;
        int bulundumu = 0;
        protected override void OnStart(string[] args)
        {

            // TODO: Hizmetinizi başlatmak için kodu buraya ekleyin.
            SqlConnection connection = new SqlConnection(@"YOUR_SQL_CONNECTION");
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
                    PopupNotifier popup2 = new PopupNotifier();
                    popup.ContentText = ograd.ToString() + " " + ogrsoyad.ToString() + " adlı öğrencinin taksit ödeme tarihi geçmiştir";
                    popup.TitleText = "Hatırlatma";
                   
                    popup.Popup();


                }
            }
            connection.Close();
        }

        protected override void OnStop()
        {
            // TODO: Hizmetinizi durdurmak için ihtiyaç olunan bir kapatmayı gerçekleştirmek için kodu buraya ekleyin.
        }
    }
}
