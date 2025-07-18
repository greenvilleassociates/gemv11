using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GEMAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "snowflake");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:snowflake.snowflake", ",,")
                .Annotation("Npgsql:PostgresExtension:spock.spock", ",,");

            migrationBuilder.CreateSequence(
                name: "emp_eid_seq",
                startValue: 2L,
                incrementBy: 2);

            migrationBuilder.CreateSequence(
                name: "emp_eid_seq0",
                startValue: 1000L);

            migrationBuilder.CreateSequence(
                name: "emp_eid_seq1",
                incrementBy: 2);

            migrationBuilder.CreateSequence(
                name: "emp_eid_seq2",
                startValue: 10000L);

            migrationBuilder.CreateSequence(
                name: "id_seq",
                schema: "snowflake");

            migrationBuilder.CreateSequence(
                name: "uid_seq",
                startValue: 20000L);

            migrationBuilder.CreateTable(
                name: "gaccounts",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    accountname = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    companyid = table.Column<int>(type: "integer", nullable: true),
                    wholesalevendorid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gaccounts_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gapps",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    appid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    appdescription = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    apptype = table.Column<int>(type: "integer", nullable: true),
                    appregion = table.Column<int>(type: "integer", nullable: true),
                    dbmstype = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    dbmsvendor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    dbmstopology = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    gridid = table.Column<int>(type: "integer", nullable: true),
                    targetgeometry = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true, defaultValueSql: "'4sidedpolygon'::character varying"),
                    targetgrid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true, defaultValueSql: "'US-InnerCore'::character varying"),
                    targetgridid = table.Column<int>(type: "integer", nullable: true, defaultValue: 1),
                    iscompliant = table.Column<int>(type: "integer", nullable: true),
                    licenseid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    versionnumber = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    totalseats = table.Column<int>(type: "integer", nullable: true),
                    licenseexpiration = table.Column<DateOnly>(type: "date", nullable: true),
                    licensetype = table.Column<int>(type: "integer", nullable: true),
                    legalcontactid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gapps_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gapptype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    apptype = table.Column<int>(type: "integer", nullable: true),
                    apptypedescription = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gapptype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gbranches",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    branchid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    brancdescription = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    siteid = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gbranches_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gbregions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    regionid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    regiondescription = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gbregions_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gchange",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    changeid = table.Column<long>(type: "bigint", nullable: true),
                    workeffortsize = table.Column<string>(type: "character(25)", fixedLength: true, maxLength: 25, nullable: true),
                    busunit = table.Column<string>(type: "character(25)", fixedLength: true, maxLength: 25, nullable: true),
                    engineerid = table.Column<string>(type: "character(50)", fixedLength: true, maxLength: 50, nullable: true),
                    description = table.Column<string>(type: "character(3500)", fixedLength: true, maxLength: 3500, nullable: true),
                    status = table.Column<string>(type: "character(10)", fixedLength: true, maxLength: 10, nullable: true),
                    approvalid = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    changestart = table.Column<DateOnly>(type: "date", nullable: true),
                    changeend = table.Column<DateOnly>(type: "date", nullable: true),
                    holdinfo = table.Column<string>(type: "character(1000)", fixedLength: true, maxLength: 1000, nullable: true),
                    comments = table.Column<string>(type: "character(3000)", fixedLength: true, maxLength: 3000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gchange_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gchannels",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    channelid = table.Column<int>(type: "integer", nullable: true),
                    circuitid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gchannels_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gchanneltype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    channeltypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gchanneltype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gcircuits",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    circuittypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    aloc = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    zloc = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gcircuits_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gcircuittype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    circuittypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gcircuittype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gcompany",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyname = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    dynamicsid = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    oracleid = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    alohaid = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gcompany_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gcomputer",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    computerid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    computertype = table.Column<int>(type: "integer", nullable: true),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gcomputer_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gconduits",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    conduitid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    conduittype = table.Column<int>(type: "integer", nullable: true),
                    rowid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gconduits_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gcountry",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    countryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    exchange = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    region = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gcountry_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gcpeother",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vendorid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gcpeother_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gcpetype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpetypeid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gcpetype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gcustomer",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    address1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    address2 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    city = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    state = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    zip = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    phone = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    customerid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    oracleid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    dynamicsid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    alohaid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gcustomer_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdataservices",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    networkid = table.Column<int>(type: "integer", nullable: true),
                    dataserviceid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdataservices_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdbmsreleases",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vendorname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendorid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    releasedescription = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    releaseversion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    releasesystemrequirements = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdbmsreleases_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdbmsreplication",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vendorname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendorid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    replicationdescription = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdbmsreplication_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdbmstopology",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dbmstopology = table.Column<int>(type: "integer", nullable: true),
                    dbmstopologydescription = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdbmstopology_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdbmstype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dbmstype = table.Column<int>(type: "integer", nullable: true),
                    dbmstypedescription = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdbmstype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdbmsvendors",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vendorname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendorid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    dynamicsid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    oracleid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdbmsvendors_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdisk",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    diskid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    disktype = table.Column<int>(type: "integer", nullable: true),
                    machineid = table.Column<int>(type: "integer", nullable: true),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    serverid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    lat = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    @long = table.Column<string>(name: "long", type: "character varying(100)", maxLength: 100, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdisk_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdisktype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    disktype = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    vendorid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdisktype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gdservicetype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datatypeid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gdservicetype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gemployees",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employeeid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    fullname = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    primarysite = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    homeoffice = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gemployees_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gengineregions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    regiondescription = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    regionid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gengineregions_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gfax",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    faxid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    faxtype = table.Column<int>(type: "integer", nullable: true),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gfax_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gfirewallcontexts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firewallid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    contextid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gfirewallcontexts_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gfirewalls",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firewallid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gfirewalls_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ggateways",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    gatewayid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    gatewaytype = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ggateways_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ggatewaytype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ggatewaytype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ggridnodes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    rackid = table.Column<int>(type: "integer", nullable: true),
                    locationid = table.Column<int>(type: "integer", nullable: true),
                    floorid = table.Column<int>(type: "integer", nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    telemetryip = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    rootid1 = table.Column<int>(type: "integer", nullable: true),
                    rootid2 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ggridnodes_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ggridroots",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    rackid = table.Column<int>(type: "integer", nullable: true),
                    locationid = table.Column<int>(type: "integer", nullable: true),
                    floorid = table.Column<int>(type: "integer", nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    telemetryip = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ggridroots_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ggrids",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    geometry = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    gridsite1 = table.Column<int>(type: "integer", nullable: true),
                    gridnode1id = table.Column<int>(type: "integer", nullable: true),
                    gridsite2 = table.Column<int>(type: "integer", nullable: true),
                    gridnode2id = table.Column<int>(type: "integer", nullable: true),
                    gridsite3 = table.Column<int>(type: "integer", nullable: true),
                    gridnode3id = table.Column<int>(type: "integer", nullable: true),
                    gridsite4 = table.Column<int>(type: "integer", nullable: true),
                    gridnode4id = table.Column<int>(type: "integer", nullable: true),
                    gridsite5 = table.Column<int>(type: "integer", nullable: true),
                    gridnode5id = table.Column<int>(type: "integer", nullable: true),
                    gridsite6 = table.Column<int>(type: "integer", nullable: true),
                    gridnode6id = table.Column<int>(type: "integer", nullable: true),
                    drsite1 = table.Column<int>(type: "integer", nullable: true),
                    drnode1id = table.Column<int>(type: "integer", nullable: true),
                    drsite2 = table.Column<int>(type: "integer", nullable: true),
                    drnode2id = table.Column<int>(type: "integer", nullable: true),
                    rootid1 = table.Column<int>(type: "integer", nullable: true),
                    rootid2 = table.Column<int>(type: "integer", nullable: true),
                    vendor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendorid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    vendorgridname = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ggrids_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ggridtopology",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    topologyid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    topologydescription = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ggridtopology_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ghdvideo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    videoid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    vidtype = table.Column<int>(type: "integer", nullable: true),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ghdvideo_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ghostimages",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imageid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    imageurl = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    imagevendor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendoraccountid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    operatingsystem = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ghostimages_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ghostlpars",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    lparid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ghostlpars_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ghosts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    switchid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    serverid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    lpars = table.Column<int>(type: "integer", nullable: true),
                    imageid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ghosts_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ghostvms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vmid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ghostvms_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ghregions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    regionid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    regiondescription = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ghregions_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ginventory",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    inventorytype = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    serialnumber = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("inventory_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ginventorytype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("inventorytype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gitsm",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ticketid = table.Column<long>(type: "bigint", nullable: true),
                    custid = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    oracleid = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    dynamicsid = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    summary = table.Column<string>(type: "character(200)", fixedLength: true, maxLength: 200, nullable: true),
                    priority = table.Column<string>(type: "character(10)", fixedLength: true, maxLength: 10, nullable: true),
                    res1 = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    res2 = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    res3 = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    res4 = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    ticketstatus = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    opendate = table.Column<DateOnly>(type: "date", nullable: true),
                    closedate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gitsm_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gitsm_detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    detailid = table.Column<long>(type: "bigint", nullable: true),
                    ticketid = table.Column<long>(type: "bigint", nullable: true),
                    linenumber = table.Column<string>(type: "character(50)", fixedLength: true, maxLength: 50, nullable: true),
                    linedetail = table.Column<string>(type: "character(1000)", fixedLength: true, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gitsm_detail_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "glayer2switches",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    siteid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("glayer2switches_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "glicensetype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    licensetypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    term = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("glicensetype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gmanagers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    managerid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    fullname = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gmanagers_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gnetworks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    networkid = table.Column<int>(type: "integer", nullable: true),
                    networktypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gnetworks_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gnetworksplicebox",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    spliceid = table.Column<long>(type: "bigint", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    gpslat = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    gpslong = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    user1 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    user2 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    user3 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    user4 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    user5 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gnetworksplicebox_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gnetworktype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    networktypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gnetworktype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gopticalring",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ringid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ringtype = table.Column<int>(type: "integer", nullable: true),
                    siteid1 = table.Column<int>(type: "integer", nullable: true),
                    siteid2 = table.Column<int>(type: "integer", nullable: true),
                    siteid3 = table.Column<int>(type: "integer", nullable: true),
                    siteid4 = table.Column<int>(type: "integer", nullable: true),
                    siteid5 = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    lat = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    @long = table.Column<string>(name: "long", type: "character varying(100)", maxLength: 100, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gopticalring_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gopticalsegments",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    segmenttypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    aloc = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    zloc = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gopticalsegments_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gopttype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    opttypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gopttype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gphones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    phoneid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    phonetype = table.Column<int>(type: "integer", nullable: true),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    lat = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    @long = table.Column<string>(name: "long", type: "character varying(100)", maxLength: 100, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gphones_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gphysicalpar",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gphysicalpar_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gproducts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    productid = table.Column<int>(type: "integer", nullable: true),
                    productname = table.Column<string>(type: "character(50)", fixedLength: true, maxLength: 50, nullable: true),
                    product_woo_id = table.Column<string>(type: "character(50)", fixedLength: true, maxLength: 50, nullable: true),
                    proudct_woo_instance = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    product_woo_url = table.Column<string>(type: "character(250)", fixedLength: true, maxLength: 250, nullable: true),
                    vendorid = table.Column<string>(type: "character(25)", fixedLength: true, maxLength: 25, nullable: true),
                    oracleid = table.Column<string>(type: "character(50)", fixedLength: true, maxLength: 50, nullable: true),
                    dynamicsid = table.Column<string>(type: "character(50)", fixedLength: true, maxLength: 50, nullable: true),
                    division = table.Column<string>(type: "character(30)", fixedLength: true, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gproducts_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grightofway",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rowid = table.Column<int>(type: "integer", nullable: true),
                    rowtype = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("grightofway_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grouters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    routerid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("grouters_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gsecvideo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    videoid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    vidtype = table.Column<int>(type: "integer", nullable: true),
                    siteid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gsecvideo_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gservers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    serverid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gservers_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gserviceorderdetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    skuid = table.Column<int>(type: "integer", nullable: true),
                    skuidc = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    listcost = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    unitcost = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    statetax = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    federalvat = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gserviceorderdetail_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gserviceorders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    regiondescription = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    regionid = table.Column<int>(type: "integer", nullable: true),
                    ordertype = table.Column<int>(type: "integer", nullable: true),
                    custid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    orderdescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    totalitems = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gserviceorders_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gserviceordertype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    servicetypedescription = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    servicetypeid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gserviceordertype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gsites",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    siteid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    sitedescription = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    siteclli = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    address1 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    address2 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    stateregion = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    postal = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    phone = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    fax = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    sitecontactid = table.Column<int>(type: "integer", nullable: true),
                    cllicode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gsites_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gsitetype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sitetypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gsitetype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gsoftwarelicenses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    licenseid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    licensetypeid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    startdate = table.Column<DateOnly>(type: "date", nullable: true),
                    enddate = table.Column<DateOnly>(type: "date", nullable: true),
                    notificationdate = table.Column<DateOnly>(type: "date", nullable: true),
                    alertemail = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    technicalcontactid = table.Column<int>(type: "integer", nullable: true),
                    gridid = table.Column<int>(type: "integer", nullable: true),
                    totalseats = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gsoftwarelicenses_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gswitches",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    switchid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gswitches_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gtelephonenumber",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tn = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    phoneid = table.Column<int>(type: "integer", nullable: true),
                    channelid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gtelephonenumber_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gtrunks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gtrunks_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gtrunktype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    trunktypeid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gtrunktype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gusergroups",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    groupname = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    groupid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gusergroups_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gusers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    jid = table.Column<int>(type: "integer", nullable: true),
                    userid = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    firstname = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    lastname = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    username = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    address1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    address2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    city = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    region = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    postal = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    country = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    faxnumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    cardnumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    expirecard = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    securitycard = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true),
                    nameoncard = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    cardaddress1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardaddress2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardzip = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardregion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardcity = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardcountry = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    firstproduct = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    registrationdate = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ssduns = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    secondproduct = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    keytype = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cellphone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    corporatename = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    fullname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gusers_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gusers_cards",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userid = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    appid = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardtype = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardnumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cardexpiration = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    cardsecurity = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    appdate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gusers_cards_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvendor",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vendorid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendorname = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    vendoraddress1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendoraddress2 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendorcity = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendorstate = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    vendorzip = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvendor_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvoicegateway",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    switchid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvoicegateway_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvoiceplatforms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    platformid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    platformtype = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telemetryipaddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vpnid2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    serverid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvoiceplatforms_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvoiceplatformtype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    platformtype = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvoiceplatformtype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvoiceservices",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    networkid = table.Column<int>(type: "integer", nullable: true),
                    voiceserviceid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvoiceservices_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvoicetrunks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    trunkid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    trunktypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvoicetrunks_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvoicetrunktype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    trunktypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvoicetrunktype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvolumes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    volumeid = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    volumetype = table.Column<int>(type: "integer", nullable: true),
                    diskid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvolumes_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvpns",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vpnid = table.Column<int>(type: "integer", nullable: true),
                    circuitid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    inventoryid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvpns_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvpntype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vpntypeid = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvpntype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gvservicetype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    voicetypeid = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gvservicetype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gwholesalers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    wholesalename = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    companyid = table.Column<int>(type: "integer", nullable: true),
                    dynamicsid = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    oracleid = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    alohaid = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gwholesalers_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gworkorders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    custid = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    oracleid = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    dynamicsid = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    summary = table.Column<string>(type: "character(200)", fixedLength: true, maxLength: 200, nullable: true),
                    priority = table.Column<string>(type: "character(10)", fixedLength: true, maxLength: 10, nullable: true),
                    res1 = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    res2 = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    res3 = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    res4 = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    ticketstatus = table.Column<string>(type: "character(100)", fixedLength: true, maxLength: 100, nullable: true),
                    opendate = table.Column<DateOnly>(type: "date", nullable: true),
                    closedate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gworkorders_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gworktype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    worktypeid = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gworktype_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_action_log_config",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    type_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    id_holder = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    title_holder = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    table_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    text_prefix = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_action_log_config_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_action_logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    message_language_key = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    message = table.Column<string>(type: "text", nullable: false),
                    log_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    extension = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying"),
                    user_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    item_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    ip_address = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false, defaultValueSql: "'0.0.0.0'::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_action_logs_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_action_logs_extensions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    extension = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_action_logs_extensions_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_action_logs_users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    notify = table.Column<int>(type: "integer", nullable: false),
                    extensions = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_action_logs_users_pkey", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "h_assets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Nested set parent."),
                    lft = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Nested set lft."),
                    rgt = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Nested set rgt."),
                    level = table.Column<int>(type: "integer", nullable: false, comment: "The cached level in the nested tree."),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The unique name for the asset."),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The descriptive title for the asset."),
                    rules = table.Column<string>(type: "character varying(5120)", maxLength: 5120, nullable: false, comment: "JSON encoded access control.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_assets_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_associations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "A reference to the associated item."),
                    context = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The context of the associated item."),
                    key = table.Column<string>(type: "character(32)", fixedLength: true, maxLength: 32, nullable: false, comment: "The key for the association computed from an md5 on associated ids.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_associations_idx_context_id", x => new { x.context, x.id });
                });

            migrationBuilder.CreateTable(
                name: "h_banner_clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    contact = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    extrainfo = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    checked_out = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    metakey = table.Column<string>(type: "text", nullable: false),
                    own_prefix = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    metakey_prefix = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    purchase_type = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "'-1'::integer"),
                    track_clicks = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "'-1'::integer"),
                    track_impressions = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "'-1'::integer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_banner_clients_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_banner_tracks",
                columns: table => new
                {
                    track_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    track_type = table.Column<long>(type: "bigint", nullable: false),
                    banner_id = table.Column<long>(type: "bigint", nullable: false),
                    count = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_banner_tracks_pkey", x => new { x.track_date, x.track_type, x.banner_id });
                });

            migrationBuilder.CreateTable(
                name: "h_banners",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cid = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    type = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    imptotal = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    impmade = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    clicks = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    clickurl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValueSql: "''::character varying"),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    catid = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    description = table.Column<string>(type: "text", nullable: false),
                    custombannercode = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    sticky = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    metakey = table.Column<string>(type: "text", nullable: false),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    own_prefix = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    metakey_prefix = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    purchase_type = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "'-1'::integer"),
                    track_clicks = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "'-1'::integer"),
                    track_impressions = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "'-1'::integer"),
                    checked_out = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_up = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_down = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    reset = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying"),
                    created_by = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    created_by_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_by = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    version = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_banners_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    asset_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "FK to the #__assets table."),
                    parent_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    lft = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    rgt = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    level = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    path = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    extension = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying"),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    description = table.Column<string>(type: "text", nullable: true),
                    published = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    checked_out = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    @params = table.Column<string>(name: "params", type: "text", nullable: true),
                    metadesc = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false, defaultValueSql: "''::character varying", comment: "The meta description for the page."),
                    metakey = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false, defaultValueSql: "''::character varying", comment: "The meta keywords for the page."),
                    metadata = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false, defaultValueSql: "''::character varying", comment: "JSON encoded metadata properties."),
                    created_user_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    created_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_user_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    modified_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    hits = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying"),
                    version = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_categories_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_contact_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    con_position = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    suburb = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    state = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    country = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    postcode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    telephone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    fax = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    misc = table.Column<string>(type: "text", nullable: true),
                    image = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    email_to = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    default_con = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    published = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    checked_out = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    catid = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    mobile = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    webpage = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    sortname1 = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    sortname2 = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    sortname3 = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created_by = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    created_by_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_by = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    metakey = table.Column<string>(type: "text", nullable: false),
                    metadesc = table.Column<string>(type: "text", nullable: false),
                    metadata = table.Column<string>(type: "text", nullable: false),
                    featured = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0, comment: "Set if contact is featured."),
                    xreference = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying", comment: "A reference to enable linkages to external data sets."),
                    publish_up = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_down = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    version = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L),
                    hits = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_contact_details_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_content",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    asset_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "FK to the #__assets table."),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    introtext = table.Column<string>(type: "text", nullable: false),
                    fulltext = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    catid = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created_by = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    created_by_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_by = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    checked_out = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_up = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_down = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    images = table.Column<string>(type: "text", nullable: false),
                    urls = table.Column<string>(type: "text", nullable: false),
                    attribs = table.Column<string>(type: "character varying(5120)", maxLength: 5120, nullable: false),
                    version = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    metakey = table.Column<string>(type: "text", nullable: false),
                    metadesc = table.Column<string>(type: "text", nullable: false),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    hits = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    metadata = table.Column<string>(type: "text", nullable: false),
                    featured = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0, comment: "Set if article is featured."),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying", comment: "The language code for the article."),
                    xreference = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying", comment: "A reference to enable linkages to external data sets."),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_content_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_content_frontpage",
                columns: table => new
                {
                    content_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_content_frontpage_pkey", x => x.content_id);
                });

            migrationBuilder.CreateTable(
                name: "h_content_rating",
                columns: table => new
                {
                    content_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    rating_sum = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    rating_count = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    lastip = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_content_rating_pkey", x => x.content_id);
                });

            migrationBuilder.CreateTable(
                name: "h_content_types",
                columns: table => new
                {
                    type_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    type_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    table = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    rules = table.Column<string>(type: "text", nullable: false),
                    field_mappings = table.Column<string>(type: "text", nullable: false),
                    router = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    content_history_options = table.Column<string>(type: "character varying(5120)", maxLength: 5120, nullable: true, defaultValueSql: "NULL::character varying", comment: "JSON string for com_contenthistory options")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_content_types_pkey", x => x.type_id);
                });

            migrationBuilder.CreateTable(
                name: "h_contentitem_tag_map",
                columns: table => new
                {
                    type_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    core_content_id = table.Column<int>(type: "integer", nullable: false, comment: "PK from the core content table"),
                    content_item_id = table.Column<int>(type: "integer", nullable: false, comment: "PK from the content type table"),
                    tag_id = table.Column<int>(type: "integer", nullable: false, comment: "PK from the tag table"),
                    tag_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone", comment: "Date of most recent save for this tag-item"),
                    type_id = table.Column<int>(type: "integer", nullable: false, comment: "PK from the content_type table")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "h_core_log_searches",
                columns: table => new
                {
                    search_term = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, defaultValueSql: "''::character varying"),
                    hits = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "h_extensions",
                columns: table => new
                {
                    extension_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    package_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Parent package ID for extensions installed as a package."),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    type = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    element = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    folder = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    client_id = table.Column<short>(type: "smallint", nullable: false),
                    enabled = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L),
                    @protected = table.Column<short>(name: "protected", type: "smallint", nullable: false, defaultValue: (short)0),
                    manifest_cache = table.Column<string>(type: "text", nullable: false),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    custom_data = table.Column<string>(type: "text", nullable: false),
                    system_data = table.Column<string>(type: "text", nullable: false),
                    checked_out = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    ordering = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    state = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_extensions_pkey", x => x.extension_id);
                });

            migrationBuilder.CreateTable(
                name: "h_fields",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    asset_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    context = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    group_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    label = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    default_value = table.Column<string>(type: "text", nullable: true),
                    type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "'text'::character varying"),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    description = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    required = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    checked_out = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    fieldparams = table.Column<string>(type: "text", nullable: false),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying"),
                    created_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created_user_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    modified_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_by = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_fields_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_fields_categories",
                columns: table => new
                {
                    field_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    category_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_fields_categories_pkey", x => new { x.field_id, x.category_id });
                });

            migrationBuilder.CreateTable(
                name: "h_fields_groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    asset_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    context = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    description = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    checked_out = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    ordering = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying"),
                    created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created_by = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_by = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_fields_groups_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_fields_values",
                columns: table => new
                {
                    field_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    item_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "h_finder_filters",
                columns: table => new
                {
                    filter_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_by_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_by = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    checked_out = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    map_count = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    data = table.Column<string>(type: "text", nullable: false),
                    @params = table.Column<string>(name: "params", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_filters_pkey", x => x.filter_id);
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    url = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    route = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    title = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: true, defaultValueSql: "NULL::character varying"),
                    description = table.Column<string>(type: "text", nullable: true),
                    indexdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    md5sum = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true, defaultValueSql: "NULL::character varying"),
                    published = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    state = table.Column<int>(type: "integer", nullable: true, defaultValue: 1),
                    access = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    language = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false, defaultValueSql: "''::character varying"),
                    publish_start_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    start_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    list_price = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false),
                    sale_price = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false),
                    type_id = table.Column<long>(type: "bigint", nullable: false),
                    @object = table.Column<byte[]>(name: "object", type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_pkey", x => x.link_id);
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms0",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms0_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms1",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms1_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms2",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms2_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms3",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms3_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms4",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms4_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms5",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms5_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms6",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms6_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms7",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms7_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms8",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms8_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_terms9",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_terms9_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_termsa",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_termsa_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_termsb",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_termsb_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_termsc",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_termsc_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_termsd",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_termsd_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_termse",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_termse_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_links_termsf",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_links_termsf_pkey", x => new { x.link_id, x.term_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_taxonomy",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    access = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    ordering = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_taxonomy_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_finder_taxonomy_map",
                columns: table => new
                {
                    link_id = table.Column<int>(type: "integer", nullable: false),
                    node_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_taxonomy_map_pkey", x => new { x.link_id, x.node_id });
                });

            migrationBuilder.CreateTable(
                name: "h_finder_terms",
                columns: table => new
                {
                    term_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    term = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    stem = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    common = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    phrase = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false),
                    soundex = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    links = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    language = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_terms_pkey", x => x.term_id);
                });

            migrationBuilder.CreateTable(
                name: "h_finder_terms_common",
                columns: table => new
                {
                    term = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    language = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "h_finder_tokens",
                columns: table => new
                {
                    term = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    stem = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    common = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    phrase = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false, defaultValueSql: "1"),
                    context = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)2),
                    language = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "h_finder_tokens_aggregate",
                columns: table => new
                {
                    term_id = table.Column<int>(type: "integer", nullable: false),
                    map_suffix = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    term = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    stem = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    common = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    phrase = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    term_weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false),
                    context = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)2),
                    context_weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false),
                    total_weight = table.Column<decimal>(type: "numeric(8,2)", precision: 8, scale: 2, nullable: false),
                    language = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "h_finder_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    mime = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_finder_types_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_languages",
                columns: table => new
                {
                    lang_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    asset_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    lang_code = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    title_native = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    sef = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    image = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    metakey = table.Column<string>(type: "text", nullable: false),
                    metadesc = table.Column<string>(type: "text", nullable: false),
                    sitename = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false, defaultValueSql: "''::character varying"),
                    published = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    access = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_languages_pkey", x => x.lang_id);
                });

            migrationBuilder.CreateTable(
                name: "h_menu",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    menutype = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: false, comment: "The type of menu this item belongs to. FK to #__menu_types.menutype"),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "The display title of the menu item."),
                    alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "The SEF alias of the menu item."),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    path = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false, defaultValueSql: "''::character varying", comment: "The computed path of the menu item based on the alias field."),
                    link = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false, comment: "The actually link the menu item refers to."),
                    type = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false, comment: "The type of link: Component, URL, Alias, Separator"),
                    published = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0, comment: "The published state of the menu link."),
                    parent_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 1, comment: "The parent menu item in the menu tree."),
                    level = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "The relative level in the tree."),
                    component_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "FK to #__extensions.id"),
                    checked_out = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "FK to #__users.id"),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone", comment: "The time the menu item was checked out."),
                    browserNav = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0, comment: "The click behaviour of the link."),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "The access level required to view the menu item."),
                    img = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying", comment: "The image of the menu item."),
                    template_style_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false, comment: "JSON encoded data for the menu item."),
                    lft = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Nested set lft."),
                    rgt = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Nested set rgt."),
                    home = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0, comment: "Indicates if this menu item is the home or default page."),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying"),
                    client_id = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_menu_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_menu_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    asset_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    menutype = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: false),
                    title = table.Column<string>(type: "character varying(48)", maxLength: 48, nullable: false),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    client_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_menu_types_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_messages",
                columns: table => new
                {
                    message_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id_from = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    user_id_to = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    folder_id = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    date_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    priority = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    subject = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    message = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_messages_pkey", x => x.message_id);
                });

            migrationBuilder.CreateTable(
                name: "h_messages_cfg",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    cfg_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    cfg_value = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "h_modules",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    asset_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    content = table.Column<string>(type: "text", nullable: true),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    position = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying"),
                    checked_out = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_up = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_down = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    published = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    module = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, defaultValueSql: "NULL::character varying"),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    showtitle = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    client_id = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_modules_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_modules_menu",
                columns: table => new
                {
                    moduleid = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    menuid = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_modules_menu_pkey", x => new { x.moduleid, x.menuid });
                });

            migrationBuilder.CreateTable(
                name: "h_newsfeeds",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catid = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    alias = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    link = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false, defaultValueSql: "''::character varying"),
                    published = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    numarticles = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L),
                    cache_time = table.Column<long>(type: "bigint", nullable: false, defaultValue: 3600L),
                    checked_out = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    rtl = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying"),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created_by = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    created_by_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_by = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    metakey = table.Column<string>(type: "text", nullable: false),
                    metadesc = table.Column<string>(type: "text", nullable: false),
                    metadata = table.Column<string>(type: "text", nullable: false),
                    xreference = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying", comment: "A reference to enable linkages to external data sets."),
                    publish_up = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_down = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    description = table.Column<string>(type: "text", nullable: false),
                    version = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L),
                    hits = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    images = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_newsfeeds_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_overrider",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    constant = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    @string = table.Column<string>(name: "string", type: "text", nullable: false),
                    file = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_overrider_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_postinstall_messages",
                columns: table => new
                {
                    postinstall_message_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    extension_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 700L, comment: "FK to jos_extensions"),
                    title_key = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying", comment: "Lang key for the title"),
                    description_key = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying", comment: "Lang key for description"),
                    action_key = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    language_extension = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "'com_postinstall'::character varying", comment: "Extension holding lang keys"),
                    language_client_id = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    type = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false, defaultValueSql: "'link'::character varying", comment: "Message type - message, link, action"),
                    action_file = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, defaultValueSql: "''::character varying", comment: "RAD URI to the PHP file containing action method"),
                    action = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, defaultValueSql: "''::character varying", comment: "Action method name or URL"),
                    condition_file = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, defaultValueSql: "NULL::character varying", comment: "RAD URI to file holding display condition method"),
                    condition_method = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, defaultValueSql: "NULL::character varying", comment: "Display condition method, must return boolean"),
                    version_introduced = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "'3.2.0'::character varying", comment: "Version when this message was introduced"),
                    enabled = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_postinstall_messages_pkey", x => x.postinstall_message_id);
                });

            migrationBuilder.CreateTable(
                name: "h_privacy_consents",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    subject = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    body = table.Column<string>(type: "text", nullable: false),
                    remind = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    token = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_privacy_consents_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_privacy_requests",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    requested_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    request_type = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false, defaultValueSql: "''::character varying"),
                    confirm_token = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    confirm_token_created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_privacy_requests_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_redirect_links",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    old_url = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    new_url = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true),
                    referer = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    comment = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    hits = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    published = table.Column<short>(type: "smallint", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    header = table.Column<int>(type: "integer", nullable: false, defaultValue: 301)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_redirect_links_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_schemas",
                columns: table => new
                {
                    extension_id = table.Column<long>(type: "bigint", nullable: false),
                    version_id = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_schemas_pkey", x => new { x.extension_id, x.version_id });
                });

            migrationBuilder.CreateTable(
                name: "h_session",
                columns: table => new
                {
                    session_id = table.Column<byte[]>(type: "bytea", nullable: false),
                    client_id = table.Column<short>(type: "smallint", nullable: true),
                    guest = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)1),
                    time = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    data = table.Column<string>(type: "text", nullable: true),
                    userid = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    username = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_session_pkey", x => x.session_id);
                });

            migrationBuilder.CreateTable(
                name: "h_tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    lft = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    rgt = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    level = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    path = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    description = table.Column<string>(type: "text", nullable: false),
                    published = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    checked_out = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    metadesc = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    metakey = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    metadata = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    created_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created_by_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    modified_user_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    modified_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    images = table.Column<string>(type: "text", nullable: false),
                    urls = table.Column<string>(type: "text", nullable: false),
                    hits = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying"),
                    version = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L),
                    publish_up = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_down = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_tags_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_template_styles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    template = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying"),
                    client_id = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    home = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "'0'::character varying"),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    inheritable = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    parent = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, defaultValueSql: "''::character varying"),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_template_styles_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_ucm_base",
                columns: table => new
                {
                    ucm_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ucm_item_id = table.Column<long>(type: "bigint", nullable: false),
                    ucm_type_id = table.Column<long>(type: "bigint", nullable: false),
                    ucm_language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_ucm_base_pkey", x => x.ucm_id);
                });

            migrationBuilder.CreateTable(
                name: "h_ucm_content",
                columns: table => new
                {
                    core_content_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    core_type_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    core_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    core_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    core_body = table.Column<string>(type: "text", nullable: true),
                    core_state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    core_checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    core_checked_out_user_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    core_access = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    core_params = table.Column<string>(type: "text", nullable: true),
                    core_featured = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    core_metadata = table.Column<string>(type: "text", nullable: true),
                    core_created_user_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    core_created_by_alias = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    core_created_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    core_modified_user_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    core_modified_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    core_language = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false, defaultValueSql: "''::character varying"),
                    core_publish_up = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    core_publish_down = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    core_content_item_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    asset_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    core_images = table.Column<string>(type: "text", nullable: true),
                    core_urls = table.Column<string>(type: "text", nullable: true),
                    core_hits = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    core_version = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L),
                    core_ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    core_metakey = table.Column<string>(type: "text", nullable: true),
                    core_metadesc = table.Column<string>(type: "text", nullable: true),
                    core_catid = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    core_xreference = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying"),
                    core_type_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_ucm_content_pkey", x => x.core_content_id);
                });

            migrationBuilder.CreateTable(
                name: "h_ucm_history",
                columns: table => new
                {
                    version_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ucm_item_id = table.Column<int>(type: "integer", nullable: false),
                    ucm_type_id = table.Column<int>(type: "integer", nullable: false),
                    version_note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying", comment: "Optional version name"),
                    save_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00+00'::timestamp with time zone"),
                    editor_user_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    character_count = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "Number of characters in this version."),
                    sha1_hash = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValueSql: "''::character varying", comment: "SHA1 hash of the version_data column."),
                    version_data = table.Column<string>(type: "text", nullable: false, comment: "json-encoded string of version data"),
                    keep_forever = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0, comment: "0=auto delete; 1=keep")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_ucm_history_pkey", x => x.version_id);
                });

            migrationBuilder.CreateTable(
                name: "h_update_sites",
                columns: table => new
                {
                    update_site_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, defaultValueSql: "''::character varying"),
                    type = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true, defaultValueSql: "''::character varying"),
                    location = table.Column<string>(type: "text", nullable: false),
                    enabled = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    last_check_timestamp = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    extra_query = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_update_sites_pkey", x => x.update_site_id);
                },
                comment: "Update Sites");

            migrationBuilder.CreateTable(
                name: "h_update_sites_extensions",
                columns: table => new
                {
                    update_site_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    extension_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_update_sites_extensions_pkey", x => new { x.update_site_id, x.extension_id });
                },
                comment: "Links extensions to update sites");

            migrationBuilder.CreateTable(
                name: "h_updates",
                columns: table => new
                {
                    update_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    update_site_id = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    extension_id = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, defaultValueSql: "''::character varying"),
                    description = table.Column<string>(type: "text", nullable: false),
                    element = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, defaultValueSql: "''::character varying"),
                    type = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true, defaultValueSql: "''::character varying"),
                    folder = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true, defaultValueSql: "''::character varying"),
                    client_id = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    version = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true, defaultValueSql: "''::character varying"),
                    data = table.Column<string>(type: "text", nullable: false),
                    detailsurl = table.Column<string>(type: "text", nullable: false),
                    infourl = table.Column<string>(type: "text", nullable: false),
                    extra_query = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_updates_pkey", x => x.update_id);
                },
                comment: "Available Updates");

            migrationBuilder.CreateTable(
                name: "h_user_keys",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    token = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    invalid = table.Column<short>(type: "smallint", nullable: false),
                    time = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    uastring = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_user_keys_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_user_notes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    catid = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    subject = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    body = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    checked_out = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    checked_out_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    created_user_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    created_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    modified_user_id = table.Column<int>(type: "integer", nullable: false),
                    modified_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    review_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_up = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    publish_down = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_user_notes_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_user_profiles",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    profile_key = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    profile_value = table.Column<string>(type: "text", nullable: false),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                },
                comment: "Simple user profile storage table");

            migrationBuilder.CreateTable(
                name: "h_user_usergroup_map",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Foreign Key to #__users.id"),
                    group_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Foreign Key to #__usergroups.id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_user_usergroup_map_pkey", x => new { x.user_id, x.group_id });
                });

            migrationBuilder.CreateTable(
                name: "h_usergroups",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Adjacency List Reference Id"),
                    lft = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Nested set lft."),
                    rgt = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Nested set rgt."),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_usergroups_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, defaultValueSql: "''::character varying"),
                    username = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false, defaultValueSql: "''::character varying"),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    block = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    sendEmail = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    registerDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    lastvisitDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone"),
                    activation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    lastResetTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'::timestamp without time zone", comment: "Date of last password reset"),
                    resetCount = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L, comment: "Count of password resets since lastResetTime"),
                    otpKey = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false, defaultValueSql: "''::character varying"),
                    otep = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false, defaultValueSql: "''::character varying"),
                    requireReset = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0, comment: "Require user to reset password on next login")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_users_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "h_viewlevels",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, defaultValueSql: "''::character varying"),
                    ordering = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    rules = table.Column<string>(type: "character varying(5120)", maxLength: 5120, nullable: false, comment: "JSON encoded access control.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("h_viewlevels_pkey", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "h_action_logs_idx_extension_itemid",
                table: "h_action_logs",
                columns: new[] { "extension", "item_id" });

            migrationBuilder.CreateIndex(
                name: "h_action_logs_idx_user_id",
                table: "h_action_logs",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "h_action_logs_idx_user_id_extension",
                table: "h_action_logs",
                columns: new[] { "user_id", "extension" });

            migrationBuilder.CreateIndex(
                name: "h_action_logs_idx_user_id_logdate",
                table: "h_action_logs",
                columns: new[] { "user_id", "log_date" });

            migrationBuilder.CreateIndex(
                name: "h_action_logs_users_idx_notify",
                table: "h_action_logs_users",
                column: "notify");

            migrationBuilder.CreateIndex(
                name: "h_assets_idx_asset_name",
                table: "h_assets",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_assets_idx_lft_rgt",
                table: "h_assets",
                columns: new[] { "lft", "rgt" });

            migrationBuilder.CreateIndex(
                name: "h_assets_idx_parent_id",
                table: "h_assets",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "h_associations_idx_key",
                table: "h_associations",
                column: "key");

            migrationBuilder.CreateIndex(
                name: "h_banner_clients_idx_metakey_prefix",
                table: "h_banner_clients",
                column: "metakey_prefix");

            migrationBuilder.CreateIndex(
                name: "h_banner_clients_idx_own_prefix",
                table: "h_banner_clients",
                column: "own_prefix");

            migrationBuilder.CreateIndex(
                name: "h_banner_tracks_idx_banner_id",
                table: "h_banner_tracks",
                column: "banner_id");

            migrationBuilder.CreateIndex(
                name: "h_banner_tracks_idx_track_date",
                table: "h_banner_tracks",
                column: "track_date");

            migrationBuilder.CreateIndex(
                name: "h_banner_tracks_idx_track_type",
                table: "h_banner_tracks",
                column: "track_type");

            migrationBuilder.CreateIndex(
                name: "h_banners_idx_banner_catid",
                table: "h_banners",
                column: "catid");

            migrationBuilder.CreateIndex(
                name: "h_banners_idx_language",
                table: "h_banners",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_banners_idx_metakey_prefix",
                table: "h_banners",
                column: "metakey_prefix");

            migrationBuilder.CreateIndex(
                name: "h_banners_idx_own_prefix",
                table: "h_banners",
                column: "own_prefix");

            migrationBuilder.CreateIndex(
                name: "h_banners_idx_state",
                table: "h_banners",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "h_categories_cat_idx",
                table: "h_categories",
                columns: new[] { "extension", "published", "access" });

            migrationBuilder.CreateIndex(
                name: "h_categories_idx_access",
                table: "h_categories",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_categories_idx_alias",
                table: "h_categories",
                column: "alias");

            migrationBuilder.CreateIndex(
                name: "h_categories_idx_checkout",
                table: "h_categories",
                column: "checked_out");

            migrationBuilder.CreateIndex(
                name: "h_categories_idx_language",
                table: "h_categories",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_categories_idx_left_right",
                table: "h_categories",
                columns: new[] { "lft", "rgt" });

            migrationBuilder.CreateIndex(
                name: "h_categories_idx_path",
                table: "h_categories",
                column: "path");

            migrationBuilder.CreateIndex(
                name: "h_contact_details_idx_access",
                table: "h_contact_details",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_contact_details_idx_catid",
                table: "h_contact_details",
                column: "catid");

            migrationBuilder.CreateIndex(
                name: "h_contact_details_idx_checkout",
                table: "h_contact_details",
                column: "checked_out");

            migrationBuilder.CreateIndex(
                name: "h_contact_details_idx_createdby",
                table: "h_contact_details",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "h_contact_details_idx_featured_catid",
                table: "h_contact_details",
                columns: new[] { "featured", "catid" });

            migrationBuilder.CreateIndex(
                name: "h_contact_details_idx_language",
                table: "h_contact_details",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_contact_details_idx_state",
                table: "h_contact_details",
                column: "published");

            migrationBuilder.CreateIndex(
                name: "h_contact_details_idx_xreference",
                table: "h_contact_details",
                column: "xreference");

            migrationBuilder.CreateIndex(
                name: "h_content_idx_access",
                table: "h_content",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_content_idx_alias",
                table: "h_content",
                column: "alias");

            migrationBuilder.CreateIndex(
                name: "h_content_idx_catid",
                table: "h_content",
                column: "catid");

            migrationBuilder.CreateIndex(
                name: "h_content_idx_checkout",
                table: "h_content",
                column: "checked_out");

            migrationBuilder.CreateIndex(
                name: "h_content_idx_createdby",
                table: "h_content",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "h_content_idx_featured_catid",
                table: "h_content",
                columns: new[] { "featured", "catid" });

            migrationBuilder.CreateIndex(
                name: "h_content_idx_language",
                table: "h_content",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_content_idx_state",
                table: "h_content",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "h_content_idx_xreference",
                table: "h_content",
                column: "xreference");

            migrationBuilder.CreateIndex(
                name: "h_content_types_idx_alias",
                table: "h_content_types",
                column: "type_alias");

            migrationBuilder.CreateIndex(
                name: "h_contentitem_tag_map_idx_core_content_id",
                table: "h_contentitem_tag_map",
                column: "core_content_id");

            migrationBuilder.CreateIndex(
                name: "h_contentitem_tag_map_idx_date_id",
                table: "h_contentitem_tag_map",
                columns: new[] { "tag_date", "tag_id" });

            migrationBuilder.CreateIndex(
                name: "h_contentitem_tag_map_idx_tag_type",
                table: "h_contentitem_tag_map",
                columns: new[] { "tag_id", "type_id" });

            migrationBuilder.CreateIndex(
                name: "h_uc_ItemnameTagid",
                table: "h_contentitem_tag_map",
                columns: new[] { "type_id", "content_item_id", "tag_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_extensions_element_clientid",
                table: "h_extensions",
                columns: new[] { "element", "client_id" });

            migrationBuilder.CreateIndex(
                name: "h_extensions_element_folder_clientid",
                table: "h_extensions",
                columns: new[] { "element", "folder", "client_id" });

            migrationBuilder.CreateIndex(
                name: "h_extensions_extension",
                table: "h_extensions",
                columns: new[] { "type", "element", "folder", "client_id" });

            migrationBuilder.CreateIndex(
                name: "h_fields_idx_access",
                table: "h_fields",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_fields_idx_checked_out",
                table: "h_fields",
                column: "checked_out");

            migrationBuilder.CreateIndex(
                name: "h_fields_idx_context",
                table: "h_fields",
                column: "context");

            migrationBuilder.CreateIndex(
                name: "h_fields_idx_created_user_id",
                table: "h_fields",
                column: "created_user_id");

            migrationBuilder.CreateIndex(
                name: "h_fields_idx_language",
                table: "h_fields",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_fields_idx_state",
                table: "h_fields",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "h_fields_groups_idx_access",
                table: "h_fields_groups",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_fields_groups_idx_checked_out",
                table: "h_fields_groups",
                column: "checked_out");

            migrationBuilder.CreateIndex(
                name: "h_fields_groups_idx_context",
                table: "h_fields_groups",
                column: "context");

            migrationBuilder.CreateIndex(
                name: "h_fields_groups_idx_created_by",
                table: "h_fields_groups",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "h_fields_groups_idx_language",
                table: "h_fields_groups",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_fields_groups_idx_state",
                table: "h_fields_groups",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "h_fields_values_idx_field_id",
                table: "h_fields_values",
                column: "field_id");

            migrationBuilder.CreateIndex(
                name: "h_fields_values_idx_item_id",
                table: "h_fields_values",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "h_finder_links_idx_md5",
                table: "h_finder_links",
                column: "md5sum");

            migrationBuilder.CreateIndex(
                name: "h_finder_links_idx_published_list",
                table: "h_finder_links",
                columns: new[] { "published", "state", "access", "publish_start_date", "publish_end_date", "list_price" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_idx_published_sale",
                table: "h_finder_links",
                columns: new[] { "published", "state", "access", "publish_start_date", "publish_end_date", "sale_price" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_idx_title",
                table: "h_finder_links",
                column: "title");

            migrationBuilder.CreateIndex(
                name: "h_finder_links_idx_type",
                table: "h_finder_links",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms0_idx_link_term_weight",
                table: "h_finder_links_terms0",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms0_idx_term_weight",
                table: "h_finder_links_terms0",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms1_idx_link_term_weight",
                table: "h_finder_links_terms1",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms1_idx_term_weight",
                table: "h_finder_links_terms1",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms2_idx_link_term_weight",
                table: "h_finder_links_terms2",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms2_idx_term_weight",
                table: "h_finder_links_terms2",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms3_idx_link_term_weight",
                table: "h_finder_links_terms3",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms3_idx_term_weight",
                table: "h_finder_links_terms3",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms4_idx_link_term_weight",
                table: "h_finder_links_terms4",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms4_idx_term_weight",
                table: "h_finder_links_terms4",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms5_idx_link_term_weight",
                table: "h_finder_links_terms5",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms5_idx_term_weight",
                table: "h_finder_links_terms5",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms6_idx_link_term_weight",
                table: "h_finder_links_terms6",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms6_idx_term_weight",
                table: "h_finder_links_terms6",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms7_idx_link_term_weight",
                table: "h_finder_links_terms7",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms7_idx_term_weight",
                table: "h_finder_links_terms7",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms8_idx_link_term_weight",
                table: "h_finder_links_terms8",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms8_idx_term_weight",
                table: "h_finder_links_terms8",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms9_idx_link_term_weight",
                table: "h_finder_links_terms9",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_terms9_idx_term_weight",
                table: "h_finder_links_terms9",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsa_idx_link_term_weight",
                table: "h_finder_links_termsa",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsa_idx_term_weight",
                table: "h_finder_links_termsa",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsb_idx_link_term_weight",
                table: "h_finder_links_termsb",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsb_idx_term_weight",
                table: "h_finder_links_termsb",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsc_idx_link_term_weight",
                table: "h_finder_links_termsc",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsc_idx_term_weight",
                table: "h_finder_links_termsc",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsd_idx_link_term_weight",
                table: "h_finder_links_termsd",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsd_idx_term_weight",
                table: "h_finder_links_termsd",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termse_idx_link_term_weight",
                table: "h_finder_links_termse",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termse_idx_term_weight",
                table: "h_finder_links_termse",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsf_idx_link_term_weight",
                table: "h_finder_links_termsf",
                columns: new[] { "link_id", "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_links_termsf_idx_term_weight",
                table: "h_finder_links_termsf",
                columns: new[] { "term_id", "weight" });

            migrationBuilder.CreateIndex(
                name: "h_finder_taxonomy_access",
                table: "h_finder_taxonomy",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_finder_taxonomy_idx_parent_published",
                table: "h_finder_taxonomy",
                columns: new[] { "parent_id", "state", "access" });

            migrationBuilder.CreateIndex(
                name: "h_finder_taxonomy_ordering",
                table: "h_finder_taxonomy",
                column: "ordering");

            migrationBuilder.CreateIndex(
                name: "h_finder_taxonomy_parent_id",
                table: "h_finder_taxonomy",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "h_finder_taxonomy_state",
                table: "h_finder_taxonomy",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "h_finder_taxonomy_map_link_id",
                table: "h_finder_taxonomy_map",
                column: "link_id");

            migrationBuilder.CreateIndex(
                name: "h_finder_taxonomy_map_node_id",
                table: "h_finder_taxonomy_map",
                column: "node_id");

            migrationBuilder.CreateIndex(
                name: "h_finder_terms_idx_soundex_phrase",
                table: "h_finder_terms",
                columns: new[] { "soundex", "phrase" });

            migrationBuilder.CreateIndex(
                name: "h_finder_terms_idx_stem_phrase",
                table: "h_finder_terms",
                columns: new[] { "stem", "phrase" });

            migrationBuilder.CreateIndex(
                name: "h_finder_terms_idx_term",
                table: "h_finder_terms",
                column: "term",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_finder_terms_idx_term_phrase",
                table: "h_finder_terms",
                columns: new[] { "term", "phrase" });

            migrationBuilder.CreateIndex(
                name: "h_finder_terms_common_idx_lang",
                table: "h_finder_terms_common",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_finder_terms_common_idx_word_lang",
                table: "h_finder_terms_common",
                columns: new[] { "term", "language" });

            migrationBuilder.CreateIndex(
                name: "h_finder_tokens_idx_context",
                table: "h_finder_tokens",
                column: "context");

            migrationBuilder.CreateIndex(
                name: "h_finder_tokens_idx_word",
                table: "h_finder_tokens",
                column: "term");

            migrationBuilder.CreateIndex(
                name: "_h_finder_tokens_aggregate_keyword_id",
                table: "h_finder_tokens_aggregate",
                column: "term_id");

            migrationBuilder.CreateIndex(
                name: "h_finder_tokens_aggregate_token",
                table: "h_finder_tokens_aggregate",
                column: "term");

            migrationBuilder.CreateIndex(
                name: "h_finder_types_title",
                table: "h_finder_types",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_languages_idx_access",
                table: "h_languages",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_languages_idx_langcode",
                table: "h_languages",
                column: "lang_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_languages_idx_ordering",
                table: "h_languages",
                column: "ordering");

            migrationBuilder.CreateIndex(
                name: "h_languages_idx_sef",
                table: "h_languages",
                column: "sef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_menu_idx_alias",
                table: "h_menu",
                column: "alias");

            migrationBuilder.CreateIndex(
                name: "h_menu_idx_client_id_parent_id_alias_language",
                table: "h_menu",
                columns: new[] { "client_id", "parent_id", "alias", "language" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_menu_idx_componentid",
                table: "h_menu",
                columns: new[] { "component_id", "menutype", "published", "access" });

            migrationBuilder.CreateIndex(
                name: "h_menu_idx_language",
                table: "h_menu",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_menu_idx_left_right",
                table: "h_menu",
                columns: new[] { "lft", "rgt" });

            migrationBuilder.CreateIndex(
                name: "h_menu_idx_menutype",
                table: "h_menu",
                column: "menutype");

            migrationBuilder.CreateIndex(
                name: "h_menu_idx_path",
                table: "h_menu",
                column: "path");

            migrationBuilder.CreateIndex(
                name: "h_menu_types_idx_menutype",
                table: "h_menu_types",
                column: "menutype",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_messages_useridto_state",
                table: "h_messages",
                columns: new[] { "user_id_to", "state" });

            migrationBuilder.CreateIndex(
                name: "h_messages_cfg_idx_user_var_name",
                table: "h_messages_cfg",
                columns: new[] { "user_id", "cfg_name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_modules_idx_language",
                table: "h_modules",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_modules_newsfeeds",
                table: "h_modules",
                columns: new[] { "module", "published" });

            migrationBuilder.CreateIndex(
                name: "h_modules_published",
                table: "h_modules",
                columns: new[] { "published", "access" });

            migrationBuilder.CreateIndex(
                name: "h_newsfeeds_idx_access",
                table: "h_newsfeeds",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_newsfeeds_idx_catid",
                table: "h_newsfeeds",
                column: "catid");

            migrationBuilder.CreateIndex(
                name: "h_newsfeeds_idx_checkout",
                table: "h_newsfeeds",
                column: "checked_out");

            migrationBuilder.CreateIndex(
                name: "h_newsfeeds_idx_createdby",
                table: "h_newsfeeds",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "h_newsfeeds_idx_language",
                table: "h_newsfeeds",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_newsfeeds_idx_state",
                table: "h_newsfeeds",
                column: "published");

            migrationBuilder.CreateIndex(
                name: "h_newsfeeds_idx_xreference",
                table: "h_newsfeeds",
                column: "xreference");

            migrationBuilder.CreateIndex(
                name: "h_privacy_consents_idx_user_id",
                table: "h_privacy_consents",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "h_redirect_links_idx_link_modifed",
                table: "h_redirect_links",
                column: "modified_date");

            migrationBuilder.CreateIndex(
                name: "h_redirect_links_idx_old_url",
                table: "h_redirect_links",
                column: "old_url");

            migrationBuilder.CreateIndex(
                name: "h_session_idx_client_id_guest",
                table: "h_session",
                columns: new[] { "client_id", "guest" });

            migrationBuilder.CreateIndex(
                name: "h_session_time",
                table: "h_session",
                column: "time");

            migrationBuilder.CreateIndex(
                name: "h_session_userid",
                table: "h_session",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "h_tags_cat_idx",
                table: "h_tags",
                columns: new[] { "published", "access" });

            migrationBuilder.CreateIndex(
                name: "h_tags_idx_access",
                table: "h_tags",
                column: "access");

            migrationBuilder.CreateIndex(
                name: "h_tags_idx_alias",
                table: "h_tags",
                column: "alias");

            migrationBuilder.CreateIndex(
                name: "h_tags_idx_checkout",
                table: "h_tags",
                column: "checked_out");

            migrationBuilder.CreateIndex(
                name: "h_tags_idx_language",
                table: "h_tags",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "h_tags_idx_left_right",
                table: "h_tags",
                columns: new[] { "lft", "rgt" });

            migrationBuilder.CreateIndex(
                name: "h_tags_idx_path",
                table: "h_tags",
                column: "path");

            migrationBuilder.CreateIndex(
                name: "h_template_styles_idx_client_id",
                table: "h_template_styles",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "h_template_styles_idx_client_id_home",
                table: "h_template_styles",
                columns: new[] { "client_id", "home" });

            migrationBuilder.CreateIndex(
                name: "h_template_styles_idx_template",
                table: "h_template_styles",
                column: "template");

            migrationBuilder.CreateIndex(
                name: "h_ucm_base_ucm_item_id",
                table: "h_ucm_base",
                column: "ucm_item_id");

            migrationBuilder.CreateIndex(
                name: "h_ucm_base_ucm_language_id",
                table: "h_ucm_base",
                column: "ucm_language_id");

            migrationBuilder.CreateIndex(
                name: "h_ucm_base_ucm_type_id",
                table: "h_ucm_base",
                column: "ucm_type_id");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_access",
                table: "h_ucm_content",
                column: "core_access");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_alias",
                table: "h_ucm_content",
                column: "core_alias");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_content_type",
                table: "h_ucm_content",
                column: "core_type_alias");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_core_checked_out_user_id",
                table: "h_ucm_content",
                column: "core_checked_out_user_id");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_core_created_user_id",
                table: "h_ucm_content",
                column: "core_created_user_id");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_core_modified_user_id",
                table: "h_ucm_content",
                column: "core_modified_user_id");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_core_type_id",
                table: "h_ucm_content",
                column: "core_type_id");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_created_time",
                table: "h_ucm_content",
                column: "core_created_time");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_language",
                table: "h_ucm_content",
                column: "core_language");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_modified_time",
                table: "h_ucm_content",
                column: "core_modified_time");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_title",
                table: "h_ucm_content",
                column: "core_title");

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_idx_type_alias_item_id",
                table: "h_ucm_content",
                columns: new[] { "core_type_alias", "core_content_item_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_ucm_content_tag_idx",
                table: "h_ucm_content",
                columns: new[] { "core_state", "core_access" });

            migrationBuilder.CreateIndex(
                name: "h_ucm_history_idx_save_date",
                table: "h_ucm_history",
                column: "save_date");

            migrationBuilder.CreateIndex(
                name: "h_ucm_history_idx_ucm_item_id",
                table: "h_ucm_history",
                columns: new[] { "ucm_type_id", "ucm_item_id" });

            migrationBuilder.CreateIndex(
                name: "h_user_keys_idx_user_id",
                table: "h_user_keys",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "h_user_keys_series",
                table: "h_user_keys",
                column: "series",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_user_notes_idx_category_id",
                table: "h_user_notes",
                column: "catid");

            migrationBuilder.CreateIndex(
                name: "h_user_notes_idx_user_id",
                table: "h_user_notes",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "h_user_profiles_idx_user_id_profile_key",
                table: "h_user_profiles",
                columns: new[] { "user_id", "profile_key" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_usergroups_idx_usergroup_adjacency_lookup",
                table: "h_usergroups",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "h_usergroups_idx_usergroup_nested_set_lookup",
                table: "h_usergroups",
                columns: new[] { "lft", "rgt" });

            migrationBuilder.CreateIndex(
                name: "h_usergroups_idx_usergroup_parent_title_lookup",
                table: "h_usergroups",
                columns: new[] { "parent_id", "title" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_usergroups_idx_usergroup_title_lookup",
                table: "h_usergroups",
                column: "title");

            migrationBuilder.CreateIndex(
                name: "h_users_email",
                table: "h_users",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "h_users_idx_block",
                table: "h_users",
                column: "block");

            migrationBuilder.CreateIndex(
                name: "h_users_idx_name",
                table: "h_users",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "h_users_idx_username",
                table: "h_users",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "h_viewlevels_idx_assetgroup_title_lookup",
                table: "h_viewlevels",
                column: "title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gaccounts");

            migrationBuilder.DropTable(
                name: "gapps");

            migrationBuilder.DropTable(
                name: "gapptype");

            migrationBuilder.DropTable(
                name: "gbranches");

            migrationBuilder.DropTable(
                name: "gbregions");

            migrationBuilder.DropTable(
                name: "gchange");

            migrationBuilder.DropTable(
                name: "gchannels");

            migrationBuilder.DropTable(
                name: "gchanneltype");

            migrationBuilder.DropTable(
                name: "gcircuits");

            migrationBuilder.DropTable(
                name: "gcircuittype");

            migrationBuilder.DropTable(
                name: "gcompany");

            migrationBuilder.DropTable(
                name: "gcomputer");

            migrationBuilder.DropTable(
                name: "gconduits");

            migrationBuilder.DropTable(
                name: "gcountry");

            migrationBuilder.DropTable(
                name: "gcpeother");

            migrationBuilder.DropTable(
                name: "gcpetype");

            migrationBuilder.DropTable(
                name: "gcustomer");

            migrationBuilder.DropTable(
                name: "gdataservices");

            migrationBuilder.DropTable(
                name: "gdbmsreleases");

            migrationBuilder.DropTable(
                name: "gdbmsreplication");

            migrationBuilder.DropTable(
                name: "gdbmstopology");

            migrationBuilder.DropTable(
                name: "gdbmstype");

            migrationBuilder.DropTable(
                name: "gdbmsvendors");

            migrationBuilder.DropTable(
                name: "gdisk");

            migrationBuilder.DropTable(
                name: "gdisktype");

            migrationBuilder.DropTable(
                name: "gdservicetype");

            migrationBuilder.DropTable(
                name: "gemployees");

            migrationBuilder.DropTable(
                name: "gengineregions");

            migrationBuilder.DropTable(
                name: "gfax");

            migrationBuilder.DropTable(
                name: "gfirewallcontexts");

            migrationBuilder.DropTable(
                name: "gfirewalls");

            migrationBuilder.DropTable(
                name: "ggateways");

            migrationBuilder.DropTable(
                name: "ggatewaytype");

            migrationBuilder.DropTable(
                name: "ggridnodes");

            migrationBuilder.DropTable(
                name: "ggridroots");

            migrationBuilder.DropTable(
                name: "ggrids");

            migrationBuilder.DropTable(
                name: "ggridtopology");

            migrationBuilder.DropTable(
                name: "ghdvideo");

            migrationBuilder.DropTable(
                name: "ghostimages");

            migrationBuilder.DropTable(
                name: "ghostlpars");

            migrationBuilder.DropTable(
                name: "ghosts");

            migrationBuilder.DropTable(
                name: "ghostvms");

            migrationBuilder.DropTable(
                name: "ghregions");

            migrationBuilder.DropTable(
                name: "ginventory");

            migrationBuilder.DropTable(
                name: "ginventorytype");

            migrationBuilder.DropTable(
                name: "gitsm");

            migrationBuilder.DropTable(
                name: "gitsm_detail");

            migrationBuilder.DropTable(
                name: "glayer2switches");

            migrationBuilder.DropTable(
                name: "glicensetype");

            migrationBuilder.DropTable(
                name: "gmanagers");

            migrationBuilder.DropTable(
                name: "gnetworks");

            migrationBuilder.DropTable(
                name: "gnetworksplicebox");

            migrationBuilder.DropTable(
                name: "gnetworktype");

            migrationBuilder.DropTable(
                name: "gopticalring");

            migrationBuilder.DropTable(
                name: "gopticalsegments");

            migrationBuilder.DropTable(
                name: "gopttype");

            migrationBuilder.DropTable(
                name: "gphones");

            migrationBuilder.DropTable(
                name: "gphysicalpar");

            migrationBuilder.DropTable(
                name: "gproducts");

            migrationBuilder.DropTable(
                name: "grightofway");

            migrationBuilder.DropTable(
                name: "grouters");

            migrationBuilder.DropTable(
                name: "gsecvideo");

            migrationBuilder.DropTable(
                name: "gservers");

            migrationBuilder.DropTable(
                name: "gserviceorderdetail");

            migrationBuilder.DropTable(
                name: "gserviceorders");

            migrationBuilder.DropTable(
                name: "gserviceordertype");

            migrationBuilder.DropTable(
                name: "gsites");

            migrationBuilder.DropTable(
                name: "gsitetype");

            migrationBuilder.DropTable(
                name: "gsoftwarelicenses");

            migrationBuilder.DropTable(
                name: "gswitches");

            migrationBuilder.DropTable(
                name: "gtelephonenumber");

            migrationBuilder.DropTable(
                name: "gtrunks");

            migrationBuilder.DropTable(
                name: "gtrunktype");

            migrationBuilder.DropTable(
                name: "gusergroups");

            migrationBuilder.DropTable(
                name: "gusers");

            migrationBuilder.DropTable(
                name: "gusers_cards");

            migrationBuilder.DropTable(
                name: "gvendor");

            migrationBuilder.DropTable(
                name: "gvoicegateway");

            migrationBuilder.DropTable(
                name: "gvoiceplatforms");

            migrationBuilder.DropTable(
                name: "gvoiceplatformtype");

            migrationBuilder.DropTable(
                name: "gvoiceservices");

            migrationBuilder.DropTable(
                name: "gvoicetrunks");

            migrationBuilder.DropTable(
                name: "gvoicetrunktype");

            migrationBuilder.DropTable(
                name: "gvolumes");

            migrationBuilder.DropTable(
                name: "gvpns");

            migrationBuilder.DropTable(
                name: "gvpntype");

            migrationBuilder.DropTable(
                name: "gvservicetype");

            migrationBuilder.DropTable(
                name: "gwholesalers");

            migrationBuilder.DropTable(
                name: "gworkorders");

            migrationBuilder.DropTable(
                name: "gworktype");

            migrationBuilder.DropTable(
                name: "h_action_log_config");

            migrationBuilder.DropTable(
                name: "h_action_logs");

            migrationBuilder.DropTable(
                name: "h_action_logs_extensions");

            migrationBuilder.DropTable(
                name: "h_action_logs_users");

            migrationBuilder.DropTable(
                name: "h_assets");

            migrationBuilder.DropTable(
                name: "h_associations");

            migrationBuilder.DropTable(
                name: "h_banner_clients");

            migrationBuilder.DropTable(
                name: "h_banner_tracks");

            migrationBuilder.DropTable(
                name: "h_banners");

            migrationBuilder.DropTable(
                name: "h_categories");

            migrationBuilder.DropTable(
                name: "h_contact_details");

            migrationBuilder.DropTable(
                name: "h_content");

            migrationBuilder.DropTable(
                name: "h_content_frontpage");

            migrationBuilder.DropTable(
                name: "h_content_rating");

            migrationBuilder.DropTable(
                name: "h_content_types");

            migrationBuilder.DropTable(
                name: "h_contentitem_tag_map");

            migrationBuilder.DropTable(
                name: "h_core_log_searches");

            migrationBuilder.DropTable(
                name: "h_extensions");

            migrationBuilder.DropTable(
                name: "h_fields");

            migrationBuilder.DropTable(
                name: "h_fields_categories");

            migrationBuilder.DropTable(
                name: "h_fields_groups");

            migrationBuilder.DropTable(
                name: "h_fields_values");

            migrationBuilder.DropTable(
                name: "h_finder_filters");

            migrationBuilder.DropTable(
                name: "h_finder_links");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms0");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms1");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms2");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms3");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms4");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms5");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms6");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms7");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms8");

            migrationBuilder.DropTable(
                name: "h_finder_links_terms9");

            migrationBuilder.DropTable(
                name: "h_finder_links_termsa");

            migrationBuilder.DropTable(
                name: "h_finder_links_termsb");

            migrationBuilder.DropTable(
                name: "h_finder_links_termsc");

            migrationBuilder.DropTable(
                name: "h_finder_links_termsd");

            migrationBuilder.DropTable(
                name: "h_finder_links_termse");

            migrationBuilder.DropTable(
                name: "h_finder_links_termsf");

            migrationBuilder.DropTable(
                name: "h_finder_taxonomy");

            migrationBuilder.DropTable(
                name: "h_finder_taxonomy_map");

            migrationBuilder.DropTable(
                name: "h_finder_terms");

            migrationBuilder.DropTable(
                name: "h_finder_terms_common");

            migrationBuilder.DropTable(
                name: "h_finder_tokens");

            migrationBuilder.DropTable(
                name: "h_finder_tokens_aggregate");

            migrationBuilder.DropTable(
                name: "h_finder_types");

            migrationBuilder.DropTable(
                name: "h_languages");

            migrationBuilder.DropTable(
                name: "h_menu");

            migrationBuilder.DropTable(
                name: "h_menu_types");

            migrationBuilder.DropTable(
                name: "h_messages");

            migrationBuilder.DropTable(
                name: "h_messages_cfg");

            migrationBuilder.DropTable(
                name: "h_modules");

            migrationBuilder.DropTable(
                name: "h_modules_menu");

            migrationBuilder.DropTable(
                name: "h_newsfeeds");

            migrationBuilder.DropTable(
                name: "h_overrider");

            migrationBuilder.DropTable(
                name: "h_postinstall_messages");

            migrationBuilder.DropTable(
                name: "h_privacy_consents");

            migrationBuilder.DropTable(
                name: "h_privacy_requests");

            migrationBuilder.DropTable(
                name: "h_redirect_links");

            migrationBuilder.DropTable(
                name: "h_schemas");

            migrationBuilder.DropTable(
                name: "h_session");

            migrationBuilder.DropTable(
                name: "h_tags");

            migrationBuilder.DropTable(
                name: "h_template_styles");

            migrationBuilder.DropTable(
                name: "h_ucm_base");

            migrationBuilder.DropTable(
                name: "h_ucm_content");

            migrationBuilder.DropTable(
                name: "h_ucm_history");

            migrationBuilder.DropTable(
                name: "h_update_sites");

            migrationBuilder.DropTable(
                name: "h_update_sites_extensions");

            migrationBuilder.DropTable(
                name: "h_updates");

            migrationBuilder.DropTable(
                name: "h_user_keys");

            migrationBuilder.DropTable(
                name: "h_user_notes");

            migrationBuilder.DropTable(
                name: "h_user_profiles");

            migrationBuilder.DropTable(
                name: "h_user_usergroup_map");

            migrationBuilder.DropTable(
                name: "h_usergroups");

            migrationBuilder.DropTable(
                name: "h_users");

            migrationBuilder.DropTable(
                name: "h_viewlevels");

            migrationBuilder.DropSequence(
                name: "emp_eid_seq");

            migrationBuilder.DropSequence(
                name: "emp_eid_seq0");

            migrationBuilder.DropSequence(
                name: "emp_eid_seq1");

            migrationBuilder.DropSequence(
                name: "emp_eid_seq2");

            migrationBuilder.DropSequence(
                name: "id_seq",
                schema: "snowflake");

            migrationBuilder.DropSequence(
                name: "uid_seq");
        }
    }
}
