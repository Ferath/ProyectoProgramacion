<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/MasterPag.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MiDiarioIntimo.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Grid para mostrar las noticias, que será reemplazado una vez se haga el llamado desde la BD -->
    <asp:GridView ID="GrdNoticias" align="center"  runat="server"></asp:GridView>

</asp:Content>
