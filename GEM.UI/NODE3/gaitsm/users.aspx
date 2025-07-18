<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
<style type="text/css">
.auto-style1 {
	text-align: center;
}
</style>
</head>

<body>

<form id="form1" runat="server">
	<div class="auto-style1">
		<br />
		<img alt="" height="258" src="cocky590.png" width="333" /><br />
		USERS RESULTS SCREEN<br />
		<br />
		<br />
		<HR>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEMPROD" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [h_users]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [h_users] WHERE [id] = ? AND [name] = ? AND [username] = ? AND [email] = ? AND [password] = ? AND [block] = ? AND (([sendEmail] = ?) OR ([sendEmail] IS NULL AND ? IS NULL)) AND [registerDate] = ? AND [lastvisitDate] = ? AND [activation] = ? AND [params] = ? AND [lastResetTime] = ? AND [resetCount] = ? AND [otpKey] = ? AND [otep] = ? AND (([requireReset] = ?) OR ([requireReset] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [h_users] ([name], [username], [email], [password], [block], [sendEmail], [registerDate], [lastvisitDate], [activation], [params], [lastResetTime], [resetCount], [otpKey], [otep], [requireReset]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [h_users] SET [name] = ?, [username] = ?, [email] = ?, [password] = ?, [block] = ?, [sendEmail] = ?, [registerDate] = ?, [lastvisitDate] = ?, [activation] = ?, [params] = ?, [lastResetTime] = ?, [resetCount] = ?, [otpKey] = ?, [otep] = ?, [requireReset] = ? WHERE [id] = ? AND [name] = ? AND [username] = ? AND [email] = ? AND [password] = ? AND [block] = ? AND (([sendEmail] = ?) OR ([sendEmail] IS NULL AND ? IS NULL)) AND [registerDate] = ? AND [lastvisitDate] = ? AND [activation] = ? AND [params] = ? AND [lastResetTime] = ? AND [resetCount] = ? AND [otpKey] = ? AND [otep] = ? AND (([requireReset] = ?) OR ([requireReset] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_name" Type="String" />
			<asp:Parameter Name="original_username" Type="String" />
			<asp:Parameter Name="original_email" Type="String" />
			<asp:Parameter Name="original_password" Type="String" />
			<asp:Parameter Name="original_block" Type="Int16" />
			<asp:Parameter Name="original_sendEmail" Type="Int16" />
			<asp:Parameter Name="original_sendEmail" Type="Int16" />
			<asp:Parameter Name="original_registerDate" Type="DateTime" />
			<asp:Parameter Name="original_lastvisitDate" Type="DateTime" />
			<asp:Parameter Name="original_activation" Type="String" />
			<asp:Parameter Name="original_params" Type="String" />
			<asp:Parameter Name="original_lastResetTime" Type="DateTime" />
			<asp:Parameter Name="original_resetCount" Type="Int64" />
			<asp:Parameter Name="original_otpKey" Type="String" />
			<asp:Parameter Name="original_otep" Type="String" />
			<asp:Parameter Name="original_requireReset" Type="Int16" />
			<asp:Parameter Name="original_requireReset" Type="Int16" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="name" Type="String" />
			<asp:Parameter Name="username" Type="String" />
			<asp:Parameter Name="email" Type="String" />
			<asp:Parameter Name="password" Type="String" />
			<asp:Parameter Name="block" Type="Int16" />
			<asp:Parameter Name="sendEmail" Type="Int16" />
			<asp:Parameter Name="registerDate" Type="DateTime" />
			<asp:Parameter Name="lastvisitDate" Type="DateTime" />
			<asp:Parameter Name="activation" Type="String" />
			<asp:Parameter Name="params" Type="String" />
			<asp:Parameter Name="lastResetTime" Type="DateTime" />
			<asp:Parameter Name="resetCount" Type="Int64" />
			<asp:Parameter Name="otpKey" Type="String" />
			<asp:Parameter Name="otep" Type="String" />
			<asp:Parameter Name="requireReset" Type="Int16" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="name" Type="String" />
			<asp:Parameter Name="username" Type="String" />
			<asp:Parameter Name="email" Type="String" />
			<asp:Parameter Name="password" Type="String" />
			<asp:Parameter Name="block" Type="Int16" />
			<asp:Parameter Name="sendEmail" Type="Int16" />
			<asp:Parameter Name="registerDate" Type="DateTime" />
			<asp:Parameter Name="lastvisitDate" Type="DateTime" />
			<asp:Parameter Name="activation" Type="String" />
			<asp:Parameter Name="params" Type="String" />
			<asp:Parameter Name="lastResetTime" Type="DateTime" />
			<asp:Parameter Name="resetCount" Type="Int64" />
			<asp:Parameter Name="otpKey" Type="String" />
			<asp:Parameter Name="otep" Type="String" />
			<asp:Parameter Name="requireReset" Type="Int16" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_name" Type="String" />
			<asp:Parameter Name="original_username" Type="String" />
			<asp:Parameter Name="original_email" Type="String" />
			<asp:Parameter Name="original_password" Type="String" />
			<asp:Parameter Name="original_block" Type="Int16" />
			<asp:Parameter Name="original_sendEmail" Type="Int16" />
			<asp:Parameter Name="original_sendEmail" Type="Int16" />
			<asp:Parameter Name="original_registerDate" Type="DateTime" />
			<asp:Parameter Name="original_lastvisitDate" Type="DateTime" />
			<asp:Parameter Name="original_activation" Type="String" />
			<asp:Parameter Name="original_params" Type="String" />
			<asp:Parameter Name="original_lastResetTime" Type="DateTime" />
			<asp:Parameter Name="original_resetCount" Type="Int64" />
			<asp:Parameter Name="original_otpKey" Type="String" />
			<asp:Parameter Name="original_otep" Type="String" />
			<asp:Parameter Name="original_requireReset" Type="Int16" />
			<asp:Parameter Name="original_requireReset" Type="Int16" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<asp:GridView id="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="id" AllowPaging="True" AllowSorting="True">
		<Columns>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True">
			</asp:CommandField>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" InsertVisible="False">
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
<HR>
</body>

</html>
