<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RIPPEDD.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
    <br />
    <asp:TextBox ID="txtbxFirstName" runat="server" style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
    <br />
    <asp:TextBox ID="txtbxLastName" runat="server" style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
    <br />
    <asp:TextBox ID="txtbxUsername" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
    <br />
    <asp:TextBox ID="txtbxPassword" runat="server" style="margin-top: 0px" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblSecurityQuestion" runat="server" Text="Security Question:"></asp:Label>
    <br />
    <asp:TextBox ID="txtbxSecurityQuestion" runat="server" style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblSecurityAnswer" runat="server" Text="Security Answer:"></asp:Label>
    <br />
    <asp:TextBox ID="txtSecurityAnswer" runat="server" OnTextChanged="TextBox6_TextChanged" style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
    <br />
</asp:Content>
