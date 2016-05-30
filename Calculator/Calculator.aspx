<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>
                    <td>
                        <asp:TextBox ID="InputField" runat="server" Text="" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BTNSeven" runat="server" Width="30px" Text="7" CommandArgument="7" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNEight" runat="server" Width="30px" Text="8" CommandArgument="8" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNNine" runat="server" Width="30px" Text="9" CommandArgument="9" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNPlus" runat="server" Width="30px" Text="+" CommandArgument="+" OnClick="BTN_Operator_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BTNFour" runat="server" Width="30px" Text="4" CommandArgument="4" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNFive" runat="server" Width="30px" Text="5" CommandArgument="5" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNSix" runat="server" Width="30px" Text="6" CommandArgument="6" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNMinus" runat="server" Width="30px" Text="-" CommandArgument="-" OnClick="BTN_Operator_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BTNOne" runat="server" Width="30px" Text="1" CommandArgument="1" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNTwo" runat="server" Width="30px" Text="2" CommandArgument="2" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNThree" runat="server" Width="30px" Text="3" CommandArgument="3" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNMultiply" runat="server" Width="30px" Text="x" CommandArgument="x" OnClick="BTN_Operator_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BTNZero" runat="server" Width="30px" Text="0" CommandArgument="0" OnClick="BTN_Add_Value_Click" />
                        <asp:Button ID="BTNClear" runat="server" Width="30px" Text="C" OnClick="BTN_Clear_Click" />
                        <asp:Button ID="BTNEquals" runat="server" Width="30px" Text="=" OnClick="BTN_Equals_Click" />
                        <asp:Button ID="BTNDivide" runat="server" Width="30px" Text="/" CommandArgument="/" OnClick="BTN_Operator_Click" />
                    </td>
                </tr>
            </table>

            <asp:Label ID="ExceptionHandler" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
