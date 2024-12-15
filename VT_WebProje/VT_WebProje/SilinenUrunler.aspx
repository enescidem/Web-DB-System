<%@ Page Title="Silinen Ürünler" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Silinen Ürünler.aspx.cs" Inherits="VT_WebProje.Silinen_Ürünler" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1 align="center"><b>SİLİNEN ÜRÜNLER</b></h1>
            <p align="center">
                <asp:Label ID="LabelAd1" runat="server" Text="Ürün Barkod No: "></asp:Label>
                <asp:TextBox ID="TextBoxBarkod" runat="server" Height="26px" Width="64px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="LabelAd" runat="server" Text="Ürün Adı: "></asp:Label>
                <asp:TextBox ID="TextBoxUrunAd" runat="server" Height="26px" Width="182px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
                <asp:Label ID="LabelAd0" runat="server" Text="Ürün Stok Miktarı: "></asp:Label>
                <asp:TextBox ID="TextBoxStok" runat="server" Height="26px" Width="69px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
                <asp:Label ID="LabelAd2" runat="server" Text="Kategori ID: "></asp:Label>
                <asp:TextBox ID="TextBoxKategori" runat="server" Height="26px" Width="68px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
                <asp:Label ID="LabelAd3" runat="server" Text="Tedarikçi Firma ID: "></asp:Label>
                <asp:TextBox ID="TextBoxTedarikci" runat="server" Height="26px" Width="68px"></asp:TextBox>
                </p>
            <p align="center">
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonGeriYukle" runat="server" Text="Ürün Geri Yükle" OnClick="ButtonGeriYukle_Click" />
            &nbsp;&nbsp;&nbsp;
                </p>
            <p align="center">
                &nbsp;<b><asp:Label ID="Label1" runat="server" Text="SONUÇ: "></asp:Label></b>
                <b><asp:Label ID="LabelSonuc" runat="server"></asp:Label></b>
            </p>
                <h4><b>NOT: Tüm Alanları eksiksiz doldurunuz!&nbsp; </b></h4>
               
            <p align="center">
                <asp:GridView align="center" ID="SilinenUrunlerGW" runat="server" Height="228px" Width="1288px" AutoGenerateColumns="False">
                    <Columns >
                        <asp:BoundField DataField="UrunBarkodNo" HeaderText="Ürün Barkod No" SortExpression="UrunBarkodNo" />
                        <asp:BoundField DataField="UrunAd" HeaderText="Ürün Adı" SortExpression="UrunAd" />
                        <asp:BoundField DataField="UrunStok" HeaderText="Ürün Stok Miktarı" SortExpression="UrunStok" />
                        <asp:BoundField DataField="KategoriID" HeaderText="Kategori ID" SortExpression="KategoriID" />
                        <asp:BoundField DataField="TF_ID" HeaderText="Tedarikçi Firma ID" SortExpression="TF_ID" />
                    </Columns>
                </asp:GridView>
            </p>
        </div>
</asp:Content>

