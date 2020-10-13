<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MG_WebCalc_SE256._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-top:20px;">
        <table>
            <%--** Display --%>
            <tr>
                <td colspan="4">
                    <asp:TextBox ID="txtLCD" runat="server" Columns="20" />
                </td>
            </tr>

            <%-- All buttons in a grid --%>
            <tr>
                <td><asp:Button ID="btn0" Text="0" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btn1" Text="1" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btn2" Text="2" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btnPlus" Text="+" runat="server" OnClick="btnPlus_Click"/></td>
                
                
            </tr>

            <tr>
                <td><asp:Button ID="btn3" Text="3" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btn4" Text="4" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btn5" Text="5" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btnMinus" Text="-" runat="server" OnClick="btnMinus_Click"/></td>
                
            </tr>
            
            <tr>
                <td><asp:Button ID="btn6" Text="6" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btn7" Text="7" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btn8" Text="8" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btnMultiply" Text="*" runat="server" OnClick="btnMultiply_Click"/></td>
                
            </tr>
            
            <tr>
                <td><asp:Button ID="btnBlank" Text="  " runat="server"/></td>
                <td><asp:Button ID="btn9" Text="9" runat="server" OnClick="NumButtons_Click"/></td>
                <td><asp:Button ID="btnBlank2" Text="  " runat="server"/></td>
                <td><asp:Button ID="btnDivide" Text="/" runat="server" OnClick="btnDivide_Click"/></td>
                
                
            </tr>
            <tr>
                <td><asp:Button ID="Button1" Text="  " runat="server"/></td>
                <td><asp:Button ID="Button2" Text="  " runat="server"/></td>
                <td><asp:Button ID="Button3" Text="  " runat="server"/></td>
                <td><asp:Button ID="btnEquals" Text="=" runat="server" OnClick="btnEquals_Click"/></td>
            </tr>
        </table>
    </div>

</asp:Content>
