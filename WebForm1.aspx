<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Sorting_a_List_of_Numbers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="font-family: 'Arial Black'">
            <strong style="font-size: xx-large; font-style: italic; color: #FF0000">Enter the List Of Numbers </strong>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server" BorderColor="Red" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Insertion</asp:ListItem>
                        <asp:ListItem>Bubble </asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sort" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox2" runat="server" BackColor="Red" BorderColor="Red" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
