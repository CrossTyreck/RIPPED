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
                center: new google.maps.LatLng(33.422412, -111.933304),
                zoom: 15,
                //mapTypeId: google.maps.MapTypeId.SATELLITE

            };
            var map = new google.maps.Map(document.getElementById("map-canvas"),
                mapOptions);

        }
        google.maps.event.addDomListener(window, 'load', initialize);
    </script>


</asp:Content>
<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">

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




