<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Page Language="C#" %>
<html dir="ltr" xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>
ISPUSERS

<form id="form1" runat="server">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEM32" ProviderName="System.Data.Odbc" SelectCommand="select * from h_users;">
	</asp:SqlDataSource>
	<asp:GridView id="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
		<Columns>
			<asp:CommandField ShowSelectButton="True">
			</asp:CommandField>
			<asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="name" HeaderText="name" SortExpression="name">
			</asp:BoundField>
			<asp:BoundField DataField="username" HeaderText="username" SortExpression="username">
			</asp:BoundField>
			<asp:BoundField DataField="email" HeaderText="email" SortExpression="email">
			</asp:BoundField>
			<asp:BoundField DataField="password" HeaderText="password" SortExpression="password">
			</asp:BoundField>
			<asp:BoundField DataField="block" HeaderText="block" SortExpression="block">
			</asp:BoundField>
			<asp:BoundField DataField="sendEmail" HeaderText="sendEmail" SortExpression="sendEmail">
			</asp:BoundField>
			<asp:BoundField DataField="registerDate" HeaderText="registerDate" SortExpression="registerDate">
			</asp:BoundField>
			<asp:BoundField DataField="lastvisitDate" HeaderText="lastvisitDate" SortExpression="lastvisitDate">
			</asp:BoundField>
			<asp:BoundField DataField="activation" HeaderText="activation" SortExpression="activation">
			</asp:BoundField>
			<asp:BoundField DataField="params" HeaderText="params" SortExpression="params">
			</asp:BoundField>
			<asp:BoundField DataField="lastResetTime" HeaderText="lastResetTime" SortExpression="lastResetTime">
			</asp:BoundField>
			<asp:BoundField DataField="resetCount" HeaderText="resetCount" SortExpression="resetCount">
			</asp:BoundField>
			<asp:BoundField DataField="otpKey" HeaderText="otpKey" SortExpression="otpKey">
			</asp:BoundField>
			<asp:BoundField DataField="otep" HeaderText="otep" SortExpression="otep">
			</asp:BoundField>
			<asp:BoundField DataField="requireReset" HeaderText="requireReset" SortExpression="requireReset">
			</asp:BoundField>
		</Columns>
	</asp:GridView>
</form>

</body>

</html>
