<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="p8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            &nbsp;<br />
            Meal Prefreances:<asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Snacks</asp:ListItem>
                <asp:ListItem>Thali</asp:ListItem>
                <asp:ListItem>Mini Thali</asp:ListItem>
                <asp:ListItem>Candy</asp:ListItem>
                <asp:ListItem>Chips</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            Vaccinated:<asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Dose1</asp:ListItem>
                <asp:ListItem>Dose2</asp:ListItem>
                <asp:ListItem>Applied</asp:ListItem>
                <asp:ListItem>Not applied</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Vaccien Name:<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Covishild</asp:ListItem>
                <asp:ListItem>Cowix</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Display Details" />
            <br />
        </div>
    </form>
</body>
</html>
