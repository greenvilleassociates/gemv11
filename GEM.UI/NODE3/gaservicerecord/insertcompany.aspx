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
		<br><br>COCKY ENTERPRISES <br>COMPANY MANAGER<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gcustomer] WHERE [id] = ? AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([address1] = ?) OR ([address1] IS NULL AND ? IS NULL)) AND (([address2] = ?) OR ([address2] IS NULL AND ? IS NULL)) AND (([city] = ?) OR ([city] IS NULL AND ? IS NULL)) AND (([state] = ?) OR ([state] IS NULL AND ? IS NULL)) AND (([zip] = ?) OR ([zip] IS NULL AND ? IS NULL)) AND (([phone] = ?) OR ([phone] IS NULL AND ? IS NULL)) AND (([inventoryid] = ?) OR ([inventoryid] IS NULL AND ? IS NULL)) AND (([customerid] = ?) OR ([customerid] IS NULL AND ? IS NULL)) AND (([oracleid] = ?) OR ([oracleid] IS NULL AND ? IS NULL)) AND (([dynamicsid] = ?) OR ([dynamicsid] IS NULL AND ? IS NULL)) AND (([alohaid] = ?) OR ([alohaid] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gcustomer] ([description], [address1], [address2], [city], [state], [zip], [phone], [inventoryid], [customerid], [oracleid], [dynamicsid], [alohaid]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gcustomer]" UpdateCommand="UPDATE [gcustomer] SET [description] = ?, [address1] = ?, [address2] = ?, [city] = ?, [state] = ?, [zip] = ?, [phone] = ?, [inventoryid] = ?, [customerid] = ?, [oracleid] = ?, [dynamicsid] = ?, [alohaid] = ? WHERE [id] = ? AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([address1] = ?) OR ([address1] IS NULL AND ? IS NULL)) AND (([address2] = ?) OR ([address2] IS NULL AND ? IS NULL)) AND (([city] = ?) OR ([city] IS NULL AND ? IS NULL)) AND (([state] = ?) OR ([state] IS NULL AND ? IS NULL)) AND (([zip] = ?) OR ([zip] IS NULL AND ? IS NULL)) AND (([phone] = ?) OR ([phone] IS NULL AND ? IS NULL)) AND (([inventoryid] = ?) OR ([inventoryid] IS NULL AND ? IS NULL)) AND (([customerid] = ?) OR ([customerid] IS NULL AND ? IS NULL)) AND (([oracleid] = ?) OR ([oracleid] IS NULL AND ? IS NULL)) AND (([dynamicsid] = ?) OR ([dynamicsid] IS NULL AND ? IS NULL)) AND (([alohaid] = ?) OR ([alohaid] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_address1" Type="String" />
			<asp:Parameter Name="original_address1" Type="String" />
			<asp:Parameter Name="original_address2" Type="String" />
			<asp:Parameter Name="original_address2" Type="String" />
			<asp:Parameter Name="original_city" Type="String" />
			<asp:Parameter Name="original_city" Type="String" />
			<asp:Parameter Name="original_state" Type="String" />
			<asp:Parameter Name="original_state" Type="String" />
			<asp:Parameter Name="original_zip" Type="String" />
			<asp:Parameter Name="original_zip" Type="String" />
			<asp:Parameter Name="original_phone" Type="String" />
			<asp:Parameter Name="original_phone" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_customerid" Type="String" />
			<asp:Parameter Name="original_customerid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_alohaid" Type="String" />
			<asp:Parameter Name="original_alohaid" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="address1" Type="String" />
			<asp:Parameter Name="address2" Type="String" />
			<asp:Parameter Name="city" Type="String" />
			<asp:Parameter Name="state" Type="String" />
			<asp:Parameter Name="zip" Type="String" />
			<asp:Parameter Name="phone" Type="String" />
			<asp:Parameter Name="inventoryid" Type="String" />
			<asp:Parameter Name="customerid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="dynamicsid" Type="String" />
			<asp:Parameter Name="alohaid" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="address1" Type="String" />
			<asp:Parameter Name="address2" Type="String" />
			<asp:Parameter Name="city" Type="String" />
			<asp:Parameter Name="state" Type="String" />
			<asp:Parameter Name="zip" Type="String" />
			<asp:Parameter Name="phone" Type="String" />
			<asp:Parameter Name="inventoryid" Type="String" />
			<asp:Parameter Name="customerid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="dynamicsid" Type="String" />
			<asp:Parameter Name="alohaid" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_address1" Type="String" />
			<asp:Parameter Name="original_address1" Type="String" />
			<asp:Parameter Name="original_address2" Type="String" />
			<asp:Parameter Name="original_address2" Type="String" />
			<asp:Parameter Name="original_city" Type="String" />
			<asp:Parameter Name="original_city" Type="String" />
			<asp:Parameter Name="original_state" Type="String" />
			<asp:Parameter Name="original_state" Type="String" />
			<asp:Parameter Name="original_zip" Type="String" />
			<asp:Parameter Name="original_zip" Type="String" />
			<asp:Parameter Name="original_phone" Type="String" />
			<asp:Parameter Name="original_phone" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_inventoryid" Type="String" />
			<asp:Parameter Name="original_customerid" Type="String" />
			<asp:Parameter Name="original_customerid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_alohaid" Type="String" />
			<asp:Parameter Name="original_alohaid" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
			</asp:BoundField>
			<asp:BoundField DataField="address1" HeaderText="address1" SortExpression="address1">
			</asp:BoundField>
			<asp:BoundField DataField="address2" HeaderText="address2" SortExpression="address2">
			</asp:BoundField>
			<asp:BoundField DataField="city" HeaderText="city" SortExpression="city">
			</asp:BoundField>
			<asp:BoundField DataField="state" HeaderText="state" SortExpression="state">
			</asp:BoundField>
			<asp:BoundField DataField="zip" HeaderText="zip" SortExpression="zip">
			</asp:BoundField>
			<asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone">
			</asp:BoundField>
			<asp:BoundField DataField="inventoryid" HeaderText="inventoryid" SortExpression="inventoryid">
			</asp:BoundField>
			<asp:BoundField DataField="customerid" HeaderText="customerid" SortExpression="customerid">
			</asp:BoundField>
			<asp:BoundField DataField="oracleid" HeaderText="oracleid" SortExpression="oracleid">
			</asp:BoundField>
			<asp:BoundField DataField="dynamicsid" HeaderText="dynamicsid" SortExpression="dynamicsid">
			</asp:BoundField>
			<asp:BoundField DataField="alohaid" HeaderText="alohaid" SortExpression="alohaid">
			</asp:BoundField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managecustomers.aspx">Return to Customer Manager</a>
</div>
</body>
</html>