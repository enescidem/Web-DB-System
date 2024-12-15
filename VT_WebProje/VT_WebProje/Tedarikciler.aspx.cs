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
    public partial class Tedarikciler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TabloYukle();
        }

        private void TabloYukle()
        {
            //SAYFA YÜKLENİRKEN GRİDVİEWA(TABLOYA) DEĞELERİ ATMAK İÇİN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlDataAdapter adp = new MySqlDataAdapter("CALL SakliYordam()", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TedarikciGW.DataSource = dt;
                TedarikciGW.DataBind();
            }
        }

        protected void ButtonEkle_Click(object sender, EventArgs e)
        {
            //EKLE BUTONUNA BASTIĞIMIZDA EKLEME İNSERT SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tedarikcifirmatbl(TF_İsim, TF_Telefon, TF_Mail) VALUES('" + TextBoxTedarikciAd.Text + "' , '" + Convert.ToInt64(TextBoxTedarikciTel.Text) + "' , '" + TextBoxTedarikciMail.Text + "');", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            LabelSonuc.Text = "Ekleme İşlemi Başarılı";
            TabloYukle();
        }

        protected void ButtonGuncelle_Click(object sender, EventArgs e)
        {
            //GÜNCELLEME BUTONUNA BASTIĞIMIZDA GERÇEKLEŞEN UPDATE SORGUSU LIKE
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlCommand cmd = new MySqlCommand("UPDATE tedarikcifirmatbl SET TF_İsim='" + TextBoxTedarikciAd.Text + "', TF_Telefon='" + Convert.ToInt64(TextBoxTedarikciTel.Text) + "', TF_Mail='" + TextBoxTedarikciMail.Text + "' WHERE TF_ID LIKE '" + Convert.ToInt32(TextBoxTedarikciID.Text) + "';", con);
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
            MySqlCommand cmd = new MySqlCommand("DELETE FROM tedarikcifirmatbl WHERE TF_ID='" + Convert.ToInt32(TextBoxTedarikciID.Text) + "';", con);
            con.Open();
            MySqlDataReader read;
            read = cmd.ExecuteReader();
            LabelSonuc.Text = "Silme İşlemi Başarılı";
            TabloYukle();
        }
       
    }
}