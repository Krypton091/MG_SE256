﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="SE256_Lab_MattG.Backend.ControlPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Control Panel</h2>

        <table>
            <tr>
                <td><a href="HMDMgr.aspx" runat="server">Add an HMD (Head Mounted Display)</a></td>
            </tr>
            <tr>
                <!--Let user logout from program-->
                <td><asp:Button ID="btnLogout" runat="server" Text="Log Out" OnClick="btnLogout_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
