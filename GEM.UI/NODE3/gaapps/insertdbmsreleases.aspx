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
		<br><br><br><br>COCKY ENTERPRISES DBMS RELEASE MANAGER <br><br>
		<div class="auto-style1">
			<asp:DetailsView id="DetailsView1" runat="server" Height="23px" Width="483px" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
				<Fields>
					<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
					</asp:BoundField>
					<asp:BoundField DataField="vendorname" HeaderText="vendorname" SortExpression="vendorname">
					</asp:BoundField>
					<asp:BoundField DataField="vendorid" HeaderText="vendorid" SortExpression="vendorid">
					</asp:BoundField>
					<asp:BoundField DataField="releasedescription" HeaderText="releasedescription" SortExpression="releasedescription">
					</asp:BoundField>
					<asp:BoundField DataField="releaseversion" HeaderText="releaseversion" SortExpression="releaseversion">
					</asp:BoundField>
					<asp:BoundField DataField="releasesystemrequirements" HeaderText="releasesystemrequirements" SortExpression="releasesystemrequirements">
					</asp:BoundField>
					<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
					</asp:CommandField>
				</Fields>
			</asp:DetailsView>
		</div>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gdbmsreleases] WHERE [id] = ? AND (([vendorname] = ?) OR ([vendorname] IS NULL AND ? IS NULL)) AND (([vendorid] = ?) OR ([vendorid] IS NULL AND ? IS NULL)) AND (([releasedescription] = ?) OR ([releasedescription] IS NULL AND ? IS NULL)) AND (([releaseversion] = ?) OR ([releaseversion] IS NULL AND ? IS NULL)) AND (([releasesystemrequirements] = ?) OR ([releasesystemrequirements] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gdbmsreleases] ([vendorname], [vendorid], [releasedescription], [releaseversion], [releasesystemrequirements]) VALUES (?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gdbmsreleases]" UpdateCommand="UPDATE [gdbmsreleases] SET [vendorname] = ?, [vendorid] = ?, [releasedescription] = ?, [releaseversion] = ?, [releasesystemrequirements] = ? WHERE [id] = ? AND (([vendorname] = ?) OR ([vendorname] IS NULL AND ? IS NULL)) AND (([vendorid] = ?) OR ([vendorid] IS NULL AND ? IS NULL)) AND (([releasedescription] = ?) OR ([releasedescription] IS NULL AND ? IS NULL)) AND (([releaseversion] = ?) OR ([releaseversion] IS NULL AND ? IS NULL)) AND (([releasesystemrequirements] = ?) OR ([releasesystemrequirements] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_releasedescription" Type="String" />
			<asp:Parameter Name="original_releasedescription" Type="String" />
			<asp:Parameter Name="original_releaseversion" Type="String" />
			<asp:Parameter Name="original_releaseversion" Type="String" />
			<asp:Parameter Name="original_releasesystemrequirements" Type="String" />
			<asp:Parameter Name="original_releasesystemrequirements" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="vendorname" Type="String" />
			<asp:Parameter Name="vendorid" Type="String" />
			<asp:Parameter Name="releasedescription" Type="String" />
			<asp:Parameter Name="releaseversion" Type="String" />
			<asp:Parameter Name="releasesystemrequirements" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="vendorname" Type="String" />
			<asp:Parameter Name="vendorid" Type="String" />
			<asp:Parameter Name="releasedescription" Type="String" />
			<asp:Parameter Name="releaseversion" Type="String" />
			<asp:Parameter Name="releasesystemrequirements" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_releasedescription" Type="String" />
			<asp:Parameter Name="original_releasedescription" Type="String" />
			<asp:Parameter Name="original_releaseversion" Type="String" />
			<asp:Parameter Name="original_releaseversion" Type="String" />
			<asp:Parameter Name="original_releasesystemrequirements" Type="String" />
			<asp:Parameter Name="original_releasesystemrequirements" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
</form>
<BR>
<HR>
<span><a href="managedbmsreleases.aspx">Return To DBMS Release Manager</a><BR></span>
<HR>
</div>
</body>
</html>