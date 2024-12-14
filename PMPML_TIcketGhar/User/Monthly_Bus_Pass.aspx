<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Monthly_Bus_Pass.aspx.cs" Inherits="PMPML_TIcketGhar.User.Monthly_Bus_Pass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Monthly Bus Pass Form</title>
    <link rel="stylesheet" href="../UserTemplate/css/respo_monthlyPass_styles.css">
</head>
<body>
    <form id="form1" runat="server">
       <div class="background">
        <div class="overlay"></div>
        <div class="form-container">
            <h1>Monthly Bus Pass<br>
                !!मासिक पास!!

            </h1>
            <form id="pass-form">
                <div class="form-group">
                    <label for="name">Name:</label>
                    <%--<input type="text" id="name" name="name" required>--%>
                    <asp:TextBox ID="txtName" runat="server" required></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="mobile">Mobile No:</label>
                    <%--<input type="tel" id="mobile" name="mobile" pattern="[0-9]{10}" required>--%>
                    <asp:TextBox ID="txtMobile" runat="server" required pattern="[0-9]{10}"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="aadhar">Aadhar No:</label>
                    <%--<input type="text" id="aadhar" name="aadhar" pattern="[0-9]{12}" required>--%>
                    <asp:TextBox ID="txtAadhar" runat="server" required pattern="[0-9]{12}"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="gender">Gender:</label>
                    <%--<select id="gender" name="gender" required>
                        <option value="male">Male</option>
                        <option value="female">Female</option>
                        <option value="other">Other</option>
                    </select>--%>
                    <asp:DropDownList ID="ddlGender" runat="server" required>
                    <asp:ListItem Value="male">Male</asp:ListItem>
                    <asp:ListItem Value="female">Female</asp:ListItem>
                    <asp:ListItem Value="other">Other</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="doc-code">Document Verified Code:</label>
                    <%--<input type="text" id="doc-code" name="doc-code" required>--%>
                    <asp:TextBox ID="txtVerificationCode" runat="server" required></asp:TextBox>
                </div>
                <%--<button type="submit">Submit</button>--%>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" BackColor="Lime" />
            </form>
        </div>
    </div>
    <script src="respo_monthlyPass_scripts.js"></script>
    </form>
</body>
</html>
