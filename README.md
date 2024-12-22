# Web-DB-System
 
# Market Admin Paneli DB Projesi

## Proje Hakkında
Bu proje, market yöneticilerinin ürün, müşteri, sipariş ve tedarikçi bilgilerini kolayca yönetebileceği bir yönetim paneli uygulamasıdır.

MySQL veritabanında temel SQL sorguları ile INNER JOIN, LEFT JOIN, Saklı Prosedürler (Stored Procedures) ve Tetikleyiciler (Triggers) gibi ileri teknikler kullanılarak geliştirilmiş bir market yönetim sistemi sunar.

---

## İçindekiler
1. [Projenin Amacı](#projenin-amacı)
2. [Teknolojiler](#teknolojiler)
3. [ER Diyagram](#er-diyagram)
4. [Tablolar Arasındaki İlişkiler](#tablolar-aras%C4%B1ndaki-i%CC%87li%C5%9Fkiler)
5. [Ana Sayfa (Default)](#ana-sayfa-default)
6. [Ürünler Sayfası](#%C3%BCr%C3%BCnler-sayfas%C4%B1)
   - [Tabloyu Getiren SQL Sorgusu](#tabloyu-getiren-sql-sorgusu)
   - [Ürün Ekleme](#%C3%BCr%C3%BCn-ekleme)
   - [Ürün Güncelleme](#%C3%BCr%C3%BCn-g%C3%BCncelleme)
   - [Ürün Silme](#%C3%BCr%C3%BCn-silme)
7. [Silinen Ürünler Sayfası](#silinen-%C3%BCr%C3%BCnler-sayfas%C4%B1)
   - [Tabloyu Getiren SQL Sorgusu](#tabloyu-getiren-sql-sorgusu-1)
   - [Ürün Geri Yükleme](#%C3%BCr%C3%BCn-geri-y%C3%BCkleme)
8. [Müşteriler Sayfası](#m%C3%BC%C5%9fteriler-sayfas%C4%B1)
   - [Tabloyu Getiren SQL Sorgusu](#tabloyu-getiren-sql-sorgusu-2)
   - [Toplam Müşteri Sayısını Getiren SQL Sorgusu](#toplam-m%C3%BC%C5%9fteri-say%C4%B1s%C4%B1n%C4%B1-getiren-sql-sorgusu)
   - [Müşteri Arama](#m%C3%BC%C5%9fteri-arama)
9. [Siparişler Sayfası](#sipari%C5%9fler-sayfas%C4%B1)
   - [Tabloyu Getiren SQL Sorgusu](#tabloyu-getiren-sql-sorgusu-3)
   - [Toplam Sipariş Sayısını Getiren SQL Sorgusu](#toplam-sipari%C5%9f-say%C4%B1s%C4%B1n%C4%B1-getiren-sql-sorgusu)
10. [Ürün Kategorileri Sayfası](#%C3%BCr%C3%BCn-kategorileri-sayfas%C4%B1)
    - [Tabloyu Getiren SQL Sorgusu](#tabloyu-getiren-sql-sorgusu-4)
    - [Ürün Kategorisi Ekleme](#%C3%BCr%C3%BCn-kategorisi-ekleme)
    - [Ürün Kategorisi Güncelleme](#%C3%BCr%C3%BCn-kategorisi-g%C3%BCncelleme)
    - [Ürün Kategorisi Silme](#%C3%BCr%C3%BCn-kategorisi-silme)
11. [Tedarikçiler Sayfası](#tedarik%C3%A7iler-sayfas%C4%B1)
    - [Tabloyu Getiren SQL Sorgusu](#tabloyu-getiren-sql-sorgusu-5)
    - [Tedarikçi Ekleme](#tedarik%C3%A7i-ekleme)
    - [Tedarikçi Güncelleme](#tedarik%C3%A7i-g%C3%BCncelleme)
    - [Tedarikçi Silme](#tedarik%C3%A7i-silme)

---

## Projenin Amacı
Bu projede amaç, bir market yönetici paneli oluşturarak kullanıcı dostu bir sistem sunmaktır. Proje, yöneticilerin:

- Market veritabanını etkin bir şekilde yönetmesini,
- Ürün bilgilerini eklemesini, güncellemesini ve silmesini,
- Silinen ürünleri kayıtlardan geri yüklemesini,
- Müşteri bilgilerini takip etmesini ve arama yapmasını,
- Sipariş kayıtlarını listelemesini ve analiz etmesini,
- Tedarikçi bilgilerinin düzenlenmesini ve yönetilmesini sağlamayı hedefler.

---

## Teknolojiler
- **Programlama Dili:** C#
- **Veritabanı:** MySQL
- **Araçlar:** Visual Studio IDE
- **Veritabanı İlişkileri:** INNER JOIN, LEFT JOIN, TRIGGER, STORED PROCEDURE (Saklı Yordam)
- **UI:** ASP.NET Web Forms

---

## ER Diyagram
![image](https://github.com/user-attachments/assets/7402a902-70e0-4571-9929-5b566427c951)


---

## Tablolar Arasındaki İlişkiler
![image](https://github.com/user-attachments/assets/3e2e3239-e5a6-4ca2-a936-bf3037d35bd1)
Yanında anahtar işareti bulunan nitelikler PRİMARY KEY’dir. 

Burada okların ucundaki yuvarlaklara baktığımızda küçük olan yuvarlaklar Herhangi bir tablonun PRİMARY KEY’ini Büyük olan yuvarlaklar ise o primary keyin diğer tabloda FOREIGN KEY olarak kullanıldığını göstermektedir.  

ÖRNEK olarak: urunkategoritbl tablosunun PRİMARY KEY’i olan KategoriID, urunlertbl tablosunda yine KategoriID ismini alarak FOREIGN KEY olmuştur. 

![image](https://github.com/user-attachments/assets/4e4f0548-be00-471f-be74-d6518479ee97)

![image](https://github.com/user-attachments/assets/ef310863-9c05-4c18-846e-87d1cedb5795)

![image](https://github.com/user-attachments/assets/d6a8b9bd-ec2e-4acd-a468-3c33ea0cf0a7)
siparistbl’de SiparisNo niteliği auto increment dır yani otomatik artan bir değerdir. Burada MusteriTelefon’un musteritbl tablosundaki MusteriTelefon niteliği ile ilişkisi olduğunu görüyoruz. 

Aynı şekilde UrunBarkodNo’nun da urunlertbl tablosundaki UrunBarkodNo ile ilişkisi olduğunu görüyoruz. 

![image](https://github.com/user-attachments/assets/cb1af9eb-ed03-40cd-9930-e5909255305e)
tedarikcifirmatbl'de TF_ID niteliği auto increment dır yani otomatik artan bir değerdir.

![image](https://github.com/user-attachments/assets/15db8128-de42-48eb-94b8-08cd7a6b7ab7)
urunkategoritbl'de KategoriID niteliği auto increment dır yani otomatik artan bir değerdir. 

![image](https://github.com/user-attachments/assets/302db8a3-633e-4dce-a093-01d73f180af7)
uruntbl’de UrunBarkodNo niteliği auto increment dır yani otomatik artan bir değerdir. Burada farklı olarak UrunStok niteliğinin DEFAULT değeri olduğunu görüyoruz (0 olarak). KategoriID niteliği ise urunkategoritbl tablosunda bulunan KategoriID niteliği ile ilişkilidir. Aynı şekilde TF_ID niteliği de tedarikcifirmatbl tablosunda bulunan TF_ID niteliği ile ilişki kurulmuştur. 

---

## Ana Sayfa (Default)
![image](https://github.com/user-attachments/assets/b3816caa-2d6a-4ada-abc2-b08704ed4aa6)
Düz ana sayfa herhangi bir sql sorgusu bulunmamaktadır.

---

## Ürünler Sayfası
![image](https://github.com/user-attachments/assets/59424304-c20c-45fa-8a82-66b0599e84a5)

### Tabloyu Getiren SQL Sorgusu
```csharp
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
```
Bu kod bloğunda SELECT komutu ile Veri Tabanında oluşturduğumuz tabloyu UrunlerGW GridView’ına (Tablo’ya) aktarıyoruz. Daha sonra TabloYukle() fonksiyonu Sayfa Yüklenirken(Page_Load) da çalıştırıyoruz.  

Buradaki sorguda alt sorgudan (SELECT `UrunBarkodNo`, `UrunAd`, `UrunStok`, urunkategoritbl.KategoriAdi, urunlertbl.KategoriID , `TF_ID` FROM `urunlertbl` INNER JOIN urunkategoritbl ON urunlertbl.KategoriID=urunkategoritbl.KategoriID) dönen tablo: 

PHPMYADMİN MYSQL Veri Tabanı Yönetim Sisteminde:
![image](https://github.com/user-attachments/assets/306b40fd-7870-4e9c-a6c2-ed0660f2df11)
Budur. Bu alt sorgudan dönen tabloda ”yenitbl” ismini verdim. Tüm sorgudan dönen tablo ise: 
![image](https://github.com/user-attachments/assets/f217a510-a135-414f-b68d-d808c61f1ecb)
Budur. Burada alt sorgu ile 3 tabloyu JOIN işlemi ile birleştirip toplu bir tablo oluşturdum.

### Ürün Ekleme
```csharp
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
```
Burada textboxlardan aldığım verileri doğru veri tiplerine çevirerek veritabanına INSERT ediyorum ve en son da TabloYukle() fonksiyonunu çağırarak tabloyu güncelliyorum. Basit bir ekleme işlemi:
![image](https://github.com/user-attachments/assets/da9121d5-14d4-4ee0-a3c1-268e635fa608)
Ekleme işleminden sonra oluşan sayfa üsttedir.

---

### Ürün Güncelleme
```csharp
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
```
Burada textboxlardan aldığım verileri doğru veri tiplerine çevirerek veritabanındaki girilen barkodno ile eşleştirerek güncelliyorum ve en son da TabloYukle() fanksiyonunu çağırarak tabloyu güncelliyorum. Basit bir UPDATE işlemi: 
![image](https://github.com/user-attachments/assets/adf65dca-7cb8-47f7-969b-26b13d306847)
Güncelleme işleminden sonra oluşan tablo üstte gösterildiği gibidir. 

---

### Ürün Silme
```csharp
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
```
Burada textboxdan alınan Barkod No ile veritabanında bulunan UrunBarkodNo eşleşmesi ile DELETE işlemi oluyor. Bu sırada TRİGGER ile DELETE işleminden önce(BEFORE) silinenurunlertbl’ye silinen ürün INSERT ediliyor.  

YAZDIĞIM TRİGGER SORGUSU:
![image](https://github.com/user-attachments/assets/3180963e-fa34-4d65-bdbc-d506ac049842)
Basit bir silme işlemi yapalım:
![image](https://github.com/user-attachments/assets/54e0d314-b51b-43bc-ad9d-dd07e4249e62)
Tablonun son durumu böyle oluyor. Şimdide konuyla alakalı olan Silinen Ürünler Sayfasına geçelim. 

---

## Silinen Ürünler Sayfası
![image](https://github.com/user-attachments/assets/6731ce48-8f97-4ac1-bbc0-381f49cc338f)
Gördüğümüz gibi silinen ürün tabloya aktarılmış. Tabloyu getiren SQL sorgusuna bakalım.

### Tabloyu Getiren SQL Sorgusu
```csharp
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
```
Bu kod bloğunda SELECT komutu ile Veri Tabanında oluşturduğumuz silinenurunlertbl tabloyu SilinenUrunlerGW GridView’ına (Tablo’ya) aktarıyoruz. Daha sonra TabloYukle() fonksiyonu Sayfa Yüklenirken(Page_Load) da çalıştırıyoruz. 

---

### Ürün Geri Yükleme
```csharp
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
```
Bu kod bloğunda öncelikle Geri Yükle butonuna bastığımzda urunlertbl tablosuna textboxlardan alınan verileri INSERT ediyoruz. Daha sonra  DELETE sorgusu ile silinenurunlertbl den geri yükleyeceğimiz veriyi siliyoruz. 

Verileri girip ürün geri yükle dediğimizde oluşan durum: 

SİLİNEN ÜRÜNLER SAYFASI:
![image](https://github.com/user-attachments/assets/16679a59-dc08-47a2-876d-3a58d0946bf4)

ÜRÜNLER SAYFASI:
![image](https://github.com/user-attachments/assets/a79438bc-705b-45b1-ae65-378fd204c24f)
Gördüğümüz gibi silinen ürünlerden silinip ürünler tablosuna geri eklenmiş oldu. 

---

## Müşteriler Sayfası
![image](https://github.com/user-attachments/assets/b2a54ce3-8e2a-47fb-bbb6-ada425bd5aa2)

### Tabloyu Getiren SQL Sorgusu
```csharp
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
```
Bu kod bloğunda SELECT komutu ile Veri Tabanında oluşturduğumuz musteritbl tabloyu MusteriAdi’na göre ORDER BY (ASC yazmamamın sebebi ORDER BY’ın default olarak ASC döndürmesidir.) ile alfabetik olarak sıralıyoruz. MusterilerGW GridView’ına (Tablo’ya) aktarıyoruz. Daha sonra TabloYukle() fonksiyonu Sayfa Yüklenirken(Page_Load) da çalıştırıyoruz. 

---

### Toplam Müşteri Sayısını Getiren SQL Sorgusu
```csharp
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
```
Bu kod bloğunda SELECT sorgusu ile MusteriAdi’nı count yapıyorum yani kaç adet Müşteri olduğunu buluyorum ve bunu as yardımı ile musteritoplam ismini veriyorum. Son olarak da labela musteritoplam değerini atıyorum. 

---

### Müşteri Arama
```csharp
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
```
Bu kod bloğunda SELECT sorgusu ile tüm tabloyu döndürüyorum. Fakat WHERE sorgusu ile ise MusteriAdi’nı LIKE ile TextBoxAra’dan dönen kelimeye veya harfe göre % joker karakteri ile arıyorum.(Örnek  TextBoxAra’ya a yazdığımızda a% olarak SQL sorgusu dönücek ve a ile başlayan Müşteriler gelicek.)  

Örnek bir arama işlemi:
![image](https://github.com/user-attachments/assets/4e594f47-88c0-4f1f-8d19-935314ad3faa)

---

## Siparişler Sayfası
![image](https://github.com/user-attachments/assets/43ae3fbd-d669-4920-8894-cfecd7118103)

### Tabloyu Getiren SQL Sorgusu
```csharp
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
```
Bu kod bloğunda biraz uzun SQL sorgumuz var. Öncelikle urunlertbl tablosuna u ismini siparistbl tablosuna s ismini ve musteritbl tablosuna m ismini veriyoruz daha sonra SELECT ile tabloda hangi sütunların olacağını beliliyorum s.SiparisNo gibi. Daha sonra WHERE ile urunlertbl tablosundaki UrunBarkodNo ile siparistbl tablosundaki UrunBarkodNo su eşit olan ve siparistbl tablosundaki MusteriTelefon ile musteritbl tablosundaki MusteriTelefon eşit olan değerleri döndürüyor. ORDER BY ve DESC ile siparistbl tablosundaki SatilanUrunAdedi en yüksekten küçüğe doğru sıralanıyor.

---

### Toplam Sipariş Sayısını Getiren SQL Sorgusu
```csharp
public partial class Siparisler : System.Web.UI.Page 

    { 

        protected void Page_Load(object sender, EventArgs e) 

        { 

            TabloYukle();//TABLOYU SAYFA YÜKLENİRKEN AKTARIYORUZ 

            //TOPLAM SİPARİŞ SAYISINI BULAN SQL SORGUSU 

            MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=marketveritabani; Uid=root; Pwd='';"); 

            con.Open(); 

            MySqlCommand cmd = new MySqlCommand("SELECT count(SiparisNo) as siparistoplam FROM siparistbl", con); 

            MySqlDataReader read = cmd.ExecuteReader(); 

            read.Read(); 

            LabelToplamSiparis.Text = Convert.ToString(read["siparistoplam"]); 

        } 
```
BU kod bloğunda SELECT sorgusu ile SiparisNo’yu count yapıyorum yani kaç adet Sipariş olduğunu buluyorum ve bunu AS yardımı ile siparistoplam ismini veriyorum. Son olarak da labela musteritoplam değerini atıyorum. 

---

## Ürün Kategorileri Sayfası
![image](https://github.com/user-attachments/assets/8ab2ccde-2f2f-4b11-9c32-596fb59793a8)

### Tabloyu Getiren SQL Sorgusu
```csharp
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
```
Bu kod bloğunda Veri Tabanında oluşturduğumuz VİEW ile urunkategoritbl tablosunu KategoriListesi adlı VİEW'e aktarıyoruz daha sonra UrunKategoriGW GridView’ına (Tablo’ya) SELECT komutu ile seçiyoruz. Daha sonra TabloYukle() fonksiyonu Sayfa Yüklenirken(Page_Load) da çalıştırıyoruz.

#### Oluşturduğum VİEW:
![image](https://github.com/user-attachments/assets/1c6fa07e-ef44-41f1-9494-59322941b156)

---

### Ürün Kategorisi Ekleme
```csharp
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
```
Burada textboxlardan aldığım verileri doğru veri tiplerine çevirerek veritabanına INSERT ediyorum ve en son da TabloYukle() fonksiyonunu çağırarak tabloyu güncelliyorum. Basit bir ekleme işlemi: 
![image](https://github.com/user-attachments/assets/134a8ae0-3ee2-47b0-8d52-7df16163bd96)
Ekleme işleminden sonra oluşan sayfa üsttedir. 

---

### Ürün Kategorisi Güncelleme
```csharp
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
```
Burada textboxlardan aldığım verileri doğru veri tiplerine çevirerek veritabanındaki KategoriID’ye textoxa girilen KategoriID’yi LIKE ile eşleştirip o KategoriID’ye ait verileri güncelliyorum ve en son da TabloYukle() fanksiyonunu çağırarak tabloyu güncelliyorum. Basit bir UPDATE işlemi:
![image](https://github.com/user-attachments/assets/a36e6b20-20c4-4c6c-a5a7-2f8b4b577491)
Güncelleme işleminden sonra oluşan Ürün Kategorileri sayfası üsttedir.  Kategori ID si 1 olan Kategori Adı İçecekler olan kısmı Gazlı İçecekler olarak değiştirdikten sonra Ürünler sayfasındaki tablodaki değişikilik aşağıdadır:
![image](https://github.com/user-attachments/assets/94d0a052-2657-4eec-add7-bd563a04f78f)

---

### Ürün Kategorisi Silme
```csharp
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
```
Burada textboxdan alınan ve veritabanında bulunan KategoriD eşleşmesi ile DELETE işlemi oluyor.  

Örnek bir delete işlemi:  
![image](https://github.com/user-attachments/assets/17b5b781-b9ed-430d-839d-615b006bdf1b)
Kategorideki delete işlemi sonrası Ürünler Sayfasındaki değişim:
![image](https://github.com/user-attachments/assets/e81acad6-a8f7-41bf-b152-aa7a79333fad)
Bunun sebebi tablolaların birbirleri ile ilişkili olmalarıdır. Burada urunkategoritbl’de primary key olan KategoriID’nin urunlertbl’de foreign key olarak kullanılmasıdır. Aynı şekilde Siparişler tablosundaki değişim:
![image](https://github.com/user-attachments/assets/229d8a54-73d3-4567-bb3b-83fde0ec7e6a)
Gördüğümüz gibi sipariş sayısı 7’den 4’e düşmüş ve Gazlı İçecek kategorisinde satın alınan siparişler kaldırılmış. 

---

## Tedarikçiler Sayfası
![image](https://github.com/user-attachments/assets/df37d7e7-e0c0-493e-a093-0431bf82044d)

### Tabloyu Getiren SQL Sorgusu
```csharp
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
```
Bu kod bloğunda Saklı Yordam kullandım. Saklı yordam sayesinde Select Sorgusu yerine CALL SakliYordam() yazarak daha basit ve hızlı bir şekilde TABLO’yu çağırıyoruz. Yazdığım Saklı Yordam:
![image](https://github.com/user-attachments/assets/12360645-6275-4bc8-b975-7b3f10a9207b)

---

### Tedarikçi Ekleme
```csharp
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
```
Bu kod bloğunda INSERT sorgusu görüyoruz. Yukarıda açıkladığım insert sorguları ile aynı mantığa sahip. Basit bir ekleme işlemi görelim. Ürün Kategorilerine Cips eklemiştik onunla alakalı bir firma ekleyelim:
![image](https://github.com/user-attachments/assets/ecaab791-4bbd-43d9-aa31-9c12eb109413)

---

### Tedarikçi Güncelleme
```csharp
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
```
Burada textboxlardan aldığım verileri doğru veri tiplerine çevirerek veritabanındaki TF_ID ile textboxa girilen Tedarikçi ID’yi LIKE ile eşleştirip o KategoriID’ye ait verileri güncelliyorum ve en son da TabloYukle() fanksiyonunu çağırarak tabloyu güncelliyorum. Basit bir UPDATE işlemi:
![image](https://github.com/user-attachments/assets/1e568c91-0b17-416c-8b46-d1c268311281)
Update işlemi sonrası Ürünler tablosundaki değişim:
![image](https://github.com/user-attachments/assets/33696bb0-4f73-4414-bac6-71db879cb380)
Bunun sebebi tablolaların birbirleri ile ilişkili olmalarıdır. Burada tedarikcifirmatbl’de primary key olan TF_ID’nin urunlertbl’de foreign key olarak kullanılmasıdır.

---

### Tedarikçi Silme
```csharp
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
```
Yine yukarda yaptıklarımız gibi klasik bir DELETE işlemidir. Örnek bir silme işlemi:
![image](https://github.com/user-attachments/assets/b77ded03-6f3c-45ec-8c19-54ccb9273436)

---

