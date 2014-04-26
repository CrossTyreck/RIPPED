<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HealthInput.aspx.cs" Inherits="RIPPEDD.HealthInput" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server">
    <div class="menubar">
        `
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Welcome to the Health Input Page. Please select an activity. Enter data for today." Font-Size="X-Large"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Select Activity: " Font-Size="Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlWorkoutChoices" runat="server" AutoPostBack="True" OnSelectedIndexChanged="WorkoutChoices_SetView">
            </asp:DropDownList>
        </asp:Panel>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <div style="overflow: auto">
        <asp:MultiView ID="WorkoutChoices" runat="server">
            <asp:View ID="Welcome" runat="server">


                <center> 
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Baby1.png" Width ="450px" Height="399px" />
                        <br />
                        This page lets you enter in your daily health data.
                        <br /> Select what type of input data you would like in the drop down menu above.
                        <br /> When done, press the sumbit button below per category.
                    </center>
                <br />

            </asp:View>


            <asp:View ID="CardioWorkout" runat="server">
                <br />
                <center> 

                <asp:Panel ID="pnlRoadRunning" CssClass="healthInputData" runat="server">
                    <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblRoadRunning" runat="server" Text="Road Running (miles):"></asp:Label>
                        </div>
                        <div style="padding-bottom: 5px">
                            <asp:TextBox ID="txtRoadRunning" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div style="padding-bottom: 1px">
                            <asp:Label ID="lblRoadRunningDescription" runat="server" Text="Road Running Description"></asp:Label>
                        </div>
                        <div style="padding-bottom: 5px">
                            <asp:TextBox ID="txtRoadRunningDescription" runat="server" Height="50px" TextMode="MultiLine" Width="300px" MaxLength="5"></asp:TextBox>
                            
                        </div>
                    </div>
                   
                </asp:Panel>

                <asp:Panel ID="pnlTreadmill" CssClass="healthInputData" runat="server">
                    <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblTreadmill" runat="server" Text="Treadmill(miles): "></asp:Label>
                        </div>
                        <div>
                            <asp:TextBox ID="txtTreadmill" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </asp:Panel>


                <asp:Panel ID="pnlCycling" CssClass="healthInputData" runat="server">
                    <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblCycling" runat="server" Text="Cycling(miles): "></asp:Label>
                        </div>
                         <div> 
                             <asp:TextBox ID="txtCycling" runat="server"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="pnlSwimming" CssClass="healthInputData" runat="server">
                     <div style="padding-bottom: 5px">
                        <div>
                         <asp:Label ID="lblSwimming" runat="server" Text="Swimming(# of 25y laps): "></asp:Label>
                        </div>
                         <div> 
                        <asp:TextBox ID="txtSwimming" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>

                </asp:Panel>

                <asp:Panel ID="pnlWalking" CssClass="healthInputData" runat="server">
                    <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblWalking" runat="server" Text="Walking(miles): "></asp:Label>
                        </div>
                         <div> 
                        <asp:TextBox ID="txtWalking" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>

                </asp:Panel>

                <asp:Panel ID="pnlRowing" CssClass="healthInputData" runat="server">

                      <div style="padding-bottom: 5px">
                        <div>
                           <asp:Label ID="lblRowing" runat="server" Text="Rowing(miles): "></asp:Label>
                        </div>
                         <div> 
                       <asp:TextBox ID="txtRowing" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>



                </asp:Panel>
           
                    
                </center>
                    
                

                <br />
                <br />
            </asp:View>
            <asp:View ID="StrengthWorkout" runat="server">
                <br />

<%--                PANEL TEMPLATE
                <asp:Panel ID="pnl" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            LABEL
                        </div>
                         <div> 
                            TEXTBOX
                         </div>
                    </div>
                </asp:Panel>
--%>
                <center>
                <asp:Panel ID="pnlClimbing" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblClimbing" runat="server" Text="Climbing (minutes): "></asp:Label>
                        </div>
                         <div> 
                            <asp:TextBox ID="txtClimbing" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="pnlBoxing" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblBoxing" runat="server" Text="Boxing (minutes): "></asp:Label>
                        </div>
                         <div> 
                            <asp:TextBox ID="txtBoxing" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="pnlPushups" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblPushups" runat="server" Text="# of pushups: "></asp:Label>
                        </div>
                         <div> 
                            <asp:TextBox ID="txtPushups" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>


                <asp:Panel ID="pnlSiptups" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblSitups" runat="server" Text="# of situps: "></asp:Label>
                        </div>
                         <div> 
                            <asp:TextBox ID="txtSitups" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>
                
                
                <asp:Panel ID="pnlWorkout" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblWorkoutRoutine" runat="server" Text="Workout Routine"></asp:Label>
                        </div>
                         <div> 
                            <asp:TextBox ID="txtWorkoutRoutine" runat="server" 
                                Text="Describe your workout routine here (workouts, # of reps, weights, etc)." 
                                TextMode="multiline" Height="223px" Width="558px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>     
                   
                </center>

               

                <br />
            </asp:View>
            <asp:View ID="WorkActivities" runat="server">
                <%-- activities at work : computer use, exercise, etc --%>
               
<%--                PANEL TEMPLATE
                <asp:Panel ID="pnl" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            LABEL
                        </div>
                         <div> 
                            TEXTBOX
                         </div>
                    </div>
                </asp:Panel>
--%>

                <center>

                <asp:Panel ID="pnlComputerTimeWork" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                             <asp:Label ID="lblComputerTime" runat="server" Text="Computer Use Time(hours): "></asp:Label>

                        </div>
                         <div> 
                             <asp:TextBox ID="txtComputerTime" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="pnlBreaksPerHour" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblBreaksPerHour" runat="server" Text="# of breaks(stretch, etc)(hourly): "></asp:Label>
                        </div>
                         <div> 
                            <asp:TextBox ID="txtBreaksPerHour" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>
               
                <asp:Panel ID="pnlLunchTime" CssClass="healthInputData" runat="server">
                        <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblLunchTime" runat="server" Text="Lunch Time length(minutes): "></asp:Label>
                        </div>
                            <div> 
                            <asp:TextBox ID="txtLunchTime" runat="server" Width="118px"></asp:TextBox>
                            </div>
                    </div>
                </asp:Panel>

                     
                <asp:Panel ID="pnlWorkTime" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblWorkTime" runat="server" Text="Number of hours worked: "></asp:Label>
                        </div>
                         <div> 
                            <asp:TextBox ID="txtWorkTime" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>
              

                     
                
                <asp:Panel ID="pnlMeetingTime" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            <asp:Label ID="lblMeetingTime" runat="server" Text="Meeting time(hours): "></asp:Label>
                        </div>
                         <div> 
                            <asp:TextBox ID="txtMeetingTime" runat="server" Width="118px"></asp:TextBox>
                         </div>
                    </div>
                </asp:Panel>


                
                 </center>

                     
                


                <br />
            </asp:View>

            <asp:View ID="HealthIndicators" runat="server">

<%--                PANEL TEMPLATE
                <asp:Panel ID="pnl" CssClass="healthInputData" runat="server">
                      <div style="padding-bottom: 5px">
                        <div>
                            LABEL
                        </div>
                         <div> 
                            TEXTBOX
                         </div>
                    </div>
                </asp:Panel>
--%>

                <%-- bmi, heart rate, etc --%>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="lblWeight" runat="server" Text="Current Weight (in lbs): "></asp:Label>
                <asp:TextBox ID="txtWeight" runat="server" Width="118px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="lblBMI" runat="server" Text="Body Mass Index (BMI): "></asp:Label>
                <asp:TextBox ID="txtBMI" runat="server" Width="118px"></asp:TextBox>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                     <asp:Label ID="lblSittingHeartRate" runat="server" Text="Sitting Heart Rate(beats per minute): "></asp:Label>
                <asp:TextBox ID="txtSittingHeartRate" runat="server" Width="118px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblWorkingHeartRate" runat="server" Text="Working Heart Rate(beats per minute): "></asp:Label>
                <asp:TextBox ID="txtWorkingHeartRate" runat="server" Width="118px"></asp:TextBox>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                     <asp:Label ID="lblHeight" runat="server" Text="Current Height (inches): "></asp:Label>
                <asp:TextBox ID="txtHeight" runat="server" Width="118px"></asp:TextBox>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                     <asp:Label ID="lblSleep" runat="server" Text="Sleep amount (hours): "></asp:Label>
                <asp:TextBox ID="txtSleep" runat="server" Width="118px"></asp:TextBox>
                <br />

            </asp:View>

            <asp:View ID="CouchPotato" runat="server">

                <%-- home activities --%>

                <br />

                &nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="lblComputerTimeHome" runat="server" Text="Computer Use Time(hours): "></asp:Label>
                <asp:TextBox ID="txtComputerTimeHome" runat="server" Width="118px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="lblTelevision" runat="server" Text="Television time (hours): "></asp:Label>
                <asp:TextBox ID="txtTelevision" runat="server" Width="118px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="lblChores" runat="server" Text="Chores time (hours): "></asp:Label>
                <asp:TextBox ID="txtChores" runat="server" Width="118px"></asp:TextBox>


                <br />

            </asp:View>

            <asp:View ID="Injuries" runat="server">

                <asp:Panel ID="Panel3" CssClass="healthInputDataLarge" runat="server">
               
                    
                    
                     <asp:Panel ID="pnlInjuryList" ScrollBars="Vertical" runat="server" CssClass="healthInputDataRightMargin" Width="280px" BorderStyle="Solid" BorderWidth="2px" Height="516px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Injury List" Font-Size="Large" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True"></asp:Label>
         <%--   <br />
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
       --%> </asp:Panel>
                    
                    
                    
                    
                    
                    
                     <asp:ImageMap ID="imgBodyDiagram" runat="server" HotSpotMode="PostBack" ImageUrl="~/Images/hurt-hs.jpg" OnClick="SetInjury">
            <asp:RectangleHotSpot AlternateText="Head" Bottom="53" HotSpotMode="PostBack" Left="68" PostBackValue="Head" Right="93" Top="27" />
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
                      <asp:TextBox ID="txtInjuryReport" Text="Click on a body part above, and then write your concerns here!" runat="server" Height="77px" Width="525px"
                          TextMode="multiline"></asp:TextBox>

                    </asp:Panel>



            </asp:View>
        </asp:MultiView>
        </p>
    <p>
        <center>  <asp:Button ID="btnSubmitResults" runat="server" OnClick="btnSubmitResults_Click" Text="Submit Results!" />
&nbsp;
        <asp:Label ID="lblSubmissionInfo" runat="server" Visible="False"></asp:Label>
    </p>
        </center>
    </div>
</asp:Content>
