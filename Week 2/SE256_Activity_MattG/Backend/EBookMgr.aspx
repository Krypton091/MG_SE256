﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EBookMgr.aspx.cs" Inherits="SE256_Activity_MattG.Backend.EBookMgr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">

    <a href="~/Backend/ControlPanel.aspx" runat="server">Return to Control Panel</a>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>Book ID</td>
            <td><asp:Label ID="lblEBook_ID" runat="server" /></td>
        </tr>
        
        <tr>
            <td>Book Title</td>
            <td><asp:TextBox ID="txtTitle" runat="server" MaxLength="255" /></td>
        </tr>

        <tr>
            <td>Author First Name</td>
            <td><asp:TextBox ID="txtAuthorFirst" runat="server" MaxLength="20" /></td>
        </tr>

        <tr>
            <td>Author Last Name</td>
            <td><asp:TextBox ID="txtAuthorLast" runat="server" MaxLength="40" /></td>
        </tr>

        <tr>
            <td>Author Email</td>
            <td><asp:TextBox ID="txtAuthorEmail" runat="server" MaxLength="20" /></td>
        </tr>

        <tr>
            <td>Date Published</td>
            <td><asp:Calendar ID="calDatePublished" runat="server"/></td>
        </tr>

        <tr>
            <td>Number of Pages</td>
            <td><asp:TextBox ID="txtPages" runat="server" MaxLength="5"/></td>
        </tr>

        <tr>
            <td>Price</td>
            <td><asp:TextBox ID="txtPrice" runat="server" MaxLength="10"/></td>
        </tr>
        
        <tr>
            <td>Bookmark Page</td>
            <td><asp:TextBox ID="txtBookmarkPage" runat="server" MaxLength="5"/></td>
        </tr>

        <tr>
            <td>Date Rental Expires</td>
            <td><asp:Calendar ID="calRentalExpires" runat="server"/></td>
        </tr>

    </table>

    <br />
    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
    <br />
    <br />
    <asp:Label ID="lblFeedback" runat="server" />

</asp:Content>
