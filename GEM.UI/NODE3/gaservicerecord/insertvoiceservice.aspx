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
		<br><br>COCKY ENTERPRISES <br>VOICE SERVICE MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gvoiceservices] WHERE [id] = ? AND (([networkid] = ?) OR ([networkid] IS NULL AND ? IS NULL)) AND (([voiceserviceid] = ?) OR ([voiceserviceid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([inventoryid] = ?) OR ([inventoryid] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gvoiceservices] ([networkid], [voiceserviceid], [description], [inventoryid]) VALUES (?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gvoiceservices]" UpdateCommand="UPDATE [gvoiceservices] SET [networkid] = ?, [voiceserviceid] = ?, [description] = ?, [inventoryid] = ? WHERE [id] = ? AND (([networkid] = ?) OR ([networkid] IS NULL AND ? IS NULL)) AND (([voiceserviceid] = ?) OR ([voiceserviceid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([inventoryid] = ?) OR ([inventoryid] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_networkid" Type="Int32" />
			<asp:Parameter Name="original_networkid" Type="Int32" />
			<asp:Parameter Name="original_voiceserviceid" Type="String" />
			<asp:Parameter Name="original_voiceserviceid" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="networkid" Type="Int32" />
			<asp:Parameter Name="voiceserviceid" Type="String" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="inventoryid" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="networkid" Type="Int32" />
			<asp:Parameter Name="voiceserviceid" Type="String" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="inventoryid" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_networkid" Type="Int32" />
			<asp:Parameter Name="original_networkid" Type="Int32" />
			<asp:Parameter Name="original_voiceserviceid" Type="String" />
			<asp:Parameter Name="original_voiceserviceid" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="networkid" HeaderText="networkid" SortExpression="networkid">
			</asp:BoundField>
			<asp:BoundField DataField="voiceserviceid" HeaderText="voiceserviceid" SortExpression="voiceserviceid">
			</asp:BoundField>
			<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
			</asp:BoundField>
			<asp:BoundField DataField="inventoryid" HeaderText="inventoryid" SortExpression="inventoryid">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managevoiceservices.aspx">Return to Voice Service Manager</a>
</div>
</body>
</html>