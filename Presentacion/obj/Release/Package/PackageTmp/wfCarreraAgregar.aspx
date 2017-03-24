<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfCarreraAgregar.aspx.cs" Inherits="Presentacion.wfCarreraAgregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
    <tr>
        <td>
            <asp:MultiView ID="mvAgruparVistas" runat="server">
                <asp:View ID="vwIngresarCarrera" runat="server">
                    
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 429px">Nombre de la carrera</td>
                            <td style="font-size: 8pt">
                                <asp:TextBox ID="txtNombreCarrera" runat="server" Width="278px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 429px">Fecha de inicio</td>
                            <td>
                                <asp:TextBox ID="txtFechaInicio" runat="server" TextMode="Date"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 429px">Fecha de cierre</td>
                            <td>
                                <asp:TextBox ID="txtFechaCierre" runat="server" TextMode="Date"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 429px">Fecha de proceso</td>
                            <td>
                                <asp:Label ID="lblFechaProceso" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 429px">Asignaturas incluídas</td>
                            <td>
                                <asp:DropDownList ID="ddlListadoAsignaturas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlListadoAsignaturas_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 429px">&nbsp;</td>
                            <td>
                                <asp:ListBox ID="lstAsignaturasSeleccionadas" runat="server" Width="174px"></asp:ListBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 429px">&nbsp;</td>
                            <td>
                                <asp:CustomValidator ID="cvErrores" runat="server" ErrorMessage="Ocurrió un error al guardar" ForeColor="Red"></asp:CustomValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 429px">&nbsp;</td>
                            <td>
                                <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
                                &nbsp;</td>
                        </tr>
                    </table>



                </asp:View>
                <asp:View ID="vwMostrarResultado" runat="server">
                    
                 
                    <table class="nav-justified">
                        <tr>
                            <td>
                                <asp:Label ID="lblResultado" runat="server" Font-Bold="True" ForeColor="#003399" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" Text="Aceptar" />
                            </td>
                        </tr>
                    </table>
                    
                 
                </asp:View>

            </asp:MultiView>
        </td>
    </tr>
    </table>
</asp:Content>
