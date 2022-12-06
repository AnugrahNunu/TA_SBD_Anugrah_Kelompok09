﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coach.aspx.cs" Inherits="TA_Anugrah_Kelompok09.Coach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coach Page</title>
    <link href="style/CoachStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:white">Coach</h1>
            <br />
            <asp:Button ID="Dashboard" runat="server" Text="Dashboard" CssClass="btnDashboard" OnClick="Dashboard_Click" /><br />
            <br />
        </div>

        <div class="CoachForm">
            <table style="width:100%">
                <tr>
                    <td>
                        <asp:Label Text="ID" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdCoach" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label Text="Career" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtCareer" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Name" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtNameCoach" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label Text="ID Fighter" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdFighter" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Age :</td>
                    <td>
                        <asp:TextBox ID="txtAgeCoach" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>

        <div>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="ADD" CssClass="btnAdd" OnClick="btnAdd_Click" />
            &nbsp;<asp:Button ID="btnSoftDelete" runat="server" Text="SOFT DELETE" CssClass="btnSoftDelete" OnClick="btnSoftDelete_Click" />
            &nbsp;<asp:Button ID="btnHardDelete" runat="server" Text="HARD DELETE" CssClass="btnHardDelete" OnClick="btnHardDelete_Click" />
            &nbsp;<asp:Button ID="btnUpdate" runat="server" Text="UPDATE" CssClass="btnUpdate" OnClick="btnUpdate_Click" />
            &nbsp;<asp:Button ID="btnRestore" runat="server" Text="RESTORE" CssClass="btnRestore"  OnClick="btnRestore_Click" />
            &nbsp;<asp:Button ID="btnClear" runat="server" Text="CLEAR" CssClass="btnClear" OnClick="btnClear_Click" />
            <br />
            <br />  
        </div>
        <div>
            <asp:Label Text="Search :" runat="server" CssClass="Search" />
            <asp:TextBox ID="txtSearchName" placeholder="Name/null" autocomplete="off" CssClass="txtS" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtSearchAge" placeholder="Age/null" autocomplete="off" CssClass="txtS" runat="server"></asp:TextBox>
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
        </div>
    </form>
</body>
</html>
