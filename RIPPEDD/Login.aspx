<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="RIPPEDD.Login" %>


<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server" />

<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblRegister" runat="server" Text="New? Great! Please register for access. "></asp:Label>
        <br />
        <asp:Button ID="btnRegister" runat="server" OnClick="Button1_Click" Text="Register" />
        <br />
        <asp:Label ID="lblRegistered" runat="server" ForeColor="Green" Text="Thanks for registering!" Visible="False"></asp:Label>
        <br />
        Please login.<br />
        <br />
        <asp:Panel ID="pnlLogin" runat="server" Height="185px" Width="472px">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblUserName" runat="server" Text="User Name: "></asp:Label>
            &nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            &nbsp;
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_OnClick" Text="Login" Width="74px" />
            &nbsp;</asp:Panel>

    </div>
</asp:Content>

