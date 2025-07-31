<html>
<head><title>CockyMoviesManager</title>
<style type="text/css">
.auto-style1 {
	text-align: center;
}
</style>
</head>
<body>
<form id="form1" runat="server">
	<div align="center">
	<div class="auto-style1">
		<br>
		<asp:Image id="Image1" runat="server" ImageUrl="./cocky590.png" Height="174px" Width="248px" />
		<br><br><br><br>COCKY ENTERPRISES<br>INSERT A NEW WHOLESALE ACCOUNT<br>
		<div class="auto-style1">
		</div>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEMPROD;uid=gridsa;pwd=test12345" DeleteCommand="DELETE FROM [gwholesalers] WHERE [id] = ? AND (([wholesalename] = ?) OR ([wholesalename] IS NULL AND ? IS NULL)) AND (([companyid] = ?) OR ([companyid] IS NULL AND ? IS NULL)) AND (([dynamicsid] = ?) OR ([dynamicsid] IS NULL AND ? IS NULL)) AND (([oracleid] = ?) OR ([oracleid] IS NULL AND ? IS NULL)) AND (([alohaid] = ?) OR ([alohaid] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gwholesalers] ([wholesalename], [companyid], [dynamicsid], [oracleid], [alohaid]) VALUES (?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gwholesalers]" UpdateCommand="UPDATE [gwholesalers] SET [wholesalename] = ?, [companyid] = ?, [dynamicsid] = ?, [oracleid] = ?, [alohaid] = ? WHERE [id] = ? AND (([wholesalename] = ?) OR ([wholesalename] IS NULL AND ? IS NULL)) AND (([companyid] = ?) OR ([companyid] IS NULL AND ? IS NULL)) AND (([dynamicsid] = ?) OR ([dynamicsid] IS NULL AND ? IS NULL)) AND (([oracleid] = ?) OR ([oracleid] IS NULL AND ? IS NULL)) AND (([alohaid] = ?) OR ([alohaid] IS NULL AND ? IS NULL))" ConflictDetection="CompareAllValues">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int64" />
			<asp:Parameter Name="original_wholesalename" Type="String" />
			<asp:Parameter Name="original_wholesalename" Type="String" />
			<asp:Parameter Name="original_companyid" Type="Int32" />
			<asp:Parameter Name="original_companyid" Type="Int32" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_alohaid" Type="String" />
			<asp:Parameter Name="original_alohaid" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="wholesalename" Type="String" />
			<asp:Parameter Name="companyid" Type="Int32" />
			<asp:Parameter Name="dynamicsid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="alohaid" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="wholesalename" Type="String" />
			<asp:Parameter Name="companyid" Type="Int32" />
			<asp:Parameter Name="dynamicsid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="alohaid" Type="String" />
			<asp:Parameter Name="original_id" Type="Int64" />
			<asp:Parameter Name="original_wholesalename" Type="String" />
			<asp:Parameter Name="original_wholesalename" Type="String" />
			<asp:Parameter Name="original_companyid" Type="Int32" />
			<asp:Parameter Name="original_companyid" Type="Int32" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_alohaid" Type="String" />
			<asp:Parameter Name="original_alohaid" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True" Font-Size="10pt">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="wholesalename" HeaderText="wholesalename" SortExpression="wholesalename">
			</asp:BoundField>
			<asp:BoundField DataField="companyid" HeaderText="companyid" SortExpression="companyid">
			</asp:BoundField>
			<asp:BoundField DataField="dynamicsid" HeaderText="dynamicsid" SortExpression="dynamicsid">
			</asp:BoundField>
			<asp:BoundField DataField="oracleid" HeaderText="oracleid" SortExpression="oracleid">
			</asp:BoundField>
			<asp:BoundField DataField="alohaid" HeaderText="alohaid" SortExpression="alohaid">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="index.aspx">Return to EIS Console</a>

</body>
</html>