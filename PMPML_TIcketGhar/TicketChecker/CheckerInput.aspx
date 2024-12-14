<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckerInput.aspx.cs" Inherits="PMPML_TIcketGhar.TicketChecker.CheckerInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bus Conductor Input</title>
    <link rel="stylesheet" href="conductor111_styles.css">
</head>
<body>
    <div class="background-container">
        <!-- Content Container -->
        <div class="content-container">
            <div class="form-container">
                <h2 class="form-heading">Bus Conductor Input</h2>
                <form id="conductor-form">
                    <label for="prn">PRN Number:</label>
                    <input type="text" id="prn" name="prn" placeholder="Enter PRN Number" maxlength="5" required>

                    <label for="aadhaar">Aadhaar Number:</label>
                    <input type="text" id="aadhaar" name="aadhaar" placeholder="Enter Aadhaar Number" maxlength="12" required>
                     <form id="form1" runat="server">
                        <%--<button type="submit">Submit</button>--%>
                         <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                        </form>
                    
                </form>
            </div>
        </div>
    </div>
    <script src="conductor111_script.js"></script>
   
</body>
</html>
