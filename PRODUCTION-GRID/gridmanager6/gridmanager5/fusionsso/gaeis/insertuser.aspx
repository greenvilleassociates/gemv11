
<head>
<style type="text/css">
.auto-style1 {
	text-align: center;
}
</style>
</head>
<body>
<div align="center">
<form id="form1" runat="server">
	<p class="auto-style1"></p>
	<p class="auto-style1">
	<img alt="" height="460" src="cocky547.png" width="460"></p>
	<p>Insert Users</p>
	<p>
	<div class="auto-style1" align="center">
	<asp:DetailsView id="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="676px">
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
			<asp:BoundField DataField="profileurl" HeaderText="profileurl" SortExpression="profileurl">
			</asp:BoundField>
			<asp:BoundField DataField="role" HeaderText="role" SortExpression="role">
			</asp:BoundField>
			<asp:BoundField DataField="fullname" HeaderText="fullname" SortExpression="fullname">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Data Source=cockysql.database.windows.net;Initial Catalog=ce;User ID=cockysa;Password=*Columbia1" DeleteCommand="DELETE FROM [users] WHERE [id] = @original_id AND (([firstname] = @original_firstname) OR ([firstname] IS NULL AND @original_firstname IS NULL)) AND (([lastname] = @original_lastname) OR ([lastname] IS NULL AND @original_lastname IS NULL)) AND (([username] = @original_username) OR ([username] IS NULL AND @original_username IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND (([employee] = @original_employee) OR ([employee] IS NULL AND @original_employee IS NULL)) AND (([employeeid] = @original_employeeid) OR ([employeeid] IS NULL AND @original_employeeid IS NULL)) AND (([microsoftid] = @original_microsoftid) OR ([microsoftid] IS NULL AND @original_microsoftid IS NULL)) AND (([ncrid] = @original_ncrid) OR ([ncrid] IS NULL AND @original_ncrid IS NULL)) AND (([oracleid] = @original_oracleid) OR ([oracleid] IS NULL AND @original_oracleid IS NULL)) AND (([azureid] = @original_azureid) OR ([azureid] IS NULL AND @original_azureid IS NULL)) AND (([plainpassword] = @original_plainpassword) OR ([plainpassword] IS NULL AND @original_plainpassword IS NULL)) AND (([hashedpassword] = @original_hashedpassword) OR ([hashedpassword] IS NULL AND @original_hashedpassword IS NULL)) AND (([passwordtype] = @original_passwordtype) OR ([passwordtype] IS NULL AND @original_passwordtype IS NULL)) AND (([jid] = @original_jid) OR ([jid] IS NULL AND @original_jid IS NULL)) AND (([profileurl] = @original_profileurl) OR ([profileurl] IS NULL AND @original_profileurl IS NULL)) AND (([role] = @original_role) OR ([role] IS NULL AND @original_role IS NULL)) AND (([fullname] = @original_fullname) OR ([fullname] IS NULL AND @original_fullname IS NULL))" InsertCommand="INSERT INTO [users] ([firstname], [lastname], [username], [email], [employee], [employeeid], [microsoftid], [ncrid], [oracleid], [azureid], [plainpassword], [hashedpassword], [passwordtype], [jid], [profileurl], [role], [fullname]) VALUES (@firstname, @lastname, @username, @email, @employee, @employeeid, @microsoftid, @ncrid, @oracleid, @azureid, @plainpassword, @hashedpassword, @passwordtype, @jid, @profileurl, @role, @fullname)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [users]" UpdateCommand="UPDATE [users] SET [firstname] = @firstname, [lastname] = @lastname, [username] = @username, [email] = @email, [employee] = @employee, [employeeid] = @employeeid, [microsoftid] = @microsoftid, [ncrid] = @ncrid, [oracleid] = @oracleid, [azureid] = @azureid, [plainpassword] = @plainpassword, [hashedpassword] = @hashedpassword, [passwordtype] = @passwordtype, [jid] = @jid, [profileurl] = @profileurl, [role] = @role, [fullname] = @fullname WHERE [id] = @original_id AND (([firstname] = @original_firstname) OR ([firstname] IS NULL AND @original_firstname IS NULL)) AND (([lastname] = @original_lastname) OR ([lastname] IS NULL AND @original_lastname IS NULL)) AND (([username] = @original_username) OR ([username] IS NULL AND @original_username IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND (([employee] = @original_employee) OR ([employee] IS NULL AND @original_employee IS NULL)) AND (([employeeid] = @original_employeeid) OR ([employeeid] IS NULL AND @original_employeeid IS NULL)) AND (([microsoftid] = @original_microsoftid) OR ([microsoftid] IS NULL AND @original_microsoftid IS NULL)) AND (([ncrid] = @original_ncrid) OR ([ncrid] IS NULL AND @original_ncrid IS NULL)) AND (([oracleid] = @original_oracleid) OR ([oracleid] IS NULL AND @original_oracleid IS NULL)) AND (([azureid] = @original_azureid) OR ([azureid] IS NULL AND @original_azureid IS NULL)) AND (([plainpassword] = @original_plainpassword) OR ([plainpassword] IS NULL AND @original_plainpassword IS NULL)) AND (([hashedpassword] = @original_hashedpassword) OR ([hashedpassword] IS NULL AND @original_hashedpassword IS NULL)) AND (([passwordtype] = @original_passwordtype) OR ([passwordtype] IS NULL AND @original_passwordtype IS NULL)) AND (([jid] = @original_jid) OR ([jid] IS NULL AND @original_jid IS NULL)) AND (([profileurl] = @original_profileurl) OR ([profileurl] IS NULL AND @original_profileurl IS NULL)) AND (([role] = @original_role) OR ([role] IS NULL AND @original_role IS NULL)) AND (([fullname] = @original_fullname) OR ([fullname] IS NULL AND @original_fullname IS NULL))">
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
			<asp:Parameter Name="original_plainpassword" Type="String" />
			<asp:Parameter Name="original_hashedpassword" Type="String" />
			<asp:Parameter Name="original_passwordtype" Type="Int32" />
			<asp:Parameter Name="original_jid" Type="Int32" />
			<asp:Parameter Name="original_profileurl" Type="String" />
			<asp:Parameter Name="original_role" Type="String" />
			<asp:Parameter Name="original_fullname" Type="String" />
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
			<asp:Parameter Name="plainpassword" Type="String" />
			<asp:Parameter Name="hashedpassword" Type="String" />
			<asp:Parameter Name="passwordtype" Type="Int32" />
			<asp:Parameter Name="jid" Type="Int32" />
			<asp:Parameter Name="profileurl" Type="String" />
			<asp:Parameter Name="role" Type="String" />
			<asp:Parameter Name="fullname" Type="String" />
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
			<asp:Parameter Name="plainpassword" Type="String" />
			<asp:Parameter Name="hashedpassword" Type="String" />
			<asp:Parameter Name="passwordtype" Type="Int32" />
			<asp:Parameter Name="jid" Type="Int32" />
			<asp:Parameter Name="profileurl" Type="String" />
			<asp:Parameter Name="role" Type="String" />
			<asp:Parameter Name="fullname" Type="String" />
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
			<asp:Parameter Name="original_plainpassword" Type="String" />
			<asp:Parameter Name="original_hashedpassword" Type="String" />
			<asp:Parameter Name="original_passwordtype" Type="Int32" />
			<asp:Parameter Name="original_jid" Type="Int32" />
			<asp:Parameter Name="original_profileurl" Type="String" />
			<asp:Parameter Name="original_role" Type="String" />
			<asp:Parameter Name="original_fullname" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	</p>
</form></div>	<p>
    <a href="index.aspx">Return to Index </a></p>

</body>
</html/>

