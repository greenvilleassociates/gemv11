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
		<br><br>COCKY ENTERPRISES <br>APP MAINTENANCE<br><br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=GEMPROD" DeleteCommand="DELETE FROM [gapps] WHERE [id] = ? AND (([appid] = ?) OR ([appid] IS NULL AND ? IS NULL)) AND (([appdescription] = ?) OR ([appdescription] IS NULL AND ? IS NULL)) AND (([apptype] = ?) OR ([apptype] IS NULL AND ? IS NULL)) AND (([appregion] = ?) OR ([appregion] IS NULL AND ? IS NULL)) AND (([dbmstype] = ?) OR ([dbmstype] IS NULL AND ? IS NULL)) AND (([dbmsvendor] = ?) OR ([dbmsvendor] IS NULL AND ? IS NULL)) AND (([dbmstopology] = ?) OR ([dbmstopology] IS NULL AND ? IS NULL)) AND (([gridid] = ?) OR ([gridid] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gapps] ([appid], [appdescription], [apptype], [appregion], [dbmstype], [dbmsvendor], [dbmstopology], [gridid]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gapps]" UpdateCommand="UPDATE [gapps] SET [appid] = ?, [appdescription] = ?, [apptype] = ?, [appregion] = ?, [dbmstype] = ?, [dbmsvendor] = ?, [dbmstopology] = ?, [gridid] = ? WHERE [id] = ? AND (([appid] = ?) OR ([appid] IS NULL AND ? IS NULL)) AND (([appdescription] = ?) OR ([appdescription] IS NULL AND ? IS NULL)) AND (([apptype] = ?) OR ([apptype] IS NULL AND ? IS NULL)) AND (([appregion] = ?) OR ([appregion] IS NULL AND ? IS NULL)) AND (([dbmstype] = ?) OR ([dbmstype] IS NULL AND ? IS NULL)) AND (([dbmsvendor] = ?) OR ([dbmsvendor] IS NULL AND ? IS NULL)) AND (([dbmstopology] = ?) OR ([dbmstopology] IS NULL AND ? IS NULL)) AND (([gridid] = ?) OR ([gridid] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_appid" Type="String" />
			<asp:Parameter Name="original_appid" Type="String" />
			<asp:Parameter Name="original_appdescription" Type="String" />
			<asp:Parameter Name="original_appdescription" Type="String" />
			<asp:Parameter Name="original_apptype" Type="Int32" />
			<asp:Parameter Name="original_apptype" Type="Int32" />
			<asp:Parameter Name="original_appregion" Type="Int32" />
			<asp:Parameter Name="original_appregion" Type="Int32" />
			<asp:Parameter Name="original_dbmstype" Type="String" />
			<asp:Parameter Name="original_dbmstype" Type="String" />
			<asp:Parameter Name="original_dbmsvendor" Type="String" />
			<asp:Parameter Name="original_dbmsvendor" Type="String" />
			<asp:Parameter Name="original_dbmstopology" Type="String" />
			<asp:Parameter Name="original_dbmstopology" Type="String" />
			<asp:Parameter Name="original_gridid" Type="Int32" />
			<asp:Parameter Name="original_gridid" Type="Int32" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="appid" Type="String" />
			<asp:Parameter Name="appdescription" Type="String" />
			<asp:Parameter Name="apptype" Type="Int32" />
			<asp:Parameter Name="appregion" Type="Int32" />
			<asp:Parameter Name="dbmstype" Type="String" />
			<asp:Parameter Name="dbmsvendor" Type="String" />
			<asp:Parameter Name="dbmstopology" Type="String" />
			<asp:Parameter Name="gridid" Type="Int32" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="appid" Type="String" />
			<asp:Parameter Name="appdescription" Type="String" />
			<asp:Parameter Name="apptype" Type="Int32" />
			<asp:Parameter Name="appregion" Type="Int32" />
			<asp:Parameter Name="dbmstype" Type="String" />
			<asp:Parameter Name="dbmsvendor" Type="String" />
			<asp:Parameter Name="dbmstopology" Type="String" />
			<asp:Parameter Name="gridid" Type="Int32" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_appid" Type="String" />
			<asp:Parameter Name="original_appid" Type="String" />
			<asp:Parameter Name="original_appdescription" Type="String" />
			<asp:Parameter Name="original_appdescription" Type="String" />
			<asp:Parameter Name="original_apptype" Type="Int32" />
			<asp:Parameter Name="original_apptype" Type="Int32" />
			<asp:Parameter Name="original_appregion" Type="Int32" />
			<asp:Parameter Name="original_appregion" Type="Int32" />
			<asp:Parameter Name="original_dbmstype" Type="String" />
			<asp:Parameter Name="original_dbmstype" Type="String" />
			<asp:Parameter Name="original_dbmsvendor" Type="String" />
			<asp:Parameter Name="original_dbmsvendor" Type="String" />
			<asp:Parameter Name="original_dbmstopology" Type="String" />
			<asp:Parameter Name="original_dbmstopology" Type="String" />
			<asp:Parameter Name="original_gridid" Type="Int32" />
			<asp:Parameter Name="original_gridid" Type="Int32" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="appid" HeaderText="appid" SortExpression="appid">
			</asp:BoundField>
			<asp:BoundField DataField="appdescription" HeaderText="appdescription" SortExpression="appdescription">
			</asp:BoundField>
			<asp:BoundField DataField="apptype" HeaderText="apptype" SortExpression="apptype">
			</asp:BoundField>
			<asp:BoundField DataField="appregion" HeaderText="appregion" SortExpression="appregion">
			</asp:BoundField>
			<asp:BoundField DataField="dbmstype" HeaderText="dbmstype" SortExpression="dbmstype">
			</asp:BoundField>
			<asp:BoundField DataField="dbmsvendor" HeaderText="dbmsvendor" SortExpression="dbmsvendor">
			</asp:BoundField>
			<asp:BoundField DataField="dbmstopology" HeaderText="dbmstopology" SortExpression="dbmstopology">
			</asp:BoundField>
			<asp:BoundField DataField="gridid" HeaderText="gridid" SortExpression="gridid">
			</asp:BoundField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="manageemployees.aspx">Return to Employee Console</a>
</div>
</body>
</html>