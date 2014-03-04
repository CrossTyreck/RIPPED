<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Welcome.aspx.cs" Inherits="RIPPEDD.Welcome" %>


<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server" >
    <div class="menubar">
        <div class="table">
            <ul id="horizontal-list">
                <li><asp:LinkButton ID="InputHealth" runat="server" Style="text-decoration: none"  OnClick="InputHealth_Click" ForeColor="Black">Input Health Data</asp:LinkButton>
                </li>
                <li><asp:LinkButton ID="ViewHealthProfessionals" runat="server" Style="text-decoration: none" ForeColor="Black" OnClick="HealthProfessionals_Click">View Health Professionals</asp:LinkButton>
                </li>    
                <li><asp:LinkButton ID="GenerateHealthReport" runat="server" Style="text-decoration: none"  ForeColor="Black" OnClick="GenerateHealthReport_Click" >Health Report</asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <div>
      
  

        <br />
        <asp:Label ID="Label1" runat="server" BorderColor="#FF9933" BorderStyle="Groove" Font-Bold="True" Font-Size="X-Large" style="text-align: center" Text="Review your health stats"></asp:Label>
        <br />
        <img alt="TestLine" class="auto-style1" src="Images/2DFastLine.png" />&nbsp;&nbsp;
        <img alt="TestRadar" class="auto-style1" src="Images/2DRadarArea.png" />&nbsp;&nbsp;
        <img alt="TestPie" class="auto-style1" src="Images/3DPie2.png" /></div>
</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="Stylesheets">
    <link href="Content/Site.css" rel="stylesheet" />
<style type="text/css">
    .auto-style1 {
        width: 300px;
        height: 225px;
    }
</style>
</asp:Content>


