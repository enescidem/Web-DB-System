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
    public partial class Musteriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TabloYukle();//Tabloyu sayfa yüklenirken aktarıyoruz.
            //TOPLAM MÜŞTERİ SAYISINI BULAN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT count(MusteriAdi) as musteritoplam FROM musteritbl", con);
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            LabelToplamMusteri.Text = Convert.ToString(read["musteritoplam"]);
        }
        private void TabloYukle()
        {
            //SAYFA YÜKLENİRKEN GRİDVİEWA(TABLOYA) DEĞELERİ ATMAK İÇİN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM musteritbl ORDER BY MusteriAdi", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MusterilerGW.DataSource = dt;
                MusterilerGW.DataBind();
            }
        }

        protected void TextBoxAra_TextChanged(object sender, EventArgs e)
        {
            //ARAMA TEXTBOXINA GİRİLEN DEĞERLERE GÖRE TABLODAN O KİŞİYİ DÖNDÜRME VE GRİDVİEWA(TABLOYA) DEĞELERİ ATMAK İÇİN SQL SORGUSU
            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';");
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM musteritbl WHERE MusteriAdi LIKE '" + TextBoxAra.Text + "%'", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            MusterilerGW.DataSource = dt;
            MusterilerGW.DataBind();
            con.Close();
        }
    }
}