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
		<br><br>COCKY ENTERPRISES<br>GRID NODE MANAGER DETAIL<br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [ggridnodes] WHERE [id] = ? AND (([siteid] = ?) OR ([siteid] IS NULL AND ? IS NULL)) AND (([rackid] = ?) OR ([rackid] IS NULL AND ? IS NULL)) AND (([locationid] = ?) OR ([locationid] IS NULL AND ? IS NULL)) AND (([floorid] = ?) OR ([floorid] IS NULL AND ? IS NULL)) AND (([ipaddress] = ?) OR ([ipaddress] IS NULL AND ? IS NULL)) AND (([telemetryip] = ?) OR ([telemetryip] IS NULL AND ? IS NULL)) AND (([rootid1] = ?) OR ([rootid1] IS NULL AND ? IS NULL)) AND (([rootid2] = ?) OR ([rootid2] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [ggridnodes] ([siteid], [rackid], [locationid], [floorid], [ipaddress], [telemetryip], [rootid1], [rootid2]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [ggridnodes]" UpdateCommand="UPDATE [ggridnodes] SET [siteid] = ?, [rackid] = ?, [locationid] = ?, [floorid] = ?, [ipaddress] = ?, [telemetryip] = ?, [rootid1] = ?, [rootid2] = ? WHERE [id] = ? AND (([siteid] = ?) OR ([siteid] IS NULL AND ? IS NULL)) AND (([rackid] = ?) OR ([rackid] IS NULL AND ? IS NULL)) AND (([locationid] = ?) OR ([locationid] IS NULL AND ? IS NULL)) AND (([floorid] = ?) OR ([floorid] IS NULL AND ? IS NULL)) AND (([ipaddress] = ?) OR ([ipaddress] IS NULL AND ? IS NULL)) AND (([telemetryip] = ?) OR ([telemetryip] IS NULL AND ? IS NULL)) AND (([rootid1] = ?) OR ([rootid1] IS NULL AND ? IS NULL)) AND (([rootid2] = ?) OR ([rootid2] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_siteid" Type="Int32" />
			<asp:Parameter Name="original_siteid" Type="Int32" />
			<asp:Parameter Name="original_rackid" Type="Int32" />
			<asp:Parameter Name="original_rackid" Type="Int32" />
			<asp:Parameter Name="original_locationid" Type="Int32" />
			<asp:Parameter Name="original_locationid" Type="Int32" />
			<asp:Parameter Name="original_floorid" Type="Int32" />
			<asp:Parameter Name="original_floorid" Type="Int32" />
			<asp:Parameter Name="original_ipaddress" Type="String" />
			<asp:Parameter Name="original_ipaddress" Type="String" />
			<asp:Parameter Name="original_telemetryip" Type="String" />
			<asp:Parameter Name="original_telemetryip" Type="String" />
			<asp:Parameter Name="original_rootid1" Type="Int32" />
			<asp:Parameter Name="original_rootid1" Type="Int32" />
			<asp:Parameter Name="original_rootid2" Type="Int32" />
			<asp:Parameter Name="original_rootid2" Type="Int32" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="siteid" Type="Int32" />
			<asp:Parameter Name="rackid" Type="Int32" />
			<asp:Parameter Name="locationid" Type="Int32" />
			<asp:Parameter Name="floorid" Type="Int32" />
			<asp:Parameter Name="ipaddress" Type="String" />
			<asp:Parameter Name="telemetryip" Type="String" />
			<asp:Parameter Name="rootid1" Type="Int32" />
			<asp:Parameter Name="rootid2" Type="Int32" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="siteid" Type="Int32" />
			<asp:Parameter Name="rackid" Type="Int32" />
			<asp:Parameter Name="locationid" Type="Int32" />
			<asp:Parameter Name="floorid" Type="Int32" />
			<asp:Parameter Name="ipaddress" Type="String" />
			<asp:Parameter Name="telemetryip" Type="String" />
			<asp:Parameter Name="rootid1" Type="Int32" />
			<asp:Parameter Name="rootid2" Type="Int32" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_siteid" Type="Int32" />
			<asp:Parameter Name="original_siteid" Type="Int32" />
			<asp:Parameter Name="original_rackid" Type="Int32" />
			<asp:Parameter Name="original_rackid" Type="Int32" />
			<asp:Parameter Name="original_locationid" Type="Int32" />
			<asp:Parameter Name="original_locationid" Type="Int32" />
			<asp:Parameter Name="original_floorid" Type="Int32" />
			<asp:Parameter Name="original_floorid" Type="Int32" />
			<asp:Parameter Name="original_ipaddress" Type="String" />
			<asp:Parameter Name="original_ipaddress" Type="String" />
			<asp:Parameter Name="original_telemetryip" Type="String" />
			<asp:Parameter Name="original_telemetryip" Type="String" />
			<asp:Parameter Name="original_rootid1" Type="Int32" />
			<asp:Parameter Name="original_rootid1" Type="Int32" />
			<asp:Parameter Name="original_rootid2" Type="Int32" />
			<asp:Parameter Name="original_rootid2" Type="Int32" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" InsertVisible="False">
			</asp:BoundField>
			<asp:BoundField DataField="siteid" HeaderText="siteid" SortExpression="siteid">
			</asp:BoundField>
			<asp:BoundField DataField="rackid" HeaderText="rackid" SortExpression="rackid">
			</asp:BoundField>
			<asp:BoundField DataField="locationid" HeaderText="locationid" SortExpression="locationid">
			</asp:BoundField>
			<asp:BoundField DataField="floorid" HeaderText="floorid" SortExpression="floorid">
			</asp:BoundField>
			<asp:BoundField DataField="ipaddress" HeaderText="ipaddress" SortExpression="ipaddress">
			</asp:BoundField>
			<asp:BoundField DataField="telemetryip" HeaderText="telemetryip" SortExpression="telemetryip">
			</asp:BoundField>
			<asp:BoundField DataField="rootid1" HeaderText="rootid1" SortExpression="rootid1">
			</asp:BoundField>
			<asp:BoundField DataField="rootid2" HeaderText="rootid2" SortExpression="rootid2">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managegridnodes.aspx">Grid Node Manager</a>
</div>
</body>
</html>