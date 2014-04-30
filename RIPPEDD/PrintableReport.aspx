<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrintableReport.aspx.cs" Inherits="RIPPEDD.PrintableReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Printable Report</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="Panel2" runat="server" CssClass="floatLeft" Width="630px" BorderStyle="None" BorderWidth="2px" Height="480px" HorizontalAlign="Center" Wrap="False">
            <br />
            &nbsp;
            <asp:CHART ID="Chart" runat="server" BackColor="#D3DFF0" BackGradientStyle="TopBottom" BorderColor="26, 59, 105" BorderlineDashStyle="Solid" BorderWidth="2" Height="230px" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" ImageType="Png" Palette="BrightPastel" style="margin-top: 0px" Width="300px">
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
                    <asp:Legend BackColor="Transparent" Enabled="False" Font="Trebuchet MS, 8.25pt, style=Bold" IsTextAutoFit="False" Name="Default">
                    </asp:Legend>
                </legends>
                <Titles>
                    <asp:Title Font="Trebuchet MS, 14.25pt, style=Bold" ForeColor="26, 59, 105" Name="Title1" ShadowColor="32, 0, 0, 0" ShadowOffset="3" Text="Strength Training">
                    </asp:Title>
                </Titles>
                <borderskin SkinStyle="Emboss" />
            </asp:CHART>
            <asp:CHART ID="Chart3" runat="server" BackColor="#D3DFF0" BackGradientStyle="TopBottom" BorderColor="26, 59, 105" BorderlineDashStyle="Solid" BorderWidth="2" Height="230px" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" ImageType="Png" Palette="BrightPastel" style="margin-top: 0px" Width="300px">
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
                    <asp:Legend BackColor="Transparent" Enabled="False" Font="Trebuchet MS, 8.25pt, style=Bold" IsTextAutoFit="False" Name="Default">
                    </asp:Legend>
                </legends>
                <Titles>
                    <asp:Title Font="Trebuchet MS, 14.25pt, style=Bold" ForeColor="26, 59, 105" Name="Title1" ShadowColor="32, 0, 0, 0" ShadowOffset="3" Text="Sleep/Time management">
                    </asp:Title>
                </Titles>
                <borderskin SkinStyle="Emboss" />
            </asp:CHART>
            <br />
            &nbsp;&nbsp;
            
            <asp:CHART id="Chart1" runat="server" Palette="BrightPastel" BackColor="#D3DFF0" ImageType="Png" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" Width="300px" Height="230px" BorderlineDashStyle="Solid" BackGradientStyle="TopBottom" BorderWidth="2" BorderColor="26, 59, 105">
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
                                <asp:Title Font="Trebuchet MS, 14.25pt, style=Bold" ForeColor="26, 59, 105" Name="Title1" ShadowColor="32, 0, 0, 0" ShadowOffset="3" Text="Cardio Training">
                                </asp:Title>
                            </Titles>
							<borderskin SkinStyle="Emboss"></borderskin>
						</asp:CHART>


            <asp:CHART ID="Chart2" runat="server" BackColor="#D3DFF0" BackGradientStyle="TopBottom" BorderColor="26, 59, 105" BorderlineDashStyle="Solid" BorderWidth="2" Height="230px" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" ImageType="Png" Palette="BrightPastel">
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
                    <asp:Legend BackColor="Transparent" Enabled="False" Font="Trebuchet MS, 8.25pt, style=Bold" IsTextAutoFit="False" Name="Default">
                    </asp:Legend>
                </legends>
                <Titles>
                    <asp:Title Font="Trebuchet MS, 14.25pt, style=Bold" ForeColor="26, 59, 105" Name="Title1" ShadowColor="32, 0, 0, 0" ShadowOffset="3" Text="Weight/BMI/HR">
                    </asp:Title>
                </Titles>
                <borderskin SkinStyle="Emboss" />
            </asp:CHART>


        </asp:Panel>
    </div>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Latest Workout: "></asp:Label>
    <br />
    <asp:TextBox ID="workout" runat="server" Width="316px"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Injuries"></asp:Label>
    <br />
    <asp:Label ID="aLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:TextBox ID="firstInjury" runat="server" Height="20px" Width="300px"></asp:TextBox>
    <br />
    <asp:Label ID="bLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:TextBox ID="secondInjury" runat="server" Height="20px" Width="300px"></asp:TextBox>
    <br />
    <asp:Label ID="cLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:TextBox ID="thirdInjury" runat="server" Height="20px" Width="300px"></asp:TextBox>
    <br />
    <asp:Label ID="dLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:TextBox ID="fourthInjury" runat="server" Height="20px" Width="300px"></asp:TextBox>
    <br />
    <asp:Label ID="eLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:TextBox ID="fifthInjury" runat="server" Height="20px" Width="300px"></asp:TextBox>
    </form>
</body>
</html>
