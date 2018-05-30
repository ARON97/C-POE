<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Schedule_Appointment.aspx.cs" Inherits="BasicWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form" runat="server">
    <div class="page">
       <div class="form1"> 
        &nbsp;<h1>WELCOME TO STAR HOSPITAL</h1><br />
        &nbsp;<h2>Please schedule an appointment</h2><br />  
        <p>Name:</p><br />
        <asp:TextBox CssClass="text" ID="nametxtb" runat="server" Width="222px"></asp:TextBox>
        <br />
        <br />
        <p>Surname:<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" Display="Dynamic" ForeColor="Red" ControlToValidate="surnametxtb"></asp:RequiredFieldValidator>
           </p><br />
        <asp:TextBox CssClass="text" ID="surnametxtb" runat="server" Width="222px"></asp:TextBox>
        <br />
        <br />
        <p>Phone No.<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" Display="Dynamic" ForeColor="Red" ControlToValidate="phoneNotxtb"></asp:RequiredFieldValidator>
           </p><br />
        <asp:TextBox CssClass="text" ID="phoneNotxtb" runat="server" Width="222px"></asp:TextBox>
           <br />
           <br />
        <p>Date:</p>
        <asp:TextBox CssClass="text" ID="Date" runat="server" Width="222px"></asp:TextBox>
           <br />
           <asp:Calendar CssClass="text" ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />
        <br />
        <asp:Button CssClass="my-buttons" ID="schedulebtn" runat="server" OnClick="Button1_Click" Text="Schedule" Width="235px" />
        <br />
        <br />
        <br />
    
    </div>
        </div>
    </form>
</body>
</html>
