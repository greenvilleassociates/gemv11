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
<div>
<hr>
<HR>
<div class="row3">
<div class="column3">
<ul>
<H3>Application Actions</H3>
<li>BackupSystem</li>
<li><a href="http://gridmanager.590team1.info:8080">Synch Hosting Accounts</a></li>
<li>GEM-Enterprise</li>
<li>GEM-GridManager</li>
<li>GEM-ControllerManager</li>
<li>LocalControllerManager</li>
<li>590-MyLinkApp</li>
<li>547-CockyEntertainmentApp</li>
<H3>Grid Actions</H3>
<li><a href="../gaservicerecord/insertinventory.aspx">Insert New Inventory Item</a></li>
	<li>I<a href="../gaservicerecord/insertinventorytype.aspx">nsert New 
	Inventory Type</a></li>
	<li>Check Postgres Synch</li>
<li>Check Grid Applications For A Customer</li>
<li>Check Local NFS Mounts</li>
<li>Check Grid NFS Mounts</li>
<li><a href="https://www.json2graph.com/">JSON Visualization</a></li>
<li><a href="https://jsonformatter.net/json-viewer/">JSON Formatting Tools</a></li>
</ul>
	<p>&nbsp;</p>
</div>
<div class="column3">
<ul>
<H3>EIS Application Information</H3>
<li>GridInventorySummary</li>
<li>GridHealth</li>
<li>AppTotals</li>
<li>DBMSInstances</li>
<li>GridSSO</li>
<li>GridVoice</li>
<H3>Active Grid Information</H3>
<li>1-Campus Grid</li>
<li>2-North America Grid</li>
<li>3-Amazon Global EurAmerica</li>
</ul>
</div>
<div class="column3">
<ul>
<li>
<H3>Commons</H3>
<li>Hosting Regions</li>
<li>Grids</li>
<li>Grid Nodes</li>
<li>Wholesale Accounts</li>
<li>Hosting Accounts</li>
<H3>System Administration Tasks</H3>
<li><a href="https://jsonformatter.net/json-viewer/">Bulk User Manager</a></li>
<li><a href="managewholesalers.aspx">Wholesale Accounts</a></li>
<li><a href="managecompanys.aspx">Manage Companys</a></li>
<li><a href="manageaccounts.aspx">Hosting Accounts</a></li>
<H3>Gridmanager Administration</H3>
<li><a href="manageusers.aspx">User Manager</li>
<li><a href="manageusergroups.aspx">Groups Manager</li>
<li><a href="managesites.aspx">Manage Sites</li>
<li><a href="managegridnodes.aspx">Manage Nodes</li>
<li><a href="managebregions.aspx">Manage Branch Regions</li>
</ul>
</div>
</div>
<br>
<HR>
<div align="center"><h2><font color="green">FusionInformatica</font></h2></div>
<hr>
<div class="informatica">
<button class="accordion">Inventory Information</button>
<div class="panel">
<div class="row2">
<div class="column2">
 <h4>Grid Performance</h4>
  <canvas id="myChart1" style="position: relative; height:80vh; width:80vw"></canvas>
</div>
<div class="column2">
 <h4>App Information</h4>
  <canvas id="myChart2" style="position: relative; height:80vh; width:80vw"></canvas>
</div>
<div class="column2">
 <h4>Customer Summary</h4>
  <canvas id="myChart3" style="position: relative; height:80vh; width:80vw"></canvas>
</div>
<div class="column2">
 <h4>Alert Messages</h4>
  <canvas id="myChart4" style="position: relative; height:80vh; width:80vw"></canvas>
</div>
<div class="column2">
 <h4>Latest Actions</h4>
  <canvas id="myChart5" style="position: relative; height:80vh; width:80vw"></canvas>
</div>
</div>
</div>
<br><hr>
<button class="accordion">Traffic Information</button>
<div class="panel">
<h4>TRAFFIC INFORMATION BY QUARTER</h4>
<br>
  <canvas id="myChart" style="position: relative; height:80vh; width:80vw"></canvas>
<br>
  <canvas id="myChart01" style="position: relative; height:80vh; width:80vw"></canvas>
<br>
  <canvas id="myChart02" style="position: relative; height:80vh; width:80vw"></canvas>
</div>
<br><hr>
<button class="accordion" id="fetchLogs">Security Logs</button>
<div class="panel">
<pre id="syslogDisplay" style="border: 1px solid #ccc; padding: 10px; background: #f9f9f9; overflow: auto;"></pre>  
</div>
<br><hr>
<button class="accordion">Ops Detail</button>
<div class="panel">
  <p id="sendlogs">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
</div>
</div>
</div>

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

  const ctx = document.getElementById('myChart1');
  new Chart(ctx, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [200000, 100000, 300000, 800000, 16000, 3000],
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
  const ctx2 = document.getElementById('myChart2');
  new Chart(ctx2, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
  const ctx3 = document.getElementById('myChart3');
  new Chart(ctx3, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
  const ctx4 = document.getElementById('myChart4');
  new Chart(ctx4, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
  const ctx5 = document.getElementById('myChart5');
  new Chart(ctx5, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
   var ctx6 = document.getElementById('myChart').getContext('2d');
        var myline = new Chart(ctx6, {
            type: 'line',
            data: {
                labels: ['January', 'February', 'March'],
                datasets: [{
                    label: 'Q1',
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
         var ctx8 = document.getElementById('myChart08').getContext('2d');
         var myline2 = new Chart(ctx8, {
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
 
 		var ctx9 = document.getElementById('myChart09').getContext('2d');
        var myline3 = new Chart(ctx9, {
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
  const ctx10 = document.getElementById('myChart10');
  new Chart(ctx10, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [200000, 100000, 300000, 800000, 16000, 3000],
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
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [200000, 100000, 300000, 800000, 16000, 3000],
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
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [200000, 100000, 300000, 800000, 16000, 3000],
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
  const ctx2 = document.getElementById('myChart2');
  new Chart(ctx2, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
  const ctx3 = document.getElementById('myChart3');
  new Chart(ctx3, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
  const ctx4 = document.getElementById('myChart4');
  new Chart(ctx4, {
    type: 'bar',
    data: {
      labels: ['Grids', 'WholesaleAccounts', 'Accounts', 'GridApps', 'DBMS Instances', 'OtherApps'],
      datasets: [{
        label: 'Global Inventory Instance#',
        data: [3, 1, 3, 8, 16, 3],
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
    const someuid = localStorage.getItem('uid');
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