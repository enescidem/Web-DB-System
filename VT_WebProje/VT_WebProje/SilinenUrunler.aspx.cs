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
    public partial class Silinen_Ürünler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TabloYukle();
        }
        private void TabloYukle()
        {
            //SAYFA YÜKLENİRKEN GRİDVİEWA(TABLOYA) DEĞELERİ ATMAK İÇİN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM silinenurunlertbl", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count >= 0)
            {
                SilinenUrunlerGW.DataSource = dt;
                SilinenUrunlerGW.DataBind();
            }
        }

        protected void ButtonGeriYukle_Click(object sender, EventArgs e)
        {
            //GERİ YÜKLE BUTONUNA BASTIĞIMIZDA EKLEME İNSERT SORGUSU 
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("insert into urunlertbl(UrunBarkodNo, UrunAd, UrunStok, KategoriID, TF_ID) values('" +Convert.ToInt32(TextBoxBarkod.Text) + "' ,'" + TextBoxUrunAd.Text + "' , '" + Convert.ToInt64(TextBoxStok.Text) + "' , '" + Convert.ToInt32(TextBoxKategori.Text) + "', '" + Convert.ToInt32(TextBoxTedarikci.Text) + "');", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            read.Close();
            //VE DELETE SORGUSU
            MySqlCommand cmd1 = new MySqlCommand("DELETE FROM silinenurunlertbl WHERE UrunBarkodNo='" + Convert.ToInt32(TextBoxBarkod.Text) + "';", con);
            MySqlDataReader read1;
            read1 = cmd1.ExecuteReader();
            LabelSonuc.Text = "Geri Yükleme İşlemi Başarılı";
            TabloYukle();
        }
        
    }
}