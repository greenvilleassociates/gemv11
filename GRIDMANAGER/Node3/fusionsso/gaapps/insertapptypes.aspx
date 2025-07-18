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
		<asp:Image id="Image1" runat="server" ImageUrl="./cocky590.png" Height="97px" Width="103px" />
		<br><br><br><br>COCKY ENTERPRISES APP MANAGER<br>APP TYPE MAINTENANCE 
		SCREEN<br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gapptype] WHERE [id] = ? AND (([apptype] = ?) OR ([apptype] IS NULL AND ? IS NULL)) AND (([apptypedescription] = ?) OR ([apptypedescription] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gapptype] ([apptype], [apptypedescription]) VALUES (?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gapptype]" UpdateCommand="UPDATE [gapptype] SET [apptype] = ?, [apptypedescription] = ? WHERE [id] = ? AND (([apptype] = ?) OR ([apptype] IS NULL AND ? IS NULL)) AND (([apptypedescription] = ?) OR ([apptypedescription] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_apptype" Type="Int32" />
			<asp:Parameter Name="original_apptype" Type="Int32" />
			<asp:Parameter Name="original_apptypedescription" Type="String" />
			<asp:Parameter Name="original_apptypedescription" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="apptype" Type="Int32" />
			<asp:Parameter Name="apptypedescription" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="apptype" Type="Int32" />
			<asp:Parameter Name="apptypedescription" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_apptype" Type="Int32" />
			<asp:Parameter Name="original_apptype" Type="Int32" />
			<asp:Parameter Name="original_apptypedescription" Type="String" />
			<asp:Parameter Name="original_apptypedescription" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="apptype" HeaderText="apptype" SortExpression="apptype">
			</asp:BoundField>
			<asp:BoundField DataField="apptypedescription" HeaderText="apptypedescription" SortExpression="apptypedescription">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="manageapps.aspx">Return to App Console</a>
</div>
</body>
</html>