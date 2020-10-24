<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SE256_Lab_MattG.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
    <div>

    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        40 Juniper Lane<br />
        Griswold, CT 06351<br />
        <abbr title="Phone">P:</abbr>
        860-710-0849
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:mgray@email.neit.edu">mgray@email.neit.edu</a>
    </address>
</asp:Content>
