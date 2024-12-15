<%@ Page Title="Tedarikçiler" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Tedarikciler.aspx.cs" Inherits="VT_WebProje.Tedarikciler" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1 align="center">TEDARİKÇİLER</h1>
            <p align="center">
                <asp:Label ID="Label1" runat="server" Text="Tedarikçi ID: "></asp:Label>
                <asp:TextBox ID="TextBoxTedarikciID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Tedarikçi Adı: "></asp:Label>
                <asp:TextBox ID="TextBoxTedarikciAd" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Tedarikçi Telefon: "></asp:Label>
                <asp:TextBox ID="TextBoxTedarikciTel" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Tedarikçi Mail: "></asp:Label>
                <asp:TextBox ID="TextBoxTedarikciMail" runat="server"></asp:TextBox>
            </p>
            <p align="center">
                <asp:Button ID="ButtonEkle" runat="server" OnClick="ButtonEkle_Click" Text="EKLE" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonGuncelle" runat="server" OnClick="ButtonGuncelle_Click" Text="GÜNCELLE" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonSil" runat="server" OnClick="ButtonSil_Click" Text="SİL" />
            </p>
            <p align="center">
                <asp:Label ID="Label5" runat="server" Text="SONUC: "></asp:Label>
                <asp:Label ID="LabelSonuc" runat="server"></asp:Label>
            </p>
            <h4><b>NOT:&nbsp; </b></h4>
            <h4><b>Ürün Silmek için sadece Tedarikçi ID girmeniz yeterlidir! </b></h4>
            <h4><b>Ürün Güncellemek İçin Tüm alanları doldurun! </b></h4>
            <h4><b>Ürün Eklemek için Tedarikçi ID hariç hepsini doldurunuz!</b></h4>
            <p>&nbsp;</p>
           
            
                <asp:GridView align="center" ID="TedarikciGW" runat="server" AutoGenerateColumns="False" Height="232px" Width="1349px">
                    <Columns>
                        <asp:BoundField DataField="TF_ID" HeaderText="Tedarikçi ID" SortExpression="TF_ID" />
                        <asp:BoundField DataField="TF_İsim" HeaderText="Tedarikçi Adı" SortExpression="TF_İsim" />
                        <asp:BoundField DataField="TF_Telefon" HeaderText="Tedarikçi Telefon" SortExpression="TF_Telefon" />
                        <asp:BoundField DataField="TF_Mail" HeaderText="Tedarikçi Mail" SortExpression="TF_Mail" />
                    </Columns>
                </asp:GridView>
           
        </div>
</asp:Content>
