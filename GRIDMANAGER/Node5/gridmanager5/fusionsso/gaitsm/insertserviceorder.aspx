<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
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
		<img alt="" height="258" src="cocky590.png" width="333" /><br />
		COCKY ENTERPRISES<br />
		PROVISIONING ORDER DETAILS<br />
		<br />
		<br />
		<HR>
	</div>
	<asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="Dsn=GEMPROD" ProviderName="System.Data.Odbc" SelectCommand="SELECT * FROM [gserviceorders]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [gserviceorders] WHERE [id] = ? AND (([regiondescription] = ?) OR ([regiondescription] IS NULL AND ? IS NULL)) AND (([regionid] = ?) OR ([regionid] IS NULL AND ? IS NULL)) AND (([ordertype] = ?) OR ([ordertype] IS NULL AND ? IS NULL)) AND (([custid] = ?) OR ([custid] IS NULL AND ? IS NULL)) AND (([orderdescription] = ?) OR ([orderdescription] IS NULL AND ? IS NULL)) AND (([totalitems] = ?) OR ([totalitems] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [gserviceorders] ([regiondescription], [regionid], [ordertype], [custid], [orderdescription], [totalitems]) VALUES (?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [gserviceorders] SET [regiondescription] = ?, [regionid] = ?, [ordertype] = ?, [custid] = ?, [orderdescription] = ?, [totalitems] = ? WHERE [id] = ? AND (([regiondescription] = ?) OR ([regiondescription] IS NULL AND ? IS NULL)) AND (([regionid] = ?) OR ([regionid] IS NULL AND ? IS NULL)) AND (([ordertype] = ?) OR ([ordertype] IS NULL AND ? IS NULL)) AND (([custid] = ?) OR ([custid] IS NULL AND ? IS NULL)) AND (([orderdescription] = ?) OR ([orderdescription] IS NULL AND ? IS NULL)) AND (([totalitems] = ?) OR ([totalitems] IS NULL AND ? IS NULL))">
		<DeleteParameters>
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_regiondescription" Type="String" />
			<asp:Parameter Name="original_regiondescription" Type="String" />
			<asp:Parameter Name="original_regionid" Type="Int32" />
			<asp:Parameter Name="original_regionid" Type="Int32" />
			<asp:Parameter Name="original_ordertype" Type="Int32" />
			<asp:Parameter Name="original_ordertype" Type="Int32" />
			<asp:Parameter Name="original_custid" Type="String" />
			<asp:Parameter Name="original_custid" Type="String" />
			<asp:Parameter Name="original_orderdescription" Type="String" />
			<asp:Parameter Name="original_orderdescription" Type="String" />
			<asp:Parameter Name="original_totalitems" Type="Int32" />
			<asp:Parameter Name="original_totalitems" Type="Int32" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="regiondescription" Type="String" />
			<asp:Parameter Name="regionid" Type="Int32" />
			<asp:Parameter Name="ordertype" Type="Int32" />
			<asp:Parameter Name="custid" Type="String" />
			<asp:Parameter Name="orderdescription" Type="String" />
			<asp:Parameter Name="totalitems" Type="Int32" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="regiondescription" Type="String" />
			<asp:Parameter Name="regionid" Type="Int32" />
			<asp:Parameter Name="ordertype" Type="Int32" />
			<asp:Parameter Name="custid" Type="String" />
			<asp:Parameter Name="orderdescription" Type="String" />
			<asp:Parameter Name="totalitems" Type="Int32" />
			<asp:Parameter Name="original_id" Type="Int32" />
			<asp:Parameter Name="original_regiondescription" Type="String" />
			<asp:Parameter Name="original_regiondescription" Type="String" />
			<asp:Parameter Name="original_regionid" Type="Int32" />
			<asp:Parameter Name="original_regionid" Type="Int32" />
			<asp:Parameter Name="original_ordertype" Type="Int32" />
			<asp:Parameter Name="original_ordertype" Type="Int32" />
			<asp:Parameter Name="original_custid" Type="String" />
			<asp:Parameter Name="original_custid" Type="String" />
			<asp:Parameter Name="original_orderdescription" Type="String" />
			<asp:Parameter Name="original_orderdescription" Type="String" />
			<asp:Parameter Name="original_totalitems" Type="Int32" />
			<asp:Parameter Name="original_totalitems" Type="Int32" />
		</UpdateParameters>
	</asp:SqlDataSource>
	<asp:DetailsView id="DetailsView1" runat="server" AllowPaging="True" DataSourceID="SqlDataSource1" Height="50px" Width="518px" AutoGenerateRows="False" DataKeyNames="id">
		<Fields>
			<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id">
			</asp:BoundField>
			<asp:BoundField DataField="regiondescription" HeaderText="regiondescription" SortExpression="regiondescription">
			</asp:BoundField>
			<asp:BoundField DataField="regionid" HeaderText="regionid" SortExpression="regionid">
			</asp:BoundField>
			<asp:BoundField DataField="ordertype" HeaderText="ordertype" SortExpression="ordertype">
			</asp:BoundField>
			<asp:BoundField DataField="custid" HeaderText="custid" SortExpression="custid">
			</asp:BoundField>
			<asp:BoundField DataField="orderdescription" HeaderText="orderdescription" SortExpression="orderdescription">
			</asp:BoundField>
			<asp:BoundField DataField="totalitems" HeaderText="totalitems" SortExpression="totalitems">
			</asp:BoundField>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True">
			</asp:CommandField>
		</Fields>
	</asp:DetailsView>
</form></div>
<p><a href="serviceorders.aspx">Return to the Provisioning Manager</a></p>
<HR>
</body>

</html>
