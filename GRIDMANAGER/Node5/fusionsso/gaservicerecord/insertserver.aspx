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
		<br><br>COCKY ENTERPRISES <br>SERVER MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gservers] WHERE [id] = ? AND (([serverid] = ?) OR ([serverid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([ipaddress] = ?) OR ([ipaddress] IS NULL AND ? IS NULL)) AND (([telemetryipaddress] = ?) OR ([telemetryipaddress] IS NULL AND ? IS NULL)) AND (([vpnid1] = ?) OR ([vpnid1] IS NULL AND ? IS NULL)) AND (([vpnid2] = ?) OR ([vpnid2] IS NULL AND ? IS NULL)) AND (([inventoryid] = ?) OR ([inventoryid] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gservers] ([serverid], [description], [ipaddress], [telemetryipaddress], [vpnid1], [vpnid2], [inventoryid]) VALUES (?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gservers]" UpdateCommand="UPDATE [gservers] SET [serverid] = ?, [description] = ?, [ipaddress] = ?, [telemetryipaddress] = ?, [vpnid1] = ?, [vpnid2] = ?, [inventoryid] = ? WHERE [id] = ? AND (([serverid] = ?) OR ([serverid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([ipaddress] = ?) OR ([ipaddress] IS NULL AND ? IS NULL)) AND (([telemetryipaddress] = ?) OR ([telemetryipaddress] IS NULL AND ? IS NULL)) AND (([vpnid1] = ?) OR ([vpnid1] IS NULL AND ? IS NULL)) AND (([vpnid2] = ?) OR ([vpnid2] IS NULL AND ? IS NULL)) AND (([inventoryid] = ?) OR ([inventoryid] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_serverid" Type="String" />
			<asp:Parameter Name="original_serverid" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_ipaddress" Type="String" />
			<asp:Parameter Name="original_ipaddress" Type="String" />
			<asp:Parameter Name="original_telemetryipaddress" Type="String" />
			<asp:Parameter Name="original_telemetryipaddress" Type="String" />
			<asp:Parameter Name="original_vpnid1" Type="String" />
			<asp:Parameter Name="original_vpnid1" Type="String" />
			<asp:Parameter Name="original_vpnid2" Type="String" />
			<asp:Parameter Name="original_vpnid2" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="serverid" Type="String" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="ipaddress" Type="String" />
			<asp:Parameter Name="telemetryipaddress" Type="String" />
			<asp:Parameter Name="vpnid1" Type="String" />
			<asp:Parameter Name="vpnid2" Type="String" />
			<asp:Parameter Name="inventoryid" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="serverid" Type="String" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="ipaddress" Type="String" />
			<asp:Parameter Name="telemetryipaddress" Type="String" />
			<asp:Parameter Name="vpnid1" Type="String" />
			<asp:Parameter Name="vpnid2" Type="String" />
			<asp:Parameter Name="inventoryid" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_serverid" Type="String" />
			<asp:Parameter Name="original_serverid" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_ipaddress" Type="String" />
			<asp:Parameter Name="original_ipaddress" Type="String" />
			<asp:Parameter Name="original_telemetryipaddress" Type="String" />
			<asp:Parameter Name="original_telemetryipaddress" Type="String" />
			<asp:Parameter Name="original_vpnid1" Type="String" />
			<asp:Parameter Name="original_vpnid1" Type="String" />
			<asp:Parameter Name="original_vpnid2" Type="String" />
			<asp:Parameter Name="original_vpnid2" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="serverid" HeaderText="serverid" SortExpression="serverid">
			</asp:BoundField>
			<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
			</asp:BoundField>
			<asp:BoundField DataField="ipaddress" HeaderText="ipaddress" SortExpression="ipaddress">
			</asp:BoundField>
			<asp:BoundField DataField="telemetryipaddress" HeaderText="telemetryipaddress" SortExpression="telemetryipaddress">
			</asp:BoundField>
			<asp:BoundField DataField="vpnid1" HeaderText="vpnid1" SortExpression="vpnid1">
			</asp:BoundField>
			<asp:BoundField DataField="vpnid2" HeaderText="vpnid2" SortExpression="vpnid2">
			</asp:BoundField>
			<asp:BoundField DataField="inventoryid" HeaderText="inventoryid" SortExpression="inventoryid">
			</asp:BoundField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="manageservers.aspx">Return to Server Manager</a>
</div>
</body>
</html>