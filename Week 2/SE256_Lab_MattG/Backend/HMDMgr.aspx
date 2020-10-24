<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HMDMgr.aspx.cs" Inherits="SE256_Lab_MattG.Backend.HMDMgr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">

    <a href="~/Backend/ControlPanel.aspx" runat="server">Return to Control Panel</a>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>HMD ID</td>
            <td><asp:Label ID="lblHMD_ID" runat="server" /></td>
        </tr>
        
        <tr>
            <td>HMD Name</td>
            <td><asp:TextBox ID="txtHmdName" runat="server" MaxLength="20" /></td>
        </tr>

        <tr>
            <td>Screen Resolution</td>
            <td><asp:TextBox ID="txtScreenRes" runat="server" MaxLength="20" />e.g (1920x1080)</td>
        </tr>

        <tr>
            <td>Refresh Rate</td>
            <td><asp:TextBox ID="txtRefreshRate" runat="server" MaxLength="4" />(Hz)</td>
        </tr>

        <tr>
            <td>Display Type</td>
            <td><asp:TextBox ID="txtDisplayType" runat="server" MaxLength="20" />(OLED, LCD, etc.)</td>
        </tr>

        <tr>
            <td>[PC] or [Standalone]</td>
            <td><asp:TextBox ID="txtPcOrStandalone" runat="server" MaxLength="15"/></td>
        </tr>

        <tr>
            <td>Brand</td>
            <td><asp:TextBox ID="txtBrand" runat="server" MaxLength="20"/></td>
        </tr>

        <tr>
            <td>Date Released</td>
            <td><asp:Calendar ID="calDateReleased" runat="server"/></td>
        </tr>

        

        <tr>
            <td>Price</td>
            <td><asp:TextBox ID="txtPrice" runat="server" MaxLength="10"/></td>
        </tr>

    </table>

    <br />
    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
    <br />
    <br />
    <asp:Label ID="lblFeedback" runat="server" />

</asp:Content>
