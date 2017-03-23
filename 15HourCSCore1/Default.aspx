<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My "First" C#<asp:Label runat="server" Text="Label"></asp:Label> Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="sampLabel" runat="server" Text="Label"></asp:Label>
        <br/>
        Ma First webpage
    </div>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </form>
</body>
</html>
