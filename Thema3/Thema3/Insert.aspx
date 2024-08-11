<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="Thema3.Insert1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <title>Register Citizen</title>
    <meta name="decription" content="Register a vaccinated or an unvaccinated citizen"/>
    <link rel="stylesheet" runat="server" media="screen" type="text/css" href="StylePage.css"/>
    <style type="text/css">
        .auto-style1 {
            height: 49px;
        }
        .auto-style2 {
            text-align: left;
            vertical-align: center;
            height: 49px;
        }
        .auto-style3 {
            text-align: right;
            vertical-align: center;
            height: 49px;
        }
        .auto-style4 {
            height: 49px;
            text-align: right;
        }
        .auto-style5 {
            height: 49px;
            text-align: left;
        }
        .auto-style6 {
            vertical-align: center;
        }
        .auto-style7 {
            font-size: 150%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
		    <a href="HomePage.aspx">Home</a>
            <a href="Search.aspx">Search</a>
			<a class="active" href="#">Register Citizen</a>
			<a href="ViewAll.aspx">View All Vaccinated People</a>
		</div>
        <br/><br/>
        <div class="info">
<%--Table to align labels and textboxes on registration form--%>
            <table class="auto-style1">
                <tr>
					<th colspan="2" class="header">Register Citizen</th>
				</tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="FirstName" runat="server" Text="First Name:"></asp:Label>
                    </td>
                    <td class="second">
                        <asp:TextBox ID="TextBox1" runat="server" Width="193px" ToolTip="Please Enter your First Name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ErrorMessage="First Name is Required" ControlToValidate="TextBox1" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorFirstName" runat="server" ErrorMessage="Invalid First Name" ControlToValidate="TextBox1" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]*$" Display="Dynamic">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="LastName" runat="server" Text="Last Name:"></asp:Label>
                    </td>
                    <td class="second">
                        <asp:TextBox ID="TextBox2" runat="server" Width="194px" ToolTip="Please Enter your Last Name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="TextBox2" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorLastName" runat="server" ErrorMessage="Invalid Last Name" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]*$" Display="Dynamic">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Email" runat="server" Text="E-mail:"></asp:Label>
                    </td>
                    <td class="second">
                        <asp:TextBox ID="TextBox3" runat="server" Width="192px" TextMode="Email" ToolTip="Please Enter your Email Address"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Email is Required" ControlToValidate="TextBox3" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email" ControlToValidate="TextBox3" ForeColor ="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="PhoneNumber" runat="server" Text="Phone Number:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox4" runat="server" Width="191px" TextMode="Phone" ToolTip="Enter your phone number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhoneNumber" runat="server" ErrorMessage="Phone Number is Required" ControlToValidate="TextBox4" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server" ErrorMessage="Invalid Phone" ControlToValidate="TextBox4" ForeColor="Red" ValidationExpression="^[6]{1}[9]{1}[0-9]{8}$" Display="Dynamic">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="BirthDate" runat="server" Text="Birth Date:"></asp:Label>
                    </td>
                    <td class="second">
                        <asp:TextBox ID="TextBox9" runat="server" ToolTip="Enter Birth Date" Width="166px" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorBirthDate" runat="server" ErrorMessage="Birth Date is Required" ControlToValidate="TextBox9" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <%--<asp:RegularExpressionValidator ID="RegularExpressionValidatorBirthDate" runat="server" ErrorMessage="Invalid Birth Date" ControlToValidate="TextBox9" ForeColor="Red" ValidationExpression="(^(((0[1-9]|1[0-9]|2[0-8])[\/](0[1-9]|1[012]))|((29|30|31)[\/](0[13578]|1[02]))|((29|30)[\/](0[4,6,9]|11)))[\/](19|[2-9][0-9])\d\d$)|(^29[\/]02[\/](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)" Display="Dynamic">*</asp:RegularExpressionValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Sex" runat="server" Text="Gender:"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <div>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" Height="29px" Width="282px" Font-Size="Large" CssClass="auto-style7">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                        </div>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorGender" runat="server" ErrorMessage="Gender is Required" ControlToValidate="RadioButtonList1" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="HomeAddress" runat="server" Text="Home Address:"></asp:Label>
                    </td>
                    <td class="second">
                        <asp:TextBox ID="TextBox6" runat="server" Width="185px" ToolTip="Enter Home Address"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorHomeAddress" runat="server" ErrorMessage="Home Address is Required" ControlToValidate="TextBox6" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="AMKA" runat="server" Text="AMKA:"></asp:Label>
                    </td>
                    <td class="second">
                        <asp:TextBox ID="TextBox8" runat="server" Width="186px" ToolTip="Enter AMKA here"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorAMKA" runat="server" ErrorMessage="AMKA is Required" ControlToValidate="TextBox8" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorAMKA" runat="server" ErrorMessage="Invalid AMKA" ControlToValidate="TextBox8" ForeColor="Red" Enabled="False" ValidationExpression="(?:0[1-9]|[12][0-9]|3[01])(?:0[1-9]|1[0-2])[0-9]{7}" Display="Dynamic">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="UnderlyingDiseases" runat="server" Text="Underlying Diseases:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="RadioButtonList2" RepeatDirection="Horizontal" runat="server" Font-Size="Large" Height="51px" Width="173px" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                            <asp:ListItem>Yes</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUD" runat="server" ErrorMessage="Diseases Selection is Required" ControlToValidate="RadioButtonList2" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox12" runat="server" ToolTip="What diseases do you have?" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Date" runat="server" Text="Date:"></asp:Label>
                    </td>
                    <td class="second">
                        <asp:TextBox ID="TextBox10" runat="server" ToolTip="Vaccine Dates" Width="153px" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorVD" runat="server" ErrorMessage="Vaccination Date is Required" ControlToValidate="TextBox10" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>                        
<%--                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorVaccinationDate" runat="server" ErrorMessage="Invalid Vaccination Date" ControlToValidate="TextBox10" ForeColor="Red" ValidationExpression="(^(((0[1-9]|1[0-9]|2[0-8])[\/](0[1-9]|1[012]))|((29|30|31)[\/](0[13578]|1[02]))|((29|30)[\/](0[4,6,9]|11)))[\/](19|[2-9][0-9])\d\d$)|(^29[\/]02[\/](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)" Display="Dynamic">*</asp:RegularExpressionValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Time" runat="server" Text="Time:"></asp:Label>
                    </td>
                    <td class="second">
                        <asp:TextBox ID="TextBox11" runat="server" MaxLength="5" TextMode="Time" Width="109px">Enter Time Here</asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTime" runat="server" ErrorMessage="Time Selection is Required" ControlToValidate="TextBox11" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr class="footer">
					<td colspan="2">
					    <asp:Button ID="RegisterB" runat="server" Text="Register" class="submit" OnClick="RegisterB_Click"/>
                        <asp:Button ID="CancelB" runat="server" Text="Clear" class="cancel" OnClientClick="this.form.reset();return false;" OnClick="CancelB_Click"/>
					</td>
				</tr>
                <tr class="footer">
                   	<td colspan="2">
					    <asp:Label ID="StatusL" runat="server" Font-Bold="true"></asp:Label>
					</td>
                </tr>
                <tr class="footer">
                   	<td colspan="2">
                           <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Validation Errors:" runat="server" ForeColor="Red" DisplayMode="List"/>
					</td>
                </tr>
            </table>
        </div>
<%--Koxanoglou Theodoros P20094
    Kourpas Danas Aimilios P20100
    Siampanis Apostolis P20173--%>
    </form>
</body>
</html>
