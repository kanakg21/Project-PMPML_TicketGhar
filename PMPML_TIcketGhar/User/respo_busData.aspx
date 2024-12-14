<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="respo_busData.aspx.cs" Inherits="PMPML_TIcketGhar.User.respo_busData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bus Selection</title>
    <link rel="stylesheet" href="../UserTemplate/css/BusData_styles.css">
</head>
<body>
   
    <div class="container">
        <%--<div class="bus-info" id="bus1">--%>
        <asp:Panel ID="bus1Panel" CssClass="bus-info" runat="server">

            <h3>Bus 1</h3><br>
            <label>Bus Number: 276</label><br>
            <label>From: Karve Nagar</label><br>
            <label>To: Ratana Hospital</label><br>
            <label>Fare: 15 Rs</label><br>
            <input type="radio" name="bus" value="bus1">
            </asp:Panel>
        <%--</div>--%>
        <%--<div class="bus-info" id="bus2">--%>
            <asp:Panel ID="bus2Panel" CssClass="bus-info" runat="server">
            <h3>Bus 2</h3><br>
            <label>Bus Number: 2A UP </label><br>
            <label>From: KATRAJ</label><br>
            <label>To: SHIVAJINAGAR</label><br>
            <label>Fare: 25 Rs</label><br>
            <input type="radio" name="bus" value="bus2">
            </asp:Panel>

        <%--</div>--%>
        <asp:Panel ID="bus3Panel" CssClass="bus-info" runat="server">

        <%--<div class="bus-info" id="bus3">--%>
            <h3>Bus 3</h3><br>
            <label>Bus Number:58 UP </label><br>
            <label>From: SHANIPAR</label><br>
            <label>To: GOKHALE NAGAR</label><br>
            <label>Fare: 10 Rs</label><br>
            <input type="radio" name="bus" value="bus3">
        </asp:Panel>
        <%--</div>--%>
        <asp:Panel ID="bus4Panel" CssClass="bus-info" runat="server">

        <%--<div class="bus-info" id="bus4">--%>
            <h3>Bus 4</h3><br>
            <label>Bus Number: 119 DOWN</label><br>
            <label>From: ALANDI</label><br>
            <label>To: MANAPA</label><br>
            <label>Fare: 25 Rs</label><br>
            <input type="radio" name="bus" value="bus4">
            </asp:Panel>
        <%--</div>--%>
        <asp:Panel ID="bus5Panel" CssClass="bus-info" runat="server">

        <%--<div class="bus-info" id="bus5">--%>
            <h3>Bus 5</h3><br>
            <label>Bus Number: 2A DOWN</label><br>
            <label>From: SHIVAJINAGAR</label><br>
            <label>To: KATRAJ</label><br>
            <label>Fare: 25 Rs</label><br>
            <input type="radio" name="bus" value="bus5">
            </asp:Panel>
        <%--</div>--%>
    </div>
    <div class="form-container">
        <%--<input type="text" id="mobile-number" placeholder="Enter Mobile Number">--%>
         <form id="form1" runat="server">
        <asp:TextBox ID="txtMobileNumber" runat="server" CssClass="form-control" Placeholder="Enter Mobile Number"></asp:TextBox>
        <%--<button id="pay-now" disabled>Pay Now</button>--%>
        <asp:Button ID="btnPayNow" runat="server" Text="Pay Now" OnClick="btnPayNow_Click1" />

    </div>
    <script src="../UserTemplate/js/BusData_script.js"></script>
        </form>
</body>
</html>
