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
		<br><br><br><br>COCKY ENTERPRISES<br>INSERT A NEW MANAGER<br>
		<div class="auto-style1">
		</div>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Data Source=cockysql.database.windows.net;Initial Catalog=ce;User ID=cockysa;Password=*Columbia1" DeleteCommand="DELETE FROM [manager] WHERE [id] = @original_id AND (([fullname] = @original_fullname) OR ([fullname] IS NULL AND @original_fullname IS NULL)) AND (([emplid] = @original_emplid) OR ([emplid] IS NULL AND @original_emplid IS NULL)) AND (([userid] = @original_userid) OR ([userid] IS NULL AND @original_userid IS NULL)) AND (([storeid] = @original_storeid) OR ([storeid] IS NULL AND @original_storeid IS NULL)) AND (([saddress1] = @original_saddress1) OR ([saddress1] IS NULL AND @original_saddress1 IS NULL)) AND (([saddress2] = @original_saddress2) OR ([saddress2] IS NULL AND @original_saddress2 IS NULL)) AND (([scity] = @original_scity) OR ([scity] IS NULL AND @original_scity IS NULL)) AND (([sstate] = @original_sstate) OR ([sstate] IS NULL AND @original_sstate IS NULL)) AND (([szipcode] = @original_szipcode) OR ([szipcode] IS NULL AND @original_szipcode IS NULL))" InsertCommand="INSERT INTO [manager] ([fullname], [emplid], [userid], [storeid], [saddress1], [saddress2], [scity], [sstate], [szipcode]) VALUES (@fullname, @emplid, @userid, @storeid, @saddress1, @saddress2, @scity, @sstate, @szipcode)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [manager]" UpdateCommand="UPDATE [manager] SET [fullname] = @fullname, [emplid] = @emplid, [userid] = @userid, [storeid] = @storeid, [saddress1] = @saddress1, [saddress2] = @saddress2, [scity] = @scity, [sstate] = @sstate, [szipcode] = @szipcode WHERE [id] = @original_id AND (([fullname] = @original_fullname) OR ([fullname] IS NULL AND @original_fullname IS NULL)) AND (([emplid] = @original_emplid) OR ([emplid] IS NULL AND @original_emplid IS NULL)) AND (([userid] = @original_userid) OR ([userid] IS NULL AND @original_userid IS NULL)) AND (([storeid] = @original_storeid) OR ([storeid] IS NULL AND @original_storeid IS NULL)) AND (([saddress1] = @original_saddress1) OR ([saddress1] IS NULL AND @original_saddress1 IS NULL)) AND (([saddress2] = @original_saddress2) OR ([saddress2] IS NULL AND @original_saddress2 IS NULL)) AND (([scity] = @original_scity) OR ([scity] IS NULL AND @original_scity IS NULL)) AND (([sstate] = @original_sstate) OR ([sstate] IS NULL AND @original_sstate IS NULL)) AND (([szipcode] = @original_szipcode) OR ([szipcode] IS NULL AND @original_szipcode IS NULL))" ConflictDetection="CompareAllValues">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_fullname" Type="String" />
			<asp:Parameter Name="original_emplid" Type="Int32" />
			<asp:Parameter Name="original_userid" Type="Int32" />
			<asp:Parameter Name="original_storeid" Type="Int32" />
			<asp:Parameter Name="original_saddress1" Type="String" />
			<asp:Parameter Name="original_saddress2" Type="String" />
			<asp:Parameter Name="original_scity" Type="String" />
			<asp:Parameter Name="original_sstate" Type="String" />
			<asp:Parameter Name="original_szipcode" Type="String" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="fullname" Type="String" />
			<asp:Parameter Name="emplid" Type="Int32" />
			<asp:Parameter Name="userid" Type="Int32" />
			<asp:Parameter Name="storeid" Type="Int32" />
			<asp:Parameter Name="saddress1" Type="String" />
			<asp:Parameter Name="saddress2" Type="String" />
			<asp:Parameter Name="scity" Type="String" />
			<asp:Parameter Name="sstate" Type="String" />
			<asp:Parameter Name="szipcode" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="fullname" Type="String" />
			<asp:Parameter Name="emplid" Type="Int32" />
			<asp:Parameter Name="userid" Type="Int32" />
			<asp:Parameter Name="storeid" Type="Int32" />
			<asp:Parameter Name="saddress1" Type="String" />
			<asp:Parameter Name="saddress2" Type="String" />
			<asp:Parameter Name="scity" Type="String" />
			<asp:Parameter Name="sstate" Type="String" />
			<asp:Parameter Name="szipcode" Type="String" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_fullname" Type="String" />
			<asp:Parameter Name="original_emplid" Type="Int32" />
			<asp:Parameter Name="original_userid" Type="Int32" />
			<asp:Parameter Name="original_storeid" Type="Int32" />
			<asp:Parameter Name="original_saddress1" Type="String" />
			<asp:Parameter Name="original_saddress2" Type="String" />
			<asp:Parameter Name="original_scity" Type="String" />
			<asp:Parameter Name="original_sstate" Type="String" />
			<asp:Parameter Name="original_szipcode" Type="String" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<p>
	<asp:DetailsView id="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="622px" AllowPaging="True" Font-Size="10pt">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="fullname" HeaderText="fullname" SortExpression="fullname">
			</asp:BoundField>
			<asp:BoundField DataField="emplid" HeaderText="emplid" SortExpression="emplid">
			</asp:BoundField>
			<asp:BoundField DataField="userid" HeaderText="userid" SortExpression="userid">
			</asp:BoundField>
			<asp:BoundField DataField="storeid" HeaderText="storeid" SortExpression="storeid">
			</asp:BoundField>
			<asp:BoundField DataField="saddress1" HeaderText="saddress1" SortExpression="saddress1">
			</asp:BoundField>
			<asp:BoundField DataField="saddress2" HeaderText="saddress2" SortExpression="saddress2">
			</asp:BoundField>
			<asp:BoundField DataField="scity" HeaderText="scity" SortExpression="scity">
			</asp:BoundField>
			<asp:BoundField DataField="sstate" HeaderText="sstate" SortExpression="sstate">
			</asp:BoundField>
			<asp:BoundField DataField="szipcode" HeaderText="szipcode" SortExpression="szipcode">
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