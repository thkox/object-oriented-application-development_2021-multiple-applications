<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Thema3.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" runat="server" media="screen" type="text/css" href="StylePage.css"/>
    <style type="text/css">
        .centerControl {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="navbar">
            <a href="HomePage.aspx">Home</a>
            <a class="active" href="#">Search</a>
			<a href="Insert.aspx">Register Citizen</a>
			<a href="ViewAll.aspx">View All Vaccinated People</a>
        </div>
        <br/><br/>
        <div class="centerControl">
            <h2>Search for a vaccinated person</h2>
            <br/>
        </div>
        <div class="centerControl">
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="11" Font-Size="X-Large" Width="255px"></asp:TextBox>
        </div>
        <br/><br/>
        <div class="centerControl">
             <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" CssClass="searchB" />
        </div>
        <br/><br/><br/>
        <div>      
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" OnRowDeleting="GridView2_RowDeleting" ForeColor="#333333" GridLines="None">  
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>  
                <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>
                        <asp:Button ID="btn_Delete" runat="server" Text="Delete" CommandName="Delete"/> 
                    </EditItemTemplate>  
                </asp:TemplateField>  
<%-----------------Data binding the colums of the table with the colums of our db--%>
                <asp:TemplateField HeaderText="FirstName">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_FirstName" runat="server" Text='<%#Eval("FirstName") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_FirstName" runat="server" Text='<%#Eval("FirstName") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="LastName">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_LastName" runat="server" Text='<%#Eval("LastName") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_LastName" runat="server" Text='<%#Eval("LastName") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Email" runat="server" Text='<%#Eval("Email") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Email" runat="server" Text='<%#Eval("Email") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="PhoneNumber">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_PhoneNumber" runat="server" Text='<%#Eval("Phone") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_PhoneNumber" runat="server" Text='<%#Eval("Phone") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="BirthDate">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_BirthDate" runat="server" Text='<%#Eval("BirthDate") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_BirthDate" runat="server" Text='<%#Eval("BirthDate") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Gender">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Gender" runat="server" Text='<%#Eval("Gender") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Gender" runat="server" Text='<%#Eval("Gender") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="HomeAddress">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_HomeAddress" runat="server" Text='<%#Eval("HomeAddress") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_HomeAddress" runat="server" Text='<%#Eval("HomeAddress") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="AMKA">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_AMKA" runat="server" Text='<%#Eval("AMKA") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_AMKA" runat="server" Text='<%#Eval("AMKA") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="UnderLyingDiseases">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_UnderLyingDiseases" runat="server" Text='<%#Eval("UnderLyingDiseases") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_UnderLyingDiseases" runat="server" Text='<%#Eval("UnderLyingDiseases") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="VaccinationDate">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_VaccinationDate" runat="server" Text='<%#Eval("Date") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_VaccinationDate" runat="server" Text='<%#Eval("Date") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="VaccinationTime">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_VaccinationTime" runat="server" Text='<%#Eval("Time") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_VaccinationTime" runat="server" Text='<%#Eval("Time") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
            </Columns>  
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
<%--Koxanoglou Theodoros P20094
    Kourpas Danas Aimilios P20100
    Siampanis Apostolis P20173--%>
    </form>
</body>
</html>
