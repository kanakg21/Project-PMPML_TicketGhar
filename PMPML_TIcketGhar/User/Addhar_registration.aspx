<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addhar_registration.aspx.cs" Inherits="PMPML_TIcketGhar.User.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registration Form</title>
    <link rel="stylesheet" href="../UserTemplate/css/styles3.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <form class="registration-form">
            <h2>Registration Form</h2>
            <div class="input-group">
                <label for="fullname">Full Name</label>
                <input type="text" id="inputField" name="inputField" pattern="[A-Za-z ]*" title="Only alphabets and spaces are allowed" required>
            </div>
            <div class="input-group">
                <label for="mobnumber">Mobile Number</label>
                <input type="text" id="mobileNumber" name="mobileNumber" pattern="\d{10}" title="Please enter exactly 10 digits" required>
            </div>
            <div class="input-group">
                <label for="email">Email</label>
                <input type="email" id="email" name="email" required>
            </div>
            <div class="input-group">
                <label for="aadhaar">Aadhaar No.</label>
                <input type="text" id="numericInput" name="numericInput" pattern="\d{12}" title="Please enter exactly 12 digits" required>
            </div>
            <div class="input-group">
                <label>Gender</label>
                <div class="gender-group">
                    <input type="radio" id="male" name="gender" value="male" required>
                    <label for="male">Male</label>
                    <input type="radio" id="female" name="gender" value="female" required>
                    <label for="female">Female</label>
                </div>
            </div>
            <%--<button type="submit">Register</button>--%>
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" BackColor="Lime" style="margin-left: 55px" Width="489px" />

        </form>
    </div>
    </form>
</body>
</html>
