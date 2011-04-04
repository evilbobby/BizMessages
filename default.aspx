<%@ Page title="Example" language="C#" autoeventwireup="true" inherits="error" Codebehind="default.aspx.cs" %>

<!DOCTYPE html>
<html>
<head>
	<title></title> 
</head>
<body>
	<form id="form1" runat="server">
	<div class="testCSS" style="clear: none;">
		<br />Biz Messages User Control to show success or failure messages <br /><br />
		
		<asp:Button id="btnShowFailures1" runat="server" text="Show Failures 1" onclick="btnShowFailures1_Click" />
		With Bullets <cmw:BizMessages id="bizMessages1" runat="server" /><br /><br />
		
		<asp:Button id="btnShowSuccess1" runat="server" text="Show Successes 1" onclick="btnShowSuccess1_Click" />
		With Bullets <cmw:BizMessages id="bizMessages2" runat="server" /><br /><br />
		
		<asp:Button id="btnShowFailures2" runat="server" text="Show Failures 2" onclick="btnShowFailures2_Click" />
		Without Bullets <cmw:BizMessages id="bizMessages3" runat="server" /><br /><br />
		
		<asp:Button id="btnShowSuccess2" runat="server" text="Show Successes 2" onclick="btnShowSuccess2_Click" />
		Without Bullets <cmw:BizMessages id="bizMessages4" runat="server" /><br /><br />
		
		<asp:Button id="btnShowErrors" runat="server" text="Show Errors" onclick="btnShowErrors_Click" />
		Show Errors <cmw:BizMessages id="bizErrors" runat="server" /><br /><br />
		
		<asp:Button id="btnShowIList" runat="server" text="Show List of objects" onclick="btnShowList_Click" />
		<cmw:BizMessages id="bizIList" runat="server" />
	</div>
	</form>
</body>
</html>