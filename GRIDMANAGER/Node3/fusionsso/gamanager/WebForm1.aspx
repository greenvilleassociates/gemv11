<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Star Spangled Banner</div>
        <div>&nbsp;<asp:SqlDataSource id="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Dsn=JTEST" DeleteCommand="DELETE FROM [users] WHERE [id] = ? AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([fullname] = ?) OR ([fullname] IS NULL AND ? IS NULL)) AND (([username] = ?) OR ([username] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [users] ([description], [fullname], [username]) VALUES (?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [users]" UpdateCommand="UPDATE [users] SET [description] = ?, [fullname] = ?, [username] = ? WHERE [id] = ? AND (([description] = ?) OR ([description] IS NULL AND ? IS NULL)) AND (([fullname] = ?) OR ([fullname] IS NULL AND ? IS NULL)) AND (([username] = ?) OR ([username] IS NULL AND ? IS NULL))">
			<DeleteParameters>
				<asp:Parameter Name="original_id" Type="Int32" />
				<asp:Parameter Name="original_description" Type="String" />
				<asp:Parameter Name="original_description" Type="String" />
				<asp:Parameter Name="original_fullname" Type="String" />
				<asp:Parameter Name="original_fullname" Type="String" />
				<asp:Parameter Name="original_username" Type="String" />
				<asp:Parameter Name="original_username" Type="String" />
			</DeleteParameters>
			<InsertParameters>
				<asp:Parameter Name="description" Type="String" />
				<asp:Parameter Name="fullname" Type="String" />
				<asp:Parameter Name="username" Type="String" />
			</InsertParameters>
			<UpdateParameters>
				<asp:Parameter Name="description" Type="String" />
				<asp:Parameter Name="fullname" Type="String" />
				<asp:Parameter Name="username" Type="String" />
				<asp:Parameter Name="original_id" Type="Int32" />
				<asp:Parameter Name="original_description" Type="String" />
				<asp:Parameter Name="original_description" Type="String" />
				<asp:Parameter Name="original_fullname" Type="String" />
				<asp:Parameter Name="original_fullname" Type="String" />
				<asp:Parameter Name="original_username" Type="String" />
				<asp:Parameter Name="original_username" Type="String" />
			</UpdateParameters>
			</asp:SqlDataSource>
		</div>
        <div class="wlp-whitespace-only-element-expansion">
            &nbsp;</div>
        <div class="">
            <asp:GridView runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="id">
				<Columns>
					<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
					</asp:BoundField>
					<asp:BoundField DataField="description" HeaderText="description" SortExpression="description">
					</asp:BoundField>
					<asp:BoundField DataField="fullname" HeaderText="fullname" SortExpression="fullname">
					</asp:BoundField>
					<asp:BoundField DataField="username" HeaderText="username" SortExpression="username">
					</asp:BoundField>
				</Columns>
			</asp:GridView>
            &nbsp;</div>
        
        
    </form>
</body>
</html>
