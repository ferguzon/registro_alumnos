<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfCarreraReporteListado.aspx.cs" Inherits="Presentacion.wfCarreraReporteListado" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <rsweb:ReportViewer ID="rptListadoCarreras" runat="server" Width="1231px">
                </rsweb:ReportViewer>
            </td>
        </tr>
    </table>
</asp:Content>
