<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="BasicWebApp.FirstWebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <form id="form" runat="server">
    <div class="page">
       <div class="form1"> 
        &nbsp;<h1>WELCOME TO STAR HOSPITAL</h1><br />
        <br />
        <asp:TextBox class="text" ID="usernametxtb" placeholder="Username" runat="server" Width="270px" OnTextChanged="usernametxtb_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox class="text" ID="passwordtxtb" placeholder="Password" runat="server" Width="270px" OnTextChanged="passwordtxtb_TextChanged"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox class="checkbox" ID="CheckBox1" runat="server" Text="Show Password" />
           &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button class="my-buttons" ID="Button1" runat="server" commandname="Login" Text="Login" Width="97px" validationgroup="Login"/>
       
        <br />
        <br />
        <br />


    </div>
        </div>
    </form>
</body>
</html>
