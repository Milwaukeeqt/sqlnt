<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SQLnTABLES.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SQLnTABLES</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Name:
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        <br />
        Surname:
        <asp:TextBox ID="SurnameTextBox" runat="server"></asp:TextBox>
        <br />
        Age:
        <asp:TextBox ID="AgeTextBox" runat="server"></asp:TextBox>
        <br />
        Gender:
        <asp:DropDownList ID="GenderDropDownList" AppendDataBoundItems="true" runat="server">
            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_OnClick"/>
        <br/>
        <asp:GridView ID="GridView" AutoGenerateColumns="False" runat="server">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Surname" HeaderText="Surname"/>
                <asp:BoundField DataField="Age" HeaderText="Age" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
