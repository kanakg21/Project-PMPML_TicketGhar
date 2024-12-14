<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checker.aspx.cs" Inherits="PMPML_TIcketGhar.Checker.Checker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Ticket Validation</title>
</head>
     <link rel="stylesheet" type="text/css" href="conductor_style.css">
<body>
    <form id="form1" runat="server">
     <div>
         <h1>Ticket Validation</h1>
         <asp:Label ID="lblPRN" runat="server" Text="PRN Number:"></asp:Label>
         <asp:TextBox ID="txtPRN" runat="server"></asp:TextBox><br /><br />
         <asp:Label ID="lblAadhar" runat="server" Text="Last 4 Digits of Aadhar:"></asp:Label>
         <asp:TextBox ID="txtAadhar" runat="server"></asp:TextBox><br /><br />
         <asp:Button ID="btnValidate" runat="server" Text="Validate" OnClick="btnValidate_Click" /><br /><br />
         <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
         <br>
         <asp:Button ID="Button1" runat="server" Text="Reset" ForeColor="White" OnClick="Button1_Click" />
         <br>
         <br>
         <asp:Button ID="Button2" runat="server" Text="Penalty" ForeColor="Red" OnClick="Button2_Click" />
     </div>
 </form>
</body>
</html>
