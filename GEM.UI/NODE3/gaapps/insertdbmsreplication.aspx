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
		<br><br><br><br>COCKY ENTERPRISES DBMS REPLICATION<br><br>
		<div class="auto-style1">
			<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="125px" AllowPaging="True">
				<Fields>
					<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
					</asp:BoundField>
					<asp:BoundField DataField="vendorname" HeaderText="vendorname" SortExpression="vendorname">
					</asp:BoundField>
					<asp:BoundField DataField="vendorid" HeaderText="vendorid" SortExpression="vendorid">
					</asp:BoundField>
					<asp:BoundField DataField="replicationdescription" HeaderText="replicationdescription" SortExpression="replicationdescription">
					</asp:BoundField>
					<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
					</asp:CommandField>
				</Fields>
			</asp:DetailsView>
		</div>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gdbmsreplication] WHERE [id] = ? AND (([vendorname] = ?) OR ([vendorname] IS NULL AND ? IS NULL)) AND (([vendorid] = ?) OR ([vendorid] IS NULL AND ? IS NULL)) AND (([replicationdescription] = ?) OR ([replicationdescription] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gdbmsreplication] ([vendorname], [vendorid], [replicationdescription]) VALUES (?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gdbmsreplication]" UpdateCommand="UPDATE [gdbmsreplication] SET [vendorname] = ?, [vendorid] = ?, [replicationdescription] = ? WHERE [id] = ? AND (([vendorname] = ?) OR ([vendorname] IS NULL AND ? IS NULL)) AND (([vendorid] = ?) OR ([vendorid] IS NULL AND ? IS NULL)) AND (([replicationdescription] = ?) OR ([replicationdescription] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_replicationdescription" Type="String" />
			<asp:Parameter Name="original_replicationdescription" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="vendorname" Type="String" />
			<asp:Parameter Name="vendorid" Type="String" />
			<asp:Parameter Name="replicationdescription" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="vendorname" Type="String" />
			<asp:Parameter Name="vendorid" Type="String" />
			<asp:Parameter Name="replicationdescription" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_replicationdescription" Type="String" />
			<asp:Parameter Name="original_replicationdescription" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
</form>
<BR>
<HR>
<span><a href="managedbmsreplication.aspx">DBMS Replication</a><BR></span>
<HR>
</div>
</body>
</html>