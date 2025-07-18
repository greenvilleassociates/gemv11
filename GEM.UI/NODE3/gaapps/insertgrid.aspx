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
		<br><br>COCKY ENTERPRISES <br>GRID DETAIL MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [ggrids] WHERE [id] = ? AND (([geometry] = ?) OR ([geometry] IS NULL AND ? IS NULL)) AND (([gridsite1] = ?) OR ([gridsite1] IS NULL AND ? IS NULL)) AND (([gridnode1id] = ?) OR ([gridnode1id] IS NULL AND ? IS NULL)) AND (([gridsite2] = ?) OR ([gridsite2] IS NULL AND ? IS NULL)) AND (([gridnode2id] = ?) OR ([gridnode2id] IS NULL AND ? IS NULL)) AND (([gridsite3] = ?) OR ([gridsite3] IS NULL AND ? IS NULL)) AND (([gridnode3id] = ?) OR ([gridnode3id] IS NULL AND ? IS NULL)) AND (([gridsite4] = ?) OR ([gridsite4] IS NULL AND ? IS NULL)) AND (([gridnode4id] = ?) OR ([gridnode4id] IS NULL AND ? IS NULL)) AND (([gridsite5] = ?) OR ([gridsite5] IS NULL AND ? IS NULL)) AND (([gridnode5id] = ?) OR ([gridnode5id] IS NULL AND ? IS NULL)) AND (([gridsite6] = ?) OR ([gridsite6] IS NULL AND ? IS NULL)) AND (([gridnode6id] = ?) OR ([gridnode6id] IS NULL AND ? IS NULL)) AND (([drsite1] = ?) OR ([drsite1] IS NULL AND ? IS NULL)) AND (([drnode1id] = ?) OR ([drnode1id] IS NULL AND ? IS NULL)) AND (([drsite2] = ?) OR ([drsite2] IS NULL AND ? IS NULL)) AND (([drnode2id] = ?) OR ([drnode2id] IS NULL AND ? IS NULL)) AND (([rootid1] = ?) OR ([rootid1] IS NULL AND ? IS NULL)) AND (([rootid2] = ?) OR ([rootid2] IS NULL AND ? IS NULL)) AND (([vendor] = ?) OR ([vendor] IS NULL AND ? IS NULL)) AND (([vendorid] = ?) OR ([vendorid] IS NULL AND ? IS NULL)) AND (([vendorgridname] = ?) OR ([vendorgridname] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [ggrids] ([geometry], [gridsite1], [gridnode1id], [gridsite2], [gridnode2id], [gridsite3], [gridnode3id], [gridsite4], [gridnode4id], [gridsite5], [gridnode5id], [gridsite6], [gridnode6id], [drsite1], [drnode1id], [drsite2], [drnode2id], [rootid1], [rootid2], [vendor], [vendorid], [vendorgridname]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [ggrids]" UpdateCommand="UPDATE [ggrids] SET [geometry] = ?, [gridsite1] = ?, [gridnode1id] = ?, [gridsite2] = ?, [gridnode2id] = ?, [gridsite3] = ?, [gridnode3id] = ?, [gridsite4] = ?, [gridnode4id] = ?, [gridsite5] = ?, [gridnode5id] = ?, [gridsite6] = ?, [gridnode6id] = ?, [drsite1] = ?, [drnode1id] = ?, [drsite2] = ?, [drnode2id] = ?, [rootid1] = ?, [rootid2] = ?, [vendor] = ?, [vendorid] = ?, [vendorgridname] = ? WHERE [id] = ? AND (([geometry] = ?) OR ([geometry] IS NULL AND ? IS NULL)) AND (([gridsite1] = ?) OR ([gridsite1] IS NULL AND ? IS NULL)) AND (([gridnode1id] = ?) OR ([gridnode1id] IS NULL AND ? IS NULL)) AND (([gridsite2] = ?) OR ([gridsite2] IS NULL AND ? IS NULL)) AND (([gridnode2id] = ?) OR ([gridnode2id] IS NULL AND ? IS NULL)) AND (([gridsite3] = ?) OR ([gridsite3] IS NULL AND ? IS NULL)) AND (([gridnode3id] = ?) OR ([gridnode3id] IS NULL AND ? IS NULL)) AND (([gridsite4] = ?) OR ([gridsite4] IS NULL AND ? IS NULL)) AND (([gridnode4id] = ?) OR ([gridnode4id] IS NULL AND ? IS NULL)) AND (([gridsite5] = ?) OR ([gridsite5] IS NULL AND ? IS NULL)) AND (([gridnode5id] = ?) OR ([gridnode5id] IS NULL AND ? IS NULL)) AND (([gridsite6] = ?) OR ([gridsite6] IS NULL AND ? IS NULL)) AND (([gridnode6id] = ?) OR ([gridnode6id] IS NULL AND ? IS NULL)) AND (([drsite1] = ?) OR ([drsite1] IS NULL AND ? IS NULL)) AND (([drnode1id] = ?) OR ([drnode1id] IS NULL AND ? IS NULL)) AND (([drsite2] = ?) OR ([drsite2] IS NULL AND ? IS NULL)) AND (([drnode2id] = ?) OR ([drnode2id] IS NULL AND ? IS NULL)) AND (([rootid1] = ?) OR ([rootid1] IS NULL AND ? IS NULL)) AND (([rootid2] = ?) OR ([rootid2] IS NULL AND ? IS NULL)) AND (([vendor] = ?) OR ([vendor] IS NULL AND ? IS NULL)) AND (([vendorid] = ?) OR ([vendorid] IS NULL AND ? IS NULL)) AND (([vendorgridname] = ?) OR ([vendorgridname] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_geometry" Type="String" />
			<asp:Parameter Name="original_geometry" Type="String" />
			<asp:Parameter Name="original_gridsite1" Type="Int32" />
			<asp:Parameter Name="original_gridsite1" Type="Int32" />
			<asp:Parameter Name="original_gridnode1id" Type="Int32" />
			<asp:Parameter Name="original_gridnode1id" Type="Int32" />
			<asp:Parameter Name="original_gridsite2" Type="Int32" />
			<asp:Parameter Name="original_gridsite2" Type="Int32" />
			<asp:Parameter Name="original_gridnode2id" Type="Int32" />
			<asp:Parameter Name="original_gridnode2id" Type="Int32" />
			<asp:Parameter Name="original_gridsite3" Type="Int32" />
			<asp:Parameter Name="original_gridsite3" Type="Int32" />
			<asp:Parameter Name="original_gridnode3id" Type="Int32" />
			<asp:Parameter Name="original_gridnode3id" Type="Int32" />
			<asp:Parameter Name="original_gridsite4" Type="Int32" />
			<asp:Parameter Name="original_gridsite4" Type="Int32" />
			<asp:Parameter Name="original_gridnode4id" Type="Int32" />
			<asp:Parameter Name="original_gridnode4id" Type="Int32" />
			<asp:Parameter Name="original_gridsite5" Type="Int32" />
			<asp:Parameter Name="original_gridsite5" Type="Int32" />
			<asp:Parameter Name="original_gridnode5id" Type="Int32" />
			<asp:Parameter Name="original_gridnode5id" Type="Int32" />
			<asp:Parameter Name="original_gridsite6" Type="Int32" />
			<asp:Parameter Name="original_gridsite6" Type="Int32" />
			<asp:Parameter Name="original_gridnode6id" Type="Int32" />
			<asp:Parameter Name="original_gridnode6id" Type="Int32" />
			<asp:Parameter Name="original_drsite1" Type="Int32" />
			<asp:Parameter Name="original_drsite1" Type="Int32" />
			<asp:Parameter Name="original_drnode1id" Type="Int32" />
			<asp:Parameter Name="original_drnode1id" Type="Int32" />
			<asp:Parameter Name="original_drsite2" Type="Int32" />
			<asp:Parameter Name="original_drsite2" Type="Int32" />
			<asp:Parameter Name="original_drnode2id" Type="Int32" />
			<asp:Parameter Name="original_drnode2id" Type="Int32" />
			<asp:Parameter Name="original_rootid1" Type="Int32" />
			<asp:Parameter Name="original_rootid1" Type="Int32" />
			<asp:Parameter Name="original_rootid2" Type="Int32" />
			<asp:Parameter Name="original_rootid2" Type="Int32" />
			<asp:Parameter Name="original_vendor" Type="String" />
			<asp:Parameter Name="original_vendor" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorgridname" Type="String" />
			<asp:Parameter Name="original_vendorgridname" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="geometry" Type="String" />
			<asp:Parameter Name="gridsite1" Type="Int32" />
			<asp:Parameter Name="gridnode1id" Type="Int32" />
			<asp:Parameter Name="gridsite2" Type="Int32" />
			<asp:Parameter Name="gridnode2id" Type="Int32" />
			<asp:Parameter Name="gridsite3" Type="Int32" />
			<asp:Parameter Name="gridnode3id" Type="Int32" />
			<asp:Parameter Name="gridsite4" Type="Int32" />
			<asp:Parameter Name="gridnode4id" Type="Int32" />
			<asp:Parameter Name="gridsite5" Type="Int32" />
			<asp:Parameter Name="gridnode5id" Type="Int32" />
			<asp:Parameter Name="gridsite6" Type="Int32" />
			<asp:Parameter Name="gridnode6id" Type="Int32" />
			<asp:Parameter Name="drsite1" Type="Int32" />
			<asp:Parameter Name="drnode1id" Type="Int32" />
			<asp:Parameter Name="drsite2" Type="Int32" />
			<asp:Parameter Name="drnode2id" Type="Int32" />
			<asp:Parameter Name="rootid1" Type="Int32" />
			<asp:Parameter Name="rootid2" Type="Int32" />
			<asp:Parameter Name="vendor" Type="String" />
			<asp:Parameter Name="vendorid" Type="String" />
			<asp:Parameter Name="vendorgridname" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="geometry" Type="String" />
			<asp:Parameter Name="gridsite1" Type="Int32" />
			<asp:Parameter Name="gridnode1id" Type="Int32" />
			<asp:Parameter Name="gridsite2" Type="Int32" />
			<asp:Parameter Name="gridnode2id" Type="Int32" />
			<asp:Parameter Name="gridsite3" Type="Int32" />
			<asp:Parameter Name="gridnode3id" Type="Int32" />
			<asp:Parameter Name="gridsite4" Type="Int32" />
			<asp:Parameter Name="gridnode4id" Type="Int32" />
			<asp:Parameter Name="gridsite5" Type="Int32" />
			<asp:Parameter Name="gridnode5id" Type="Int32" />
			<asp:Parameter Name="gridsite6" Type="Int32" />
			<asp:Parameter Name="gridnode6id" Type="Int32" />
			<asp:Parameter Name="drsite1" Type="Int32" />
			<asp:Parameter Name="drnode1id" Type="Int32" />
			<asp:Parameter Name="drsite2" Type="Int32" />
			<asp:Parameter Name="drnode2id" Type="Int32" />
			<asp:Parameter Name="rootid1" Type="Int32" />
			<asp:Parameter Name="rootid2" Type="Int32" />
			<asp:Parameter Name="vendor" Type="String" />
			<asp:Parameter Name="vendorid" Type="String" />
			<asp:Parameter Name="vendorgridname" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_geometry" Type="String" />
			<asp:Parameter Name="original_geometry" Type="String" />
			<asp:Parameter Name="original_gridsite1" Type="Int32" />
			<asp:Parameter Name="original_gridsite1" Type="Int32" />
			<asp:Parameter Name="original_gridnode1id" Type="Int32" />
			<asp:Parameter Name="original_gridnode1id" Type="Int32" />
			<asp:Parameter Name="original_gridsite2" Type="Int32" />
			<asp:Parameter Name="original_gridsite2" Type="Int32" />
			<asp:Parameter Name="original_gridnode2id" Type="Int32" />
			<asp:Parameter Name="original_gridnode2id" Type="Int32" />
			<asp:Parameter Name="original_gridsite3" Type="Int32" />
			<asp:Parameter Name="original_gridsite3" Type="Int32" />
			<asp:Parameter Name="original_gridnode3id" Type="Int32" />
			<asp:Parameter Name="original_gridnode3id" Type="Int32" />
			<asp:Parameter Name="original_gridsite4" Type="Int32" />
			<asp:Parameter Name="original_gridsite4" Type="Int32" />
			<asp:Parameter Name="original_gridnode4id" Type="Int32" />
			<asp:Parameter Name="original_gridnode4id" Type="Int32" />
			<asp:Parameter Name="original_gridsite5" Type="Int32" />
			<asp:Parameter Name="original_gridsite5" Type="Int32" />
			<asp:Parameter Name="original_gridnode5id" Type="Int32" />
			<asp:Parameter Name="original_gridnode5id" Type="Int32" />
			<asp:Parameter Name="original_gridsite6" Type="Int32" />
			<asp:Parameter Name="original_gridsite6" Type="Int32" />
			<asp:Parameter Name="original_gridnode6id" Type="Int32" />
			<asp:Parameter Name="original_gridnode6id" Type="Int32" />
			<asp:Parameter Name="original_drsite1" Type="Int32" />
			<asp:Parameter Name="original_drsite1" Type="Int32" />
			<asp:Parameter Name="original_drnode1id" Type="Int32" />
			<asp:Parameter Name="original_drnode1id" Type="Int32" />
			<asp:Parameter Name="original_drsite2" Type="Int32" />
			<asp:Parameter Name="original_drsite2" Type="Int32" />
			<asp:Parameter Name="original_drnode2id" Type="Int32" />
			<asp:Parameter Name="original_drnode2id" Type="Int32" />
			<asp:Parameter Name="original_rootid1" Type="Int32" />
			<asp:Parameter Name="original_rootid1" Type="Int32" />
			<asp:Parameter Name="original_rootid2" Type="Int32" />
			<asp:Parameter Name="original_rootid2" Type="Int32" />
			<asp:Parameter Name="original_vendor" Type="String" />
			<asp:Parameter Name="original_vendor" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorid" Type="String" />
			<asp:Parameter Name="original_vendorgridname" Type="String" />
			<asp:Parameter Name="original_vendorgridname" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" InsertVisible="False">
			</asp:BoundField>
			<asp:BoundField DataField="geometry" HeaderText="geometry" SortExpression="geometry">
			</asp:BoundField>
			<asp:BoundField DataField="gridsite1" HeaderText="gridsite1" SortExpression="gridsite1">
			</asp:BoundField>
			<asp:BoundField DataField="gridnode1id" HeaderText="gridnode1id" SortExpression="gridnode1id">
			</asp:BoundField>
			<asp:BoundField DataField="gridsite2" HeaderText="gridsite2" SortExpression="gridsite2">
			</asp:BoundField>
			<asp:BoundField DataField="gridnode2id" HeaderText="gridnode2id" SortExpression="gridnode2id">
			</asp:BoundField>
			<asp:BoundField DataField="gridsite3" HeaderText="gridsite3" SortExpression="gridsite3">
			</asp:BoundField>
			<asp:BoundField DataField="gridnode3id" HeaderText="gridnode3id" SortExpression="gridnode3id">
			</asp:BoundField>
			<asp:BoundField DataField="gridsite4" HeaderText="gridsite4" SortExpression="gridsite4">
			</asp:BoundField>
			<asp:BoundField DataField="gridnode4id" HeaderText="gridnode4id" SortExpression="gridnode4id">
			</asp:BoundField>
			<asp:BoundField DataField="gridsite5" HeaderText="gridsite5" SortExpression="gridsite5">
			</asp:BoundField>
			<asp:BoundField DataField="gridnode5id" HeaderText="gridnode5id" SortExpression="gridnode5id">
			</asp:BoundField>
			<asp:BoundField DataField="gridsite6" HeaderText="gridsite6" SortExpression="gridsite6">
			</asp:BoundField>
			<asp:BoundField DataField="gridnode6id" HeaderText="gridnode6id" SortExpression="gridnode6id">
			</asp:BoundField>
			<asp:BoundField DataField="drsite1" HeaderText="drsite1" SortExpression="drsite1">
			</asp:BoundField>
			<asp:BoundField DataField="drnode1id" HeaderText="drnode1id" SortExpression="drnode1id">
			</asp:BoundField>
			<asp:BoundField DataField="drsite2" HeaderText="drsite2" SortExpression="drsite2">
			</asp:BoundField>
			<asp:BoundField DataField="drnode2id" HeaderText="drnode2id" SortExpression="drnode2id">
			</asp:BoundField>
			<asp:BoundField DataField="rootid1" HeaderText="rootid1" SortExpression="rootid1">
			</asp:BoundField>
			<asp:BoundField DataField="rootid2" HeaderText="rootid2" SortExpression="rootid2">
			</asp:BoundField>
			<asp:BoundField DataField="vendor" HeaderText="vendor" SortExpression="vendor">
			</asp:BoundField>
			<asp:BoundField DataField="vendorid" HeaderText="vendorid" SortExpression="vendorid">
			</asp:BoundField>
			<asp:BoundField DataField="vendorgridname" HeaderText="vendorgridname" SortExpression="vendorgridname">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managegrids.aspx">Return to Grid Manager</a>
</div>
</body>
</html>