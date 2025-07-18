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
		<asp:Image id="Image1" runat="server" ImageUrl="./cocky547.png" />
		<br><br><br><br>COCKY ENTERPRISES<br>INSERT A NEW STORE<br>
		<div class="auto-style1">
		</div>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Data Source=cockysql.database.windows.net;Initial Catalog=ce;User ID=cockysa;Password=*Columbia1" DeleteCommand="DELETE FROM [stores] WHERE [id] = @original_id AND (([description] = @original_description) OR ([description] IS NULL AND @original_description IS NULL)) AND (([regionid] = @original_regionid) OR ([regionid] IS NULL AND @original_regionid IS NULL)) AND (([bu] = @original_bu) OR ([bu] IS NULL AND @original_bu IS NULL)) AND (([address1] = @original_address1) OR ([address1] IS NULL AND @original_address1 IS NULL)) AND (([address2] = @original_address2) OR ([address2] IS NULL AND @original_address2 IS NULL)) AND (([city] = @original_city) OR ([city] IS NULL AND @original_city IS NULL)) AND (([state] = @original_state) OR ([state] IS NULL AND @original_state IS NULL)) AND (([zipcode] = @original_zipcode) OR ([zipcode] IS NULL AND @original_zipcode IS NULL))" InsertCommand="INSERT INTO [stores] ([description], [regionid], [bu], [address1], [address2], [city], [state], [zipcode]) VALUES (@description, @regionid, @bu, @address1, @address2, @city, @state, @zipcode)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [stores]" UpdateCommand="UPDATE [stores] SET [description] = @description, [regionid] = @regionid, [bu] = @bu, [address1] = @address1, [address2] = @address2, [city] = @city, [state] = @state, [zipcode] = @zipcode WHERE [id] = @original_id AND (([description] = @original_description) OR ([description] IS NULL AND @original_description IS NULL)) AND (([regionid] = @original_regionid) OR ([regionid] IS NULL AND @original_regionid IS NULL)) AND (([bu] = @original_bu) OR ([bu] IS NULL AND @original_bu IS NULL)) AND (([address1] = @original_address1) OR ([address1] IS NULL AND @original_address1 IS NULL)) AND (([address2] = @original_address2) OR ([address2] IS NULL AND @original_address2 IS NULL)) AND (([city] = @original_city) OR ([city] IS NULL AND @original_city IS NULL)) AND (([state] = @original_state) OR ([state] IS NULL AND @original_state IS NULL)) AND (([zipcode] = @original_zipcode) OR ([zipcode] IS NULL AND @original_zipcode IS NULL))" ConflictDetection="CompareAllValues">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_regionid" Type="Int32" />
			<asp:Parameter Name="original_bu" Type="Int32" />
			<asp:Parameter Name="original_address1" Type="String" />
			<asp:Parameter Name="original_address2" Type="String" />
			<asp:Parameter Name="original_city" Type="String" />
			<asp:Parameter Name="original_state" Type="String" />
			<asp:Parameter Name="original_zipcode" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="regionid" Type="Int32" />
			<asp:Parameter Name="bu" Type="Int32" />
			<asp:Parameter Name="address1" Type="String" />
			<asp:Parameter Name="address2" Type="String" />
			<asp:Parameter Name="city" Type="String" />
			<asp:Parameter Name="state" Type="String" />
			<asp:Parameter Name="zipcode" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="description" Type="String" />
			<asp:Parameter Name="regionid" Type="Int32" />
			<asp:Parameter Name="bu" Type="Int32" />
			<asp:Parameter Name="address1" Type="String" />
			<asp:Parameter Name="address2" Type="String" />
			<asp:Parameter Name="city" Type="String" />
			<asp:Parameter Name="state" Type="String" />
			<asp:Parameter Name="zipcode" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_description" Type="String" />
			<asp:Parameter Name="original_regionid" Type="Int32" />
			<asp:Parameter Name="original_bu" Type="Int32" />
			<asp:Parameter Name="original_address1" Type="String" />
			<asp:Parameter Name="original_address2" Type="String" />
			<asp:Parameter Name="original_city" Type="String" />
			<asp:Parameter Name="original_state" Type="String" />
			<asp:Parameter Name="original_zipcode" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True" Font-Size="10pt">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
			</asp:BoundField>
			<asp:BoundField DataField="regionid" HeaderText="regionid" SortExpression="regionid">
			</asp:BoundField>
			<asp:BoundField DataField="bu" HeaderText="bu" SortExpression="bu">
			</asp:BoundField>
			<asp:BoundField DataField="address1" HeaderText="address1" SortExpression="address1">
			</asp:BoundField>
			<asp:BoundField DataField="address2" HeaderText="address2" SortExpression="address2">
			</asp:BoundField>
			<asp:BoundField DataField="city" HeaderText="city" SortExpression="city">
			</asp:BoundField>
			<asp:BoundField DataField="state" HeaderText="state" SortExpression="state">
			</asp:BoundField>
			<asp:BoundField DataField="zipcode" HeaderText="zipcode" SortExpression="zipcode">
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