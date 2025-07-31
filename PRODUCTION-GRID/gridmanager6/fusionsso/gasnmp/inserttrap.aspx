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
		<br><br>COCKY ENTERPRISES <br>SNMP Maintenance<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMCORP2" DeleteCommand="DELETE FROM [ctssnmpv5] WHERE [id] = ? AND (([trap_id] = ?) OR ([trap_id] IS NULL AND ? IS NULL)) AND (([timestamp] = ?) OR ([timestamp] IS NULL AND ? IS NULL)) AND (([source_ip] = ?) OR ([source_ip] IS NULL AND ? IS NULL)) AND (([community_string] = ?) OR ([community_string] IS NULL AND ? IS NULL)) AND (([snmp_version] = ?) OR ([snmp_version] IS NULL AND ? IS NULL)) AND (([enterprise_oid] = ?) OR ([enterprise_oid] IS NULL AND ? IS NULL)) AND (([generic_trap_type] = ?) OR ([generic_trap_type] IS NULL AND ? IS NULL)) AND (([specific_trap_code] = ?) OR ([specific_trap_code] IS NULL AND ? IS NULL)) AND (([agent_address] = ?) OR ([agent_address] IS NULL AND ? IS NULL)) AND (([lat] = ?) OR ([lat] IS NULL AND ? IS NULL)) AND (([long] = ?) OR ([long] IS NULL AND ? IS NULL)) AND (([ctsfulllocation] = ?) OR ([ctsfulllocation] IS NULL AND ? IS NULL)) AND (([vpnid] = ?) OR ([vpnid] IS NULL AND ? IS NULL)) AND (([user1] = ?) OR ([user1] IS NULL AND ? IS NULL)) AND (([user2] = ?) OR ([user2] IS NULL AND ? IS NULL)) AND (([user3] = ?) OR ([user3] IS NULL AND ? IS NULL)) AND (([user4] = ?) OR ([user4] IS NULL AND ? IS NULL)) AND (([user5] = ?) OR ([user5] IS NULL AND ? IS NULL)) AND (([loopback_source_ip] = ?) OR ([loopback_source_ip] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [ctssnmpv5] ([trap_id], [timestamp], [source_ip], [community_string], [snmp_version], [enterprise_oid], [generic_trap_type], [specific_trap_code], [agent_address], [lat], [long], [ctsfulllocation], [vpnid], [user1], [user2], [user3], [user4], [user5], [loopback_source_ip]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [ctssnmpv5]" UpdateCommand="UPDATE [ctssnmpv5] SET [trap_id] = ?, [timestamp] = ?, [source_ip] = ?, [community_string] = ?, [snmp_version] = ?, [enterprise_oid] = ?, [generic_trap_type] = ?, [specific_trap_code] = ?, [agent_address] = ?, [lat] = ?, [long] = ?, [ctsfulllocation] = ?, [vpnid] = ?, [user1] = ?, [user2] = ?, [user3] = ?, [user4] = ?, [user5] = ?, [loopback_source_ip] = ? WHERE [id] = ? AND (([trap_id] = ?) OR ([trap_id] IS NULL AND ? IS NULL)) AND (([timestamp] = ?) OR ([timestamp] IS NULL AND ? IS NULL)) AND (([source_ip] = ?) OR ([source_ip] IS NULL AND ? IS NULL)) AND (([community_string] = ?) OR ([community_string] IS NULL AND ? IS NULL)) AND (([snmp_version] = ?) OR ([snmp_version] IS NULL AND ? IS NULL)) AND (([enterprise_oid] = ?) OR ([enterprise_oid] IS NULL AND ? IS NULL)) AND (([generic_trap_type] = ?) OR ([generic_trap_type] IS NULL AND ? IS NULL)) AND (([specific_trap_code] = ?) OR ([specific_trap_code] IS NULL AND ? IS NULL)) AND (([agent_address] = ?) OR ([agent_address] IS NULL AND ? IS NULL)) AND (([lat] = ?) OR ([lat] IS NULL AND ? IS NULL)) AND (([long] = ?) OR ([long] IS NULL AND ? IS NULL)) AND (([ctsfulllocation] = ?) OR ([ctsfulllocation] IS NULL AND ? IS NULL)) AND (([vpnid] = ?) OR ([vpnid] IS NULL AND ? IS NULL)) AND (([user1] = ?) OR ([user1] IS NULL AND ? IS NULL)) AND (([user2] = ?) OR ([user2] IS NULL AND ? IS NULL)) AND (([user3] = ?) OR ([user3] IS NULL AND ? IS NULL)) AND (([user4] = ?) OR ([user4] IS NULL AND ? IS NULL)) AND (([user5] = ?) OR ([user5] IS NULL AND ? IS NULL)) AND (([loopback_source_ip] = ?) OR ([loopback_source_ip] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_trap_id" Type="String" />
			<asp:Parameter Name="original_trap_id" Type="String" />
			<asp:Parameter Name="original_timestamp" Type="String" />
			<asp:Parameter Name="original_timestamp" Type="String" />
			<asp:Parameter Name="original_source_ip" Type="String" />
			<asp:Parameter Name="original_source_ip" Type="String" />
			<asp:Parameter Name="original_community_string" Type="String" />
			<asp:Parameter Name="original_community_string" Type="String" />
			<asp:Parameter Name="original_snmp_version" Type="String" />
			<asp:Parameter Name="original_snmp_version" Type="String" />
			<asp:Parameter Name="original_enterprise_oid" Type="String" />
			<asp:Parameter Name="original_enterprise_oid" Type="String" />
			<asp:Parameter Name="original_generic_trap_type" Type="Int32" />
			<asp:Parameter Name="original_generic_trap_type" Type="Int32" />
			<asp:Parameter Name="original_specific_trap_code" Type="Int32" />
			<asp:Parameter Name="original_specific_trap_code" Type="Int32" />
			<asp:Parameter Name="original_agent_address" Type="String" />
			<asp:Parameter Name="original_agent_address" Type="String" />
			<asp:Parameter Name="original_lat" Type="String" />
			<asp:Parameter Name="original_lat" Type="String" />
			<asp:Parameter Name="original_long" Type="String" />
			<asp:Parameter Name="original_long" Type="String" />
			<asp:Parameter Name="original_ctsfulllocation" Type="String" />
			<asp:Parameter Name="original_ctsfulllocation" Type="String" />
			<asp:Parameter Name="original_vpnid" Type="String" />
			<asp:Parameter Name="original_vpnid" Type="String" />
			<asp:Parameter Name="original_user1" Type="String" />
			<asp:Parameter Name="original_user1" Type="String" />
			<asp:Parameter Name="original_user2" Type="String" />
			<asp:Parameter Name="original_user2" Type="String" />
			<asp:Parameter Name="original_user3" Type="String" />
			<asp:Parameter Name="original_user3" Type="String" />
			<asp:Parameter Name="original_user4" Type="String" />
			<asp:Parameter Name="original_user4" Type="String" />
			<asp:Parameter Name="original_user5" Type="String" />
			<asp:Parameter Name="original_user5" Type="String" />
			<asp:Parameter Name="original_loopback_source_ip" Type="String" />
			<asp:Parameter Name="original_loopback_source_ip" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="trap_id" Type="String" />
			<asp:Parameter Name="timestamp" Type="String" />
			<asp:Parameter Name="source_ip" Type="String" />
			<asp:Parameter Name="community_string" Type="String" />
			<asp:Parameter Name="snmp_version" Type="String" />
			<asp:Parameter Name="enterprise_oid" Type="String" />
			<asp:Parameter Name="generic_trap_type" Type="Int32" />
			<asp:Parameter Name="specific_trap_code" Type="Int32" />
			<asp:Parameter Name="agent_address" Type="String" />
			<asp:Parameter Name="lat" Type="String" />
			<asp:Parameter Name="long" Type="String" />
			<asp:Parameter Name="ctsfulllocation" Type="String" />
			<asp:Parameter Name="vpnid" Type="String" />
			<asp:Parameter Name="user1" Type="String" />
			<asp:Parameter Name="user2" Type="String" />
			<asp:Parameter Name="user3" Type="String" />
			<asp:Parameter Name="user4" Type="String" />
			<asp:Parameter Name="user5" Type="String" />
			<asp:Parameter Name="loopback_source_ip" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="trap_id" Type="String" />
			<asp:Parameter Name="timestamp" Type="String" />
			<asp:Parameter Name="source_ip" Type="String" />
			<asp:Parameter Name="community_string" Type="String" />
			<asp:Parameter Name="snmp_version" Type="String" />
			<asp:Parameter Name="enterprise_oid" Type="String" />
			<asp:Parameter Name="generic_trap_type" Type="Int32" />
			<asp:Parameter Name="specific_trap_code" Type="Int32" />
			<asp:Parameter Name="agent_address" Type="String" />
			<asp:Parameter Name="lat" Type="String" />
			<asp:Parameter Name="long" Type="String" />
			<asp:Parameter Name="ctsfulllocation" Type="String" />
			<asp:Parameter Name="vpnid" Type="String" />
			<asp:Parameter Name="user1" Type="String" />
			<asp:Parameter Name="user2" Type="String" />
			<asp:Parameter Name="user3" Type="String" />
			<asp:Parameter Name="user4" Type="String" />
			<asp:Parameter Name="user5" Type="String" />
			<asp:Parameter Name="loopback_source_ip" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_trap_id" Type="String" />
			<asp:Parameter Name="original_trap_id" Type="String" />
			<asp:Parameter Name="original_timestamp" Type="String" />
			<asp:Parameter Name="original_timestamp" Type="String" />
			<asp:Parameter Name="original_source_ip" Type="String" />
			<asp:Parameter Name="original_source_ip" Type="String" />
			<asp:Parameter Name="original_community_string" Type="String" />
			<asp:Parameter Name="original_community_string" Type="String" />
			<asp:Parameter Name="original_snmp_version" Type="String" />
			<asp:Parameter Name="original_snmp_version" Type="String" />
			<asp:Parameter Name="original_enterprise_oid" Type="String" />
			<asp:Parameter Name="original_enterprise_oid" Type="String" />
			<asp:Parameter Name="original_generic_trap_type" Type="Int32" />
			<asp:Parameter Name="original_generic_trap_type" Type="Int32" />
			<asp:Parameter Name="original_specific_trap_code" Type="Int32" />
			<asp:Parameter Name="original_specific_trap_code" Type="Int32" />
			<asp:Parameter Name="original_agent_address" Type="String" />
			<asp:Parameter Name="original_agent_address" Type="String" />
			<asp:Parameter Name="original_lat" Type="String" />
			<asp:Parameter Name="original_lat" Type="String" />
			<asp:Parameter Name="original_long" Type="String" />
			<asp:Parameter Name="original_long" Type="String" />
			<asp:Parameter Name="original_ctsfulllocation" Type="String" />
			<asp:Parameter Name="original_ctsfulllocation" Type="String" />
			<asp:Parameter Name="original_vpnid" Type="String" />
			<asp:Parameter Name="original_vpnid" Type="String" />
			<asp:Parameter Name="original_user1" Type="String" />
			<asp:Parameter Name="original_user1" Type="String" />
			<asp:Parameter Name="original_user2" Type="String" />
			<asp:Parameter Name="original_user2" Type="String" />
			<asp:Parameter Name="original_user3" Type="String" />
			<asp:Parameter Name="original_user3" Type="String" />
			<asp:Parameter Name="original_user4" Type="String" />
			<asp:Parameter Name="original_user4" Type="String" />
			<asp:Parameter Name="original_user5" Type="String" />
			<asp:Parameter Name="original_user5" Type="String" />
			<asp:Parameter Name="original_loopback_source_ip" Type="String" />
			<asp:Parameter Name="original_loopback_source_ip" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" InsertVisible="False">
			</asp:BoundField>
			<asp:BoundField DataField="trap_id" HeaderText="trap_id" SortExpression="trap_id">
			</asp:BoundField>
			<asp:BoundField DataField="timestamp" HeaderText="timestamp" SortExpression="timestamp">
			</asp:BoundField>
			<asp:BoundField DataField="source_ip" HeaderText="source_ip" SortExpression="source_ip">
			</asp:BoundField>
			<asp:BoundField DataField="community_string" HeaderText="community_string" SortExpression="community_string">
			</asp:BoundField>
			<asp:BoundField DataField="snmp_version" HeaderText="snmp_version" SortExpression="snmp_version">
			</asp:BoundField>
			<asp:BoundField DataField="enterprise_oid" HeaderText="enterprise_oid" SortExpression="enterprise_oid">
			</asp:BoundField>
			<asp:BoundField DataField="generic_trap_type" HeaderText="generic_trap_type" SortExpression="generic_trap_type">
			</asp:BoundField>
			<asp:BoundField DataField="specific_trap_code" HeaderText="specific_trap_code" SortExpression="specific_trap_code">
			</asp:BoundField>
			<asp:BoundField DataField="agent_address" HeaderText="agent_address" SortExpression="agent_address">
			</asp:BoundField>
			<asp:BoundField DataField="lat" HeaderText="lat" SortExpression="lat">
			</asp:BoundField>
			<asp:BoundField DataField="long" HeaderText="long" SortExpression="long">
			</asp:BoundField>
			<asp:BoundField DataField="ctsfulllocation" HeaderText="ctsfulllocation" SortExpression="ctsfulllocation">
			</asp:BoundField>
			<asp:BoundField DataField="vpnid" HeaderText="vpnid" SortExpression="vpnid">
			</asp:BoundField>
			<asp:BoundField DataField="user1" HeaderText="user1" SortExpression="user1">
			</asp:BoundField>
			<asp:BoundField DataField="user2" HeaderText="user2" SortExpression="user2">
			</asp:BoundField>
			<asp:BoundField DataField="user3" HeaderText="user3" SortExpression="user3">
			</asp:BoundField>
			<asp:BoundField DataField="user4" HeaderText="user4" SortExpression="user4">
			</asp:BoundField>
			<asp:BoundField DataField="user5" HeaderText="user5" SortExpression="user5">
			</asp:BoundField>
			<asp:BoundField DataField="loopback_source_ip" HeaderText="loopback_source_ip" SortExpression="loopback_source_ip">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="index.aspx">Return to SNMP Console</a>
</div>
</body>
</html>