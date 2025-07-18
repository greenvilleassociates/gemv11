<html>
<head><title>CockyResumeManager</title>
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
		<asp:Image id="Image1" runat="server" ImageUrl="./cocky590.png" Height="96px" Width="98px" />
		<br><br>COCKY ENTERPRISES <br>VENDOR MANAGEMENT<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gvendor] WHERE [id] = ? AND (([vendorid] = ?) OR ([vendorid] IS NULL AND ? IS NULL)) AND (([vendorname] = ?) OR ([vendorname] IS NULL AND ? IS NULL)) AND (([vendoraddress1] = ?) OR ([vendoraddress1] IS NULL AND ? IS NULL)) AND (([vendoraddress2] = ?) OR ([vendoraddress2] IS NULL AND ? IS NULL)) AND (([vendorcity] = ?) OR ([vendorcity] IS NULL AND ? IS NULL)) AND (([vendorstate] = ?) OR ([vendorstate] IS NULL AND ? IS NULL)) AND (([vendorzip] = ?) OR ([vendorzip] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gvendor] ([vendorid], [vendorname], [vendoraddress1], [vendoraddress2], [vendorcity], [vendorstate], [vendorzip]) VALUES (?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gvendor]" UpdateCommand="UPDATE [gvendor] SET [vendorid] = ?, [vendorname] = ?, [vendoraddress1] = ?, [vendoraddress2] = ?, [vendorcity] = ?, [vendorstate] = ?, [vendorzip] = ? WHERE [id] = ? AND (([vendorid] = ?) OR ([vendorid] IS NULL AND ? IS NULL)) AND (([vendorname] = ?) OR ([vendorname] IS NULL AND ? IS NULL)) AND (([vendoraddress1] = ?) OR ([vendoraddress1] IS NULL AND ? IS NULL)) AND (([vendoraddress2] = ?) OR ([vendoraddress2] IS NULL AND ? IS NULL)) AND (([vendorcity] = ?) OR ([vendorcity] IS NULL AND ? IS NULL)) AND (([vendorstate] = ?) OR ([vendorstate] IS NULL AND ? IS NULL)) AND (([vendorzip] = ?) OR ([vendorzip] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendoraddress1" Type="String" />
			<asp:Parameter Name="original_vendoraddress1" Type="String" />
			<asp:Parameter Name="original_vendoraddress2" Type="String" />
			<asp:Parameter Name="original_vendoraddress2" Type="String" />
			<asp:Parameter Name="original_vendorcity" Type="String" />
			<asp:Parameter Name="original_vendorcity" Type="String" />
			<asp:Parameter Name="original_vendorstate" Type="String" />
			<asp:Parameter Name="original_vendorstate" Type="String" />
			<asp:Parameter Name="original_vendorzip" Type="String" />
			<asp:Parameter Name="original_vendorzip" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="vendorid" Type="String" />
			<asp:Parameter Name="vendorname" Type="String" />
			<asp:Parameter Name="vendoraddress1" Type="String" />
			<asp:Parameter Name="vendoraddress2" Type="String" />
			<asp:Parameter Name="vendorcity" Type="String" />
			<asp:Parameter Name="vendorstate" Type="String" />
			<asp:Parameter Name="vendorzip" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="vendorid" Type="String" />
			<asp:Parameter Name="vendorname" Type="String" />
			<asp:Parameter Name="vendoraddress1" Type="String" />
			<asp:Parameter Name="vendoraddress2" Type="String" />
			<asp:Parameter Name="vendorcity" Type="String" />
			<asp:Parameter Name="vendorstate" Type="String" />
			<asp:Parameter Name="vendorzip" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendorname" Type="String" />
			<asp:Parameter Name="original_vendoraddress1" Type="String" />
			<asp:Parameter Name="original_vendoraddress1" Type="String" />
			<asp:Parameter Name="original_vendoraddress2" Type="String" />
			<asp:Parameter Name="original_vendoraddress2" Type="String" />
			<asp:Parameter Name="original_vendorcity" Type="String" />
			<asp:Parameter Name="original_vendorcity" Type="String" />
			<asp:Parameter Name="original_vendorstate" Type="String" />
			<asp:Parameter Name="original_vendorstate" Type="String" />
			<asp:Parameter Name="original_vendorzip" Type="String" />
			<asp:Parameter Name="original_vendorzip" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="vendorid" HeaderText="vendorid" SortExpression="vendorid">
			</asp:BoundField>
			<asp:BoundField DataField="vendorname" HeaderText="vendorname" SortExpression="vendorname">
			</asp:BoundField>
			<asp:BoundField DataField="vendoraddress1" HeaderText="vendoraddress1" SortExpression="vendoraddress1">
			</asp:BoundField>
			<asp:BoundField DataField="vendoraddress2" HeaderText="vendoraddress2" SortExpression="vendoraddress2">
			</asp:BoundField>
			<asp:BoundField DataField="vendorcity" HeaderText="vendorcity" SortExpression="vendorcity">
			</asp:BoundField>
			<asp:BoundField DataField="vendorstate" HeaderText="vendorstate" SortExpression="vendorstate">
			</asp:BoundField>
			<asp:BoundField DataField="vendorzip" HeaderText="vendorzip" SortExpression="vendorzip">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managevendors.aspx">Return to Vendor Manager</a>
</div>
</body>
</html>