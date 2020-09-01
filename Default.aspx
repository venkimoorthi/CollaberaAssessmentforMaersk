<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PromotionEngine._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Promotion Engine</h1>
        <table border="1">
            <tr>
                <th style="text-align: center">Sl. No </th>
                <th style="text-align: center">Option </th>
                <th style="text-align: center">SKU ID </th>
                <th style="text-align: center">Unit Price </th>
                <th style="text-align: center">Item Quantity </th>
            </tr>
            <tr>
                <td style="text-align: center">1</td>
                <td style="text-align: center">
                    <asp:CheckBox ID="chkA" runat="server" /></td>
                <td style="text-align: center">A </td>
                <td style="text-align: center">50 </td>
                <td style="text-align: center">
                    <asp:TextBox ID="txtQtyA" runat="server">0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">2</td>
                <td style="text-align: center">
                    <asp:CheckBox ID="chkB" runat="server" /></td>
                <td style="text-align: center">B </td>
                <td style="text-align: center">30 </td>
                <td style="text-align: center">
                    <asp:TextBox ID="txtQtyB" runat="server">0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">3</td>
                <td style="text-align: center">
                    <asp:CheckBox ID="chkC" runat="server" /></td>
                <td style="text-align: center">C </td>
                <td style="text-align: center">20 </td>
                <td style="text-align: center">
                    <asp:TextBox ID="txtQtyC" runat="server">0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">4</td>
                <td style="text-align: center">
                    <asp:CheckBox ID="chkD" runat="server" />
                </td>
                <td style="text-align: center">D </td>
                <td style="text-align: center">15 </td>
                <td style="text-align: center">
                    <asp:TextBox ID="txtQtyD" runat="server">0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="5" style="text-align: center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Check Out Order" OnClick="btnSubmit_Click" BackColor="#3366FF" Font-Bold="True" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td colspan="5" style="text-align: center; color: green">&nbsp;
                    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5" style="text-align: center; color: red">&nbsp;
                    <asp:Label ID="lblErrorMsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    
</asp:Content>
