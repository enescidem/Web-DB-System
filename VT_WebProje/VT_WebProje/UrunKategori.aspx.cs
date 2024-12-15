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
    public partial class UrunKategori : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TabloYukle();
        }

        private void TabloYukle()
        {
            //SAYFA YÜKLENİRKEN GRİDVİEWA(TABLOYA) VİEW KULLANARAK DEĞELERİ ATMAK İÇİN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM KategoriListesi", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                UrunKategoriGW.DataSource = dt;
                UrunKategoriGW.DataBind();
            }
        }

        protected void ButtonEkle_Click(object sender, EventArgs e)
        {
            //EKLE BUTONUNA BASTIĞIMIZDA EKLEME İNSERT SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("insert into urunkategoritbl(KategoriAdi) values('" + TextBoxKategoriAd.Text + "');", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            LabelSonuc.Text = "Ekleme İşlemi Başarılı";
            TabloYukle();
        }

        protected void ButtonGuncelle_Click(object sender, EventArgs e)
        {
            //GÜNCELLEME BUTONUNA BASTIĞIMIZDA GERÇEKLEŞEN UPDATE SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("UPDATE urunkategoritbl SET KategoriAdi='" + TextBoxKategoriAd.Text + "' WHERE KategoriID LIKE '" + Convert.ToInt32(TextBoxKategoriID.Text) + "';", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            LabelSonuc.Text = "Güncelleme İşlemi Başarılı";
            TabloYukle();
        }

        protected void ButtonSil_Click(object sender, EventArgs e)
        {
            //SİL BUTONUNA BASTIĞIMIZDA GERÇEKLEŞEN DELETE SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("DELETE FROM urunkategoritbl WHERE KategoriID='" + Convert.ToInt32(TextBoxKategoriID.Text) + "';", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            LabelSonuc.Text = "Silme İşlemi Başarılı";
            TabloYukle();
        }
    }
}