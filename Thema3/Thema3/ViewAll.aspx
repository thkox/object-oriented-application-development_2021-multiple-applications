<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAll.aspx.cs" Inherits="Thema3.ViewAll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" runat="server" media="screen" type="text/css" href="StylePage.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div class="navbar">
		    <a href="HomePage.aspx">Home</a>
            <a href="Search.aspx">Search</a>
			<a href="Insert.aspx">Register Citizen</a>
			<a class="active" href="#">View All Vaccinated People</a>
		</div>
        <br/><br/>
<%--Create grid view where the size based on the number of registrations--%>
        <div>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        </div>
    </form>
<%--Koxanoglou Theodoros P20094
    Kourpas Danas Aimilios P20100
    Siampanis Apostolis P20173--%>
</body>
</html>
