<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInsert.aspx.cs" Inherits="StudentCollectionWebApp.StudentInsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        : : Student Insert Page&nbsp; : :<br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#FF5050" NavigateUrl="~/StudentList.aspx">Total Student</asp:HyperLink>
        <br />
        <br />
        Enter Your ID :<br />
        <br />
        <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your Name :<br />
        <br />
        <asp:TextBox ID="YourNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your Father Name :<br />
        <br />
        <asp:TextBox ID="FatherNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your Mother Name :<br />
        <br />
        <asp:TextBox ID="MotherNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your Email Address :<br />
        <br />
        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your Phone Number :<br />
        <br />
        <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Please Select Your Gender :<br />
        <asp:CheckBoxList ID="GenderCheckBoxList" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
            <asp:ListItem Value="female">Female</asp:ListItem>
            <asp:ListItem Value="common">Unknown</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        Your Blood Group :<br />
        <br />
        <asp:TextBox ID="BloodGroupTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your School Name :<br />
        <br />
        <asp:TextBox ID="SchoolNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your College Name :<br />
        <br />
        <asp:TextBox ID="CollegeNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your University Name :<br />
        <br />
        <asp:TextBox ID="UniNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Nationality :<br />
        <br />
        <asp:TextBox ID="NationalityTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Religion :<br />
        <br />
        <asp:TextBox ID="ReligionTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click1" />
&nbsp;</div>
    </form>
</body>
</html>
