<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HealthInputReport.aspx.cs" Inherits="RIPPEDD.HealthInputReport" %>


<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server">
    <div class="menubar">
        <div class="table">
            <ul id="horizontal-list">
                <li>
                    <asp:LinkButton ID="ChangeDoctor" runat="server" Style="text-decoration: none" OnClick="ChangeDoctor_Click" ForeColor="Black">Change Primary Doctor</asp:LinkButton>
                </li>
                <li>
                    <asp:LinkButton ID="SubmitReport" runat="server" Style="text-decoration: none" OnClick="SubmitReport_Click" ForeColor="Black">Submit Report to Doctor</asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <div style="text-align: center; height: 664px;">

        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="Green" Text="Please give as much information as possible."></asp:Label>
        <br />
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
        <asp:ImageMap ID="ImageMap2" runat="server" HotSpotMode="PostBack" ImageUrl="~/Images/hurt-hs.jpg" OnClick="SetInjury">
            <asp:RectangleHotSpot AlternateText="Head" Bottom="53" HotSpotMode="PostBack" Left="68" PostBackValue="1" Right="93" Top="27" />
            <asp:RectangleHotSpot AlternateText="Right Shoulder" Bottom="110" HotSpotMode="PostBack" Left="62" PostBackValue="Right Shoulder" Right="86" Top="87" />
            <asp:RectangleHotSpot AlternateText="Right Elbow" Bottom="182" HotSpotMode="PostBack" Left="32" PostBackValue="Right Elbow" Right="54" Top="159" />
            <asp:RectangleHotSpot AlternateText="Right Hand" Bottom="233" HotSpotMode="PostBack" Left="23" PostBackValue="Right Hand" Right="47" Top="210" />
            <asp:RectangleHotSpot AlternateText="Right Knee" Bottom="342" HotSpotMode="PostBack" Left="67" PostBackValue="Right Knee" Right="89" Top="317" />
            <asp:RectangleHotSpot AlternateText="Right Foot" Bottom="450" HotSpotMode="PostBack" Left="76" PostBackValue="Right Foot" Right="97" Top="425" />
            <asp:RectangleHotSpot AlternateText="Abdomen" Bottom="198" HotSpotMode="PostBack" Left="117" PostBackValue="Abdomen" Right="142" Top="175" />
            <asp:RectangleHotSpot AlternateText="Left Shoulder" Bottom="112" HotSpotMode="PostBack" Left="168" PostBackValue="Left Shoulder" Right="194" Top="84" />
            <asp:RectangleHotSpot AlternateText="Left Elbow" Bottom="179" HotSpotMode="PostBack" Left="208" PostBackValue="Left Elbow" Right="235" Top="153" />
            <asp:RectangleHotSpot AlternateText="Left Knee" Bottom="345" HotSpotMode="PostBack" Left="168" PostBackValue="Left Knee" Right="189" Top="320" />
            <asp:RectangleHotSpot AlternateText="Left Foot" Bottom="449" HotSpotMode="PostBack" Left="168" PostBackValue="Left Foot" Right="189" Top="422" />
            <asp:RectangleHotSpot AlternateText="Neck" Bottom="102" HotSpotMode="PostBack" Left="405" PostBackValue="Neck" Right="425" Top="84" />
            <asp:RectangleHotSpot AlternateText="Left Shoulder Blade" Bottom="114" HotSpotMode="PostBack" Left="342" PostBackValue="Left Shoulder Blade" Right="367" Top="88" />
            <asp:RectangleHotSpot AlternateText="Left Forearm" Bottom="179" HotSpotMode="PostBack" Left="321" PostBackValue="Left Forearm" Right="342" Top="158" />
            <asp:RectangleHotSpot AlternateText="Lumbar" Bottom="196" HotSpotMode="PostBack" Left="406" PostBackValue="Lumbar" Right="425" Top="175" />
            <asp:RectangleHotSpot AlternateText="Thoracic" Bottom="151" HotSpotMode="PostBack" Left="406" PostBackValue="Thoracic" Right="426" Top="130" />
            <asp:RectangleHotSpot AlternateText="Left Heel" Bottom="446" HotSpotMode="PostBack" Left="359" PostBackValue="Left Heel" Right="381" Top="422" />
            <asp:RectangleHotSpot AlternateText="Right Heel" Bottom="448" HotSpotMode="PostBack" Left="447" PostBackValue="Right Heel" Right="471" Top="425" />
            <asp:RectangleHotSpot AlternateText="Right Shoulder Blade" Bottom="114" HotSpotMode="PostBack" Left="461" PostBackValue="Right Shoulder Blade" Right="492" Top="86" />
            <asp:RectangleHotSpot AlternateText="Right Forearm" Bottom="184" HotSpotMode="PostBack" Left="486" PostBackValue="Right Forearm" Right="512" Top="158" />
            <asp:RectangleHotSpot AlternateText="Left Hand" Bottom="226" HotSpotMode="PostBack" Left="217" PostBackValue="Left Hand" Right="239" Top="201" />
        </asp:ImageMap>
        <br />

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

