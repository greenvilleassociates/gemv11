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
<div align="center">
<form id="form1" runat="server">
	<div class="auto-style1">
		<img alt="" height="258" src="cocky590.png" width="333" /><br />
		WORKORDERS RESULTS SCREEN<br />
		<br />
		<br />
		<HR>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEMPROD" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gworkorders]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [gworkorders] WHERE [id] = ? AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gworkorders] ([description]) VALUES (?)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [gworkorders] SET [description] = ? WHERE [id] = ? AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="description" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<asp:DetailsView id="DetailsView1" runat="server" AllowPaging="True" DataSourceID="SqlDataSource1" Height="50px" Width="648px" AutoGenerateRows="False" DataKeyNames="id">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
			</asp:BoundField>
			<asp:BoundField DataField="custid" HeaderText="custid" SortExpression="custid">
			</asp:BoundField>
			<asp:BoundField DataField="oracleid" HeaderText="oracleid" SortExpression="oracleid">
			</asp:BoundField>
			<asp:BoundField DataField="dynamicsid" HeaderText="dynamicsid" SortExpression="dynamicsid">
			</asp:BoundField>
			<asp:BoundField DataField="summary" HeaderText="summary" SortExpression="summary">
			</asp:BoundField>
			<asp:BoundField DataField="priority" HeaderText="priority" SortExpression="priority">
			</asp:BoundField>
			<asp:BoundField DataField="res1" HeaderText="res1" SortExpression="res1">
			</asp:BoundField>
			<asp:BoundField DataField="res2" HeaderText="res2" SortExpression="res2">
			</asp:BoundField>
			<asp:BoundField DataField="res3" HeaderText="res3" SortExpression="res3">
			</asp:BoundField>
			<asp:BoundField DataField="res4" HeaderText="res4" SortExpression="res4">
			</asp:BoundField>
			<asp:BoundField DataField="ticketstatus" HeaderText="ticketstatus" SortExpression="ticketstatus">
			</asp:BoundField>
			<asp:BoundField DataField="opendate" HeaderText="opendate" SortExpression="opendate">
			</asp:BoundField>
			<asp:BoundField DataField="closedate" HeaderText="closedate" SortExpression="closedate">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
</form>
</div>
<p><a href="workorders.aspx">Return to the Workorders Manager</a></p>
<HR>
</body>

</html>
