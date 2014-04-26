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
        <br />
        <asp:Label ID="lblHealthHeader" runat="server" BorderColor="#FF9933" BorderStyle="Groove" Font-Bold="True" Font-Size="X-Large" style="text-align: center" Text="Review your health stats"></asp:Label>
        <br />
       <asp:CHART id="NumberOfActivitesByDate" runat="server" Palette="BrightPastel" BackColor="#D3DFF0" ImageType="Png" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" Width="412px" Height="296px" BorderlineDashStyle="Solid" BackGradientStyle="TopBottom" BorderWidth="1" BorderColor="26, 59, 105">
							<titles>
								<asp:Title ShadowColor="32, 0, 0, 0" Font="Trebuchet MS, 14.25pt, style=Bold" ShadowOffset="3" Text="Number of Activities by Date" ForeColor="26, 59, 105"></asp:Title>
							</titles>
							<legends>
								<asp:Legend Enabled="False" IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
							</legends>
							<borderskin SkinStyle="Emboss"></borderskin>
							<series>
								<asp:Series ChartArea="ActivitiesChartArea" Name="ActivitiesSeries1" BorderColor="180, 26, 59, 105" Color="220, 65, 140, 240">
								
								</asp:Series>
							</series>
							<chartareas>
								<asp:ChartArea Name="ActivitiesChartArea" BorderColor="64, 64, 64, 64" BackSecondaryColor="Transparent" BackColor="64, 165, 191, 228" ShadowColor="Transparent" BackGradientStyle="TopBottom">
									<area3dstyle Perspective="10" Enable3D="True" Inclination="15" IsRightAngleAxes="False" WallWidth="0" IsClustered="False" />
									<axisy LineColor="64, 64, 64, 64">
										<LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
										<MajorGrid LineColor="64, 64, 64, 64" />
									</axisy>
									<axisx LineColor="64, 64, 64, 64">
										<LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
										<MajorGrid LineColor="64, 64, 64, 64" />
									</axisx>
								</asp:ChartArea>
							</chartareas>
						</asp:CHART>
    <asp:CHART id="HealthIndicators" runat="server" Palette="BrightPastel" BackColor="#F3DFC1" ImageType="Png" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" Width="412px" Height="296px" BorderlineDashStyle="Solid" BackGradientStyle="TopBottom" BorderWidth="2" BorderColor="181, 64, 1">
		<titles>
								<asp:Title ShadowColor="32, 0, 0, 0" Font="Trebuchet MS, 14.25pt, style=Bold" ShadowOffset="3" Text="Body Mass Index Change Over Time" ForeColor="26, 59, 105"></asp:Title>
							</titles>					
        <legends>
								<asp:Legend Enabled="False" IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
							</legends>
							<borderskin SkinStyle="Emboss"></borderskin>
							<series>
								<asp:Series MarkerSize="8" BorderWidth="3" XValueType="Double" Name="IndicatorSeries1" ChartType="Line" MarkerStyle="Circle" ShadowColor="Black" BorderColor="180, 26, 59, 105" Color="220, 65, 140, 240" ShadowOffset="2" YValueType="Double"></asp:Series>
							</series>
							<chartareas>
								<asp:ChartArea Name="IndicatorsChartArea" BorderColor="64, 64, 64, 64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="OldLace" ShadowColor="Transparent" BackGradientStyle="TopBottom">
									<area3dstyle Rotation="25" Perspective="9" LightStyle="Realistic" Inclination="40" IsRightAngleAxes="False" WallWidth="3" IsClustered="False" />
									<axisy LineColor="64, 64, 64, 64">
										<LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
										<MajorGrid LineColor="64, 64, 64, 64" />
									</axisy>
									<axisx LineColor="64, 64, 64, 64">
										<LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
										<MajorGrid LineColor="64, 64, 64, 64" />
									</axisx>
								</asp:ChartArea>
							</chartareas>
						</asp:CHART>
    <asp:CHART id="HRIndicator" runat="server" Palette="BrightPastel" BackColor="#FFB2B2" ImageType="Png" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" Width="412px" Height="296px" BorderlineDashStyle="Solid" BackGradientStyle="TopBottom" BorderWidth="2" BorderColor="181, 64, 1">
		<titles>
								<asp:Title ShadowColor="32, 0, 0, 0" Font="Trebuchet MS, 14.25pt, style=Bold" ShadowOffset="3" Text="Sitting VS Working Heart Rate" ForeColor="26, 59, 105"></asp:Title>
							</titles>					
        <legends>
								<asp:Legend Enabled="True" IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
							</legends>
							<borderskin SkinStyle="Emboss"></borderskin>
							<series>
								<asp:Series MarkerSize="8" BorderWidth="3" XValueType="Double" Name="Resting HR" ChartType="Line" MarkerStyle="Circle" ShadowColor="Black" BorderColor="180, 26, 59, 105" Color="220, 65, 140, 240" ShadowOffset="2" YValueType="Double"></asp:Series>
                                <asp:Series MarkerSize="8" BorderWidth="3" XValueType="Double" Name="Working HR" ChartType="Line" MarkerStyle="Diamond" ShadowColor="Black" BorderColor="180, 26, 59, 105" Color="220, 224, 64, 10" ShadowOffset="2" YValueType="Double"></asp:Series>
							</series>
							<chartareas>
								<asp:ChartArea Name="HRIndicatorChartArea" BorderColor="64, 64, 64, 64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="OldLace" ShadowColor="Transparent" BackGradientStyle="TopBottom">
									<area3dstyle Rotation="25" Perspective="9" LightStyle="Realistic" Inclination="40" IsRightAngleAxes="False" WallWidth="3" IsClustered="False" />
									<axisy LineColor="64, 64, 64, 64">
										<LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
										<MajorGrid LineColor="64, 64, 64, 64" />
									</axisy>
									<axisx LineColor="64, 64, 64, 64">
										<LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
										<MajorGrid LineColor="64, 64, 64, 64" />
									</axisx>
								</asp:ChartArea>
							</chartareas>
						</asp:CHART>
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


