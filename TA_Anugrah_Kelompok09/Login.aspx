<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TA_Anugrah_Kelompok09.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    
    <link href="style/LoginStyle.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div class="LoginForm">
            <h2>Login</h2>
            <br />
            <div>
                <asp:Label Text="Username" CssClass="lblUsername" runat="server"></asp:Label><br />
                <asp:TextBox ID="Username" CssClass="txtUsername" placeholder="Username" autocomplete="off" runat="server"></asp:TextBox><br />
                <asp:Label Text="Password" CssClass="lblPassword" runat="server"></asp:Label><br />
                <asp:TextBox ID="Password" type="password" CssClass="txtPassword" placeholder="Password" autocomplete="off" runat="server"></asp:TextBox><br />
                <asp:Button ID="Submit" CssClass="btnSubmit" runat="server" Text="Submit" OnClick="Submit_Click" />
            </div>
            <div class="Popup" runat="server" style="display: none" id="Pop">
                    <asp:Label ID="WarningText" Text="Login Gagal"  runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
