<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HealthProfessionals.aspx.cs" Inherits="RIPPEDD.HealthProfessionals" %>

<%--<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>--%>



<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server" >
    <div class="menubar">
  </div>

      <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <style type="text/css">
      html { height: 100% }
      body { height: 100%; margin: 0; padding: 0 }
      #map-canvas { height: 450px; width: 75% }
    </style>
    <script type="text/javascript"
      src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDXfesKPhq6IBz0VwdZpebHiSiVvN4NtvQ&sensor=true">
    </script>
    <script type="text/javascript">
        function initialize() {
            var mapOptions = {
                center: new google.maps.LatLng(35.673343, 139.710388),
                zoom: 13,
                //mapTypeId: google.maps.MapTypeId.SATELLITE

            };
            var map = new google.maps.Map(document.getElementById("map-canvas"),
                mapOptions);

        }
        google.maps.event.addDomListener(window, 'load', initialize);
    </script>


</asp:Content>
<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <div>
         <asp:Label ID="lblHealthBox" runat="server" Text="Enter following information to search for a health care provider!"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblHealthCareType" runat="server" Text="Select the type of provider: "></asp:Label>
        <asp:DropDownList ID="dropDownListHealthCareType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dropDownListHC_SelectedIndexChanged">
            <asp:ListItem Text ="" />
            <asp:ListItem Text ="General Practitioner" />
            <asp:ListItem Text ="Sports Medicine" />
            <asp:ListItem Text ="Family Doctor" />
            <asp:ListItem Text ="Brain Surgeon" />
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblCity" runat="server" Text="City: "></asp:Label>
        <asp:TextBox ID="txtBoxCity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblState" runat="server" Text="State: "></asp:Label>
        <asp:TextBox ID="txtBoxState" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblZip" runat="server" Text="Zip code: "></asp:Label>
        <asp:TextBox ID="txtBoxZip" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_OnClick" Text="Submit" />
        <br />
        <br />
    </div>
    
    
    <div class="auto-style1">
     <center>
         <div id="map-canvas"/>
     </center>  

        
    </div>


   </asp:Content>



<asp:Content ID="Content1" runat="server" contentplaceholderid="Stylesheets">
    <link href="Content/Site.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>




