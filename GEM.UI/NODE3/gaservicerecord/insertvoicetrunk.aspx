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
		<br><br>COCKY ENTERPRISES <br>VOICE TRUNK MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gvoicetrunks] WHERE [id] = ? AND (([trunkid] = ?) OR ([trunkid] IS NULL AND ? IS NULL)) AND (([trunktypeid] = ?) OR ([trunktypeid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gvoicetrunks] ([trunkid], [trunktypeid], [description]) VALUES (?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gvoicetrunks]" UpdateCommand="UPDATE [gvoicetrunks] SET [trunkid] = ?, [trunktypeid] = ?, [description] = ? WHERE [id] = ? AND (([trunkid] = ?) OR ([trunkid] IS NULL AND ? IS NULL)) AND (([trunktypeid] = ?) OR ([trunktypeid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_trunkid" Type="String" />
			<asp:Parameter Name="original_trunkid" Type="String" />
			<asp:Parameter Name="original_trunktypeid" Type="Int32" />
			<asp:Parameter Name="original_trunktypeid" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="trunkid" Type="String" />
			<asp:Parameter Name="trunktypeid" Type="Int32" />
			<asp:Parameter Name="description" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="trunkid" Type="String" />
			<asp:Parameter Name="trunktypeid" Type="Int32" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_trunkid" Type="String" />
			<asp:Parameter Name="original_trunkid" Type="String" />
			<asp:Parameter Name="original_trunktypeid" Type="Int32" />
			<asp:Parameter Name="original_trunktypeid" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="trunkid" HeaderText="trunkid" SortExpression="trunkid">
			</asp:BoundField>
			<asp:BoundField DataField="trunktypeid" HeaderText="trunktypeid" SortExpression="trunktypeid">
			</asp:BoundField>
			<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managevoicetrunks.aspx">Return to Voice Trunk Manager</a>
</div>
</body>
</html>