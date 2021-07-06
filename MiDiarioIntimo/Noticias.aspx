﻿<%@ Page Title="Noticias" Language="C#" MasterPageFile="~/MasterPag.Master" AutoEventWireup="true" CodeBehind="Noticias.aspx.cs" Inherits="MiDiarioIntimo.Noticias" %>
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
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtIdNoticia" runat="server" ErrorMessage="El ID es requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Titulo: </td>
            <td class="auto-style9">
                <asp:TextBox ID="TxtTitulo" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="TxtTitulo" ErrorMessage="El Titulo es Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Fecha:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TxtFechaNoticia" TextMode="date" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtFechaNoticia" Display="Dynamic" ErrorMessage="La Fecha es Requerida" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Descripcion:</td>
            <td class="auto-style9">
                <textarea id="TxADescripcion" cols="25" rows="5"></textarea>
            </td>
            <td class="auto-style10">
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;
                <asp:Button ID="BtnSubirNoticia" runat="server" Text="Registrar" />
                <asp:LinkButton ID="LnkVolver" runat="server" OnClick="LnkVolver_Click">Volver</asp:LinkButton>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
