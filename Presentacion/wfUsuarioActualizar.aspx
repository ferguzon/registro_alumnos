<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfUsuarioActualizar.aspx.cs" Inherits="Presentacion.wfUsuarioActualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:MultiView ID="mvAgruparVistas" runat="server">
        <asp:View ID="vwBuscarUsuario" runat="server">
            <table class="nav-justified">
                <tr>
                    <td style="width: 499px">Nombre de usuario</td>
                    <td>
                        <asp:TextBox ID="txtLoginUsuario" runat="server" Width="210px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvLoginUsuario" runat="server" ControlToValidate="txtLoginUsuario" ErrorMessage="Ingrese el nombre de usuario a buscar" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 499px">&nbsp;</td>
                    <td>
                        <asp:CustomValidator ID="cvError" runat="server" ErrorMessage="Por favor revise la información ingresada" ForeColor="Red">*</asp:CustomValidator>
                        <asp:ValidationSummary ID="vsErrores" runat="server" DisplayMode="List" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 499px">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" Text="Cancelar" />
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        <asp:Label ID="lblResultado" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#003399"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:View>
         <asp:View ID="vwActualizarUsuario" runat="server">
             <table class="nav-justified">
                 <tr>
                     <td style="width: 498px">Nombre de la persona</td>
                     <td>
                         <asp:TextBox ID="txtNombrePersona" runat="server" Width="292px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvNombrePersona" runat="server" ErrorMessage="El nombre de la persona no puede estar en blanco" ForeColor="Red" ControlToValidate="txtNombrePersona">*</asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 498px; height: 27px;">Correo electrónico</td>
                     <td style="height: 27px">
                         <asp:TextBox ID="txtCorreoElectronico" runat="server" Width="289px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvCorreoElectronico" runat="server" ErrorMessage="El correo electrónico no puede estar en blanco" ForeColor="Red" ControlToValidate="txtCorreoElectronico">*</asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 498px">Nuevo nombre de usuario</td>
                     <td>
                         <asp:TextBox ID="txtLoginUsuarioActualizar" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvLoginUsuarioActualizar" runat="server" ErrorMessage="El nombre de usuario no puede estar en blanco" ForeColor="Red" ControlToValidate="txtLoginUsuario">*</asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 498px">Nueva clave</td>
                     <td>
                         <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvClave" runat="server" ErrorMessage="La clave no puede estar en blanco" ForeColor="Red" ControlToValidate="txtClave">*</asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 498px">Fecha de ingreso al sistema</td>
                     <td>
                         <asp:Label ID="lblFechaIngreso" runat="server"></asp:Label>
                         <asp:CustomValidator ID="cvErrorActualizar" runat="server" ErrorMessage="Por favor revise la información ingresada" ForeColor="Red">*</asp:CustomValidator>
                         <asp:ValidationSummary ID="vsResumenErroresActualizar" runat="server" DisplayMode="List" ForeColor="Red" />
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 498px">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td style="width: 498px">&nbsp;</td>
                     <td>
                         <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                         <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnGuardar_Click" />
                         &nbsp;<asp:Button ID="btnEliminarUsuario" runat="server" OnClick="btnEliminarUsuario_Click" Text="Eliminar usuario" />
                     </td>
                 </tr>
             </table>
        </asp:View>
        <asp:View ID="vwConfirmarEliminarUsuario" runat="server">
             
            <table class="nav-justified">
                <tr>
                    <td style="width: 749px">Por favor confirme que desea eliminar este usuario.
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="Tome en cuenta que esta acción no puede deshacerse."></asp:Label>
                        . </td>
                    <td>
                        <asp:Button ID="btnConfirmarEliminarUsuario" runat="server" OnClick="btnConfirmarEliminarUsuario_Click" Text="Confirmar" BackColor="Red" Font-Bold="True" ForeColor="White" />
                        <asp:Button ID="btnCancelarEliminacionUsuario" runat="server" OnClick="btnCancelarEliminacionUsuario_Click" Text="Cancelar" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 749px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
             
        </asp:View>

                
     </asp:MultiView>
</asp:Content>
