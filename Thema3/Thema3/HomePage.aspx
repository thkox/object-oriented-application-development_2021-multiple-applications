<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Thema3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="HomePage.css" />
    <title>Registry vaccine system!</title>
    <link rel="stylesheet" runat="server" media="screen" type="text/css" href="StylePage.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <br/><br/>
        <div>
            <h1 class="title">Welcome to our registry vaccine system!</h1>
                <br/><br/>
         </div>
         <div>
            <h2 class="subs">Please Choose an Option</h2>
         </div>
               <br/><br/>
            <div style="text-align:center;">
                <asp:Button ID="SearchB" runat="server" Text="Search" CssClass="homeB" OnClick="SearchB_Click" />
            </div>
                <br/><br/>
            <div style="text-align:center;">
                <asp:Button ID="RegisterB" runat="server" Text="Register Citizen" CssClass="homeB" OnClick="RegisterB_Click"/>
            </div>
                <br/><br/>
            <div style="text-align:center;">
                <asp:Button ID="ViewAllB" runat="server" Text="View All Vaccinated People" CssClass="homeB" OnClick="ViewAllB_Click" />
            </div>
<%--Koxanoglou Theodoros P20094
    Kourpas Danas Aimilios P20100
    Siampanis Apostolis P20173--%>
    </form>
</body>
</html>
