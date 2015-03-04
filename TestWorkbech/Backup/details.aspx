<%@ Page language="c#" Codebehind="details.aspx.cs" AutoEventWireup="false" Inherits="SessionDemoTest.WebForm3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 280px; WIDTH: 300px; POSITION: absolute; TOP: 128px; HEIGHT: 304px"
				cellSpacing="1" cellPadding="1" width="300" border="1">
				<TR>
					<TD>
						<P>
							<asp:TextBox id="tbFoods" runat="server" Height="76px" TextMode="MultiLine">1. Apples          2. Mangos         3. Banans</asp:TextBox>
							<asp:TextBox id="tbGames" runat="server" Height="76px" TextMode="MultiLine">1. QUAKE          2. Star           3. DUNE</asp:TextBox></P>
					</TD>
				</TR>
				<TR>
					<TD>
						<asp:Button id="Button1" runat="server" Text="Back"></asp:Button></TD>
				</TR>
			</TABLE>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 56px; POSITION: absolute; TOP: 32px" runat="server"
				Width="616px"></asp:Label>
		</form>
	</body>
</HTML>
