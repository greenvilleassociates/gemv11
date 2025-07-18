<html>
<head><title>CockyMoviesManager</title>
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
		<asp:Image id="Image1" runat="server" ImageUrl="./cocky547.png" />
		<br><br><br><br>COCKY ENTERPRISES USER MANAGER
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Server=tcp:cockysql.database.windows.net,1433;Initial Catalog=ce;Persist Security Info=False;User ID=cockysa;Password=*Columbia1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" DeleteCommand="DELETE FROM [users] WHERE [id] = @original_id AND (([firstname] = @original_firstname) OR ([firstname] IS NULL AND @original_firstname IS NULL)) AND (([lastname] = @original_lastname) OR ([lastname] IS NULL AND @original_lastname IS NULL)) AND (([username] = @original_username) OR ([username] IS NULL AND @original_username IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND (([employee] = @original_employee) OR ([employee] IS NULL AND @original_employee IS NULL)) AND (([employeeid] = @original_employeeid) OR ([employeeid] IS NULL AND @original_employeeid IS NULL)) AND (([microsoftid] = @original_microsoftid) OR ([microsoftid] IS NULL AND @original_microsoftid IS NULL)) AND (([ncrid] = @original_ncrid) OR ([ncrid] IS NULL AND @original_ncrid IS NULL)) AND (([oracleid] = @original_oracleid) OR ([oracleid] IS NULL AND @original_oracleid IS NULL)) AND (([azureid] = @original_azureid) OR ([azureid] IS NULL AND @original_azureid IS NULL))" InsertCommand="INSERT INTO [users] ([firstname], [lastname], [username], [email], [employee], [employeeid], [microsoftid], [ncrid], [oracleid], [azureid]) VALUES (@firstname, @lastname, @username, @email, @employee, @employeeid, @microsoftid, @ncrid, @oracleid, @azureid)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [users]" UpdateCommand="UPDATE [users] SET [firstname] = @firstname, [lastname] = @lastname, [username] = @username, [email] = @email, [employee] = @employee, [employeeid] = @employeeid, [microsoftid] = @microsoftid, [ncrid] = @ncrid, [oracleid] = @oracleid, [azureid] = @azureid WHERE [id] = @original_id AND (([firstname] = @original_firstname) OR ([firstname] IS NULL AND @original_firstname IS NULL)) AND (([lastname] = @original_lastname) OR ([lastname] IS NULL AND @original_lastname IS NULL)) AND (([username] = @original_username) OR ([username] IS NULL AND @original_username IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND (([employee] = @original_employee) OR ([employee] IS NULL AND @original_employee IS NULL)) AND (([employeeid] = @original_employeeid) OR ([employeeid] IS NULL AND @original_employeeid IS NULL)) AND (([microsoftid] = @original_microsoftid) OR ([microsoftid] IS NULL AND @original_microsoftid IS NULL)) AND (([ncrid] = @original_ncrid) OR ([ncrid] IS NULL AND @original_ncrid IS NULL)) AND (([oracleid] = @original_oracleid) OR ([oracleid] IS NULL AND @original_oracleid IS NULL)) AND (([azureid] = @original_azureid) OR ([azureid] IS NULL AND @original_azureid IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_firstname" Type="String" />
			<asp:Parameter Name="original_lastname" Type="String" />
			<asp:Parameter Name="original_username" Type="String" />
			<asp:Parameter Name="original_email" Type="String" />
			<asp:Parameter Name="original_employee" Type="Byte" />
			<asp:Parameter Name="original_employeeid" Type="String" />
			<asp:Parameter Name="original_microsoftid" Type="String" />
			<asp:Parameter Name="original_ncrid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_azureid" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="firstname" Type="String" />
			<asp:Parameter Name="lastname" Type="String" />
			<asp:Parameter Name="username" Type="String" />
			<asp:Parameter Name="email" Type="String" />
			<asp:Parameter Name="employee" Type="Byte" />
			<asp:Parameter Name="employeeid" Type="String" />
			<asp:Parameter Name="microsoftid" Type="String" />
			<asp:Parameter Name="ncrid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="azureid" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="firstname" Type="String" />
			<asp:Parameter Name="lastname" Type="String" />
			<asp:Parameter Name="username" Type="String" />
			<asp:Parameter Name="email" Type="String" />
			<asp:Parameter Name="employee" Type="Byte" />
			<asp:Parameter Name="employeeid" Type="String" />
			<asp:Parameter Name="microsoftid" Type="String" />
			<asp:Parameter Name="ncrid" Type="String" />
			<asp:Parameter Name="oracleid" Type="String" />
			<asp:Parameter Name="azureid" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_firstname" Type="String" />
			<asp:Parameter Name="original_lastname" Type="String" />
			<asp:Parameter Name="original_username" Type="String" />
			<asp:Parameter Name="original_email" Type="String" />
			<asp:Parameter Name="original_employee" Type="Byte" />
			<asp:Parameter Name="original_employeeid" Type="String" />
			<asp:Parameter Name="original_microsoftid" Type="String" />
			<asp:Parameter Name="original_ncrid" Type="String" />
			<asp:Parameter Name="original_oracleid" Type="String" />
			<asp:Parameter Name="original_azureid" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="firstname" HeaderText="firstname" SortExpression="firstname">
			</asp:BoundField>
			<asp:BoundField DataField="lastname" HeaderText="lastname" SortExpression="lastname">
			</asp:BoundField>
			<asp:BoundField DataField="username" HeaderText="username" SortExpression="username">
			</asp:BoundField>
			<asp:BoundField DataField="email" HeaderText="email" SortExpression="email">
			</asp:BoundField>
			<asp:BoundField DataField="employee" HeaderText="employee" SortExpression="employee">
			</asp:BoundField>
			<asp:BoundField DataField="employeeid" HeaderText="employeeid" SortExpression="employeeid">
			</asp:BoundField>
			<asp:BoundField DataField="microsoftid" HeaderText="microsoftid" SortExpression="microsoftid">
			</asp:BoundField>
			<asp:BoundField DataField="ncrid" HeaderText="ncrid" SortExpression="ncrid">
			</asp:BoundField>
			<asp:BoundField DataField="oracleid" HeaderText="oracleid" SortExpression="oracleid">
			</asp:BoundField>
			<asp:BoundField DataField="azureid" HeaderText="azureid" SortExpression="azureid">
			</asp:BoundField>
			<asp:BoundField DataField="plainpassword" HeaderText="plainpassword" SortExpression="plainpassword">
			</asp:BoundField>
			<asp:BoundField DataField="hashedpassword" HeaderText="hashedpassword" SortExpression="hashedpassword">
			</asp:BoundField>
			<asp:BoundField DataField="passwordtype" HeaderText="passwordtype" SortExpression="passwordtype">
			</asp:BoundField>
			<asp:BoundField DataField="jid" HeaderText="jid" SortExpression="jid">
			</asp:BoundField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<a href="managelogins.aspx">Return to User Console</a>
</div>
</body>
</html>