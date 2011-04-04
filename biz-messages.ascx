<%@ Control language="C#" autoeventwireup="true" inherits="biz_messages" Codebehind="biz-messages.ascx.cs" %>
<asp:Panel id="pnlBizMessageWrapper" runat="server"> 
<span class="bizMessageClose"><a title="dismiss this notification">x</a></span>
<ul>
	<asp:Repeater id="rptMessageList" runat="server" enableviewstate="false">
		<ItemTemplate>
			<li><%# Eval("Display")%></li>
		</ItemTemplate>
	</asp:Repeater>
</ul>
</asp:Panel>