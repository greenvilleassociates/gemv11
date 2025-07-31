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
		ITSM RESULTS SCREEN<br />
		<img alt="" height="258" src="cocky590.png" width="333" /><br />
		<br />
		<br />
		<HR>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=PostgreSQL30" ProviderName="System.Data.Odbc" SelectCommand="SELECT DISTINCT * FROM itsm">
	</asp:SqlDataSource>
	<asp:GridView id="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="id" AllowPaging="True" AllowSorting="True">
		<Columns>
			<asp:CommandField ShowSelectButton="True">
			</asp:CommandField>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="workdescription" HeaderText="workdescription" SortExpression="workdescription">
			</asp:BoundField>
		</Columns>
	</asp:GridView>
</form>
<HR>
</body>

</html>
