<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfUsuarioAgregar.aspx.cs" Inherits="Presentacion.wfUsuarioAgregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 349px">Nombre de la persona</td>
            <td>
                <asp:TextBox ID="txtNombrePersona" runat="server" Width="309px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombrePersona" runat="server" ControlToValidate="txtNombrePersona" ErrorMessage="Ingrese el nombre de la persona" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 349px">Correo electrónico</td>
            <td>
                <asp:TextBox ID="txtCorreoElectronico" runat="server" Width="309px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCorreoElectronico" runat="server" ControlToValidate="txtNombreUsuario" ErrorMessage="Ingrese la dirección de correo electrónico" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 349px">Nombre de usuario</td>
            <td>
                <asp:TextBox ID="txtNombreUsuario" runat="server" Width="168px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombreUsuario" runat="server" ControlToValidate="txtNombreUsuario" ErrorMessage="Ingrese el nombre de usuario" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 349px">Clave</td>
            <td>
                <asp:TextBox ID="txtClave" runat="server" Width="168px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvClave" runat="server" ControlToValidate="txtClave" ErrorMessage="Ingrese la clave" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 349px">Fecha de ingreso al sistema</td>
            <td>
                <asp:Label ID="lblFechaProceso" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 349px">&nbsp;</td>
            <td>
                <asp:CustomValidator ID="cvErrores" runat="server" ErrorMessage="Ocurrió un error" ForeColor="Red">*</asp:CustomValidator>
                <asp:ValidationSummary ID="vsErrores" runat="server" DisplayMode="List" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td style="width: 349px">&nbsp;</td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                <asp:Label ID="lblResultadoProceso" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#000066"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
