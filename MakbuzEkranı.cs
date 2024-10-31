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

namespace yurt_uygulaması
{
    public partial class MakbuzEkranı : Form
    {
        public MakbuzEkranı()
        {
            InitializeComponent();
        }

        private void MakbuzEkranı_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"YOUR_SQL_CONNECTION");
            connection.Open();
            SqlCommand listele = new SqlCommand("select * from borcCetveli where TC like '%" + OdemeEkrani.tc + "%'", connection);
            SqlDataReader read = listele.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();

                add.Text = read["id"].ToString();
                add.SubItems.Add(read["TaksitNo"].ToString());
                add.SubItems.Add(read["KalanBorc"].ToString());
                add.SubItems.Add(read["OdenenMiktar"].ToString());
                add.SubItems.Add(read["OdemeTarihi"].ToString());
                add.SubItems.Add(read["ToplamTaksit"].ToString());
                add.SubItems.Add(read["KalanTaksit"].ToString());

                listView1.Items.Add(add);

            }
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
