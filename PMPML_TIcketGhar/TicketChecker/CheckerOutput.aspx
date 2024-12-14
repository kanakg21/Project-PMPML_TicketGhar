<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckerOutput.aspx.cs" Inherits="PMPML_TIcketGhar.TicketCollector.CollectorInpur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ticket Checker</title>
    <link rel="stylesheet" href="ticketChecker_styles.css">
</head>
<body>
    <div class="background-container">
        <div class="ticket-checker-container">
            <h2 class="heading">Ticket Checker</h2>
            <div class="ticket-info">
                <p>From: Karve Nagar</p>
                <p>To: Shivaji Nagar</p>
                <p>Payment: Done</p>
            </div>
            <div class="buttons">
                <form id="form1" runat="server">
                <%--<button id="valid-btn" class="green-btn">Valid</button>--%>
                 <asp:Button ID="Button1" runat="server" Text="Valid" OnClick="Valid_Click" />
                <%--<button id="not-valid-btn" class="red-btn">Not Valid</button>--%>
                    <asp:Button ID="Button2" runat="server" Text="Not Valid" OnClick="NotValid_Click" />
                
                
            </div>
            <div class="penalty-container">
                <%--<label for="penalty">Enter Penalty:</label>
                <input type="text" id="penalty" placeholder="Penalty Amount" />--%>
                <%--<button id="done-btn" class="done-btn">Done</button>--%>
                <asp:Button ID="Button3" runat="server" Text="Done" OnClick="Done_Click" />
                </form>
            </div>
        </div>
    </div>
    <script src="ticketChecker_script.js"></script>
    <%--<form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
</body>
</html>
