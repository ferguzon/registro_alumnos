<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfUsuarioCambioClave.aspx.cs" Inherits="Presentacion.wfCambioClave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 332px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#003399" Text="Formulario para cambio de contraseña"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 332px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 332px">Nombre del usuario</td>
            <td>
                <asp:Label ID="lblUsuario" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 332px">Ingrese la nueva clave</td>
            <td>
                <asp:TextBox ID="txtNuevaClave" runat="server" TextMode="Password" Width="172px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 332px">Repita la nueva clave</td>
            <td>
                <asp:TextBox ID="txtRepetirNuevaClave" runat="server" TextMode="Password" Width="172px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 332px">&nbsp;</td>
            <td>
                <asp:CustomValidator ID="cvErrores" runat="server" ForeColor="Red"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 332px">&nbsp;</td>
            <td>
                <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Cancelar" />
                <asp:Button ID="btnActualizarClave" runat="server" Text="Actualizar clave" OnClick="btnActualizarClave_Click" />
            &nbsp;<asp:Label ID="lblResultado" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#003399"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
