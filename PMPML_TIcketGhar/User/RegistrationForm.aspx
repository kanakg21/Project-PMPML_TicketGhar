<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="PMPML_TIcketGhar.User.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bus Registration Form</title>
    <link rel="stylesheet" href="../UserTemplate/css/registration_styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
        <form id="registrationForm" onsubmit="return validateForm()">
            <h2>Registration Form</h2>

            <%--<label for="name">Name:</label>
            <input type="text" id="name" name="name" required>--%>
            <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" Text="Name:" />
            <asp:TextBox ID="txtName" runat="server" required="true" />

            <%--<label for="mobile">Mobile Number:</label>
            <input type="text" id="mobile" name="mobile" required>--%>
            <asp:Label ID="lblMobile" runat="server" AssociatedControlID="txtMobile" Text="Mobile Number:" />
            <asp:TextBox ID="txtMobile" runat="server" required="true" />

            <%--<label for="aadhar">Aadhar Number:</label>
            <input type="text" id="aadhar" name="aadhar" required>--%>
            <asp:Label ID="lblAadhar" runat="server" AssociatedControlID="txtAadhar" Text="Aadhar Number:" />
            <asp:TextBox ID="txtAadhar" runat="server" required="true" />

            <%--<label for="email">Email:</label>
            <input type="email" id="email" name="email" required>--%>
            <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Email:" />
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" required="true" />

            <%--<label for="gender">Gender:</label>
            <select id="gender" name="gender" required>
                <option value="">Select</option>
                <option value="male">Male</option>
                <option value="female">Female</option>
                <option value="other">Other</option>
            </select>--%>
            <asp:Label ID="lblGender" runat="server" AssociatedControlID="ddlGender" Text="Gender:" />
            <asp:DropDownList ID="ddlGender" runat="server" required="true">
            <asp:ListItem Text="Select" Value="" />
            <asp:ListItem Text="Male" Value="male" />
            <asp:ListItem Text="Female" Value="female" />
            <asp:ListItem Text="Other" Value="other" />
        </asp:DropDownList>

            <%--<label for="verificationCode">Document Verified Code:</label>
            <input type="text" id="verificationCode" name="verificationCode" required>--%>
            <asp:Label ID="lblVerificationCode" runat="server" AssociatedControlID="txtVerificationCode" Text="Document Verified Code:" />
            <asp:TextBox ID="txtVerificationCode" runat="server"/>
            

            <%--<button type="submit">Register</button>--%>
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Register_Click" BackColor="Lime" />
            
        </form>
    </div>
    <script src="../UserTemplateregistration_script.js"></script>
    </form>
</body>
</html>
