<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <p>Home Page</p>
    <a href="#">Home</a> | <a href="Registration.aspx">Registration</a>
    <form id="form1" runat="server">
        <div>
            <p>Enter Username</p>
            <asp:TextBox ID="usernameTextBox" Text ="Enter username here" runat ="server" />
            <p>Enter Password</p>
            <asp:TextBox ID="passwordTextBox" Text="Enter password here" runat="server" />

            <asp:Button ID="submitButton" Text="Log in" runat ="server" OnClick="submitEventMethod" />

        </div>
    </form>
</body>
</html>
