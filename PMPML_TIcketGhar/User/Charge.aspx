<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Charge.aspx.cs" Inherits="PMPML_TIcketGhar.User.Charge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Status</title>
<style>
    body {
        font-family: Arial, sans-serif;
        background-color: #f4f7f6; /* Light background color */
        margin: 0;
        padding: 0;
        display: flex;
        justify-content: center;
        align-items: center;
        height: 100vh;
    }

    .container {
        background: #ffffff; /* White background for the form */
        padding: 20px;
        border-radius: 10px;
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        text-align: center;
        width: 300px; /* Adjust width as needed */
    }

    .message {
        padding: 15px;
        border-radius: 5px;
        margin-bottom: 20px;
        font-size: 16px;
        font-weight: bold;
    }

    .success {
        background-color: #d4edda;
        color: #155724;
        border: 1px solid #c3e6cb;
    }

    .error {
        background-color: #f8d7da;
        color: #721c24;
        border: 1px solid #f5c6cb;
    }
</style>
</head>
<body>
   <div class="container">
    <asp:Literal ID="MessageLiteral" runat="server"></asp:Literal>
       <form id="form1" runat="server">
       <asp:Button ID="btnHome" runat="server" Text="Go to Home" OnClick="btnHome_Click" CssClass="hidden" />
           <asp:Label ID="Label1" runat="server" Text="hello"></asp:Label>
        </form>
           </div>
</body>
</html>
