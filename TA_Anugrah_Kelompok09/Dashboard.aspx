<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="TA_Anugrah_Kelompok09.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <link href="style/DashboardStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="DasboardForm">
            <h1 style="color:white">Dashboard</h1>
            <asp:Button ID="btnFighterDB" runat="server" Text="Fighter Table" CssClass="btnAdd" OnClick="FighterDB_Click" />
            &nbsp;<asp:Button ID="btnSoftDelete" runat="server" Text="Rank Table" CssClass="btnSoftDelete" OnClick="RankDB_Click" />
            &nbsp;<asp:Button ID="btnHardDelete" runat="server" Text="Coach Table" CssClass="btnHardDelete" OnClick="CoachDB_Click" />
            &nbsp;<asp:Button ID="btnUpdate" runat="server" Text="Camp Training Table" CssClass="btnUpdate" OnClick="CampDB_Click" />
            <br />
        </div>

        <div>
            <asp:Label Text="Search :" runat="server" CssClass="Search" />
            <asp:TextBox ID="txtSearchName" placeholder="Name/null" autocomplete="off" CssClass="txtS" runat="server"></asp:TextBox>
            <asp:Button ID="Search" runat="server" Text="SEARCH" CssClass="btnSearch" OnClick="btnSearch_Click" />
            <asp:GridView ID="GridView1" Width="100%" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
            <br />
            <asp:Button ID="Refresh" runat="server" Text="Refresh" CssClass="btnRefresh" OnClick="Refresh_Click" /><br />
            &nbsp; <asp:Button ID="Logout" runat="server" Text="Logout" CssClass="btnLogout" OnClick="Logout_Click" />
        </div>
    </form>
</body>
</html>
