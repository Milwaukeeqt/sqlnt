<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SQLnTABLES.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SQLnTABLES</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="NameLabel" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Surname" runat="server" Text="Surname:"></asp:Label>
        <asp:TextBox ID="SurnameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Age" runat="server" Text="Age:"></asp:Label>
        <asp:TextBox ID="AgeTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Gender" runat="server" Text="Gender:"></asp:Label>
        <asp:DropDownList ID="GenderDropDownList" AppendDataBoundItems="true" runat="server">
            <asp:ListItem Text="Male" Value="0"></asp:ListItem>
            <asp:ListItem Text="Female" Value="1"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_OnClick"/>
        <br/>
        <asp:GridView ID="GridView" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
