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
		<br><br>COCKY ENTERPRISES <br>INVENTORY MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEM32" DeleteCommand="DELETE FROM [ginventory] WHERE [id] = ? AND (([inventoryid] = ?) OR ([inventoryid] IS NULL AND ? IS NULL)) AND (([inventorytype] = ?) OR ([inventorytype] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([serialnumber] = ?) OR ([serialnumber] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [ginventory] ([inventoryid], [inventorytype], [description], [serialnumber]) VALUES (?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [ginventory]" UpdateCommand="UPDATE [ginventory] SET [inventoryid] = ?, [inventorytype] = ?, [description] = ?, [serialnumber] = ? WHERE [id] = ? AND (([inventoryid] = ?) OR ([inventoryid] IS NULL AND ? IS NULL)) AND (([inventorytype] = ?) OR ([inventorytype] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([serialnumber] = ?) OR ([serialnumber] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventorytype" Type="Int32" />
			<asp:Parameter Name="original_inventorytype" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_serialnumber" Type="String" />
			<asp:Parameter Name="original_serialnumber" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="inventoryid" Type="String" />
			<asp:Parameter Name="inventorytype" Type="Int32" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="serialnumber" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="inventoryid" Type="String" />
			<asp:Parameter Name="inventorytype" Type="Int32" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="serialnumber" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventorytype" Type="Int32" />
			<asp:Parameter Name="original_inventorytype" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_serialnumber" Type="String" />
			<asp:Parameter Name="original_serialnumber" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="inventoryid" HeaderText="inventoryid" SortExpression="inventoryid">
			</asp:BoundField>
			<asp:BoundField DataField="inventorytype" HeaderText="inventorytype" SortExpression="inventorytype">
			</asp:BoundField>
			<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
			</asp:BoundField>
			<asp:BoundField DataField="serialnumber" HeaderText="serialnumber" SortExpression="serialnumber">
			</asp:BoundField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managehostlpars.aspx">Return to LPARManager</a>
</div>
</body>
</html>