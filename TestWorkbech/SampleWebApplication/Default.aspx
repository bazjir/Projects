<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SampleWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server" id="form1">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btnClose" runat="server" Text="İptal" PassAuthorization="true" CssClass="button-new bc-grey bw100 left" OnClick="btnClose_Click" Visible="true" />

    <button type="button" onclick="javascript:__doPostBack('btnClose','')">Click Me!</button> 
    </div>
        </form>

</body>
</html>
