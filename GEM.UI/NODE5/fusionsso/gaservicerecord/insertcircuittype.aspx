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
		<br><br>COCKY ENTERPRISES <br>CIRCUIT TYPE MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gcircuittype] WHERE [id] = ? AND (([circuittypeid] = ?) OR ([circuittypeid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gcircuittype] ([circuittypeid], [description]) VALUES (?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gcircuittype]" UpdateCommand="UPDATE [gcircuittype] SET [circuittypeid] = ?, [description] = ? WHERE [id] = ? AND (([circuittypeid] = ?) OR ([circuittypeid] IS NULL AND ? IS NULL)) AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_circuittypeid" Type="Int32" />
			<asp:Parameter Name="original_circuittypeid" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="circuittypeid" Type="Int32" />
			<asp:Parameter Name="description" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="circuittypeid" Type="Int32" />
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_circuittypeid" Type="Int32" />
			<asp:Parameter Name="original_circuittypeid" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_description" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="circuittypeid" HeaderText="circuittypeid" SortExpression="circuittypeid">
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
<a href="managecircuittype.aspx">Return to Circuit Type Manager</a>
</div>
</body>
</html>