<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RIPPEDD.Register" %>

<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server" />

<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <asp:TextBox ID="txtbxDataInserted" runat="server" BorderStyle="None" ForeColor="Red" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="786px"></asp:TextBox>
    <br />
    <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
    <br />
    <asp:TextBox ID="txtbxFirstName" runat="server" Style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
    <br />
    <asp:TextBox ID="txtbxLastName" runat="server" Style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
    <br />
    <asp:TextBox ID="txtbxUsername" runat="server" Style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
    <br />
    <asp:TextBox ID="txtbxPassword" runat="server" Style="margin-top: 0px" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblSecurityQuestion" runat="server" Text="Security Question:"></asp:Label>
    <br />
    <asp:TextBox ID="txtbxSecurityQuestion" runat="server" Style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblSecurityAnswer" runat="server" Text="Security Answer:"></asp:Label>
    <br />
    <asp:TextBox ID="txtSecurityAnswer" runat="server" Style="margin-top: 0px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
    <br />
</asp:Content>
