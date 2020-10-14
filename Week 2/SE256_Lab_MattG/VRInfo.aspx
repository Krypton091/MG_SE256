<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VRInfo.aspx.cs" Inherits="SE256_Lab_MattG.VRInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
    <div>
        <h1>Latest VR News:</h1>
        <p>
            The Oculus Quest 2 has recently launched starting at $299, which allows you to play quality VR games without the need for a PC.
        </p>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <img src="Images/quest2.jpg" width="720" alt="Quest 2" />

        <h2>What are the specifications of the Quest 2?</h2>
        <p>Processor: Snapdragon XR2</p>
        <p>Resolution: 1832 × 1920 per eye (3664 x 1920 combined)</p>
        <p>Refresh Rate: 90Hz</p>
        <p>Weight: 503g (with default headstrap)</p>
        <p>Battery Life: 2-3 Hours</p>
        <p>Cost: $299 (64GB model)</p>
        <img src="Images/vrcomparison.png" width="750" alt="Quest 2 vs Valve Index vs HP Reverb G2" />
        <figcaption>Screen comparison of the Quest 2, Valve Index, and HP Reverb G2</figcaption>
        <br />
        <p>Notice the comparable screen quality between the Quest 2 and much more expensive PC headsets</p>
        <p><b>Note: The Index and Reverb G2 are $999 and $599 respectively</b></p>
    </div>
</asp:Content>
