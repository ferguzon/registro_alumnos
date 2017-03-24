<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfCarreraMostrar.aspx.cs" Inherits="Presentacion.wfCarreraMostrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:MultiView ID="mvAgruparVistas" runat="server">
        <asp:View ID="vwBuscarCarrera" runat="server">
            <table class="nav-justified">
                <tr>
                    <td style="width: 481px">Ingrese el nombre de la carrera</td>
                    <td style="width: 421px">
                        <asp:TextBox ID="txtNombreCarrera" runat="server" Width="355px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnMostrarInformacion" runat="server" OnClick="btnMostrar_Click" Text="Mostrar información" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 481px">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 481px">Fecha de inicio</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtFechaInicio" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 481px">Fecha de fin</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtFechaFin" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 481px">Fecha de proceso</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtFechaProceso" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 481px">Estado</td>
                    <td colspan="2">
                        <asp:Label ID="lblEStado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 481px">Asignaturas</td>
                    <td colspan="2">
                        <asp:GridView ID="gvAsignaturas" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="width: 481px">&nbsp;</td>
                    <td colspan="2">
                        <asp:CustomValidator ID="cvErrores" runat="server" ForeColor="Red"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 481px">&nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" Text="Regresar" />
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="vwMostrarDatos" runat="server">
        </asp:View>
    </asp:MultiView>
</asp:Content>
