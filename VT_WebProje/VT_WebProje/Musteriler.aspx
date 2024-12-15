<%@ Page Title="Müşteriler" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Musteriler.aspx.cs" Inherits="VT_WebProje.Musteriler" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1 align="center">MÜŞTERİLER</h1>
            
            <p align="center">
                <h3> <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    TOPLAM MÜŞTERİ SAYINIZ:
                
                <b><asp:Label ID="LabelToplamMusteri" runat="server"></asp:Label>
            <br />
            </b>
                     </b>
            </h3>
                </p>
           
            
            
                MÜŞTERİ ARA:
            <asp:TextBox ID="TextBoxAra" runat="server" OnTextChanged="TextBoxAra_TextChanged" Width="194px"></asp:TextBox>
            <p align="center">
                <asp:GridView align="center" ID="MusterilerGW" runat="server" AutoGenerateColumns="False" Height="359px" Width="1181px">
                    <Columns>
                        <asp:BoundField DataField="MusteriAdi" HeaderText="Müşteri Adı" SortExpression="MusteriAdi" />
                        <asp:BoundField DataField="MusteriSoyadi" HeaderText="Müşteri Soyadı" SortExpression="MusteriSoyadi" />
                        <asp:BoundField DataField="MusteriTelefon" HeaderText="Müşteri Telefon" SortExpression="MusteriTelefon" />
                    </Columns>
                </asp:GridView>
            </p>
            
        </div>
</asp:Content>