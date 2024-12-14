<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="respo_document_req.aspx.cs" Inherits="PMPML_TIcketGhar.User.respo_document_req" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PMPML Pass Information</title>
    <link rel="stylesheet" href="../UserTemplate/css/respo_documrnt_styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navigation Bar with Marquee and Images -->
    <nav>
       
    </nav>

    <!-- Main Content with Background Image -->
    <div class="content">
        <div class="document-section">
            <h2>Student Pass Documents</h2>
            <ul>
                <li>Bonafide certificate</li>
                <li>Aadhar Card</li>
                <li>Id card</li>
                <li>Passport size photo</li>
            </ul>
            <asp:RadioButton ID="RadioButton1" runat="server"  Text="Monthly Pass" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Yearly Pass" />
            <br>
            <%--<button onclick="alert('Student Pass Documents Clicked')">Proceed</button>--%>
            <asp:Button ID="btnProceed" runat="server" Text="Proceed" OnClick="btnProceed_Click" BackColor="Lime" Height="37px" Width="103px" />
        </div>
        <div class="document-section">
            <h2>Monthly Pass Documents</h2>
            <ul>
                <li>Pan card</li>
                <li>Aadhar Card</li>
                <li>Id card</li>
                <li>Passport size photo</li>
               
            </ul>
            <%--<button onclick="alert('Monthly Pass Documents Clicked')">Proceed</button>--%>
            <asp:Button ID="Button1" runat="server" Text="Proceed" OnClick="btnProceed_Click1" BackColor="Lime" Height="38px" Width="98px" />

        </div>
        <div class="document-section">
            <h2>Yearly Pass Documents</h2>
            <ul>
                <li>Pan card</li>
                <li>Aadhar Card</li>
                <li>Id card</li>
                <li>Passport size photo</li>
               
            </ul>
            <%--<button onclick="alert('Yearly Pass Documents Clicked')">Proceed</button>--%>
            <asp:Button ID="Button2" runat="server" Text="Proceed" OnClick="btnProceed_Click2" BackColor="Lime" Height="38px" Width="102px" />

        </div>
    </div>

    <!-- Footer Information about PMPML -->
    <footer>
        <p>PMPML provides efficient and reliable public transport services across Pune and Pimpri-Chinchwad.</p>
    </footer>
        <script src="script.js"></script>
    </form>
</body>
</html>
