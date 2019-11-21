<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frontend.aspx.cs" Inherits="SoftwareA.Frontend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products Page</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">ID</td>
                    <td class="auto-style2">
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
                    <td>Price</td>
                    <td>
                        <asp:TextBox ID="txt_price" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Stock</td>
                    <td>
                        <asp:TextBox ID="txt_stock" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Category</td>
                    <td>
                        <asp:TextBox ID="txt_category" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Offer</td>
                    <td>
                        <asp:TextBox ID="txt_offer" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Delivery</td>
                    <td>
                        <asp:TextBox ID="txt_delivery" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_insert" runat="server" Text="Insert" OnClick="btn_insert_Click" />
                        <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" />
                        <asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" />
                    </td>
                </tr>
            </table>
         

        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
