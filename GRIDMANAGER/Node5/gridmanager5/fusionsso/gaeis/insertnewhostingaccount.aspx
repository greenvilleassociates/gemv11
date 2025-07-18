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
		<br><br><br><br>COCKY ENTERPRISES<br>INSERT A NEW ACCOUNT<br>
		<div class="auto-style1">
		</div>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEMPROD;uid=gridsa;pwd=test12345" DeleteCommand="DELETE FROM [gaccounts] WHERE [id] = ? AND (([accountname] = ?) OR ([accountname] IS NULL AND ? IS NULL)) AND (([companyid] = ?) OR ([companyid] IS NULL AND ? IS NULL)) AND (([wholesalevendorid] = ?) OR ([wholesalevendorid] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gaccounts] ([accountname], [companyid], [wholesalevendorid]) VALUES (?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gaccounts]" UpdateCommand="UPDATE [gaccounts] SET [accountname] = ?, [companyid] = ?, [wholesalevendorid] = ? WHERE [id] = ? AND (([accountname] = ?) OR ([accountname] IS NULL AND ? IS NULL)) AND (([companyid] = ?) OR ([companyid] IS NULL AND ? IS NULL)) AND (([wholesalevendorid] = ?) OR ([wholesalevendorid] IS NULL AND ? IS NULL))" ConflictDetection="CompareAllValues">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int64" />
			<asp:Parameter Name="original_accountname" Type="String" />
			<asp:Parameter Name="original_accountname" Type="String" />
			<asp:Parameter Name="original_companyid" Type="Int32" />
			<asp:Parameter Name="original_companyid" Type="Int32" />
			<asp:Parameter Name="original_wholesalevendorid" Type="Int32" />
			<asp:Parameter Name="original_wholesalevendorid" Type="Int32" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="accountname" Type="String" />
			<asp:Parameter Name="companyid" Type="Int32" />
			<asp:Parameter Name="wholesalevendorid" Type="Int32" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="accountname" Type="String" />
			<asp:Parameter Name="companyid" Type="Int32" />
			<asp:Parameter Name="wholesalevendorid" Type="Int32" />
			<asp:Parameter Name="original_id" Type="Int64" />
			<asp:Parameter Name="original_accountname" Type="String" />
			<asp:Parameter Name="original_accountname" Type="String" />
			<asp:Parameter Name="original_companyid" Type="Int32" />
			<asp:Parameter Name="original_companyid" Type="Int32" />
			<asp:Parameter Name="original_wholesalevendorid" Type="Int32" />
			<asp:Parameter Name="original_wholesalevendorid" Type="Int32" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True" Font-Size="10pt">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="accountname" HeaderText="accountname" SortExpression="accountname">
			</asp:BoundField>
			<asp:BoundField DataField="companyid" HeaderText="companyid" SortExpression="companyid">
			</asp:BoundField>
			<asp:BoundField DataField="wholesalevendorid" HeaderText="wholesalevendorid" SortExpression="wholesalevendorid">
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