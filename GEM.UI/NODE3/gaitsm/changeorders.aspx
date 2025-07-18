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

<body onload="checkpll()">
<div align="center">
<div align=center>
<form id="form1" runat="server">
	<div class="auto-style1">
		<img alt="" height="258" src="cocky590.png" width="333" /><br />
		CHANGES RESULTS SCREEN<br />
		<br />
		<HR>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEMPROD" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gchange]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [gchange] WHERE [id] = ? AND (([changeid] = ?) OR ([changeid] IS NULL AND ? IS NULL)) AND (([workeffortsize] = ?) OR ([workeffortsize] IS NULL AND ? IS NULL)) AND (([busunit] = ?) OR ([busunit] IS NULL AND ? IS NULL)) AND (([engineerid] = ?) OR ([engineerid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([status] = ?) OR ([status] IS NULL AND ? IS NULL)) AND (([approvalid] = ?) OR ([approvalid] IS NULL AND ? IS NULL)) AND (([changestart] = ?) OR ([changestart] IS NULL AND ? IS NULL)) AND (([changeend] = ?) OR ([changeend] IS NULL AND ? IS NULL)) AND (([holdinfo] = ?) OR ([holdinfo] IS NULL AND ? IS NULL)) AND (([comments] = ?) OR ([comments] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gchange] ([changeid], [workeffortsize], [busunit], [engineerid], [description], [status], [approvalid], [changestart], [changeend], [holdinfo], [comments]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [gchange] SET [changeid] = ?, [workeffortsize] = ?, [busunit] = ?, [engineerid] = ?, [description] = ?, [status] = ?, [approvalid] = ?, [changestart] = ?, [changeend] = ?, [holdinfo] = ?, [comments] = ? WHERE [id] = ? AND (([changeid] = ?) OR ([changeid] IS NULL AND ? IS NULL)) AND (([workeffortsize] = ?) OR ([workeffortsize] IS NULL AND ? IS NULL)) AND (([busunit] = ?) OR ([busunit] IS NULL AND ? IS NULL)) AND (([engineerid] = ?) OR ([engineerid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([status] = ?) OR ([status] IS NULL AND ? IS NULL)) AND (([approvalid] = ?) OR ([approvalid] IS NULL AND ? IS NULL)) AND (([changestart] = ?) OR ([changestart] IS NULL AND ? IS NULL)) AND (([changeend] = ?) OR ([changeend] IS NULL AND ? IS NULL)) AND (([holdinfo] = ?) OR ([holdinfo] IS NULL AND ? IS NULL)) AND (([comments] = ?) OR ([comments] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_changeid" Type="Int64" />
			<asp:Parameter Name="original_changeid" Type="Int64" />
			<asp:Parameter Name="original_workeffortsize" Type="String" />
			<asp:Parameter Name="original_workeffortsize" Type="String" />
			<asp:Parameter Name="original_busunit" Type="String" />
			<asp:Parameter Name="original_busunit" Type="String" />
			<asp:Parameter Name="original_engineerid" Type="String" />
			<asp:Parameter Name="original_engineerid" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_status" Type="String" />
			<asp:Parameter Name="original_status" Type="String" />
			<asp:Parameter Name="original_approvalid" Type="String" />
			<asp:Parameter Name="original_approvalid" Type="String" />
			<asp:Parameter Name="original_changestart" Type="DateTime" />
			<asp:Parameter Name="original_changestart" Type="DateTime" />
			<asp:Parameter Name="original_changeend" Type="DateTime" />
			<asp:Parameter Name="original_changeend" Type="DateTime" />
			<asp:Parameter Name="original_holdinfo" Type="String" />
			<asp:Parameter Name="original_holdinfo" Type="String" />
			<asp:Parameter Name="original_comments" Type="String" />
			<asp:Parameter Name="original_comments" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="changeid" Type="Int64" />
			<asp:Parameter Name="workeffortsize" Type="String" />
			<asp:Parameter Name="busunit" Type="String" />
			<asp:Parameter Name="engineerid" Type="String" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="status" Type="String" />
			<asp:Parameter Name="approvalid" Type="String" />
			<asp:Parameter Name="changestart" Type="DateTime" />
			<asp:Parameter Name="changeend" Type="DateTime" />
			<asp:Parameter Name="holdinfo" Type="String" />
			<asp:Parameter Name="comments" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="changeid" Type="Int64" />
			<asp:Parameter Name="workeffortsize" Type="String" />
			<asp:Parameter Name="busunit" Type="String" />
			<asp:Parameter Name="engineerid" Type="String" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="status" Type="String" />
			<asp:Parameter Name="approvalid" Type="String" />
			<asp:Parameter Name="changestart" Type="DateTime" />
			<asp:Parameter Name="changeend" Type="DateTime" />
			<asp:Parameter Name="holdinfo" Type="String" />
			<asp:Parameter Name="comments" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_changeid" Type="Int64" />
			<asp:Parameter Name="original_changeid" Type="Int64" />
			<asp:Parameter Name="original_workeffortsize" Type="String" />
			<asp:Parameter Name="original_workeffortsize" Type="String" />
			<asp:Parameter Name="original_busunit" Type="String" />
			<asp:Parameter Name="original_busunit" Type="String" />
			<asp:Parameter Name="original_engineerid" Type="String" />
			<asp:Parameter Name="original_engineerid" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_status" Type="String" />
			<asp:Parameter Name="original_status" Type="String" />
			<asp:Parameter Name="original_approvalid" Type="String" />
			<asp:Parameter Name="original_approvalid" Type="String" />
			<asp:Parameter Name="original_changestart" Type="DateTime" />
			<asp:Parameter Name="original_changestart" Type="DateTime" />
			<asp:Parameter Name="original_changeend" Type="DateTime" />
			<asp:Parameter Name="original_changeend" Type="DateTime" />
			<asp:Parameter Name="original_holdinfo" Type="String" />
			<asp:Parameter Name="original_holdinfo" Type="String" />
			<asp:Parameter Name="original_comments" Type="String" />
			<asp:Parameter Name="original_comments" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<asp:GridView id="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="id" AllowPaging="True" AllowSorting="True">
		<Columns>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True">
			</asp:CommandField>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="changeid" HeaderText="changeid" SortExpression="changeid">
			</asp:BoundField>
			<asp:BoundField DataField="workeffortsize" HeaderText="workeffortsize" SortExpression="workeffortsize">
			</asp:BoundField>
			<asp:BoundField DataField="busunit" HeaderText="busunit" SortExpression="busunit">
			</asp:BoundField>
			<asp:BoundField DataField="engineerid" HeaderText="engineerid" SortExpression="engineerid">
			</asp:BoundField>
			<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
			</asp:BoundField>
			<asp:BoundField DataField="status" HeaderText="status" SortExpression="status">
			</asp:BoundField>
			<asp:BoundField DataField="approvalid" HeaderText="approvalid" SortExpression="approvalid">
			</asp:BoundField>
			<asp:BoundField DataField="changestart" HeaderText="changestart" SortExpression="changestart">
			</asp:BoundField>
			<asp:BoundField DataField="changeend" HeaderText="changeend" SortExpression="changeend">
			</asp:BoundField>
			<asp:BoundField DataField="holdinfo" HeaderText="holdinfo" SortExpression="holdinfo">
			</asp:BoundField>
			<asp:BoundField DataField="comments" HeaderText="comments" SortExpression="comments">
			</asp:BoundField>
		</Columns>
	</asp:GridView>
</form>
</div>
<p><a href="index.aspx">Return to System Menu</a></p>
<p><a href="changedetail.aspx">Change Detail Screen</a></p>

<HR>
</body>
<script>
function checkpll()
{
alert("checkinging security!!!");
}
</html>
