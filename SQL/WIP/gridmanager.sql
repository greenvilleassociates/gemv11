select * from gapps;
select * from gsites;
select * from ggridtopology;
alter table gsites add COLUMN CLLICODE varchar(50);
alter table ggrids add vendor varchar(100), add vendorid varchar(150), add vendorgridname varchar(200);
create table ggridroots(id int GENERATED ALWAYS AS IDENTITY PRIMARY KEY, siteid int, rackid int, locationid int, floorid int, ipaddress varchar(150), telemetryip varchar(150)); 
create table ggridnodes(id int GENERATED ALWAYS AS IDENTITY PRIMARY KEY, siteid int, rackid int, locationid int, floorid int, ipaddress varchar(150), telemetryip varchar(150), rootid1 int, rootid2 int); 
create table ggrids (id int GENERATED ALWAYS AS IDENTITY PRIMARY KEY, geometry varchar(100), gridsite1 int, gridnode1id int, gridsite2 int, gridnode2id int, gridsite3 int, gridnode3id int, gridsite4 int, gridnode4id int, gridsite5 int, gridnode5id int, gridsite6 int, gridnode6id int, drsite1 int, drnode1id int, drsite2 int, drnode2id int, rootid1 int, rootid2 int);
create table ggridtopology (id int GENERATED ALWAYS AS IDENTITY PRIMARY KEY, topologyid varchar(100), topologydescription varchar(150));
drop table ggrids;
drop table ggridtopology;
drop table ggridnodes;
drop table ggridroots;
insert into ghregions (regionid, regiondescription) values ('Region1', 'NorthAmerica');
insert into gapptype (apptype, apptypedescription) values (2, 'Controller');
insert into gapptype (apptype, apptypedescription) values (1, 'Grid SSO');
insert into gapptype (apptype, apptypedescription) values (5, 'Simplex SSO');
insert into gapptype (apptype, apptypedescription) values (3, 'Gridified Web App');
insert into gapptype (apptype, apptypedescription) values (4, 'Gridified Mobile App');
insert into gapptype (apptype, apptypedescription) values (7, 'Simplex Mobile App');
insert into gapptype (apptype, apptypedescription) values (6, 'Simplex Web App');
insert into ggridtopology (topologyid, topologydescription) values ('T1+0', 'Triangle Active-Active-Active, No DR');
insert into ggridtopology (topologyid, topologydescription) values ('HA+0', 'HA Pair Active-Active, No DR');
insert into ggridtopology (topologyid, topologydescription) values ('M5+0', '5 NodeMesh, No DR');
insert into gsites (address1) values ('300main');
insert into gsites (address1) values ('1800 washington');
insert into gsites (address1) values ('Amazon Montreal DC');
insert into gsites (address1) values ('Google Iowa Cedar Rapids DC');
insert into gsites (address1) values ('Microsoft Seattle Azure DC West Original');
insert into ggridroots (siteid) VALUES (1);
insert into ggridroots (siteid) VALUES (2);
insert into ggridnodes (siteid) VALUES (1),(2), (3), (4), (5);
insert into ggrids (geometry) VALUES (3);






x-no-links
