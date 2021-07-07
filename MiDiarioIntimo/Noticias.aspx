<%@ Page Title="Noticias" Language="C#" MasterPageFile="~/MasterPag.Master" AutoEventWireup="true" CodeBehind="Noticias.aspx.cs" Inherits="MiDiarioIntimo.Noticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
        .auto-style1 {
            width: 60%;
        }
        .auto-style2 {
            height: 23px;
            width: 1019px;
        }
        .auto-style3 {
            width: 297px;
        }
        .auto-style4 {
            height: 23px;
            width: 297px;
        }
        .auto-style5 {
            width: 1019px;
        }
        .auto-style6 {
            width: 286px;
        }
        .auto-style7 {
            height: 23px;
            width: 286px;
        }
        .auto-style8 {
            width: 297px;
            height: 26px;
        }
        .auto-style9 {
            width: 286px;
            height: 26px;
        }
        .auto-style10 {
            width: 1019px;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table class="auto-style1">
        <tr>
            <td class="auto-style3"><strong><em>Ingresar una Noticia</em></strong></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Id de la noticia</td>
            <td class="auto-style6">
                <asp:TextBox ID="TxtIdNoticia" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Titulo: </td>
            <td class="auto-style9">
                <asp:TextBox ID="TxtTitulo" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style10">
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Fecha:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TxtFechaNoticia" TextMode="date" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Descripcion:</td>
            <td class="auto-style9">
                <asp:TextBox id="TxTDescripcion" TextMode="multiline" Columns="50" Rows="5" runat="server" />
            </td>
            <td class="auto-style10">
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;
                <asp:Button ID="BtnCrearNoticia" runat="server" Text="Registrar" OnClick="btnCrearNoticia_Click" />
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                <asp:LinkButton ID="LnkVolver" runat="server" OnClick="LnkVolver_Click">Volver</asp:LinkButton>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="GrdNoticias" align="center"  runat="server"></asp:GridView>
    <br />
    <asp:TextBox ID="TxtBuscarNoticia" runat="server"></asp:TextBox>
    <asp:Button ID="BtnEliminar" runat="server" onclick="btnEliminarNoticia_Click" Text="Eliminar Noticia" />
    <asp:Button ID="BtnBuscar" runat="server" onclick="btnBuscarNoticia_Click" Text="Comprobar si Existe" />
    <asp:Label ID="LbBorrar" runat="server" Text=""></asp:Label>

</asp:Content>
