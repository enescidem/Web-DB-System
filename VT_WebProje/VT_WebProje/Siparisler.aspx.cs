using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VT_WebProje
{
    public partial class Siparisler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TabloYukle();
            //TOPLAM SİPARİŞ SAYISINI BULAN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT count(SiparisNo) as siparistoplam FROM siparistbl", con);
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            LabelToplamSiparis.Text = Convert.ToString(read["siparistoplam"]);
        }
        private void TabloYukle()
        {
            //SAYFA YÜKLENİRKEN GRİDVİEWA(TABLOYA) DEĞELERİ ATMAK İÇİN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT s.SiparisNo,m.MusteriAdi,m.MusteriSoyadi,m.MusteriTelefon, u.UrunAd, s.SatilanUrunAdedi FROM urunlertbl AS u, siparistbl AS s, musteritbl AS m WHERE u.UrunBarkodNo=s.UrunBarkodNo AND s.MusteriTelefon=m.MusteriTelefon ORDER BY S.SatilanUrunAdedi DESC", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SiparislerGW.DataSource = dt;
                SiparislerGW.DataBind();
            }
        }
    }
}