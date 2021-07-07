<%@ Page Title="Donaciones" Language="C#" MasterPageFile="~/MasterPag.Master" AutoEventWireup="true" CodeBehind="Donaciones.aspx.cs" Inherits="MiDiarioIntimo.Donaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Tabla para donar -->
        <div class="fondo"></div>
        <div class="bg-text">
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style3" id="Title" colspan="2">Donaciones&nbsp;</td>
            </tr>  
            <tr>
                <td class="auto-style2">Id Donacion:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtIdDonacion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Monto:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtCantidad_Donacion" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">Metodo de pago: </td>
                <td class="auto-style4">
                    <!-- Cargar la clase MTD de pago -->
                    <asp:DropDownList ID="DrpMetodoPago" runat="server">
                    </asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="BtnDonar" runat="server" Text="Donar" Width="101px" OnClick="BtnDonar_Click" />
                    <br />
                    <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                    <br />
                </td>
            </tr>
        </table>
        <!-- Evidencia de las donaciones -->
        <div>
            <asp:GridView ID="GrdDonaciones" align="center"  runat="server"></asp:GridView>
        </div></div>


</asp:Content>
