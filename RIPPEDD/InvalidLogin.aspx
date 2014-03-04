<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InvalidLogin.aspx.cs" Inherits="RIPPEDD.InvalidLogin" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div class="menubar">
        <div class="table">
            <ul id="horizontal-list">
                <li>
                    <asp:LinkButton ID="ContactSupport" runat="server" Style="text-decoration: none" ForeColor="Black">Contact Support</asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <div>
  
        <br />
        <span class="auto-style1">Your login was invalid. Please enter your login name and registered email address and we will send you a new password. </span> <br />
        <br />
        <asp:Panel ID="pnlLogin" runat="server" Height="185px" Width="472px">
            <br />
            &nbsp;&nbsp;<asp:Label ID="lblUserName" runat="server" Text="User Name: "></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" Width="135px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPassword" runat="server" Text="Email:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="137px"></asp:TextBox>
            <br />
            <br />
            &nbsp;
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnLogin_OnClick" Text="Submit" Width="74px" />
            &nbsp;</asp:Panel>

    </div>
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="Stylesheets">
    <link href="Content/Site.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</asp:Content>

