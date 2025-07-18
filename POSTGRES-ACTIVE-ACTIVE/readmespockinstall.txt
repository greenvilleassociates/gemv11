POSTGRES HA CONFIGURATION EXAMPLE FROM THIS SITE
https://www.crunchydata.com/blog/active-active-postgres-16

BUT HEAVILY MODIFIED AS SEEN BELOW


CHANGE LOG

CHANGE REPLICA TO LOGICAL
CHANGE MAX_WORKER PROCESSES TO 16
RESTART SERVER

ON BOTH ACTIVE-ACTIVE REPLICAS


PROMOTE THE READ ONLY REPLICA TO A MASTER SO THAT BOTH SIDES ARE MASTERS(ACTIVE-ACTIVE)
cd /usr/pgsql-17/bin/pg_ctl promote - D -D /var/lib/pgsql/17/data/


ON BOTH SIDES

CREATE ROLE repuser WITH REPLICATION LOGIN PASSWORD 'welcome1';
GRANT all ON all tables IN schema public TO repuser;

//05/08/2025
TO ALTER A ROLE TO ADD REPLICATION TYPE
ALTER ROLE existing_user WITH REPLICATION;


CREATE PUBLICATION hrpub1; on DBSERVER
CREATE PUBLICATION hrpub2; on AUSTINORA


SUBSCRIBE TO BOTH PUBLICATIONS
pg1:

CREATE SUBSCRIPTION hrsub1
  CONNECTION 'host=pg2 port=5432 user=repuser password=welcome1 dbname=postgres'
  PUBLICATION hrpub2
  WITH (origin = none, copy_data = false);
pg2:

CREATE SUBSCRIPTION hrsub2
  CONNECTION 'host=pg1 port=5432 user=repuser password=welcome1 dbname=postgres'
  PUBLICATION hrpub1
  WITH (origin = none, copy_data = true);

//OK SO THATS BASE POSTGRES AFTER YOU INSTALL THE PRODUCT BUT WE ARE USING THE PGEDGE VERSION OF POSTGRES WHICH WE ARE INSTALLING INTO /OPT PGEDGE.
//THE FOLLOWING STEPS TOOK NEARLY A WEEK TO FIGURE OUT... SO THE PGEDGE MOVIES ONLY START PGEDGE WITHOUT A SERVICE... WHEN YOU REBOOT IT WONT WORK.
//AND THEN YOU WILL LOSE ANOTHER WEEK OF CONSULTING TIME

1) CREATE AN OPT DIRECTORY IF IT DOESNT EXIST
2) MAKE SURE YOU HAVE PYTHON 3.9 OR HIGHER (THIS USUALLY REQUIRES A LINUX 9+ CHAIN OR UBUNTU24) - DEBIAN9+, RHEL9, OL9 ETC. IT NEEDS TO BE THE DEFAULT VERSION AS INSTALLING PYTHON3.9 LATER IS NOT OK WITH PGEDGE.
3) https://docs.pgedge.com/platform/installing_pgedge/manual is the MANUAL INSTRUCTIONS BUT YOU ARE GOING TO CD INTO OPT.
4) python3 -c "$(curl -fsSL https://pgedge-download.s3.amazonaws.com/REPO/install.py)" as root.
5) After it downloads you are going to CHOWN & CHMOD pgedge as follows chown -R nonrootuser:nonrootuser pgedge (this makes PGEDGE OWNED BY NONROOT USER). If you screw up permissions PGEDGE needs to be CHMOD -R 750, and server.key in DATA/PG17/ needs to be chmod 600 or the server will not start.
6) go to /etc/systemd/system and create pg17.service and follow the instructions on pg17.service in this folder. change $user to the nonroot user you just used to CHOWN to OR THE SERVICE WONT START.
7) systemctl enable pg17 makes postgres bootable. It also makes it available in service start pg17....
8) cd into pgedge and su nonrootuser BEFORE you run step2.
9)./pgedge setup -U db_superuser_name -P db_superuser_password -d db_name
