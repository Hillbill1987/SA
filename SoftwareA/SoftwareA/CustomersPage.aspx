<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomersPage.aspx.cs" Inherits="SoftwareA.CustomersPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            border: 1px solid #000000;
            background-color: #33CCFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <td>ID</td>
                    <td>
                        <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txt_address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>LoyaltyMember</td>
                    <td>
                        <asp:CheckBox ID="chk_loyalty" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_insert" runat="server" OnClick="btn_insert_Click" Text="Insert" />
                        <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" style="height: 29px" Text="update" />
                        <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="delete" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
