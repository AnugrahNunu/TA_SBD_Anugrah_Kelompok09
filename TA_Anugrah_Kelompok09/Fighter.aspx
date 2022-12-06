<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fighter.aspx.cs" Inherits="TA_Anugrah_Kelompok09.Fighter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fighter Page</title>
    <link href="style/FighterStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:white">Fighter</h1>
            <br />
            <asp:Button ID="Dashboard" runat="server" Text="Dashboard" CssClass="btnDashboard" OnClick="Dashboard_Click" /><br />
            <br />
        </div>

        <div class="FighterForm">
            <table style="width:100%">
                <tr>
                    <td>
                        <asp:Label Text="ID" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdFighter" runat="server" autocomplete="off" CssClass="txt" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label Text="Style" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtSpeciality" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Name" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtNamaFighter" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label Text="ID Rank" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdRank" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Age" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtAgeFighter" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label Text="ID Coach" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdCoach" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Weight" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtWeight" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox></td>
                    <td>
                        <asp:Label Text="ID Camp Training" runat="server" CssClass="lbl" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdCamp" runat="server" autocomplete="off" CssClass="txt"></asp:TextBox></td>
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
            <asp:TextBox ID="txtSearchStyle" placeholder="Style/null" autocomplete="off" CssClass="txtS" runat="server"></asp:TextBox>
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
