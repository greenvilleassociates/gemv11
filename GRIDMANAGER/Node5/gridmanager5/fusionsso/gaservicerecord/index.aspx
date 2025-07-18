<html>
<head>
<title>GEM Service Record</title>
<style>
* {
  box-sizing: border-box;
}
a {
        color: #800000;
    text-decoration: none;
}

/* Style for visited links */
a:visited {
    color: #800000;
}

.column {
  float: left;
  width: 16.00%;
  padding: 5px;
}

/* Clearfix (clear floats) */
.row::after {
  content: "";
  clear: both;
  display: table;
}
.column2 {
  float: left;
  width: 25.00%;
  padding: 5px;
  text-align: center;
  vertical-align: center;

}

/* Clearfix (clear floats) */
.row2::after {
  content: "";
  clear: both;
  display: table;
  text-align: center;
  vertical-align: center;
}

.no-bullets {
  list-style-type: none;
  padding: 0;
  margin: 0;
}

.auto-style1 {
	color: #FF0000;
}

.auto-style2 {
	color: #FF00FF;
}

</style>
</head>
<body onload="checkpll()">
<p align=center><img src="cocky590.png" width=100px height=100px></p>
<HR>
<div align=center><span align=center>COCKY SERVICE RECORD HOME</span></div>
<HR>
<div align="center" class="row">
<div class="column"><figure><img src="./images/us.png" width=80px height=80px><figcaption>R1 - NorthAmerica.</figcaption></figure></div>
<div class="column"><figure><img src="./images/europe.png" width=80px height=80px><figcaption>R2 - Europe.</figcaption></figure></div>
<div class="column"><figure><img src="./images/asia.png" width=80px height=80px><figcaption>R3 - Asia.</figcaption></figure></div>
<div class="column"><figure><img src="./images/latampurple.png" width=125px height=80px><figcaption>R4 - C&S America.</figcaption></figure></div>
<div class="column"><figure><img src="./images/5northpacific.png" width=125px height=80px><figcaption>R5 - North Pacific.</figcaption></figure></div>
<div class="column"><figure><img src="./images/6southpacific.png" width=80px height=80px><figcaption>R6 - South Pacific.</figcaption></figure></div>
</div>
<HR>
<div align="center" class="row2">
<ul class="column2 no-bullets">
<H3>Inventory Actions</H3>
<li>Circuit Wizard</li>
	<li><a href="manageinventory.aspx">Inventory</a></li><li><a href="managevendors.aspx">Vendors</a><li>
	<a href="managecustomers.aspx">Customers</a><li class="auto-style1">
	<a href="managecountries.aspx">Country</a></li>
<li><a href="../gaeis/manageregions.aspx">Region</a></li>
<li><a href="../gaeis/managesites.aspx">Sites</a></li>
	<li>&nbsp;<H3>Infrastructure</H3>
<li><a href="managecomputers.aspx">Computers</a></li>
	<li><a href="managelayer2switches.aspx">L2 Switches</a></li>
	<li><a href="managecpeother.aspx">Premise Devices Other</a></li>
	<li><a href="managephones.aspx">Phones</a></li>
	<li><a href="managesecurityvideo.aspx">Security Cameras</a></li>
	<li><a href="managehdvideo.aspx">HD Video Systems</a></li>
	<li><a href="managedisks.aspx">SAN Nodes</a></li>
	<li><a href="managedisks.aspx">Array Disks</a></li>
	<li><a href="managedisks.aspx">Server Disks</a></li>
	<li class="auto-style1"><a href="managedisktype.aspx">Disk Type</a></li>
	<li><a href="managerouters.aspx">Routers</a></li>
<li><a href="manageswitches.aspx">Switches</a></li>
<li><a href="managevms.aspx">Virtual Machines</a></li>
<li><a href="manageservers.aspx">Servers</a></li>
<li><a href="managehosts.aspx">Hosts</a></li>
<li><a href="managelpars.aspx">L-PARS</a></li>
<li><a href="managerouters.aspx">IP Gateway Services</a></li>
<li><a href="manageppars.aspx">P-PARS</a></li>
<li><a href="managefirewalls.aspx">Firewalls</a></li>
<li><a href="managefirewallcontexts.aspx">Contexts</a></li>

</ul>
<ul class="column2 no-bullets">
<H3>Voice Services</H3>
<li><a href="managevoiceservices.aspx">Enhanced TollFree</a></li>
<li><a href="managevoiceservices.aspx">AIN Services</a></li>
<li><a href="managevoiceservices.aspx">VoiceDirected Services</a></li>
<li><a href="managevoiceservices.aspx">VoiceMail Services</a></li>
<li><a href="managevoiceservices.aspx">Enterprise Voice Services</a></li>
<li><a href="managevoiceservices.aspx">CC Routing Systems</a></li><li>
	<a href="managevoiceservices.aspx">Other Voice Managed Services</a><li class="auto-style1">
	<a href="managevoiceservicestype.aspx">Voice Services Type</a><li>
	<li>&nbsp;<H3>Voice Facilities & Circuits</H3>
<li><a href="managevoicetrunks.aspx">ISDN</a></li>
<li><a href="managevoicetrunks.aspx">PRI</a></li>
<li><a href="managevoicetrunks.aspx">Voice DAL</a></li>
<li><a href="managevoicetrunks.aspx">POTS Lines</a></li>
<li><a href="managevoicetrunks.aspx">IP Voice Trunks</a></li>
<li><a href="managevoicetrunks.aspx">FGD Trunks</a></li>
<li><a href="managevoicetrunks.aspx">EO.Trunks</a></li>
<li><a href="managevoicetrunks.aspx">SS7 Trunks</a></li><li><a href="managetns.aspx">Telephone Numbers</a><li class="auto-style1">
	<a href="managetrunktype.aspx">Trunk Type</a><li><H3>
	&nbsp;</H3>
	<li>
	<H3>Premise Voice Services</H3>
<li><a href="managecpe.aspx">Channel Banks</a></li>
<li><a href="managecpe.aspx">Key Systems</a></li>
<li><a href="managevoiceplatforms.aspx">PBXs Premise</a></li>
<li><a href="managecpe.aspx">PSTN Trunking Gateways</a></li>
<li><a href="managecpe.aspx">Fax Gateways</a></li>
	<li class="auto-style1"><a href="managecpetype.aspx">CPE Type</a></li>


</ul>
<ul class="column2 no-bullets">

<H3>Data Services</H3>
	<li><a href="managedataservices.aspx">Other Services - Data</a></li>
	<li><a href="managedataservices.aspx">Other Managed Services</li></a><li>
	<span class="auto-style1"><a href="managedataservicetype.aspx">Data Services 
	Type </a></span>
	<H3>Voice &amp; Data Networks</H3>
<li><a href="managenetworks.aspx">PrivateIP Global Networks</a></li>
<li><a href="managenetworks.aspx">IP Global Networks</a></li>
<li><a href="managenetworks.aspx">Global Clouds</a></li>
<li><a href="managenetworks.aspx">Hybrid Networks</a></li>
<li><a href="managenetworks.aspx">Hybrid Cloud</a></li>
<li><a href="managenetworks.aspx">Hybrid Grid</a></li>
<li><a href="managenetworks.aspx">RegionalNetworks</a></li><li>
	<a href="managenetworks.aspx">PBXs Cloud</a></li>
<li><a href="managenetworks.aspx">PBXs Grids</a></li>
	<li><a href="managenetworks.aspx">VPLS Networks</a></li>
	<li><a href="managenetworks.aspx">MPLS Networks</a></li>
	<li><a href="managenetworks.aspx">Optical Mesh</a></li>
	<li class="auto-style1"><a href="managenetworktype.aspx">Network Type</a></li>
	<li class="auto-style2"><a href="managenetworks.aspx">VPLS Network</a></li>
	<li class="auto-style2"><a href="managenetworks.aspx">EthernetExtendedWAN</a></li>
	<li class="auto-style2"><a href="managenetworks.aspx">EthernetExtendedMAN</a></li>
	<li><a href="manageopticalrings.aspx">Metro Optical Rings</a>&nbsp;<H3>Data Circuits</H3>
<li><a href="managecircuits.aspx">DSL</a></li>
<li><a href="managecircuits.aspx">Private Line Circuits</a></li>
<li><a href="managecircuits.aspx">FR/ATM Circuits</a></li>
<li><a href="managecircuits.aspx">Ethernet WAN Circuits</a></li>
<li><a href="managecircuits.aspx">Ethernet Regional Circuits</a></li>
	<li><a href="managecircuits.aspx">SONET Circuit</a></li>
	<li><a href="managecircuits.aspx">DWDM Circuit</a></li>
	<li><a href="manageopticalrings.aspx">SONET Rings</a><li><a href="manageopticalrings.aspx">DWDM Rings</a><li class="auto-style1">
	<a href="managecircuittype.aspx">CircuitType</a></ul>
<ul class="column2 no-bullets">
	<li>

<H3>Inside Plant</H3>
<li><a href="../gaeis/managesites.aspx">DataCenters</a></li>
<li><a href="../gaeis/managesites.aspx">Central Offices</a></li>
<li><a href="../gaeis/managesites.aspx">Points of Presence</a></li>
<li><a href="../gaeis/managesites.aspx">Call Centers</a></li>
<li><a href="../gaeis/managesites.aspx">Internet Gateways</a></li>
<li><a href="../gaeis/managesites.aspx">LAN Rooms</a></li>
<li><a href="../gaeis/managesites.aspx">Equipment Rooms</li></a><li class="auto-style1">
	<a href="managesitetype.aspx">Site Type</a><li>
	<li>&nbsp;<H3>Outside Plant</H3>
<li><a href="managesplices.aspx">ManHoles/SplicePts</a></li>
<li><a href="manageopticalsegments.aspx">Optical Segments</a></li><li><a href="manageconduits.aspx">Conduits</a><li>
	<a href="managerow.aspx">Right of Way</a><li>
	<li><H3>Virtualized Items</H3>
<li><a href="managevpns.aspx">MPLS VPNs</a></li>
<li><a href="managevpns.aspx">VPLS VPNs</a></li>
	<li><a href="managevpntype.aspx">VPN Type</a></li>
	<li><a href="managechannels.aspx">Voice Channels</a></li>
	<li><a href="managechannels.aspx">TDM Channels</a></li>
	<li><a href="managechanneltype.aspx">Channel Type</a></li>
</ul>
</div>
<script>
function checkpll()
{
alert('checking security permissions');
               const someuid = localStorage.getItem('uid');
               if (someuid === '901') 
               {
               window.location.href = 'loginerror.html';
               }
               }

}

</script>
</body>
<br><br><br><br><br><br><br><br>

<footer style="background-color:maroon;">
<div align=center><span align=center><font color=white>Copyright University of South Carolina - 2025</font></span></div>
</footer>
</html>