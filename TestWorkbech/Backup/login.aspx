<%@ Page language="c#" Codebehind="login.aspx.cs" AutoEventWireup="false" Inherits="SessionDemoTest.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 248px; WIDTH: 472px; POSITION: absolute; TOP: 240px; HEIGHT: 75px"
				cellSpacing="1" cellPadding="1" width="472" border="1">
				<TR>
					<TD style="WIDTH: 135px">User</TD>
					<TD>
						<asp:TextBox id="TextBox1" runat="server">mubi</asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 135px">Password</TD>
					<TD>
						<asp:TextBox id="TextBox2" runat="server" TextMode="Password">mubi</asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 135px"></TD>
					<TD>
						<asp:Button id="Button1" runat="server" Text="Login"></asp:Button></TD>
				</TR>
			</TABLE>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 80px; POSITION: absolute; TOP: 64px" runat="server"
				Width="688px"></asp:Label>
		</form>
	</body>
</HTML>
