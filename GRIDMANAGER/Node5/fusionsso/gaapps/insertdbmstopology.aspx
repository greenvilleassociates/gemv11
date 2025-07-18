<html>
<head><title>CockyHRManager</title>
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
		<br>
		<asp:Image id="Image1" runat="server" ImageUrl="./cocky590.png" width="100px" height="100px"/>
		<br><br><br><br>COCKY ENTERPRISES DBMS TOPOLOGY DETAILS<br><br>
		<div class="auto-style1">
			<asp:DetailsView id="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
				<Fields>
					<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
					</asp:BoundField>
					<asp:BoundField DataField="dbmstopology" HeaderText="dbmstopology" SortExpression="dbmstopology">
					</asp:BoundField>
					<asp:BoundField DataField="dbmstopologydescription" HeaderText="dbmstopologydescription" SortExpression="dbmstopologydescription">
					</asp:BoundField>
					<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
					</asp:CommandField>
				</Fields>
			</asp:DetailsView>
		</div>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gdbmstopology] WHERE [id] = ? AND (([dbmstopology] = ?) OR ([dbmstopology] IS NULL AND ? IS NULL)) AND (([dbmstopologydescription] = ?) OR ([dbmstopologydescription] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gdbmstopology] ([dbmstopology], [dbmstopologydescription]) VALUES (?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gdbmstopology]" UpdateCommand="UPDATE [gdbmstopology] SET [dbmstopology] = ?, [dbmstopologydescription] = ? WHERE [id] = ? AND (([dbmstopology] = ?) OR ([dbmstopology] IS NULL AND ? IS NULL)) AND (([dbmstopologydescription] = ?) OR ([dbmstopologydescription] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_dbmstopology" Type="Int32" />
			<asp:Parameter Name="original_dbmstopology" Type="Int32" />
			<asp:Parameter Name="original_dbmstopologydescription" Type="String" />
			<asp:Parameter Name="original_dbmstopologydescription" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="dbmstopology" Type="Int32" />
			<asp:Parameter Name="dbmstopologydescription" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="dbmstopology" Type="Int32" />
			<asp:Parameter Name="dbmstopologydescription" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_dbmstopology" Type="Int32" />
			<asp:Parameter Name="original_dbmstopology" Type="Int32" />
			<asp:Parameter Name="original_dbmstopologydescription" Type="String" />
			<asp:Parameter Name="original_dbmstopologydescription" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
</form>
<BR>
<HR>
<span><a href="managedbmstopologies.aspx">ReturnToDBMTopologyManager</a><BR></span>
<HR>
</div>
</body>
</html>