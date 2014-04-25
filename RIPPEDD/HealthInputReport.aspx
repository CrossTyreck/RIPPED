<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HealthInputReport.aspx.cs" Inherits="RIPPEDD.HealthInputReport" %>


<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server">
    <div class="menubar">
        <div class="table">
            <ul id="horizontal-list">
                <li>
                    <asp:LinkButton ID="ChangeDoctor" runat="server" Style="text-decoration: none" OnClick="ChangeDoctor_Click" ForeColor="Black">Change Primary Doctor</asp:LinkButton>
                </li>
                <li>
                    <asp:LinkButton ID="PrintReport" runat="server" Style="text-decoration: none" OnClick="PrintReport_Click" ForeColor="Black">Print Report to Doctor</asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <div style="text-align: center; height: 664px;">

        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="Green" Text="Please give as much information as possible."></asp:Label>
        <br />
        
        <asp:Button ID="btnClick" runat="server" OnClick="btnTest_OnClick" Text="Test" />
        <br />
        <asp:Panel ID="Panel1" runat="server" CssClass="floatRight" Width="280px" BorderStyle="Solid" BorderWidth="2px" Height="516px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Injury List" Font-Size="Large" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblInjury0" runat="server" Text="Right Shoulder"></asp:Label>
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="67px" TextMode="MultiLine" Width="183px">It hurts alot when I rotate it around in front of me.</asp:TextBox>
            <br />
            <asp:Label ID="lblInjury1" runat="server" Text="Neck"></asp:Label>
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="67px" TextMode="MultiLine" Width="183px">I think I have wiplash from a fender bender.</asp:TextBox>
            <br />
            <asp:Label ID="lblInjury" runat="server" Text="Lumbar"></asp:Label>
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="67px" TextMode="MultiLine" Width="183px">My work requires that I sit down all day. My lower back has begun to hurt.</asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" CssClass="floatLeft" Width="309px" BorderStyle="Solid" BorderWidth="2px">
            <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Health Stats" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <img alt="AvgBloodPressure" class="auto-style1" src="Images/2DFastLine.png" />
            <img alt="StrengthTraining" class="auto-style2" src="Images/2DRadarArea.png" />
            <img alt="CalorieByMeal" class="auto-style3" src="Images/3DPie2.png" />
        </asp:Panel>
        
        <br />
        <br />
        <br />
        <asp:TextBox ID="firstInjury" runat="server"></asp:TextBox>
        <asp:TextBox ID="secondInjury" runat="server"></asp:TextBox>
        <asp:TextBox ID="thirdInjury" runat="server"></asp:TextBox>
        <asp:TextBox ID="fourthInjury" runat="server"></asp:TextBox>
    </div>

</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="Stylesheets">
    <link href="Content/Site.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 194px;
            height: 152px;
        }

        .auto-style2 {
            width: 191px;
            height: 145px;
        }

        .auto-style3 {
            width: 195px;
            height: 165px;
        }
    </style>
</asp:Content>

