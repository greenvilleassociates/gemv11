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
		<br><br><br><br>COCKY ENTERPRISES HR MANAGER<br>2300 FORREST 
		DRIVE<br>INSERT A NEW EMPLOYEE<br>
		<div class="auto-style1">
		</div>
	</div>
	<div align="center">
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Server=tcp:cockysql.database.windows.net,1433;Initial Catalog=ce;Persist Security Info=False;User ID=cockysa;Password=*Columbia1;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;" DeleteCommand="DELETE FROM [employees] WHERE [id] = @original_id AND (([employeeid] = @original_employeeid) OR ([employeeid] IS NULL AND @original_employeeid IS NULL)) AND (([employeetenure] = @original_employeetenure) OR ([employeetenure] IS NULL AND @original_employeetenure IS NULL)) AND (([employeestartdate] = @original_employeestartdate) OR ([employeestartdate] IS NULL AND @original_employeestartdate IS NULL)) AND (([employee_returndate] = @original_employee_returndate) OR ([employee_returndate] IS NULL AND @original_employee_returndate IS NULL)) AND (([hrid] = @original_hrid) OR ([hrid] IS NULL AND @original_hrid IS NULL)) AND (([hrsystemconstring] = @original_hrsystemconstring) OR ([hrsystemconstring] IS NULL AND @original_hrsystemconstring IS NULL)) AND (([fullname] = @original_fullname) OR ([fullname] IS NULL AND @original_fullname IS NULL)) AND (([userid] = @original_userid) OR ([userid] IS NULL AND @original_userid IS NULL)) AND (([userprofileid] = @original_userprofileid) OR ([userprofileid] IS NULL AND @original_userprofileid IS NULL))" InsertCommand="INSERT INTO [employees] ([employeeid], [employeetenure], [employeestartdate], [employee_returndate], [hrid], [hrsystemconstring], [fullname], [userid], [userprofileid]) VALUES (@employeeid, @employeetenure, @employeestartdate, @employee_returndate, @hrid, @hrsystemconstring, @fullname, @userid, @userprofileid)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [employees]" UpdateCommand="UPDATE [employees] SET [employeeid] = @employeeid, [employeetenure] = @employeetenure, [employeestartdate] = @employeestartdate, [employee_returndate] = @employee_returndate, [hrid] = @hrid, [hrsystemconstring] = @hrsystemconstring, [fullname] = @fullname, [userid] = @userid, [userprofileid] = @userprofileid WHERE [id] = @original_id AND (([employeeid] = @original_employeeid) OR ([employeeid] IS NULL AND @original_employeeid IS NULL)) AND (([employeetenure] = @original_employeetenure) OR ([employeetenure] IS NULL AND @original_employeetenure IS NULL)) AND (([employeestartdate] = @original_employeestartdate) OR ([employeestartdate] IS NULL AND @original_employeestartdate IS NULL)) AND (([employee_returndate] = @original_employee_returndate) OR ([employee_returndate] IS NULL AND @original_employee_returndate IS NULL)) AND (([hrid] = @original_hrid) OR ([hrid] IS NULL AND @original_hrid IS NULL)) AND (([hrsystemconstring] = @original_hrsystemconstring) OR ([hrsystemconstring] IS NULL AND @original_hrsystemconstring IS NULL)) AND (([fullname] = @original_fullname) OR ([fullname] IS NULL AND @original_fullname IS NULL)) AND (([userid] = @original_userid) OR ([userid] IS NULL AND @original_userid IS NULL)) AND (([userprofileid] = @original_userprofileid) OR ([userprofileid] IS NULL AND @original_userprofileid IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_employeeid" Type="String" />
			<asp:Parameter Name="original_employeetenure" Type="String" />
			<asp:Parameter Name="original_employeestartdate" Type="DateTime" />
			<asp:Parameter Name="original_employee_returndate" Type="DateTime" />
			<asp:Parameter Name="original_hrid" Type="String" />
			<asp:Parameter Name="original_hrsystemconstring" Type="String" />
			<asp:Parameter Name="original_fullname" Type="String" />
			<asp:Parameter Name="original_userid" Type="Int32" />
			<asp:Parameter Name="original_userprofileid" Type="Int32" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="employeeid" Type="String" />
			<asp:Parameter Name="employeetenure" Type="String" />
			<asp:Parameter Name="employeestartdate" Type="DateTime" />
			<asp:Parameter Name="employee_returndate" Type="DateTime" />
			<asp:Parameter Name="hrid" Type="String" />
			<asp:Parameter Name="hrsystemconstring" Type="String" />
			<asp:Parameter Name="fullname" Type="String" />
			<asp:Parameter Name="userid" Type="Int32" />
			<asp:Parameter Name="userprofileid" Type="Int32" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="employeeid" Type="String" />
			<asp:Parameter Name="employeetenure" Type="String" />
			<asp:Parameter Name="employeestartdate" Type="DateTime" />
			<asp:Parameter Name="employee_returndate" Type="DateTime" />
			<asp:Parameter Name="hrid" Type="String" />
			<asp:Parameter Name="hrsystemconstring" Type="String" />
			<asp:Parameter Name="fullname" Type="String" />
			<asp:Parameter Name="userid" Type="Int32" />
			<asp:Parameter Name="userprofileid" Type="Int32" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_employeeid" Type="String" />
			<asp:Parameter Name="original_employeetenure" Type="String" />
			<asp:Parameter Name="original_employeestartdate" Type="DateTime" />
			<asp:Parameter Name="original_employee_returndate" Type="DateTime" />
			<asp:Parameter Name="original_hrid" Type="String" />
			<asp:Parameter Name="original_hrsystemconstring" Type="String" />
			<asp:Parameter Name="original_fullname" Type="String" />
			<asp:Parameter Name="original_userid" Type="Int32" />
			<asp:Parameter Name="original_userprofileid" Type="Int32" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="employeeid" HeaderText="employeeid" SortExpression="employeeid">
			</asp:BoundField>
			<asp:BoundField DataField="employeetenure" HeaderText="employeetenure" SortExpression="employeetenure">
			</asp:BoundField>
			<asp:BoundField DataField="employeestartdate" HeaderText="employeestartdate" SortExpression="employeestartdate">
			</asp:BoundField>
			<asp:BoundField DataField="employee_returndate" HeaderText="employee_returndate" SortExpression="employee_returndate">
			</asp:BoundField>
			<asp:BoundField DataField="hrid" HeaderText="hrid" SortExpression="hrid">
			</asp:BoundField>
			<asp:BoundField DataField="hrsystemconstring" HeaderText="hrsystemconstring" SortExpression="hrsystemconstring">
			</asp:BoundField>
			<asp:BoundField DataField="fullname" HeaderText="fullname" SortExpression="fullname">
			</asp:BoundField>
			<asp:BoundField DataField="userid" HeaderText="userid" SortExpression="userid">
			</asp:BoundField>
			<asp:BoundField DataField="userprofileid" HeaderText="userprofileid" SortExpression="userprofileid">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</p>
</form>
</div>
<div>
<a href="manageemployees.aspx">Return to Employee Console</a>
</div>
</body>
</html>