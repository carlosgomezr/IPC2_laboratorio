<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IPC2_laboratorio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Crear Usuario</h1>
        <p>Nombre:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="289px"></asp:TextBox>
        </p>
        <p>Edad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="289px"></asp:TextBox>
        </p>
        <p>&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear Usuario" class="btn btn-primary btn-lg" Height="44px" Width="180px"/>
            &nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mostrar Usuarios" class="btn btn-primary btn-lg" Height="44px" Width="180px"/>
        &nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Probar Conexión" class="btn btn-primary btn-lg" Height="44px" Width="180px"/>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
