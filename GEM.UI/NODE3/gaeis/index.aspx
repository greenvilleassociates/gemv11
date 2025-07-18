<html>
<head>
<title>EIS System</title>
<script src="chart.js"></script>
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<style>
* {
  box-sizing: border-box;
}
.accordion {
  background-color: #eee;
  color: purple;
  cursor: pointer;
  padding: 18px;
  width: 100%;
  height: 50px;
  border: none;
  text-align: left;
  outline: none;
  font-size: 11px;
  transition: 0.4s;
}

.active, .accordion:hover {
  background-color: #ccc; 
}

.panel {
  padding: 0 18px;
  display: none;
  background-color: white;
  overflow: hidden;
}

.300
{
float: left;
  width: 20.00%;
  padding: 2px;
  margin-left: auto;
  margin-right: auto;
  align: center;
  text-align: center;
  font-size: 13pt;

}
.column {
  float: left;
  width: 16.00%;
  padding: 2px;
}

/* Clearfix (clear floats) */
.row::after {
  content: "";
  clear: both;
  display: table;
}
.column2 {
  float: left;
  width: 20.00%;
  padding: 2px;
  margin-left: auto;
  margin-right: auto;
  align: center;
  text-align: center;
  font-size: 13pt;
}

/* Clearfix (clear floats) */
.row2::after {
  content: "";
  clear: both;
  display: table;
  max-height: 300px;
}
.column3 {
  float: left;
  width: 33.00%;
  padding: 2px;
}

/* Clearfix (clear floats) */
.row3::after {
  content: "";
  clear: both;
  display: table;
  max-height: 300px;
}
.informatica
{
	background-color: white;
	color: green;	
}

</style>
</head>
<body onload="checkpll()">

<p align=center><img src="cocky590.png" width=100px height=100px>
</p>
<HR>
<div align="center"><span align="center">COCKY ENTERPRISES <BR>EXECUTIVE INFORMATION SYSTEMS<BR>CAMPUS HOME(NODE1)</span></div>
<hr>
<div align="center" class="row">
<div class="column"><figure><img src="./images/us.png" width=80px height=80px><figcaption>R1 - NorthAmerica.</figcaption></figure></div>
<div class="column"><figure><img src="./images/europe.png" width=80px height=80px><figcaption>R2 - Europe.</figcaption></figure></div>
<div class="column"><figure><img src="./images/asia.png" width=80px height=80px><figcaption>R3 - Asia.</figcaption></figure></div>
<div class="column"><figure><img src="./images/latampurple.png" width=125px height=80px><figcaption>R4 - C&S America.</figcaption></figure></div>
<div class="column"><figure><img src="./images/5northpacific.png" width=125px height=80px><figcaption>R5 - North Pacific.</figcaption></figure></div>
<div class="column"><figure><img src="./images/6southpacific.png" width=80px height=80px><figcaption>R6 - South Pacific.</figcaption></figure></div>
</div>

<HR>
<div class="row3">
<div class="column3">
<ul>
<H3>Significant Applications</H3>
<li><a href="http://mylink.590team1.info">590-MyLinkApp(SqlServer)</a></li>
<li><a href="https://www.usc547team1.info">547-CockyEntertainmentApp(MySql)</a></li>
<li><a href="http://gemapp.590team1.info">498-GemApp(Postgres)</a></li>
<li><a href="http://gridmanager.590team1.info" target="_blank">Node1 Home</a></li>
<li><a href="http://gridmanager2.590team1.info" target="_blank">Node2 Home</a></li>
<li><a href="http://gridmanager3.590team1.info" target="_blank">Node3 Home</a></li>
<li><a href="http://gridmanager4.590team1.info" target="_blank">Node4 Home</a></li>
<H3>Local Server Actions-N2</H3>
<li><a href="#">BackupN2-WindowsHostSites</a></li>
<li><a href="https://gridactions3.590team1.info/controllers/backup.html">BackupN3-DBInstances</a></li>
<li><a href="https://gridactions3.590team1.info/controllershowuname.html" >OSInformation</a></li>
<li><a href="https://gridactions3.590team1.info/controllershownetstat.html" >NetworkListeners</a></li>
<li><a href="https://gridactions3.590team1.info/controllershowifconfig.html">NetworkInterfaceDetail</a></li>
<li><a href="https://gridactions3.590team1.info/controllershowgridinfo.html">NetworkResponders</a></li>
<li><a href="https://gridactions3.590team1.info/controllershowlatency.html">GridPeerResponsivenes</a></li>
</ul>
	<p>&nbsp;</p>
</div>
<div class="column3">
<ul>
<H3>EIS Application Information</H3>
<li><a href="https://gridmanager3.590team.info/fusionpro/h/adminstrator">GridSSO Manager</a></li>
<li><a href="https://gridmanager3.590team.info/fusionpro/h/">GridSSO FrontPage</a></li>
<H3>Active Grid Information</H3>
<li><a href="campus.html">1-Campus Grid</a></li>
<li><a href="northamerica.html">2-North America Grid</a></li>
<li><a href="ctsglobal.html">3-Amazon Global EurAmerica</a></li>
<H3>Reports</H3>
<li><a href="https://gridmanager3.590team1.info/fusionsso/gareports/ComplianceReport.html">1-ApplicationComplianceBase</a></li>
<li><a href="https://gridmanager3.590team1.info/fusionsso/gareports/ComplianceApiReport3.html">2-ApplicationComplianceAllApps</a></li>
<li><a href="https://gridmanager3.590team1.info/fusionsso/gareports/ComplianceChart.html">3-GridAppsChart</a></li>
<li><a href="https://gridmanager3.590team1.info/fusionsso/gareports/ComplianceChart2.html">4-AppCompliance By Grid</a></li>
</ul>
</div>
<div class="column3">
<ul>
<li>
<H3>Commons</H3>
<li><a href="managehregions.aspx">Hosting Regions</a></li>
<li><a href="managegrids.aspx">Grid</a>s</li>
<li><a href="managegnodes.aspx">Grid Nodes</a></li>
<li><a href="managewholesalers.aspx">Wholesale Accounts</a></li>
<li><a href="manageaccounts.aspx">Hosting Accounts</a></li>
<H3>System Administration Tasks</H3>
<li><a href="https://jsonformatter.net/json-viewer/">Bulk User Manager</a></li>
<li><a href="managewholesalers.aspx">Wholesale Accounts</a></li>
<li><a href="managecompanys.aspx">Manage Companys</a></li>
<li><a href="manageaccounts.aspx">Hosting Accounts</a></li>
<H3>Gridmanager Administration</H3>
<li><a href="manageusers.aspx">User Manager</a></li>
<li><a href="manageusergroups.aspx">Groups Manager</a></li>
<li><a href="managesites.aspx">Manage Sites</a></li>
<li><a href="managegridnodes.aspx">Manage Nodes</a></li>
<li><a href="managebregions.aspx">Manage Branch Regions</a></li>
</ul>
</div>
</div>
<br>
<hr>

<script>
var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
  acc[i].addEventListener("click", function() {
    this.classList.toggle("active");
    var panel = this.nextElementSibling;
    if (panel.style.display === "block") {
      panel.style.display = "none";
    } else {
      panel.style.display = "block";
    }
  });
}
const ctx00 = document.getElementById('myChart00');
  new Chart(ctx00, {
    type: 'bar',
    data: {
      labels: ['WholesaleISPAccounts', 'Discos', 'ISPAccounts', 'Discos'],
      datasets: [{
        label: 'QTY#',
        data: [200000, 100000, 3000000, 100],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });

  const ctx01 = document.getElementById('myChart01');
  new Chart(ctx01, {
    type: 'bar',
    data: {
      labels: ['WholesaleISPAccounts', 'Discos', 'ISPAccounts', 'Discos'],
      datasets: [{
        label: 'QTY#',
        data: [200000, 100000, 3000000, 100],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx02 = document.getElementById('myChart02');
  new Chart(ctx02, {
    type: 'bar',
    data: {
      labels: ['Grids', 'GridApps', 'Other Apps'],
      datasets: [{
        label: 'QTY#',
        data: [2, 1, 33],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx03 = document.getElementById('myChart03');
  new Chart(ctx03, {
    type: 'bar',
    data: {
      labels: ['Grids', 'DBMS Instances', 'GridDBMS Instances'],
      datasets: [{
        label: 'QTY#',
        data: [3, 1, 3],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx04 = document.getElementById('myChart04');
  new Chart(ctx04, {
    type: 'bar',
    data: {
      labels: ['Logins', 'TextMessages', 'PhoneCalls', 'LoginErrors'],
      datasets: [{
        label: 'QTY#', 
        data: [3000000, 10000000, 32333, 8],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx05 = document.getElementById('myChart05');
  new Chart(ctx05, {
    type: 'bar',
    data: {
      labels: ['Orders', 'TroubleTickets', 'MasterTickets', 'Changes', 'Projects'],
      datasets: [{
        label: 'QTY#',
        data: [32222, 12233, 33321, 844333, 16333, 322],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
   var ctx06 = document.getElementById('myChart06').getContext('2d');
        var myline06 = new Chart(ctx06, {
            type: 'line',
            data: {
                labels: ['January', 'February', 'March'],
                datasets: [{
                    label: 'QTY#',
                    data: [6500, 5900, 8000],
                    borderColor: 'rgba(75, 192, 192, 1)',
                    borderWidth: 1,
                    fill: false
                }]
            },
            options: {
                responsive: false,
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
         var ctx07 = document.getElementById('myChart07').getContext('2d');
         var myline07 = new Chart(ctx07, {
            type: 'line',
            data: {
                labels: ['April', 'May', 'June'],
                datasets: [{
                    label: 'Q2',
                    data: [810, 5600, 3300, 2200, 1100],
                    borderColor: 'rgba(79, 122, 162, 1)',
                    borderWidth: 1,
                    fill: false
                }]
            },
            options: {
                responsive: false,
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
 
 		var ctx08 = document.getElementById('myChart08').getContext('2d');
        var myline08 = new Chart(ctx08, {
            type: 'line',
            data: {
                labels: ['July', 'Aug', 'Sept'],
                datasets: [{
                    label: 'Q3',
                    data: [55000, 400000, 800000],
                    borderColor: 'rgba(255, 0, 0, 1)',  // Red color
                    borderWidth: 1,
                    fill: false
                }]
            },
            options: {
                responsive: false,
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });

  const ctx09 = document.getElementById('myChart09');
  new Chart(ctx09, {
    type: 'bar',
    data: {
      labels: ['WholesaleISPAccounts', 'Discos', 'ISPAccounts', 'Discos'],
      datasets: [{
        label: 'QTY#',
        data: [200000, 100000, 3000000, 100],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx10 = document.getElementById('myChart10');
  new Chart(ctx10, {
    type: 'bar',
    data: {
      labels: ['Grids', 'GridApps', 'Other Apps'],
      datasets: [{
        label: 'QTY#',
        data: [2, 1, 33],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx11 = document.getElementById('myChart11');
  new Chart(ctx11, {
    type: 'bar',
    data: {
      labels: ['Grids', 'DBMS Instances', 'GridDBMS Instances'],
      datasets: [{
        label: 'QTY#',
        data: [3, 1, 3],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx12 = document.getElementById('myChart12');
  new Chart(ctx12, {
    type: 'bar',
    data: {
      labels: ['Logins', 'TextMessages', 'PhoneCalls', 'LoginErrors'],
      datasets: [{
        label: 'QTY#', 
        data: [3000000, 10000000, 32333, 8],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx13 = document.getElementById('myChart13');
  new Chart(ctx13, {
    type: 'bar',
    data: {
      labels: ['WholesaleISPAccounts', 'Discos', 'ISPAccounts', 'Discos'],
      datasets: [{
        label: 'QTY#',
        data: [200000, 100000, 3000000, 100],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx14 = document.getElementById('myChart14');
  new Chart(ctx14, {
    type: 'bar',
    data: {
      labels: ['Grids', 'GridApps', 'Other Apps'],
      datasets: [{
        label: 'QTY#',
        data: [2, 1, 33],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx15 = document.getElementById('myChart15');
  new Chart(ctx15, {
    type: 'bar',
    data: {
      labels: ['Grids', 'DBMS Instances', 'GridDBMS Instances'],
      datasets: [{
        label: 'QTY#',
        data: [3, 1, 3],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx16 = document.getElementById('myChart16');
  new Chart(ctx16, {
    type: 'bar',
    data: {
      labels: ['Logins', 'TextMessages', 'PhoneCalls', 'LoginErrors'],
      datasets: [{
        label: 'QTY#', 
        data: [3000000, 10000000, 32333, 8],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx17 = document.getElementById('myChart17');
  new Chart(ctx17, {
    type: 'bar',
    data: {
      labels: ['WholesaleISPAccounts', 'Discos', 'ISPAccounts', 'Discos'],
      datasets: [{
        label: 'QTY#',
        data: [200000, 100000, 3000000, 100],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx18 = document.getElementById('myChart18');
  new Chart(ctx18, {
    type: 'bar',
    data: {
      labels: ['Grids', 'GridApps', 'Other Apps'],
      datasets: [{
        label: 'QTY#',
        data: [2, 1, 33],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx19 = document.getElementById('myChart19');
  new Chart(ctx19, {
    type: 'bar',
    data: {
      labels: ['Grids', 'DBMS Instances', 'GridDBMS Instances'],
      datasets: [{
        label: 'QTY#',
        data: [3, 1, 3],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx20 = document.getElementById('myChart20');
  new Chart(ctx20, {
    type: 'bar',
    data: {
      labels: ['Logins', 'TextMessages', 'PhoneCalls', 'LoginErrors'],
      datasets: [{
        label: 'QTY#', 
        data: [3000000, 10000000, 32333, 8],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx21 = document.getElementById('myChart21');
  new Chart(ctx21, {
    type: 'bar',
    data: {
      labels: ['WholesaleISPAccounts', 'Discos', 'ISPAccounts', 'Discos'],
      datasets: [{
        label: 'QTY#',
        data: [200000, 100000, 3000000, 100],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx22 = document.getElementById('myChart22');
  new Chart(ctx22, {
    type: 'bar',
    data: {
      labels: ['Grids', 'GridApps', 'Other Apps'],
      datasets: [{
        label: 'QTY#',
        data: [2, 1, 33],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx23 = document.getElementById('myChart23');
  new Chart(ctx23, {
    type: 'bar',
    data: {
      labels: ['Grids', 'DBMS Instances', 'GridDBMS Instances'],
      datasets: [{
        label: 'QTY#',
        data: [3, 1, 3],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx24 = document.getElementById('myChart24');
  new Chart(ctx24, {
    type: 'bar',
    data: {
      labels: ['Logins', 'TextMessages', 'PhoneCalls', 'LoginErrors'],
      datasets: [{
        label: 'QTY#', 
        data: [3000000, 10000000, 32333, 8],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });
  const ctx25 = document.getElementById('myChart25');
  new Chart(ctx25, {
    type: 'bar',
    data: {
      labels: ['Logins', 'TextMessages', 'PhoneCalls', 'LoginErrors'],
      datasets: [{
        label: 'QTY#', 
        data: [3000000, 10000000, 32333, 8],
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });



function fetchSyslog(apiUrl) {
	   var stringdescr = 'ComeOn Please God... I need the Security logs! You called the following URL:' + apiUrl;
	  alert(stringdescr);
        $.get(apiUrl, function(data) {
  console.log("API Response:", data); // Check the raw data
  $('#syslogDisplay').text(JSON.stringify(data, null, 2));
}).fail(function(jqXHR, textStatus, errorThrown) {
  console.error("Error details:", textStatus, errorThrown); // Log the error for debugging
  $('#syslogDisplay').text(`Error fetching syslog: ${textStatus} - ${errorThrown}`);
});
    }
    

    // Button click event listener
    $('#fetchLogs').on('click', function() {
      const apiUrl = 'https://cockyapiv3-bugudue8akcsbacz.westus3-01.azurewebsites.net/api/Userlog'; // Replace with your actual API endpoint
      fetchSyslog(apiUrl); // Call the function
    });
                
    function checkpll()
    {
	alert('checking security');    
    const someuid = localStorage.getItem('jid');
		       if (someuid === '901') 
               {
               window.location.href = 'loginerror.html';
               }
               }
</script>
</body>
<footer style="background-color:maroon;">
<div align=center><span align=center><font color=white>Copyright University of South Carolina - 2025</font></span></div>
</footer>
</html>