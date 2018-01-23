<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <p>Registration Page</p>
    <a href="Default.aspx">Home</a> | <a href="#">Registration</a>
    <form id="form1" runat="server">
        <div>
            <p>Enter your first name</p>
            <asp:TextBox ID="firstnameTextBox"  runat="server" />
            <p>Enter your middle name</p>
            <asp:TextBox ID="middlenametextBox"  runat="server" />
            <p>Enter your last name</p>
            <asp:TextBox ID="lastnameTextBox"  runat="server" />
            <p>Enter your email</p>
            <asp:TextBox ID="emailTextBox"  runat="server" />
            <p>Enter your phone number</p>
            <asp:TextBox ID="phoneTextBox"  runat="server" />
            <p>Enter your Username</p>
            <asp:TextBox ID="usernameTextBox"  runat="server" />
            <p>Enter your password</p>
            <asp:TextBox ID="passwordTextBox" runat="server" />

            <asp:Button ID ="registerButton" Text="Register" runat="server" OnClick="registerEventMethod" />
        </div>
    </form>
</body>
</html>
