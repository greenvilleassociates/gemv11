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
		<br><br>COCKY ENTERPRISES <br>GRID TOPOLOGY MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEMPROD" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [ggridtopology]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [ggridtopology] WHERE [id] = ? AND (([topologyid] = ?) OR ([topologyid] IS NULL AND ? IS NULL)) AND (([topologydescription] = ?) OR ([topologydescription] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [ggridtopology] ([topologyid], [topologydescription]) VALUES (?, ?)" UpdateCommand="UPDATE [ggridtopology] SET [topologyid] = ?, [topologydescription] = ? WHERE [id] = ? AND (([topologyid] = ?) OR ([topologyid] IS NULL AND ? IS NULL)) AND (([topologydescription] = ?) OR ([topologydescription] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_topologyid" Type="String" />
			<asp:Parameter Name="original_topologyid" Type="String" />
			<asp:Parameter Name="original_topologydescription" Type="String" />
			<asp:Parameter Name="original_topologydescription" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="topologyid" Type="String" />
			<asp:Parameter Name="topologydescription" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="topologyid" Type="String" />
			<asp:Parameter Name="topologydescription" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_topologyid" Type="String" />
			<asp:Parameter Name="original_topologyid" Type="String" />
			<asp:Parameter Name="original_topologydescription" Type="String" />
			<asp:Parameter Name="original_topologydescription" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True" DataKeyNames="id">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" InsertVisible="False" ReadOnly="True">
			</asp:BoundField>
			<asp:BoundField DataField="topologyid" HeaderText="topologyid" SortExpression="topologyid">
			</asp:BoundField>
			<asp:BoundField DataField="topologydescription" HeaderText="topologydescription" SortExpression="topologydescription">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managegridtopology.aspx">Return to Grid Topology Manager</a>
</div>
</body>
</html>