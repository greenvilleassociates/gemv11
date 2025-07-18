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
		TICKET DETAIL SCREEN<br />
		<br />
		<br />
		<HR>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEMPROD" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gitsm]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [gitsm] WHERE [id] = ? AND (([ticketid] = ?) OR ([ticketid] IS NULL AND ? IS NULL)) AND (([custid] = ?) OR ([custid] IS NULL AND ? IS NULL)) AND (([oracleid] = ?) OR ([oracleid] IS NULL AND ? IS NULL)) AND (([dynamicsid] = ?) OR ([dynamicsid] IS NULL AND ? IS NULL)) AND (([summary] = ?) OR ([summary] IS NULL AND ? IS NULL)) AND (([priority] = ?) OR ([priority] IS NULL AND ? IS NULL)) AND (([res1] = ?) OR ([res1] IS NULL AND ? IS NULL)) AND (([res2] = ?) OR ([res2] IS NULL AND ? IS NULL)) AND (([res3] = ?) OR ([res3] IS NULL AND ? IS NULL)) AND (([res4] = ?) OR ([res4] IS NULL AND ? IS NULL)) AND (([ticketstatus] = ?) OR ([ticketstatus] IS NULL AND ? IS NULL)) AND (([opendate] = ?) OR ([opendate] IS NULL AND ? IS NULL)) AND (([closedate] = ?) OR ([closedate] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gitsm] ([ticketid], [custid], [oracleid], [dynamicsid], [summary], [priority], [res1], [res2], [res3], [res4], [ticketstatus], [opendate], [closedate]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [gitsm] SET [ticketid] = ?, [custid] = ?, [oracleid] = ?, [dynamicsid] = ?, [summary] = ?, [priority] = ?, [res1] = ?, [res2] = ?, [res3] = ?, [res4] = ?, [ticketstatus] = ?, [opendate] = ?, [closedate] = ? WHERE [id] = ? AND (([ticketid] = ?) OR ([ticketid] IS NULL AND ? IS NULL)) AND (([custid] = ?) OR ([custid] IS NULL AND ? IS NULL)) AND (([oracleid] = ?) OR ([oracleid] IS NULL AND ? IS NULL)) AND (([dynamicsid] = ?) OR ([dynamicsid] IS NULL AND ? IS NULL)) AND (([summary] = ?) OR ([summary] IS NULL AND ? IS NULL)) AND (([priority] = ?) OR ([priority] IS NULL AND ? IS NULL)) AND (([res1] = ?) OR ([res1] IS NULL AND ? IS NULL)) AND (([res2] = ?) OR ([res2] IS NULL AND ? IS NULL)) AND (([res3] = ?) OR ([res3] IS NULL AND ? IS NULL)) AND (([res4] = ?) OR ([res4] IS NULL AND ? IS NULL)) AND (([ticketstatus] = ?) OR ([ticketstatus] IS NULL AND ? IS NULL)) AND (([opendate] = ?) OR ([opendate] IS NULL AND ? IS NULL)) AND (([closedate] = ?) OR ([closedate] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int64" />
			<asp:Parameter Name="original_ticketid" Type="Int64" />
			<asp:Parameter Name="original_ticketid" Type="Int64" />
			<asp:Parameter Name="original_custid" Type="String" />
			<asp:Parameter Name="original_custid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_summary" Type="String" />
			<asp:Parameter Name="original_summary" Type="String" />
			<asp:Parameter Name="original_priority" Type="String" />
			<asp:Parameter Name="original_priority" Type="String" />
			<asp:Parameter Name="original_res1" Type="String" />
			<asp:Parameter Name="original_res1" Type="String" />
			<asp:Parameter Name="original_res2" Type="String" />
			<asp:Parameter Name="original_res2" Type="String" />
			<asp:Parameter Name="original_res3" Type="String" />
			<asp:Parameter Name="original_res3" Type="String" />
			<asp:Parameter Name="original_res4" Type="String" />
			<asp:Parameter Name="original_res4" Type="String" />
			<asp:Parameter Name="original_ticketstatus" Type="String" />
			<asp:Parameter Name="original_ticketstatus" Type="String" />
			<asp:Parameter Name="original_opendate" Type="DateTime" />
			<asp:Parameter Name="original_opendate" Type="DateTime" />
			<asp:Parameter Name="original_closedate" Type="DateTime" />
			<asp:Parameter Name="original_closedate" Type="DateTime" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="ticketid" Type="Int64" />
			<asp:Parameter Name="custid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="dynamicsid" Type="String" />
			<asp:Parameter Name="summary" Type="String" />
			<asp:Parameter Name="priority" Type="String" />
			<asp:Parameter Name="res1" Type="String" />
			<asp:Parameter Name="res2" Type="String" />
			<asp:Parameter Name="res3" Type="String" />
			<asp:Parameter Name="res4" Type="String" />
			<asp:Parameter Name="ticketstatus" Type="String" />
			<asp:Parameter Name="opendate" Type="DateTime" />
			<asp:Parameter Name="closedate" Type="DateTime" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="ticketid" Type="Int64" />
			<asp:Parameter Name="custid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="dynamicsid" Type="String" />
			<asp:Parameter Name="summary" Type="String" />
			<asp:Parameter Name="priority" Type="String" />
			<asp:Parameter Name="res1" Type="String" />
			<asp:Parameter Name="res2" Type="String" />
			<asp:Parameter Name="res3" Type="String" />
			<asp:Parameter Name="res4" Type="String" />
			<asp:Parameter Name="ticketstatus" Type="String" />
			<asp:Parameter Name="opendate" Type="DateTime" />
			<asp:Parameter Name="closedate" Type="DateTime" />
			<asp:Parameter Name="original_id" Type="Int64" />
			<asp:Parameter Name="original_ticketid" Type="Int64" />
			<asp:Parameter Name="original_ticketid" Type="Int64" />
			<asp:Parameter Name="original_custid" Type="String" />
			<asp:Parameter Name="original_custid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_summary" Type="String" />
			<asp:Parameter Name="original_summary" Type="String" />
			<asp:Parameter Name="original_priority" Type="String" />
			<asp:Parameter Name="original_priority" Type="String" />
			<asp:Parameter Name="original_res1" Type="String" />
			<asp:Parameter Name="original_res1" Type="String" />
			<asp:Parameter Name="original_res2" Type="String" />
			<asp:Parameter Name="original_res2" Type="String" />
			<asp:Parameter Name="original_res3" Type="String" />
			<asp:Parameter Name="original_res3" Type="String" />
			<asp:Parameter Name="original_res4" Type="String" />
			<asp:Parameter Name="original_res4" Type="String" />
			<asp:Parameter Name="original_ticketstatus" Type="String" />
			<asp:Parameter Name="original_ticketstatus" Type="String" />
			<asp:Parameter Name="original_opendate" Type="DateTime" />
			<asp:Parameter Name="original_opendate" Type="DateTime" />
			<asp:Parameter Name="original_closedate" Type="DateTime" />
			<asp:Parameter Name="original_closedate" Type="DateTime" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<asp:DetailsView id="DetailsView1" runat="server" AllowPaging="True" DataSourceID="SqlDataSource1" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="id">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="ticketid" HeaderText="ticketid" SortExpression="ticketid">
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
</form></div>
<p><a href="tickets.aspx">Return to the ITSM Manager</a></p>
<HR>
</body>

</html>
