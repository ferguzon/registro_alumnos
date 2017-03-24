<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfSesionIniciar.aspx.cs" Inherits="Presentacion.wfIniciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 468px">&nbsp;</td>
            <td>
                <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/Imagenes/Logotipo UCA para FB y correo.png" />
            </td>
        </tr>
        <tr>
            <td style="width: 468px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 468px">Nombre de usuario</td>
            <td>
                <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombreUsuario" runat="server" ControlToValidate="txtNombreUsuario" ErrorMessage="Ingrese el nombre de usuario" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 468px">Clave</td>
            <td>
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvClave" runat="server" ControlToValidate="txtClave" ErrorMessage="Ingrese la clave" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 468px">&nbsp;</td>
            <td>
                <asp:CustomValidator ID="cvErrores" runat="server" ErrorMessage="Por favor verifique los datos de inicio de sesión" ForeColor="Red">*</asp:CustomValidator>
                <asp:ValidationSummary ID="vsResumenErrores" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td style="width: 468px">&nbsp;</td>
            <td>
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
