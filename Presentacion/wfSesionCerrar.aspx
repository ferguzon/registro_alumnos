<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfSesionCerrar.aspx.cs" Inherits="Presentacion.wfCerrarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td>
                <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#000099" Text="La sesión se ha cerrado correctamente. El usuario será redirigido a la página de inicio."></asp:Label>
            &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Timer ID="Timer1" runat="server" Interval="3000" OnTick="Timer1_Tick1">
                </asp:Timer>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" Text="Regresar" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
