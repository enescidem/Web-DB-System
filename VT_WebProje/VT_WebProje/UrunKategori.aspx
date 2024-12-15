<%@ Page Title="Ürün Kategorileri" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UrunKategori.aspx.cs" Inherits="VT_WebProje.UrunKategori" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1 align="center">ÜRÜN KATEGORİLERİ</h1>
            <p align="center">
                <asp:Label ID="Label1" runat="server" Text="Kategori ID"></asp:Label>
                :<asp:TextBox ID="TextBoxKategoriID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Kategori Adı:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxKategoriAd" runat="server"></asp:TextBox>
            </p>
            <p align="center">
                <asp:Button ID="ButtonEkle" runat="server" OnClick="ButtonEkle_Click" Text="EKLE" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonGuncelle" runat="server" OnClick="ButtonGuncelle_Click" Text="GÜNCELLE" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonSil" runat="server" OnClick="ButtonSil_Click" Text="SİL" />
            </p>
            <p align="center">
                <asp:Label ID="Label3" runat="server" Text="SONUC: "></asp:Label>
                <asp:Label ID="LabelSonuc" runat="server"></asp:Label>
            </p>

            <h4><b>NOT:&nbsp; </b></h4>
            <h4><b>Ürün Silmek için sadece Kategori ID girmeniz yeterlidir! </b></h4>
            <h4><b>Ürün Güncellemek İçin Tüm alanları doldurun! </b></h4>
            <h4><b>Ürün Eklemek için Kategori ID hariç hepsini doldurunuz!</b></h4>
            <p>&nbsp;</p>
            <p align="center">
                <asp:GridView align="center" ID="UrunKategoriGW" runat="server" AutoGenerateColumns="False" Height="164px" Width="1158px">
                    <Columns>
                        <asp:BoundField DataField="KategoriID" HeaderText="Kategori ID" SortExpression="KategoriID" />
                        <asp:BoundField DataField="KategoriAdi" HeaderText="Kategori Adı" SortExpression="KategoriAdi" />
                    </Columns>
                </asp:GridView>

            </p>
                
            
        </div>
</asp:Content>