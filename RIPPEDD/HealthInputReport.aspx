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
        
        <asp:Label ID="Label4" runat="server" Text="Select Activity"></asp:Label>
        
       <asp:DropDownList Width="300px" ID="ddlist" runat="server"
                AppendDataBoundItems="True" TabIndex="3" AutoPostBack="True" 
                OnSelectedIndexChanged = "workoutSelect"  >
            <asp:ListItem Value="">Select</asp:ListItem>
            <asp:ListItem Value="CardioWorkout">CardioWorkout</asp:ListItem>
            <asp:ListItem Value="StrengthWorkout">StrengthWorkout</asp:ListItem>
            <asp:ListItem Value="WorkActivities">WorkActivities</asp:ListItem>
            <asp:ListItem Value="HealthIndicators">HealthIndicators</asp:ListItem>
            <asp:ListItem Value="CouchPotato">CouchPotato</asp:ListItem>
        </asp:DropDownList>
        
        <br />
        <asp:Panel ID="Panel1" runat="server" CssClass="floatRight" Width="280px" BorderStyle="Solid" BorderWidth="2px" Height="516px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClick" runat="server" OnClick="btnTest_OnClick" Text="List Current Injuries" />
            <br />
            <asp:Label ID="firstLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="firstInjury" runat="server" Height="20px"></asp:TextBox>
            <br />
            <asp:Label ID="secondLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="secondInjury" runat="server" Height="20px"></asp:TextBox>
            &nbsp;&nbsp;<br />&nbsp;
            <asp:Label ID="thirdLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="thirdInjury" runat="server" Height="20px"></asp:TextBox>
            <br />
            <asp:Label ID="fourthLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="fourthInjury" runat="server" Height="20px"></asp:TextBox>
            &nbsp;&nbsp;
            <br />
            <asp:Label ID="fifthLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="fifthInjury" runat="server" Height="20px"></asp:TextBox>
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" CssClass="floatLeft" Width="456px" BorderStyle="Solid" BorderWidth="2px" Height="511px">
            <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Health Stats" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True"></asp:Label>
            <br />
            <asp:CHART id="Chart" runat="server" Palette="BrightPastel" BackColor="#D3DFF0" ImageType="Png" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" Width="446px" Height="380px" BorderlineDashStyle="Solid" BackGradientStyle="TopBottom" BorderWidth="2" BorderColor="26, 59, 105">
							<Series>
                                <asp:Series BorderColor="180, 26, 59, 105" ChartArea="ChartArea1" Color="220, 65, 140, 240" Legend="Default" Name="Series1">
                                </asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea BackColor="64, 165, 191, 228" BackGradientStyle="TopBottom" BackSecondaryColor="Transparent" BorderColor="64, 64, 64, 64" Name="ChartArea1" ShadowColor="Transparent">
                                    <AxisY LineColor="64, 64, 64, 64">
                                        <MajorGrid LineColor="64, 64, 64, 64" />
                                        <LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
                                    </AxisY>
                                    <AxisX LineColor="64, 64, 64, 64">
                                        <MajorGrid LineColor="64, 64, 64, 64" />
                                        <LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
                                    </AxisX>
                                    <Area3DStyle Enable3D="True" Inclination="15" IsRightAngleAxes="False" Perspective="10" Rotation="10" WallWidth="0" />
                                </asp:ChartArea>
                            </ChartAreas>
							<legends>
								<asp:Legend Enabled="False" IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
							</legends>
							<Titles>
                                <asp:Title Font="Trebuchet MS, 14.25pt, style=Bold" ForeColor="26, 59, 105" Name="Title1" ShadowColor="32, 0, 0, 0" ShadowOffset="3" Text="Health Progress">
                                </asp:Title>
                            </Titles>
							<borderskin SkinStyle="Emboss"></borderskin>
						</asp:CHART>
            <br />
            &nbsp;&nbsp;
        </asp:Panel>
        
        <br />
        <br />
        <br />
    </div>

</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="Stylesheets">
    <link href="Content/Site.css" rel="stylesheet" />
    </asp:Content>

