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
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TabloYukle();
        }
        private void TabloYukle()
        {
            //SAYFA YÜKLENİRKEN GRİDVİEWA(TABLOYA) DEĞELERİ ATMAK İÇİN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT yenitbl.UrunBarkodNo, yenitbl.UrunAd, yenitbl.UrunStok, yenitbl.KategoriAdi, yenitbl.KategoriID , tedarikcifirmatbl.TF_İsim, yenitbl.TF_ID FROM tedarikcifirmatbl INNER JOIN (SELECT `UrunBarkodNo`, `UrunAd`, `UrunStok`, urunkategoritbl.KategoriAdi, urunlertbl.KategoriID , `TF_ID` FROM `urunlertbl` INNER JOIN urunkategoritbl ON urunlertbl.KategoriID=urunkategoritbl.KategoriID) AS yenitbl ON tedarikcifirmatbl.TF_ID=yenitbl.TF_ID", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                UrunlerGW.DataSource = dt;
                UrunlerGW.DataBind();
            }
        }

       
        protected void ButtonEkle_Click(object sender, EventArgs e)
        {
            //EKLE BUTONUNA BASTIĞIMIZDA EKLEME İNSERT SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("insert into urunlertbl(UrunAd, UrunStok, KategoriID, TF_ID) values('"+TextBoxUrunAd.Text+ "' , '" +Convert.ToInt64(TextBoxStok.Text)+ "' , '" + Convert.ToInt32(TextBoxKategori.Text) + "', '" + Convert.ToInt32(TextBoxTedarikci.Text) + "');", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            LabelSonuc.Text = "Ekleme İşlemi Başarılı";
            TabloYukle();
        }

        protected void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            //GÜNCELLEME BUTONUNA BASTIĞIMIZDA GERÇEKLEŞEN UPDATE SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("UPDATE urunlertbl SET UrunAd='" + TextBoxUrunAd.Text + "', UrunStok='" + Convert.ToInt64(TextBoxStok.Text) + "', KategoriID='" + Convert.ToInt32(TextBoxKategori.Text) + "', TF_ID='" + Convert.ToInt32(TextBoxTedarikci.Text) + "' WHERE UrunBarkodNo='" + Convert.ToInt32(TextBoxBarkod.Text) + "';", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            LabelSonuc.Text = "Güncelleme İşlemi Başarılı";
            TabloYukle();
        }

        protected void ButtonSil_Click(object sender, EventArgs e)
        {
            //SİL BUTONUNA BASTIĞIMIZDA GERÇEKLEŞEN DELETE SORGUSU VE BURADA SİLDİĞİMİZDE TRİGGER DEVREYE GİRİP silinenurunlertbl'E ÜRÜNÜ EKLİYOR
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("DELETE FROM urunlertbl WHERE UrunBarkodNo='" + Convert.ToInt32(TextBoxBarkod.Text) + "';", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            LabelSonuc.Text = "Silme İşlemi Başarılı";
            TabloYukle();
        }
    }
}