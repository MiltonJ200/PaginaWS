<%@ Page Title="Calculadora con WS" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="PaginaWS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron" style="color: white; background-color: rgb(31, 31, 31);">
        <h1>Calculadora con Web Service&nbsp;&nbsp; <asp:Image ID="Image1" runat="server" Height="121px" ImageUrl="~/img/logo.png" Width="121px" />
            &nbsp;&nbsp;
        </h1>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p class="lead">Calculadora empleando WS para hacer las operaciones basicas de 2 numeros:</p>

        <p>Ingrese los valores por favor...</p>

        <div style="display: flex; justify-content: space-between; align-items: center; color: black">

    <div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>





  
        <p style="color: white">Ahora elija la operación a realizar...</p>
        <p>

            <asp:Button ID="Button1" runat="server" Text="Suma" style="color: black; background-color: white; border-radius: 25px; padding: 3px 15px"/>
&nbsp;<asp:Button ID="Button2" runat="server" Text="Resta" style="color: black; background-color: white; border-radius: 25px; padding: 3px 15px"/>
&nbsp;<asp:Button ID="Button3" runat="server" Text="Multiplicación" style="color: black; background-color: white; border-radius: 25px; padding: 3px 15px"/>
&nbsp;<asp:Button ID="Button4" runat="server" Text="Division" style="color: black; background-color: white; border-radius: 25px; padding: 3px 15px"/>

        </div>
            <div style="color: white">
        </p>
        <p>Resultado:</p>
        <p>
         
            <asp:Label ID="Label2" runat="server" Text="Espeando operación..."></asp:Label>
            
        </p>
        </div>
             </div>

        </div>

    

</asp:Content>
