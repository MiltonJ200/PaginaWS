<%@ Page Title="Calculadora con WS" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="PaginaWS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <p style="text-align:right; font-size:25px">
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>


        <img style="display:block; margin:0 auto; max-width:150px;border-radius:50%" src="https://pbs.twimg.com/media/EomOuu3XMAAhnpU.jpg" alt="Alternate Text" />
        <h1 style="text-align:center; font-size:30px">Calculadora de 2 digitos con Web Services</h1>


        <br>
        <div style="display: flex; justify-content: space-around; color: black">

            <div>
            <p style="text-align:center">A:</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>

            <div>
            <p style="text-align:center">B:</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
  
        </div>

        <br><br>
        <div style="display:flex; justify-content:space-around">
      <asp:Button ID="Button1" runat="server" Text="Suma" style="color: white; background-color: forestgreen; padding: 3px 25px"/>
      <asp:Button ID="Button2" runat="server" Text="Resta" style="color: white; background-color: forestgreen; padding: 3px 25px"/>
      <asp:Button ID="Button3" runat="server" Text="Multiplicación" style="color: white; background-color: forestgreen; padding: 3px 25px"/>
      <asp:Button ID="Button4" runat="server" Text="Division" style="color: white; background-color: forestgreen; padding: 3px 25px"/>
        </div>

  
        <div style="text-align:center; font-size:30px">
        <br>
        <p>Calculando</p>
        <asp:Label ID="Label2" runat="server" Text="..."></asp:Label>
        </div>

</asp:Content>
