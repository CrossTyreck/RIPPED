<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HealthProfessionals.aspx.cs" Inherits="RIPPEDD.HealthProfessionals" %>

<%--<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>--%>



<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server" >
    <div class="menubar">
  </div>

</asp:Content>
<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <div>
         <asp:Label ID="lblHealthBox" runat="server" Text="Enter following information to search for a health care provider!"></asp:Label>
        <br />
        <asp:Label ID="lblDirections" runat="server" Text="All fields must be filled in correctly to view results."></asp:Label>
        <br />
        <asp:Label ID="lblDataTypes" runat="server" Text="City and State must be alphabetical characters, and Zip code must be numerical."></asp:Label>
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
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_OnClick" OnClientClick="popMap()" Text="Submit" />
        <br />
        <br />
    </div>
    
  <iframe id="gmap" runat="server"
  width="1000"
  height="500"
  frameborder="0" style="border:0"
  src="https://www.google.com/maps/embed/v1/view?key=AIzaSyAmraGWkXFKyVgd_pna2BjAnlXJ_iRsOWo
    &center=33.4294,-111.9431&zoom=13&maptype=roadmap">
   </iframe>
    
   </asp:Content>


<asp:Content ID="Content1" runat="server" contentplaceholderid="Stylesheets">
    <link href="Content/Site.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>




