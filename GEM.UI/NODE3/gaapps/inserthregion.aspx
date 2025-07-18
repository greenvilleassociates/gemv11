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
		<br><br>COCKY ENTERPRISES <br>HOSTING REGION MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [ghregions] WHERE [id] = ? AND (([regionid] = ?) OR ([regionid] IS NULL AND ? IS NULL)) AND (([regiondescription] = ?) OR ([regiondescription] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [ghregions] ([regionid], [regiondescription]) VALUES (?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [ghregions]" UpdateCommand="UPDATE [ghregions] SET [regionid] = ?, [regiondescription] = ? WHERE [id] = ? AND (([regionid] = ?) OR ([regionid] IS NULL AND ? IS NULL)) AND (([regiondescription] = ?) OR ([regiondescription] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_regionid" Type="String" />
			<asp:Parameter Name="original_regionid" Type="String" />
			<asp:Parameter Name="original_regiondescription" Type="String" />
			<asp:Parameter Name="original_regiondescription" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="regionid" Type="String" />
			<asp:Parameter Name="regiondescription" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="regionid" Type="String" />
			<asp:Parameter Name="regiondescription" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_regionid" Type="String" />
			<asp:Parameter Name="original_regionid" Type="String" />
			<asp:Parameter Name="original_regiondescription" Type="String" />
			<asp:Parameter Name="original_regiondescription" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="regionid" HeaderText="regionid" SortExpression="regionid">
			</asp:BoundField>
			<asp:BoundField DataField="regiondescription" HeaderText="regiondescription" SortExpression="regiondescription">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managehregions.aspx">Return to Employee Console</a>
</div>
</body>
</html>