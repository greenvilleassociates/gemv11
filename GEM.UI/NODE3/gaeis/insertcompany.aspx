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
		<asp:Image id="Image1" runat="server" ImageUrl="./cocky547.png" Height="174px" Width="248px" />
		<br><br><br><br>COCKY ENTERPRISES<br>INSERT A NEW COMPANY<br>
		<div class="auto-style1">
		</div>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Data Source=cockysql.database.windows.net;Initial Catalog=ce;User ID=cockysa;Password=*Columbia1" DeleteCommand="DELETE FROM [company] WHERE [id] = @original_id AND (([companyname] = @original_companyname) OR ([companyname] IS NULL AND @original_companyname IS NULL)) AND (([dynamicsid] = @original_dynamicsid) OR ([dynamicsid] IS NULL AND @original_dynamicsid IS NULL)) AND (([ncralohaid] = @original_ncralohaid) OR ([ncralohaid] IS NULL AND @original_ncralohaid IS NULL)) AND (([oracleid] = @original_oracleid) OR ([oracleid] IS NULL AND @original_oracleid IS NULL))" InsertCommand="INSERT INTO [company] ([companyname], [dynamicsid], [ncralohaid], [oracleid]) VALUES (@companyname, @dynamicsid, @ncralohaid, @oracleid)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [company]" UpdateCommand="UPDATE [company] SET [companyname] = @companyname, [dynamicsid] = @dynamicsid, [ncralohaid] = @ncralohaid, [oracleid] = @oracleid WHERE [id] = @original_id AND (([companyname] = @original_companyname) OR ([companyname] IS NULL AND @original_companyname IS NULL)) AND (([dynamicsid] = @original_dynamicsid) OR ([dynamicsid] IS NULL AND @original_dynamicsid IS NULL)) AND (([ncralohaid] = @original_ncralohaid) OR ([ncralohaid] IS NULL AND @original_ncralohaid IS NULL)) AND (([oracleid] = @original_oracleid) OR ([oracleid] IS NULL AND @original_oracleid IS NULL))" ConflictDetection="CompareAllValues">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_companyname" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_ncralohaid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="companyname" Type="String" />
			<asp:Parameter Name="dynamicsid" Type="String" />
			<asp:Parameter Name="ncralohaid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="companyname" Type="String" />
			<asp:Parameter Name="dynamicsid" Type="String" />
			<asp:Parameter Name="ncralohaid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_companyname" Type="String" />
			<asp:Parameter Name="original_dynamicsid" Type="String" />
			<asp:Parameter Name="original_ncralohaid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True" Font-Size="10pt">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="companyname" HeaderText="companyname" SortExpression="companyname">
			</asp:BoundField>
			<asp:BoundField DataField="dynamicsid" HeaderText="dynamicsid" SortExpression="dynamicsid">
			</asp:BoundField>
			<asp:BoundField DataField="ncralohaid" HeaderText="ncralohaid" SortExpression="ncralohaid">
			</asp:BoundField>
			<asp:BoundField DataField="oracleid" HeaderText="oracleid" SortExpression="oracleid">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managestores.aspx">Return to Store Console</a>

</body>
</html>