<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verification_document.aspx.cs" Inherits="PMPML_TIcketGhar.User.verification_document1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Document Upload</title>
    <link rel="stylesheet" href="../UserTemplate/css/verification_styles.css" />
</head>
<body>
       

    <form id="form1" runat="server">
                <div class="background-container" style="background-image: none">
    <div class="form-container">
        <h2 class="form-heading">Make a PDF of All Documents Required and upload it below</h2>
        <form id="pdf-upload-form" style="background-color: #FFFFFF">
            <input type="file" id="pdf-upload" name="pdf-upload" accept="application/pdf" required style="background-color: #008000">
            <%--<button type="submit">Upload PDF</button>--%>
            
            <asp:Button ID="btnUpload" runat="server" Text="Upload PDF" OnClick="btnUpload_Click" ForeColor="Lime" />
                
        </form>
    </div>
</div>
        <script src="../UserTemplate/js/verification_script.js"></script>
    </form>
</body>
</html>
