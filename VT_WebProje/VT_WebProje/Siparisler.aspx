<%@ Page Title="Siparişler" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Siparisler.aspx.cs" Inherits="VT_WebProje.Siparisler" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1 align="center">SİPARİŞLER</h1>
             <p align="center">
                <h3> <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    TOPLAM SİPARİŞ SAYISI: <b><asp:Label ID="LabelToplamSiparis" runat="server"></asp:Label>
            <br />
            </b>
                     </b>
            </h3>
                </p>

            <p align="center">
                <asp:GridView align="center" ID="SiparislerGW" runat="server" Height="477px" Width="1341px" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="SiparisNo" HeaderText="Sipariş No" SortExpression="SiparisNo" />
                        <asp:BoundField DataField="MusteriAdi" HeaderText="Müşteri Adı" SortExpression="MusteriAdi" />
                        <asp:BoundField DataField="MusteriSoyadi" HeaderText="Müşteri Soyadı" SortExpression="MusteriSoyadi" />
                        <asp:BoundField DataField="MusteriTelefon" HeaderText="Müşteri Telefon" SortExpression="MusteriTelefon" />
                        <asp:BoundField DataField="UrunAd" HeaderText="Sipariş Edilen Ürün Adı" SortExpression="UrunAd" />
                        <asp:BoundField DataField="SatilanUrunAdedi" HeaderText="Satılan Ürün Adedi" SortExpression="SatilanUrunAdedi" />
                    </Columns>
                </asp:GridView>
            </p>
        </div>
</asp:Content>