using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GEMAPI.Models;

public partial class GemContext : DbContext
{
    public GemContext()
    {
    }

    public GemContext(DbContextOptions<GemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Gaccount> Gaccounts { get; set; }

    public virtual DbSet<Gapp> Gapps { get; set; }

    public virtual DbSet<Gapptype> Gapptypes { get; set; }

    public virtual DbSet<Gbranch> Gbranches { get; set; }

    public virtual DbSet<Gbregion> Gbregions { get; set; }

    public virtual DbSet<Gchange> Gchanges { get; set; }

    public virtual DbSet<Gchannel> Gchannels { get; set; }

    public virtual DbSet<Gchanneltype> Gchanneltypes { get; set; }

    public virtual DbSet<Gcircuit> Gcircuits { get; set; }

    public virtual DbSet<Gcircuittype> Gcircuittypes { get; set; }

    public virtual DbSet<Gcompany> Gcompanies { get; set; }

    public virtual DbSet<Gcomputer> Gcomputers { get; set; }

    public virtual DbSet<Gconduit> Gconduits { get; set; }

    public virtual DbSet<Gcountry> Gcountries { get; set; }

    public virtual DbSet<Gcpeother> Gcpeothers { get; set; }

    public virtual DbSet<Gcpetype> Gcpetypes { get; set; }

    public virtual DbSet<Gcustomer> Gcustomers { get; set; }

    public virtual DbSet<Gdataservice> Gdataservices { get; set; }

    public virtual DbSet<Gdbmsrelease> Gdbmsreleases { get; set; }

    public virtual DbSet<Gdbmsreplication> Gdbmsreplications { get; set; }

    public virtual DbSet<Gdbmstopology> Gdbmstopologies { get; set; }

    public virtual DbSet<Gdbmstype> Gdbmstypes { get; set; }

    public virtual DbSet<Gdbmsvendor> Gdbmsvendors { get; set; }

    public virtual DbSet<Gdisk> Gdisks { get; set; }

    public virtual DbSet<Gdisktype> Gdisktypes { get; set; }

    public virtual DbSet<Gdservicetype> Gdservicetypes { get; set; }

    public virtual DbSet<Gemployee> Gemployees { get; set; }

    public virtual DbSet<Gengineregion> Gengineregions { get; set; }

    public virtual DbSet<Gfax> Gfaxes { get; set; }

    public virtual DbSet<Gfirewall> Gfirewalls { get; set; }

    public virtual DbSet<Gfirewallcontext> Gfirewallcontexts { get; set; }

    public virtual DbSet<Ggateway> Ggateways { get; set; }

    public virtual DbSet<Ggatewaytype> Ggatewaytypes { get; set; }

    public virtual DbSet<Ggrid> Ggrids { get; set; }

    public virtual DbSet<Ggridnode> Ggridnodes { get; set; }

    public virtual DbSet<Ggridroot> Ggridroots { get; set; }

    public virtual DbSet<Ggridtopology> Ggridtopologies { get; set; }

    public virtual DbSet<Ghdvideo> Ghdvideos { get; set; }

    public virtual DbSet<Ghost> Ghosts { get; set; }

    public virtual DbSet<Ghostimage> Ghostimages { get; set; }

    public virtual DbSet<Ghostlpar> Ghostlpars { get; set; }

    public virtual DbSet<Ghostvm> Ghostvms { get; set; }

    public virtual DbSet<Ghregion> Ghregions { get; set; }

    public virtual DbSet<Ginventory> Ginventories { get; set; }

    public virtual DbSet<Ginventorytype> Ginventorytypes { get; set; }

    public virtual DbSet<Gitsm> Gitsms { get; set; }

    public virtual DbSet<GitsmDetail> GitsmDetails { get; set; }

    public virtual DbSet<Glayer2switch> Glayer2switches { get; set; }

    public virtual DbSet<Gmanager> Gmanagers { get; set; }

    public virtual DbSet<Gnetwork> Gnetworks { get; set; }

    public virtual DbSet<Gnetworksplicebox> Gnetworkspliceboxes { get; set; }

    public virtual DbSet<Gnetworktype> Gnetworktypes { get; set; }

    public virtual DbSet<Gopticalring> Gopticalrings { get; set; }

    public virtual DbSet<Gopticalsegment> Gopticalsegments { get; set; }

    public virtual DbSet<Gopttype> Gopttypes { get; set; }

    public virtual DbSet<Gphone> Gphones { get; set; }

    public virtual DbSet<Gphysicalpar> Gphysicalpars { get; set; }

    public virtual DbSet<Gproduct> Gproducts { get; set; }

    public virtual DbSet<Grightofway> Grightofways { get; set; }

    public virtual DbSet<Grouter> Grouters { get; set; }

    public virtual DbSet<Gsecvideo> Gsecvideos { get; set; }

    public virtual DbSet<Gserver> Gservers { get; set; }

    public virtual DbSet<Gserviceorder> Gserviceorders { get; set; }

    public virtual DbSet<Gserviceorderdetail> Gserviceorderdetails { get; set; }

    public virtual DbSet<Gserviceordertype> Gserviceordertypes { get; set; }

    public virtual DbSet<Gsite> Gsites { get; set; }

    public virtual DbSet<Gsitetype> Gsitetypes { get; set; }

    public virtual DbSet<Gswitch> Gswitches { get; set; }

    public virtual DbSet<Gtelephonenumber> Gtelephonenumbers { get; set; }

    public virtual DbSet<Gtrunktype> Gtrunktypes { get; set; }

    public virtual DbSet<Guser> Gusers { get; set; }

    public virtual DbSet<Gusergroup> Gusergroups { get; set; }

    public virtual DbSet<GusersCard> GusersCards { get; set; }

    public virtual DbSet<Gvendor> Gvendors { get; set; }

    public virtual DbSet<Gvoicegateway> Gvoicegateways { get; set; }

    public virtual DbSet<Gvoiceplatform> Gvoiceplatforms { get; set; }

    public virtual DbSet<Gvoiceplatformtype> Gvoiceplatformtypes { get; set; }

    public virtual DbSet<Gvoiceservice> Gvoiceservices { get; set; }

    public virtual DbSet<Gvoicetrunk> Gvoicetrunks { get; set; }

    public virtual DbSet<Gvoicetrunktype> Gvoicetrunktypes { get; set; }

    public virtual DbSet<Gvolume> Gvolumes { get; set; }

    public virtual DbSet<Gvpn> Gvpns { get; set; }

    public virtual DbSet<Gvpntype> Gvpntypes { get; set; }

    public virtual DbSet<Gvservicetype> Gvservicetypes { get; set; }

    public virtual DbSet<Gwholesaler> Gwholesalers { get; set; }

    public virtual DbSet<Gworkorder> Gworkorders { get; set; }

    public virtual DbSet<HActionLog> HActionLogs { get; set; }

    public virtual DbSet<HActionLogConfig> HActionLogConfigs { get; set; }

    public virtual DbSet<HActionLogsExtension> HActionLogsExtensions { get; set; }

    public virtual DbSet<HActionLogsUser> HActionLogsUsers { get; set; }

    public virtual DbSet<HAsset> HAssets { get; set; }

    public virtual DbSet<HAssociation> HAssociations { get; set; }

    public virtual DbSet<HBanner> HBanners { get; set; }

    public virtual DbSet<HBannerClient> HBannerClients { get; set; }

    public virtual DbSet<HBannerTrack> HBannerTracks { get; set; }

    public virtual DbSet<HCategory> HCategories { get; set; }

    public virtual DbSet<HContactDetail> HContactDetails { get; set; }

    public virtual DbSet<HContent> HContents { get; set; }

    public virtual DbSet<HContentFrontpage> HContentFrontpages { get; set; }

    public virtual DbSet<HContentRating> HContentRatings { get; set; }

    public virtual DbSet<HContentType> HContentTypes { get; set; }

    public virtual DbSet<HContentitemTagMap> HContentitemTagMaps { get; set; }

    public virtual DbSet<HCoreLogSearch> HCoreLogSearches { get; set; }

    public virtual DbSet<HExtension> HExtensions { get; set; }

    public virtual DbSet<HField> HFields { get; set; }

    public virtual DbSet<HFieldsCategory> HFieldsCategories { get; set; }

    public virtual DbSet<HFieldsGroup> HFieldsGroups { get; set; }

    public virtual DbSet<HFieldsValue> HFieldsValues { get; set; }

    public virtual DbSet<HFinderFilter> HFinderFilters { get; set; }

    public virtual DbSet<HFinderLink> HFinderLinks { get; set; }

    public virtual DbSet<HFinderLinksTerms0> HFinderLinksTerms0s { get; set; }

    public virtual DbSet<HFinderLinksTerms1> HFinderLinksTerms1s { get; set; }

    public virtual DbSet<HFinderLinksTerms2> HFinderLinksTerms2s { get; set; }

    public virtual DbSet<HFinderLinksTerms3> HFinderLinksTerms3s { get; set; }

    public virtual DbSet<HFinderLinksTerms4> HFinderLinksTerms4s { get; set; }

    public virtual DbSet<HFinderLinksTerms5> HFinderLinksTerms5s { get; set; }

    public virtual DbSet<HFinderLinksTerms6> HFinderLinksTerms6s { get; set; }

    public virtual DbSet<HFinderLinksTerms7> HFinderLinksTerms7s { get; set; }

    public virtual DbSet<HFinderLinksTerms8> HFinderLinksTerms8s { get; set; }

    public virtual DbSet<HFinderLinksTerms9> HFinderLinksTerms9s { get; set; }

    public virtual DbSet<HFinderLinksTermsa> HFinderLinksTermsas { get; set; }

    public virtual DbSet<HFinderLinksTermsb> HFinderLinksTermsbs { get; set; }

    public virtual DbSet<HFinderLinksTermsc> HFinderLinksTermscs { get; set; }

    public virtual DbSet<HFinderLinksTermsd> HFinderLinksTermsds { get; set; }

    public virtual DbSet<HFinderLinksTermse> HFinderLinksTermses { get; set; }

    public virtual DbSet<HFinderLinksTermsf> HFinderLinksTermsfs { get; set; }

    public virtual DbSet<HFinderTaxonomy> HFinderTaxonomies { get; set; }

    public virtual DbSet<HFinderTaxonomyMap> HFinderTaxonomyMaps { get; set; }

    public virtual DbSet<HFinderTerm> HFinderTerms { get; set; }

    public virtual DbSet<HFinderTermsCommon> HFinderTermsCommons { get; set; }

    public virtual DbSet<HFinderToken> HFinderTokens { get; set; }

    public virtual DbSet<HFinderTokensAggregate> HFinderTokensAggregates { get; set; }

    public virtual DbSet<HFinderType> HFinderTypes { get; set; }

    public virtual DbSet<HLanguage> HLanguages { get; set; }

    public virtual DbSet<HMenu> HMenus { get; set; }

    public virtual DbSet<HMenuType> HMenuTypes { get; set; }

    public virtual DbSet<HMessage> HMessages { get; set; }

    public virtual DbSet<HMessagesCfg> HMessagesCfgs { get; set; }

    public virtual DbSet<HModule> HModules { get; set; }

    public virtual DbSet<HModulesMenu> HModulesMenus { get; set; }

    public virtual DbSet<HNewsfeed> HNewsfeeds { get; set; }

    public virtual DbSet<HOverrider> HOverriders { get; set; }

    public virtual DbSet<HPostinstallMessage> HPostinstallMessages { get; set; }

    public virtual DbSet<HPrivacyConsent> HPrivacyConsents { get; set; }

    public virtual DbSet<HPrivacyRequest> HPrivacyRequests { get; set; }

    public virtual DbSet<HRedirectLink> HRedirectLinks { get; set; }

    public virtual DbSet<HSchema> HSchemas { get; set; }

    public virtual DbSet<HSession> HSessions { get; set; }

    public virtual DbSet<HTag> HTags { get; set; }

    public virtual DbSet<HTemplateStyle> HTemplateStyles { get; set; }

    public virtual DbSet<HUcmBase> HUcmBases { get; set; }

    public virtual DbSet<HUcmContent> HUcmContents { get; set; }

    public virtual DbSet<HUcmHistory> HUcmHistories { get; set; }

    public virtual DbSet<HUpdate> HUpdates { get; set; }

    public virtual DbSet<HUpdateSite> HUpdateSites { get; set; }

    public virtual DbSet<HUpdateSitesExtension> HUpdateSitesExtensions { get; set; }

    public virtual DbSet<HUser> HUsers { get; set; }

    public virtual DbSet<HUserKey> HUserKeys { get; set; }

    public virtual DbSet<HUserNote> HUserNotes { get; set; }

    public virtual DbSet<HUserProfile> HUserProfiles { get; set; }

    public virtual DbSet<HUserUsergroupMap> HUserUsergroupMaps { get; set; }

    public virtual DbSet<HUsergroup> HUsergroups { get; set; }

    public virtual DbSet<HViewlevel> HViewlevels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=172.32.2.123;Port=5434;Database=gem;Username=gridsa;Password=test12345");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gaccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gaccounts_pkey");

            entity.ToTable("gaccounts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountname)
                .HasMaxLength(250)
                .HasColumnName("accountname");
            entity.Property(e => e.Companyid).HasColumnName("companyid");
            entity.Property(e => e.Wholesalevendorid).HasColumnName("wholesalevendorid");
        });

        modelBuilder.Entity<Gapp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gapps_pkey");

            entity.ToTable("gapps");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appdescription)
                .HasMaxLength(500)
                .HasColumnName("appdescription");
            entity.Property(e => e.Appid)
                .HasMaxLength(150)
                .HasColumnName("appid");
            entity.Property(e => e.Appregion).HasColumnName("appregion");
            entity.Property(e => e.Apptype).HasColumnName("apptype");
            entity.Property(e => e.Dbmstopology)
                .HasMaxLength(100)
                .HasColumnName("dbmstopology");
            entity.Property(e => e.Dbmstype)
                .HasMaxLength(100)
                .HasColumnName("dbmstype");
            entity.Property(e => e.Dbmsvendor)
                .HasMaxLength(100)
                .HasColumnName("dbmsvendor");
            entity.Property(e => e.Gridid).HasColumnName("gridid");
           entity.Property(e => e.Targetgrid)
                .HasMaxLength(150)
                .HasColumnName("targetgrid");
            entity.Property(e => e.Targetgeometry)
                .HasMaxLength(150)
                .HasColumnName("targetgeometry");
            entity.Property(e => e.Targetgridid).HasColumnName("targetgridid");
            entity.Property(e => e.Iscompliant).HasColumnName("iscompliant");
        });



        modelBuilder.Entity<Gapptype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gapptype_pkey");

            entity.ToTable("gapptype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apptype).HasColumnName("apptype");
            entity.Property(e => e.Apptypedescription)
                .HasMaxLength(150)
                .HasColumnName("apptypedescription");
        });

        modelBuilder.Entity<Gbranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gbranches_pkey");

            entity.ToTable("gbranches");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Brancdescription)
                .HasMaxLength(200)
                .HasColumnName("brancdescription");
            entity.Property(e => e.Branchid)
                .HasMaxLength(100)
                .HasColumnName("branchid");
            entity.Property(e => e.Siteid)
                .HasMaxLength(50)
                .HasColumnName("siteid");
        });

        modelBuilder.Entity<Gbregion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gbregions_pkey");

            entity.ToTable("gbregions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Regiondescription)
                .HasMaxLength(200)
                .HasColumnName("regiondescription");
            entity.Property(e => e.Regionid)
                .HasMaxLength(100)
                .HasColumnName("regionid");
        });

        modelBuilder.Entity<Gchange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gchange_pkey");

            entity.ToTable("gchange");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvalid)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("approvalid");
            entity.Property(e => e.Busunit)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("busunit");
            entity.Property(e => e.Changeend).HasColumnName("changeend");
            entity.Property(e => e.Changeid).HasColumnName("changeid");
            entity.Property(e => e.Changestart).HasColumnName("changestart");
            entity.Property(e => e.Comments)
                .HasMaxLength(3000)
                .IsFixedLength()
                .HasColumnName("comments");
            entity.Property(e => e.Description)
                .HasMaxLength(3500)
                .IsFixedLength()
                .HasColumnName("description");
            entity.Property(e => e.Engineerid)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("engineerid");
            entity.Property(e => e.Holdinfo)
                .HasMaxLength(1000)
                .IsFixedLength()
                .HasColumnName("holdinfo");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.Workeffortsize)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("workeffortsize");
        });

        modelBuilder.Entity<Gchannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gchannels_pkey");

            entity.ToTable("gchannels");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Channelid).HasColumnName("channelid");
            entity.Property(e => e.Circuitid)
                .HasMaxLength(100)
                .HasColumnName("circuitid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
        });

        modelBuilder.Entity<Gchanneltype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gchanneltype_pkey");

            entity.ToTable("gchanneltype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Channeltypeid).HasColumnName("channeltypeid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Gcircuit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gcircuits_pkey");

            entity.ToTable("gcircuits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aloc)
                .HasMaxLength(150)
                .HasColumnName("aloc");
            entity.Property(e => e.Circuittypeid).HasColumnName("circuittypeid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Zloc)
                .HasMaxLength(150)
                .HasColumnName("zloc");
        });

        modelBuilder.Entity<Gcircuittype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gcircuittype_pkey");

            entity.ToTable("gcircuittype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Circuittypeid).HasColumnName("circuittypeid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Gcompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gcompany_pkey");

            entity.ToTable("gcompany");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alohaid)
                .HasMaxLength(250)
                .HasColumnName("alohaid");
            entity.Property(e => e.Companyname)
                .HasMaxLength(250)
                .HasColumnName("companyname");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(250)
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(250)
                .HasColumnName("oracleid");
        });

        modelBuilder.Entity<Gcomputer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gcomputer_pkey");

            entity.ToTable("gcomputer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Computerid)
                .HasMaxLength(150)
                .HasColumnName("computerid");
            entity.Property(e => e.Computertype).HasColumnName("computertype");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gconduit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gconduits_pkey");

            entity.ToTable("gconduits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Conduitid)
                .HasMaxLength(150)
                .HasColumnName("conduitid");
            entity.Property(e => e.Conduittype).HasColumnName("conduittype");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Rowid).HasColumnName("rowid");
        });

        modelBuilder.Entity<Gcountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gcountry_pkey");

            entity.ToTable("gcountry");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Countryid)
                .HasMaxLength(100)
                .HasColumnName("countryid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Exchange)
                .HasMaxLength(100)
                .HasColumnName("exchange");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .HasColumnName("region");
        });

        modelBuilder.Entity<Gcpeother>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gcpeother_pkey");

            entity.ToTable("gcpeother");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(150)
                .HasColumnName("vendorid");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gcpetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gcpetype_pkey");

            entity.ToTable("gcpetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cpetypeid)
                .HasMaxLength(100)
                .HasColumnName("cpetypeid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Gcustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gcustomer_pkey");

            entity.ToTable("gcustomer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(100)
                .HasColumnName("address2");
            entity.Property(e => e.Alohaid)
                .HasMaxLength(100)
                .HasColumnName("alohaid");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Customerid)
                .HasMaxLength(100)
                .HasColumnName("customerid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(100)
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(100)
                .HasColumnName("oracleid");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("phone");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.Zip)
                .HasMaxLength(100)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<Gdataservice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdataservices_pkey");

            entity.ToTable("gdataservices");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dataserviceid)
                .HasMaxLength(100)
                .HasColumnName("dataserviceid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Networkid).HasColumnName("networkid");
        });

        modelBuilder.Entity<Gdbmsrelease>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdbmsreleases_pkey");

            entity.ToTable("gdbmsreleases");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Releasedescription)
                .HasMaxLength(100)
                .HasColumnName("releasedescription");
            entity.Property(e => e.Releasesystemrequirements)
                .HasMaxLength(500)
                .HasColumnName("releasesystemrequirements");
            entity.Property(e => e.Releaseversion)
                .HasMaxLength(100)
                .HasColumnName("releaseversion");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(100)
                .HasColumnName("vendorid");
            entity.Property(e => e.Vendorname)
                .HasMaxLength(100)
                .HasColumnName("vendorname");
        });

        modelBuilder.Entity<Gdbmsreplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdbmsreplication_pkey");

            entity.ToTable("gdbmsreplication");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Replicationdescription)
                .HasMaxLength(100)
                .HasColumnName("replicationdescription");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(100)
                .HasColumnName("vendorid");
            entity.Property(e => e.Vendorname)
                .HasMaxLength(100)
                .HasColumnName("vendorname");
        });

        modelBuilder.Entity<Gdbmstopology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdbmstopology_pkey");

            entity.ToTable("gdbmstopology");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dbmstopology).HasColumnName("dbmstopology");
            entity.Property(e => e.Dbmstopologydescription)
                .HasMaxLength(150)
                .HasColumnName("dbmstopologydescription");
        });

        modelBuilder.Entity<Gdbmstype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdbmstype_pkey");

            entity.ToTable("gdbmstype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dbmstype).HasColumnName("dbmstype");
            entity.Property(e => e.Dbmstypedescription)
                .HasMaxLength(150)
                .HasColumnName("dbmstypedescription");
        });

        modelBuilder.Entity<Gdbmsvendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdbmsvendors_pkey");

            entity.ToTable("gdbmsvendors");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(100)
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(100)
                .HasColumnName("oracleid");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(100)
                .HasColumnName("vendorid");
            entity.Property(e => e.Vendorname)
                .HasMaxLength(100)
                .HasColumnName("vendorname");
        });

        modelBuilder.Entity<Gdisk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdisk_pkey");

            entity.ToTable("gdisk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Diskid)
                .HasMaxLength(150)
                .HasColumnName("diskid");
            entity.Property(e => e.Disktype).HasColumnName("disktype");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Lat)
                .HasMaxLength(100)
                .HasColumnName("lat");
            entity.Property(e => e.Long)
                .HasMaxLength(100)
                .HasColumnName("long");
            entity.Property(e => e.Machineid).HasColumnName("machineid");
            entity.Property(e => e.Serverid).HasColumnName("serverid");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gdisktype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdisktype_pkey");

            entity.ToTable("gdisktype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Disktype).HasColumnName("disktype");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(100)
                .HasColumnName("vendorid");
        });

        modelBuilder.Entity<Gdservicetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gdservicetype_pkey");

            entity.ToTable("gdservicetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datatypeid)
                .HasMaxLength(100)
                .HasColumnName("datatypeid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Gemployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gemployees_pkey");

            entity.ToTable("gemployees");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(100)
                .HasColumnName("employeeid");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .HasColumnName("fullname");
            entity.Property(e => e.Homeoffice)
                .HasMaxLength(100)
                .HasColumnName("homeoffice");
            entity.Property(e => e.Primarysite)
                .HasMaxLength(100)
                .HasColumnName("primarysite");
        });

        modelBuilder.Entity<Gengineregion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gengineregions_pkey");

            entity.ToTable("gengineregions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Regiondescription)
                .HasMaxLength(100)
                .HasColumnName("regiondescription");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
        });

        modelBuilder.Entity<Gfax>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gfax_pkey");

            entity.ToTable("gfax");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Faxid)
                .HasMaxLength(150)
                .HasColumnName("faxid");
            entity.Property(e => e.Faxtype).HasColumnName("faxtype");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gfirewall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gfirewalls_pkey");

            entity.ToTable("gfirewalls");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Firewallid)
                .HasMaxLength(150)
                .HasColumnName("firewallid");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gfirewallcontext>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gfirewallcontexts_pkey");

            entity.ToTable("gfirewallcontexts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasMaxLength(150)
                .HasColumnName("contextid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Firewallid)
                .HasMaxLength(150)
                .HasColumnName("firewallid");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Ggateway>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ggateways_pkey");

            entity.ToTable("ggateways");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Gatewayid)
                .HasMaxLength(150)
                .HasColumnName("gatewayid");
            entity.Property(e => e.Gatewaytype).HasColumnName("gatewaytype");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Ggatewaytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ggatewaytype_pkey");

            entity.ToTable("ggatewaytype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Ggrid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ggrids_pkey");

            entity.ToTable("ggrids");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Drnode1id).HasColumnName("drnode1id");
            entity.Property(e => e.Drnode2id).HasColumnName("drnode2id");
            entity.Property(e => e.Drsite1).HasColumnName("drsite1");
            entity.Property(e => e.Drsite2).HasColumnName("drsite2");
            entity.Property(e => e.Geometry)
                .HasMaxLength(100)
                .HasColumnName("geometry");
            entity.Property(e => e.Gridnode1id).HasColumnName("gridnode1id");
            entity.Property(e => e.Gridnode2id).HasColumnName("gridnode2id");
            entity.Property(e => e.Gridnode3id).HasColumnName("gridnode3id");
            entity.Property(e => e.Gridnode4id).HasColumnName("gridnode4id");
            entity.Property(e => e.Gridnode5id).HasColumnName("gridnode5id");
            entity.Property(e => e.Gridnode6id).HasColumnName("gridnode6id");
            entity.Property(e => e.Gridsite1).HasColumnName("gridsite1");
            entity.Property(e => e.Gridsite2).HasColumnName("gridsite2");
            entity.Property(e => e.Gridsite3).HasColumnName("gridsite3");
            entity.Property(e => e.Gridsite4).HasColumnName("gridsite4");
            entity.Property(e => e.Gridsite5).HasColumnName("gridsite5");
            entity.Property(e => e.Gridsite6).HasColumnName("gridsite6");
            entity.Property(e => e.Rootid1).HasColumnName("rootid1");
            entity.Property(e => e.Rootid2).HasColumnName("rootid2");
            entity.Property(e => e.Vendor)
                .HasMaxLength(100)
                .HasColumnName("vendor");
            entity.Property(e => e.Vendorgridname)
                .HasMaxLength(200)
                .HasColumnName("vendorgridname");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(150)
                .HasColumnName("vendorid");
        });

        modelBuilder.Entity<Ggridnode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ggridnodes_pkey");

            entity.ToTable("ggridnodes");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Floorid).HasColumnName("floorid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(150)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Locationid).HasColumnName("locationid");
            entity.Property(e => e.Rackid).HasColumnName("rackid");
            entity.Property(e => e.Rootid1).HasColumnName("rootid1");
            entity.Property(e => e.Rootid2).HasColumnName("rootid2");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryip)
                .HasMaxLength(150)
                .HasColumnName("telemetryip");
        });

        modelBuilder.Entity<Ggridroot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ggridroots_pkey");

            entity.ToTable("ggridroots");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Floorid).HasColumnName("floorid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(150)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Locationid).HasColumnName("locationid");
            entity.Property(e => e.Rackid).HasColumnName("rackid");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryip)
                .HasMaxLength(150)
                .HasColumnName("telemetryip");
        });

        modelBuilder.Entity<Ggridtopology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ggridtopology_pkey");

            entity.ToTable("ggridtopology");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Topologydescription)
                .HasMaxLength(150)
                .HasColumnName("topologydescription");
            entity.Property(e => e.Topologyid)
                .HasMaxLength(100)
                .HasColumnName("topologyid");
        });

        modelBuilder.Entity<Ghdvideo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ghdvideo_pkey");

            entity.ToTable("ghdvideo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Videoid)
                .HasMaxLength(150)
                .HasColumnName("videoid");
            entity.Property(e => e.Vidtype).HasColumnName("vidtype");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Ghost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ghosts_pkey");

            entity.ToTable("ghosts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Imageid)
                .HasMaxLength(100)
                .HasColumnName("imageid");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Lpars).HasColumnName("lpars");
            entity.Property(e => e.Serverid)
                .HasMaxLength(150)
                .HasColumnName("serverid");
            entity.Property(e => e.Switchid)
                .HasMaxLength(150)
                .HasColumnName("switchid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Ghostimage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ghostimages_pkey");

            entity.ToTable("ghostimages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Imageid)
                .HasMaxLength(150)
                .HasColumnName("imageid");
            entity.Property(e => e.Imageurl)
                .HasMaxLength(150)
                .HasColumnName("imageurl");
            entity.Property(e => e.Imagevendor)
                .HasMaxLength(100)
                .HasColumnName("imagevendor");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Operatingsystem)
                .HasMaxLength(100)
                .HasColumnName("operatingsystem");
            entity.Property(e => e.Vendoraccountid)
                .HasMaxLength(100)
                .HasColumnName("vendoraccountid");
        });

        modelBuilder.Entity<Ghostlpar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ghostlpars_pkey");

            entity.ToTable("ghostlpars");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Lparid)
                .HasMaxLength(150)
                .HasColumnName("lparid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Ghostvm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ghostvms_pkey");

            entity.ToTable("ghostvms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vmid)
                .HasMaxLength(150)
                .HasColumnName("vmid");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Ghregion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ghregions_pkey");

            entity.ToTable("ghregions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Regiondescription)
                .HasMaxLength(200)
                .HasColumnName("regiondescription");
            entity.Property(e => e.Regionid)
                .HasMaxLength(100)
                .HasColumnName("regionid");
        });

        modelBuilder.Entity<Ginventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("inventory_pkey");

            entity.ToTable("ginventory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Inventorytype).HasColumnName("inventorytype");
            entity.Property(e => e.Serialnumber)
                .HasMaxLength(200)
                .HasColumnName("serialnumber");
        });

        modelBuilder.Entity<Ginventorytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("inventorytype_pkey");

            entity.ToTable("ginventorytype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Gitsm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gitsm_pkey");

            entity.ToTable("gitsm");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Closedate).HasColumnName("closedate");
            entity.Property(e => e.Custid)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("custid");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Opendate).HasColumnName("opendate");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("oracleid");
            entity.Property(e => e.Priority)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("priority");
            entity.Property(e => e.Res1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("res1");
            entity.Property(e => e.Res2)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("res2");
            entity.Property(e => e.Res3)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("res3");
            entity.Property(e => e.Res4)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("res4");
            entity.Property(e => e.Summary)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("summary");
            entity.Property(e => e.Ticketid).HasColumnName("ticketid");
            entity.Property(e => e.Ticketstatus)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("ticketstatus");
        });

        modelBuilder.Entity<GitsmDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gitsm_detail_pkey");

            entity.ToTable("gitsm_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Detailid).HasColumnName("detailid");
            entity.Property(e => e.Linedetail)
                .HasMaxLength(1000)
                .IsFixedLength()
                .HasColumnName("linedetail");
            entity.Property(e => e.Linenumber)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("linenumber");
            entity.Property(e => e.Ticketid).HasColumnName("ticketid");
        });

        modelBuilder.Entity<Glayer2switch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("glayer2switches_pkey");

            entity.ToTable("glayer2switches");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Siteid)
                .HasMaxLength(100)
                .HasColumnName("siteid");
        });

        modelBuilder.Entity<Gmanager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gmanagers_pkey");

            entity.ToTable("gmanagers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .HasColumnName("fullname");
            entity.Property(e => e.Managerid)
                .HasMaxLength(100)
                .HasColumnName("managerid");
        });

        modelBuilder.Entity<Gnetwork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gnetworks_pkey");

            entity.ToTable("gnetworks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Networkid).HasColumnName("networkid");
            entity.Property(e => e.Networktypeid).HasColumnName("networktypeid");
        });

        modelBuilder.Entity<Gnetworksplicebox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gnetworksplicebox_pkey");

            entity.ToTable("gnetworksplicebox");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Gpslat)
                .HasMaxLength(100)
                .HasColumnName("gpslat");
            entity.Property(e => e.Gpslong)
                .HasMaxLength(100)
                .HasColumnName("gpslong");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Spliceid).HasColumnName("spliceid");
            entity.Property(e => e.User1)
                .HasMaxLength(150)
                .HasColumnName("user1");
            entity.Property(e => e.User2)
                .HasMaxLength(150)
                .HasColumnName("user2");
            entity.Property(e => e.User3)
                .HasMaxLength(150)
                .HasColumnName("user3");
            entity.Property(e => e.User4)
                .HasMaxLength(150)
                .HasColumnName("user4");
            entity.Property(e => e.User5)
                .HasMaxLength(150)
                .HasColumnName("user5");
        });

        modelBuilder.Entity<Gnetworktype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gnetworktype_pkey");

            entity.ToTable("gnetworktype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Networktypeid).HasColumnName("networktypeid");
        });

        modelBuilder.Entity<Gopticalring>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gopticalring_pkey");

            entity.ToTable("gopticalring");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Lat)
                .HasMaxLength(100)
                .HasColumnName("lat");
            entity.Property(e => e.Long)
                .HasMaxLength(100)
                .HasColumnName("long");
            entity.Property(e => e.Ringid)
                .HasMaxLength(150)
                .HasColumnName("ringid");
            entity.Property(e => e.Ringtype).HasColumnName("ringtype");
            entity.Property(e => e.Siteid1).HasColumnName("siteid1");
            entity.Property(e => e.Siteid2).HasColumnName("siteid2");
            entity.Property(e => e.Siteid3).HasColumnName("siteid3");
            entity.Property(e => e.Siteid4).HasColumnName("siteid4");
            entity.Property(e => e.Siteid5).HasColumnName("siteid5");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gopticalsegment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gopticalsegments_pkey");

            entity.ToTable("gopticalsegments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aloc)
                .HasMaxLength(150)
                .HasColumnName("aloc");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Segmenttypeid).HasColumnName("segmenttypeid");
            entity.Property(e => e.Zloc)
                .HasMaxLength(150)
                .HasColumnName("zloc");
        });

        modelBuilder.Entity<Gopttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gopttype_pkey");

            entity.ToTable("gopttype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Opttypeid).HasColumnName("opttypeid");
        });

        modelBuilder.Entity<Gphone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gphones_pkey");

            entity.ToTable("gphones");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Lat)
                .HasMaxLength(100)
                .HasColumnName("lat");
            entity.Property(e => e.Long)
                .HasMaxLength(100)
                .HasColumnName("long");
            entity.Property(e => e.Phoneid)
                .HasMaxLength(150)
                .HasColumnName("phoneid");
            entity.Property(e => e.Phonetype).HasColumnName("phonetype");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gphysicalpar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gphysicalpar_pkey");

            entity.ToTable("gphysicalpar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
        });

        modelBuilder.Entity<Gproduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gproducts_pkey");

            entity.ToTable("gproducts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Division)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("division");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("oracleid");
            entity.Property(e => e.ProductWooId)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("product_woo_id");
            entity.Property(e => e.ProductWooUrl)
                .HasMaxLength(250)
                .IsFixedLength()
                .HasColumnName("product_woo_url");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Productname)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("productname");
            entity.Property(e => e.ProudctWooInstance)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("proudct_woo_instance");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("vendorid");
        });

        modelBuilder.Entity<Grightofway>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("grightofway_pkey");

            entity.ToTable("grightofway");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Rowid).HasColumnName("rowid");
            entity.Property(e => e.Rowtype).HasColumnName("rowtype");
        });

        modelBuilder.Entity<Grouter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("grouters_pkey");

            entity.ToTable("grouters");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Routerid)
                .HasMaxLength(150)
                .HasColumnName("routerid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gsecvideo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gsecvideo_pkey");

            entity.ToTable("gsecvideo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Videoid)
                .HasMaxLength(150)
                .HasColumnName("videoid");
            entity.Property(e => e.Vidtype).HasColumnName("vidtype");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gserver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gservers_pkey");

            entity.ToTable("gservers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Serverid)
                .HasMaxLength(150)
                .HasColumnName("serverid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gserviceorder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gserviceorders_pkey");

            entity.ToTable("gserviceorders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Custid)
                .HasMaxLength(100)
                .HasColumnName("custid");
            entity.Property(e => e.Orderdescription)
                .HasMaxLength(250)
                .HasColumnName("orderdescription");
            entity.Property(e => e.Ordertype).HasColumnName("ordertype");
            entity.Property(e => e.Regiondescription)
                .HasMaxLength(100)
                .HasColumnName("regiondescription");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Totalitems).HasColumnName("totalitems");
        });

        modelBuilder.Entity<Gserviceorderdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gserviceorderdetail_pkey");

            entity.ToTable("gserviceorderdetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Federalvat)
                .HasMaxLength(25)
                .HasColumnName("federalvat");
            entity.Property(e => e.Listcost)
                .HasMaxLength(25)
                .HasColumnName("listcost");
            entity.Property(e => e.Skuid).HasColumnName("skuid");
            entity.Property(e => e.Skuidc)
                .HasMaxLength(150)
                .HasColumnName("skuidc");
            entity.Property(e => e.Statetax)
                .HasMaxLength(25)
                .HasColumnName("statetax");
            entity.Property(e => e.Unitcost)
                .HasMaxLength(25)
                .HasColumnName("unitcost");
        });

        modelBuilder.Entity<Gserviceordertype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gserviceordertype_pkey");

            entity.ToTable("gserviceordertype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Servicetypedescription)
                .HasMaxLength(100)
                .HasColumnName("servicetypedescription");
            entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");
        });

        modelBuilder.Entity<Gsite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gsites_pkey");

            entity.ToTable("gsites");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(150)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(150)
                .HasColumnName("address2");
            entity.Property(e => e.Cllicode)
                .HasMaxLength(50)
                .HasColumnName("cllicode");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .HasColumnName("fax");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("phone");
            entity.Property(e => e.Postal)
                .HasMaxLength(150)
                .HasColumnName("postal");
            entity.Property(e => e.Siteclli)
                .HasMaxLength(100)
                .HasColumnName("siteclli");
            entity.Property(e => e.Sitecontactid).HasColumnName("sitecontactid");
            entity.Property(e => e.Sitedescription)
                .HasMaxLength(200)
                .HasColumnName("sitedescription");
            entity.Property(e => e.Siteid)
                .HasMaxLength(100)
                .HasColumnName("siteid");
            entity.Property(e => e.Stateregion)
                .HasMaxLength(150)
                .HasColumnName("stateregion");
        });

        modelBuilder.Entity<Gsitetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gsitetype_pkey");

            entity.ToTable("gsitetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Sitetypeid).HasColumnName("sitetypeid");
        });

        modelBuilder.Entity<Gswitch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gswitches_pkey");

            entity.ToTable("gswitches");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Switchid)
                .HasMaxLength(150)
                .HasColumnName("switchid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gtelephonenumber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gtelephonenumber_pkey");

            entity.ToTable("gtelephonenumber");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Channelid).HasColumnName("channelid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Phoneid).HasColumnName("phoneid");
            entity.Property(e => e.Tn)
                .HasMaxLength(100)
                .HasColumnName("tn");
        });

        modelBuilder.Entity<Gtrunktype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gtrunktype_pkey");

            entity.ToTable("gtrunktype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Trunktypeid)
                .HasMaxLength(100)
                .HasColumnName("trunktypeid");
        });

        modelBuilder.Entity<Guser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gusers_pkey");

            entity.ToTable("gusers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .HasColumnName("address2");
            entity.Property(e => e.Cardaddress1)
                .HasMaxLength(50)
                .HasColumnName("cardaddress1");
            entity.Property(e => e.Cardaddress2)
                .HasMaxLength(50)
                .HasColumnName("cardaddress2");
            entity.Property(e => e.Cardcity)
                .HasMaxLength(50)
                .HasColumnName("cardcity");
            entity.Property(e => e.Cardcountry)
                .HasMaxLength(50)
                .HasColumnName("cardcountry");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(50)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardregion)
                .HasMaxLength(50)
                .HasColumnName("cardregion");
            entity.Property(e => e.Cardzip)
                .HasMaxLength(50)
                .HasColumnName("cardzip");
            entity.Property(e => e.Cellphone)
                .HasMaxLength(50)
                .HasColumnName("cellphone");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Corporatename)
                .HasMaxLength(50)
                .HasColumnName("corporatename");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Expirecard)
                .HasMaxLength(10)
                .HasColumnName("expirecard");
            entity.Property(e => e.Faxnumber)
                .HasMaxLength(20)
                .HasColumnName("faxnumber");
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .HasColumnName("firstname");
            entity.Property(e => e.Firstproduct)
                .HasMaxLength(50)
                .HasColumnName("firstproduct");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.Jid).HasColumnName("jid");
            entity.Property(e => e.Keytype)
                .HasMaxLength(50)
                .HasColumnName("keytype");
            entity.Property(e => e.Lastname)
                .HasMaxLength(20)
                .HasColumnName("lastname");
            entity.Property(e => e.Nameoncard)
                .HasMaxLength(100)
                .HasColumnName("nameoncard");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Postal)
                .HasMaxLength(20)
                .HasColumnName("postal");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .HasColumnName("region");
            entity.Property(e => e.Registrationdate)
                .HasMaxLength(50)
                .HasColumnName("registrationdate");
            entity.Property(e => e.Secondproduct)
                .HasMaxLength(50)
                .HasColumnName("secondproduct");
            entity.Property(e => e.Securitycard)
                .HasMaxLength(3)
                .HasColumnName("securitycard");
            entity.Property(e => e.Ssduns)
                .HasMaxLength(50)
                .HasColumnName("ssduns");
            entity.Property(e => e.Userid)
                .HasMaxLength(20)
                .HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Gusergroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gusergroups_pkey");

            entity.ToTable("gusergroups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Groupid)
                .HasMaxLength(100)
                .HasColumnName("groupid");
            entity.Property(e => e.Groupname)
                .HasMaxLength(250)
                .HasColumnName("groupname");
        });

        modelBuilder.Entity<GusersCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gusers_cards_pkey");

            entity.ToTable("gusers_cards");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appdate).HasColumnName("appdate");
            entity.Property(e => e.Appid)
                .HasMaxLength(50)
                .HasColumnName("appid");
            entity.Property(e => e.Cardexpiration)
                .HasMaxLength(15)
                .HasColumnName("cardexpiration");
            entity.Property(e => e.Cardname)
                .HasMaxLength(50)
                .HasColumnName("cardname");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(50)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardsecurity)
                .HasMaxLength(15)
                .HasColumnName("cardsecurity");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(50)
                .HasColumnName("cardtype");
            entity.Property(e => e.Userid)
                .HasMaxLength(20)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<Gvendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvendor_pkey");

            entity.ToTable("gvendor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Vendoraddress1)
                .HasMaxLength(100)
                .HasColumnName("vendoraddress1");
            entity.Property(e => e.Vendoraddress2)
                .HasMaxLength(100)
                .HasColumnName("vendoraddress2");
            entity.Property(e => e.Vendorcity)
                .HasMaxLength(100)
                .HasColumnName("vendorcity");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(100)
                .HasColumnName("vendorid");
            entity.Property(e => e.Vendorname)
                .HasMaxLength(150)
                .HasColumnName("vendorname");
            entity.Property(e => e.Vendorstate)
                .HasMaxLength(100)
                .HasColumnName("vendorstate");
            entity.Property(e => e.Vendorzip)
                .HasMaxLength(100)
                .HasColumnName("vendorzip");
        });

        modelBuilder.Entity<Gvoicegateway>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvoicegateway_pkey");

            entity.ToTable("gvoicegateway");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Switchid)
                .HasMaxLength(150)
                .HasColumnName("switchid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gvoiceplatform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvoiceplatforms_pkey");

            entity.ToTable("gvoiceplatforms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Platformid)
                .HasMaxLength(150)
                .HasColumnName("platformid");
            entity.Property(e => e.Platformtype).HasColumnName("platformtype");
            entity.Property(e => e.Serverid)
                .HasMaxLength(150)
                .HasColumnName("serverid");
            entity.Property(e => e.Telemetryipaddress)
                .HasMaxLength(50)
                .HasColumnName("telemetryipaddress");
            entity.Property(e => e.Vpnid1)
                .HasMaxLength(50)
                .HasColumnName("vpnid1");
            entity.Property(e => e.Vpnid2)
                .HasMaxLength(50)
                .HasColumnName("vpnid2");
        });

        modelBuilder.Entity<Gvoiceplatformtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvoiceplatformtype_pkey");

            entity.ToTable("gvoiceplatformtype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Platformtype).HasColumnName("platformtype");
        });

        modelBuilder.Entity<Gvoiceservice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvoiceservices_pkey");

            entity.ToTable("gvoiceservices");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Networkid).HasColumnName("networkid");
            entity.Property(e => e.Voiceserviceid)
                .HasMaxLength(100)
                .HasColumnName("voiceserviceid");
        });

        modelBuilder.Entity<Gvoicetrunk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvoicetrunks_pkey");

            entity.ToTable("gvoicetrunks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Trunkid)
                .HasMaxLength(150)
                .HasColumnName("trunkid");
            entity.Property(e => e.Trunktypeid).HasColumnName("trunktypeid");
        });

        modelBuilder.Entity<Gvoicetrunktype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvoicetrunktype_pkey");

            entity.ToTable("gvoicetrunktype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Trunktypeid).HasColumnName("trunktypeid");
        });

        modelBuilder.Entity<Gvolume>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvolumes_pkey");

            entity.ToTable("gvolumes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Diskid).HasColumnName("diskid");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Volumeid)
                .HasMaxLength(150)
                .HasColumnName("volumeid");
            entity.Property(e => e.Volumetype).HasColumnName("volumetype");
        });

        modelBuilder.Entity<Gvpn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvpns_pkey");

            entity.ToTable("gvpns");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Circuitid)
                .HasMaxLength(100)
                .HasColumnName("circuitid");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Inventoryid)
                .HasMaxLength(100)
                .HasColumnName("inventoryid");
            entity.Property(e => e.Vpnid).HasColumnName("vpnid");
        });

        modelBuilder.Entity<Gvpntype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvpntype_pkey");

            entity.ToTable("gvpntype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Vpntypeid).HasColumnName("vpntypeid");
        });

        modelBuilder.Entity<Gvservicetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gvservicetype_pkey");

            entity.ToTable("gvservicetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Voicetypeid)
                .HasMaxLength(100)
                .HasColumnName("voicetypeid");
        });

        modelBuilder.Entity<Gwholesaler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gwholesalers_pkey");

            entity.ToTable("gwholesalers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alohaid)
                .HasMaxLength(250)
                .HasColumnName("alohaid");
            entity.Property(e => e.Companyid).HasColumnName("companyid");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(250)
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(250)
                .HasColumnName("oracleid");
            entity.Property(e => e.Wholesalename)
                .HasMaxLength(250)
                .HasColumnName("wholesalename");
        });

        modelBuilder.Entity<Gworkorder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gworkorders_pkey");

            entity.ToTable("gworkorders");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Closedate).HasColumnName("closedate");
            entity.Property(e => e.Custid)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("custid");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Opendate).HasColumnName("opendate");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("oracleid");
            entity.Property(e => e.Priority)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("priority");
            entity.Property(e => e.Res1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("res1");
            entity.Property(e => e.Res2)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("res2");
            entity.Property(e => e.Res3)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("res3");
            entity.Property(e => e.Res4)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("res4");
            entity.Property(e => e.Summary)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("summary");
            entity.Property(e => e.Ticketstatus)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("ticketstatus");
        });

        modelBuilder.Entity<HActionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_action_logs_pkey");

            entity.ToTable("h_action_logs");

            entity.HasIndex(e => new { e.Extension, e.ItemId }, "h_action_logs_idx_extension_itemid");

            entity.HasIndex(e => e.UserId, "h_action_logs_idx_user_id");

            entity.HasIndex(e => new { e.UserId, e.Extension }, "h_action_logs_idx_user_id_extension");

            entity.HasIndex(e => new { e.UserId, e.LogDate }, "h_action_logs_idx_user_id_logdate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("extension");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(40)
                .HasDefaultValueSql("'0.0.0.0'::character varying")
                .HasColumnName("ip_address");
            entity.Property(e => e.ItemId)
                .HasDefaultValue(0)
                .HasColumnName("item_id");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("log_date");
            entity.Property(e => e.Message)
                .HasDefaultValueSql("''::text")
                .HasColumnName("message");
            entity.Property(e => e.MessageLanguageKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("message_language_key");
            entity.Property(e => e.UserId)
                .HasDefaultValue(0)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<HActionLogConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_action_log_config_pkey");

            entity.ToTable("h_action_log_config");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdHolder)
                .HasMaxLength(255)
                .HasColumnName("id_holder");
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .HasColumnName("table_name");
            entity.Property(e => e.TextPrefix)
                .HasMaxLength(255)
                .HasColumnName("text_prefix");
            entity.Property(e => e.TitleHolder)
                .HasMaxLength(255)
                .HasColumnName("title_holder");
            entity.Property(e => e.TypeAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type_alias");
            entity.Property(e => e.TypeTitle)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type_title");
        });

        modelBuilder.Entity<HActionLogsExtension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_action_logs_extensions_pkey");

            entity.ToTable("h_action_logs_extensions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("extension");
        });

        modelBuilder.Entity<HActionLogsUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("h_action_logs_users_pkey");

            entity.ToTable("h_action_logs_users");

            entity.HasIndex(e => e.Notify, "h_action_logs_users_idx_notify");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_id");
            entity.Property(e => e.Extensions).HasColumnName("extensions");
            entity.Property(e => e.Notify).HasColumnName("notify");
        });

        modelBuilder.Entity<HAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_assets_pkey");

            entity.ToTable("h_assets");

            entity.HasIndex(e => e.Name, "h_assets_idx_asset_name").IsUnique();

            entity.HasIndex(e => new { e.Lft, e.Rgt }, "h_assets_idx_lft_rgt");

            entity.HasIndex(e => e.ParentId, "h_assets_idx_parent_id");

            entity.Property(e => e.Id)
                .HasComment("Primary Key")
                .HasColumnName("id");
            entity.Property(e => e.Level)
                .HasComment("The cached level in the nested tree.")
                .HasColumnName("level");
            entity.Property(e => e.Lft)
                .HasDefaultValue(0L)
                .HasComment("Nested set lft.")
                .HasColumnName("lft");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("The unique name for the asset.")
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0L)
                .HasComment("Nested set parent.")
                .HasColumnName("parent_id");
            entity.Property(e => e.Rgt)
                .HasDefaultValue(0L)
                .HasComment("Nested set rgt.")
                .HasColumnName("rgt");
            entity.Property(e => e.Rules)
                .HasMaxLength(5120)
                .HasComment("JSON encoded access control.")
                .HasColumnName("rules");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasComment("The descriptive title for the asset.")
                .HasColumnName("title");
        });

        modelBuilder.Entity<HAssociation>(entity =>
        {
            entity.HasKey(e => new { e.Context, e.Id }).HasName("h_associations_idx_context_id");

            entity.ToTable("h_associations");

            entity.HasIndex(e => e.Key, "h_associations_idx_key");

            entity.Property(e => e.Context)
                .HasMaxLength(50)
                .HasComment("The context of the associated item.")
                .HasColumnName("context");
            entity.Property(e => e.Id)
                .HasComment("A reference to the associated item.")
                .HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasComment("The key for the association computed from an md5 on associated ids.")
                .HasColumnName("key");
        });

        modelBuilder.Entity<HBanner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_banners_pkey");

            entity.ToTable("h_banners");

            entity.HasIndex(e => e.Catid, "h_banners_idx_banner_catid");

            entity.HasIndex(e => e.Language, "h_banners_idx_language");

            entity.HasIndex(e => e.MetakeyPrefix, "h_banners_idx_metakey_prefix");

            entity.HasIndex(e => e.OwnPrefix, "h_banners_idx_own_prefix");

            entity.HasIndex(e => e.State, "h_banners_idx_state");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("alias");
            entity.Property(e => e.Catid)
                .HasDefaultValue(0L)
                .HasColumnName("catid");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0L)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.Cid)
                .HasDefaultValue(0L)
                .HasColumnName("cid");
            entity.Property(e => e.Clicks)
                .HasDefaultValue(0L)
                .HasColumnName("clicks");
            entity.Property(e => e.Clickurl)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("clickurl");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValue(0L)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedByAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("created_by_alias");
            entity.Property(e => e.Custombannercode)
                .HasMaxLength(2048)
                .HasColumnName("custombannercode");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Impmade)
                .HasDefaultValue(0L)
                .HasColumnName("impmade");
            entity.Property(e => e.Imptotal)
                .HasDefaultValue(0L)
                .HasColumnName("imptotal");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.Metakey).HasColumnName("metakey");
            entity.Property(e => e.MetakeyPrefix)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("metakey_prefix");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy)
                .HasDefaultValue(0L)
                .HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.OwnPrefix)
                .HasDefaultValue((short)0)
                .HasColumnName("own_prefix");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.PublishDown)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_down");
            entity.Property(e => e.PublishUp)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_up");
            entity.Property(e => e.PurchaseType)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("purchase_type");
            entity.Property(e => e.Reset)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("reset");
            entity.Property(e => e.State)
                .HasDefaultValue((short)0)
                .HasColumnName("state");
            entity.Property(e => e.Sticky)
                .HasDefaultValue((short)0)
                .HasColumnName("sticky");
            entity.Property(e => e.TrackClicks)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("track_clicks");
            entity.Property(e => e.TrackImpressions)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("track_impressions");
            entity.Property(e => e.Type)
                .HasDefaultValue(0L)
                .HasColumnName("type");
            entity.Property(e => e.Version)
                .HasDefaultValue(1L)
                .HasColumnName("version");
        });

        modelBuilder.Entity<HBannerClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_banner_clients_pkey");

            entity.ToTable("h_banner_clients");

            entity.HasIndex(e => e.MetakeyPrefix, "h_banner_clients_idx_metakey_prefix");

            entity.HasIndex(e => e.OwnPrefix, "h_banner_clients_idx_own_prefix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0L)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.Contact)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("contact");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email");
            entity.Property(e => e.Extrainfo).HasColumnName("extrainfo");
            entity.Property(e => e.Metakey).HasColumnName("metakey");
            entity.Property(e => e.MetakeyPrefix)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("metakey_prefix");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.OwnPrefix)
                .HasDefaultValue((short)0)
                .HasColumnName("own_prefix");
            entity.Property(e => e.PurchaseType)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("purchase_type");
            entity.Property(e => e.State)
                .HasDefaultValue((short)0)
                .HasColumnName("state");
            entity.Property(e => e.TrackClicks)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("track_clicks");
            entity.Property(e => e.TrackImpressions)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("track_impressions");
        });

        modelBuilder.Entity<HBannerTrack>(entity =>
        {
            entity.HasKey(e => new { e.TrackDate, e.TrackType, e.BannerId }).HasName("h_banner_tracks_pkey");

            entity.ToTable("h_banner_tracks");

            entity.HasIndex(e => e.BannerId, "h_banner_tracks_idx_banner_id");

            entity.HasIndex(e => e.TrackDate, "h_banner_tracks_idx_track_date");

            entity.HasIndex(e => e.TrackType, "h_banner_tracks_idx_track_type");

            entity.Property(e => e.TrackDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("track_date");
            entity.Property(e => e.TrackType).HasColumnName("track_type");
            entity.Property(e => e.BannerId).HasColumnName("banner_id");
            entity.Property(e => e.Count)
                .HasDefaultValue(0L)
                .HasColumnName("count");
        });

        modelBuilder.Entity<HCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_categories_pkey");

            entity.ToTable("h_categories");

            entity.HasIndex(e => new { e.Extension, e.Published, e.Access }, "h_categories_cat_idx");

            entity.HasIndex(e => e.Access, "h_categories_idx_access");

            entity.HasIndex(e => e.Alias, "h_categories_idx_alias");

            entity.HasIndex(e => e.CheckedOut, "h_categories_idx_checkout");

            entity.HasIndex(e => e.Language, "h_categories_idx_language");

            entity.HasIndex(e => new { e.Lft, e.Rgt }, "h_categories_idx_left_right");

            entity.HasIndex(e => e.Path, "h_categories_idx_path");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0L)
                .HasColumnName("access");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("alias");
            entity.Property(e => e.AssetId)
                .HasDefaultValue(0L)
                .HasComment("FK to the #__assets table.")
                .HasColumnName("asset_id");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0L)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_time");
            entity.Property(e => e.CreatedUserId)
                .HasDefaultValue(0)
                .HasColumnName("created_user_id");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("''::text")
                .HasColumnName("description");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("extension");
            entity.Property(e => e.Hits)
                .HasDefaultValue(0)
                .HasColumnName("hits");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.Level)
                .HasDefaultValue(0)
                .HasColumnName("level");
            entity.Property(e => e.Lft)
                .HasDefaultValue(0L)
                .HasColumnName("lft");
            entity.Property(e => e.Metadata)
                .HasMaxLength(2048)
                .HasDefaultValueSql("''::character varying")
                .HasComment("JSON encoded metadata properties.")
                .HasColumnName("metadata");
            entity.Property(e => e.Metadesc)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''::character varying")
                .HasComment("The meta description for the page.")
                .HasColumnName("metadesc");
            entity.Property(e => e.Metakey)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''::character varying")
                .HasComment("The meta keywords for the page.")
                .HasColumnName("metakey");
            entity.Property(e => e.ModifiedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified_time");
            entity.Property(e => e.ModifiedUserId)
                .HasDefaultValue(0)
                .HasColumnName("modified_user_id");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("note");
            entity.Property(e => e.Params)
                .HasDefaultValueSql("''::text")
                .HasColumnName("params");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0)
                .HasColumnName("parent_id");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("path");
            entity.Property(e => e.Published)
                .HasDefaultValue((short)0)
                .HasColumnName("published");
            entity.Property(e => e.Rgt)
                .HasDefaultValue(0L)
                .HasColumnName("rgt");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
            entity.Property(e => e.Version)
                .HasDefaultValue(1L)
                .HasColumnName("version");
        });

        modelBuilder.Entity<HContactDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_contact_details_pkey");

            entity.ToTable("h_contact_details");

            entity.HasIndex(e => e.Access, "h_contact_details_idx_access");

            entity.HasIndex(e => e.Catid, "h_contact_details_idx_catid");

            entity.HasIndex(e => e.CheckedOut, "h_contact_details_idx_checkout");

            entity.HasIndex(e => e.CreatedBy, "h_contact_details_idx_createdby");

            entity.HasIndex(e => new { e.Featured, e.Catid }, "h_contact_details_idx_featured_catid");

            entity.HasIndex(e => e.Language, "h_contact_details_idx_language");

            entity.HasIndex(e => e.Published, "h_contact_details_idx_state");

            entity.HasIndex(e => e.Xreference, "h_contact_details_idx_xreference");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0L)
                .HasColumnName("access");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasColumnName("alias");
            entity.Property(e => e.Catid)
                .HasDefaultValue(0L)
                .HasColumnName("catid");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0L)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.ConPosition)
                .HasMaxLength(255)
                .HasColumnName("con_position");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValue(0)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedByAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("created_by_alias");
            entity.Property(e => e.DefaultCon)
                .HasDefaultValue((short)0)
                .HasColumnName("default_con");
            entity.Property(e => e.EmailTo)
                .HasMaxLength(255)
                .HasColumnName("email_to");
            entity.Property(e => e.Fax)
                .HasMaxLength(255)
                .HasColumnName("fax");
            entity.Property(e => e.Featured)
                .HasDefaultValue((short)0)
                .HasComment("Set if contact is featured.")
                .HasColumnName("featured");
            entity.Property(e => e.Hits)
                .HasDefaultValue(0L)
                .HasColumnName("hits");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasColumnName("language");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
            entity.Property(e => e.Metadesc).HasColumnName("metadesc");
            entity.Property(e => e.Metakey).HasColumnName("metakey");
            entity.Property(e => e.Misc).HasColumnName("misc");
            entity.Property(e => e.Mobile)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("mobile");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy)
                .HasDefaultValue(0)
                .HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.Postcode)
                .HasMaxLength(100)
                .HasColumnName("postcode");
            entity.Property(e => e.PublishDown)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_down");
            entity.Property(e => e.PublishUp)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_up");
            entity.Property(e => e.Published)
                .HasDefaultValue((short)0)
                .HasColumnName("published");
            entity.Property(e => e.Sortname1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sortname1");
            entity.Property(e => e.Sortname2)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sortname2");
            entity.Property(e => e.Sortname3)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sortname3");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.Suburb)
                .HasMaxLength(100)
                .HasColumnName("suburb");
            entity.Property(e => e.Telephone)
                .HasMaxLength(255)
                .HasColumnName("telephone");
            entity.Property(e => e.UserId)
                .HasDefaultValue(0L)
                .HasColumnName("user_id");
            entity.Property(e => e.Version)
                .HasDefaultValue(1L)
                .HasColumnName("version");
            entity.Property(e => e.Webpage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("webpage");
            entity.Property(e => e.Xreference)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("A reference to enable linkages to external data sets.")
                .HasColumnName("xreference");
        });

        modelBuilder.Entity<HContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_content_pkey");

            entity.ToTable("h_content");

            entity.HasIndex(e => e.Access, "h_content_idx_access");

            entity.HasIndex(e => e.Alias, "h_content_idx_alias");

            entity.HasIndex(e => e.Catid, "h_content_idx_catid");

            entity.HasIndex(e => e.CheckedOut, "h_content_idx_checkout");

            entity.HasIndex(e => e.CreatedBy, "h_content_idx_createdby");

            entity.HasIndex(e => new { e.Featured, e.Catid }, "h_content_idx_featured_catid");

            entity.HasIndex(e => e.Language, "h_content_idx_language");

            entity.HasIndex(e => e.State, "h_content_idx_state");

            entity.HasIndex(e => e.Xreference, "h_content_idx_xreference");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0L)
                .HasColumnName("access");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("alias");
            entity.Property(e => e.AssetId)
                .HasDefaultValue(0L)
                .HasComment("FK to the #__assets table.")
                .HasColumnName("asset_id");
            entity.Property(e => e.Attribs)
                .HasMaxLength(5120)
                .HasColumnName("attribs");
            entity.Property(e => e.Catid)
                .HasDefaultValue(0L)
                .HasColumnName("catid");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0L)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValue(0L)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedByAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("created_by_alias");
            entity.Property(e => e.Featured)
                .HasDefaultValue((short)0)
                .HasComment("Set if article is featured.")
                .HasColumnName("featured");
            entity.Property(e => e.Fulltext).HasColumnName("fulltext");
            entity.Property(e => e.Hits)
                .HasDefaultValue(0L)
                .HasColumnName("hits");
            entity.Property(e => e.Images).HasColumnName("images");
            entity.Property(e => e.Introtext).HasColumnName("introtext");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasComment("The language code for the article.")
                .HasColumnName("language");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
            entity.Property(e => e.Metadesc).HasColumnName("metadesc");
            entity.Property(e => e.Metakey).HasColumnName("metakey");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy)
                .HasDefaultValue(0L)
                .HasColumnName("modified_by");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("note");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.PublishDown)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_down");
            entity.Property(e => e.PublishUp)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_up");
            entity.Property(e => e.State)
                .HasDefaultValue((short)0)
                .HasColumnName("state");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
            entity.Property(e => e.Urls).HasColumnName("urls");
            entity.Property(e => e.Version)
                .HasDefaultValue(1L)
                .HasColumnName("version");
            entity.Property(e => e.Xreference)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("A reference to enable linkages to external data sets.")
                .HasColumnName("xreference");
        });

        modelBuilder.Entity<HContentFrontpage>(entity =>
        {
            entity.HasKey(e => e.ContentId).HasName("h_content_frontpage_pkey");

            entity.ToTable("h_content_frontpage");

            entity.Property(e => e.ContentId)
                .ValueGeneratedNever()
                .HasDefaultValue(0L)
                .HasColumnName("content_id");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
        });

        modelBuilder.Entity<HContentRating>(entity =>
        {
            entity.HasKey(e => e.ContentId).HasName("h_content_rating_pkey");

            entity.ToTable("h_content_rating");

            entity.Property(e => e.ContentId)
                .ValueGeneratedNever()
                .HasDefaultValue(0L)
                .HasColumnName("content_id");
            entity.Property(e => e.Lastip)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("lastip");
            entity.Property(e => e.RatingCount)
                .HasDefaultValue(0L)
                .HasColumnName("rating_count");
            entity.Property(e => e.RatingSum)
                .HasDefaultValue(0L)
                .HasColumnName("rating_sum");
        });

        modelBuilder.Entity<HContentType>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("h_content_types_pkey");

            entity.ToTable("h_content_types");

            entity.HasIndex(e => e.TypeAlias, "h_content_types_idx_alias");

            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.ContentHistoryOptions)
                .HasMaxLength(5120)
                .HasDefaultValueSql("NULL::character varying")
                .HasComment("JSON string for com_contenthistory options")
                .HasColumnName("content_history_options");
            entity.Property(e => e.FieldMappings).HasColumnName("field_mappings");
            entity.Property(e => e.Router)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("router");
            entity.Property(e => e.Rules).HasColumnName("rules");
            entity.Property(e => e.Table)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("table");
            entity.Property(e => e.TypeAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type_alias");
            entity.Property(e => e.TypeTitle)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type_title");
        });

        modelBuilder.Entity<HContentitemTagMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_contentitem_tag_map");

            entity.HasIndex(e => e.CoreContentId, "h_contentitem_tag_map_idx_core_content_id");

            entity.HasIndex(e => new { e.TagDate, e.TagId }, "h_contentitem_tag_map_idx_date_id");

            entity.HasIndex(e => new { e.TagId, e.TypeId }, "h_contentitem_tag_map_idx_tag_type");

            entity.HasIndex(e => new { e.TypeId, e.ContentItemId, e.TagId }, "h_uc_ItemnameTagid").IsUnique();

            entity.Property(e => e.ContentItemId)
                .HasComment("PK from the content type table")
                .HasColumnName("content_item_id");
            entity.Property(e => e.CoreContentId)
                .HasComment("PK from the core content table")
                .HasColumnName("core_content_id");
            entity.Property(e => e.TagDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasComment("Date of most recent save for this tag-item")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("tag_date");
            entity.Property(e => e.TagId)
                .HasComment("PK from the tag table")
                .HasColumnName("tag_id");
            entity.Property(e => e.TypeAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type_alias");
            entity.Property(e => e.TypeId)
                .HasComment("PK from the content_type table")
                .HasColumnName("type_id");
        });

        modelBuilder.Entity<HCoreLogSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_core_log_searches");

            entity.Property(e => e.Hits)
                .HasDefaultValue(0L)
                .HasColumnName("hits");
            entity.Property(e => e.SearchTerm)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("search_term");
        });

        modelBuilder.Entity<HExtension>(entity =>
        {
            entity.HasKey(e => e.ExtensionId).HasName("h_extensions_pkey");

            entity.ToTable("h_extensions");

            entity.HasIndex(e => new { e.Element, e.ClientId }, "h_extensions_element_clientid");

            entity.HasIndex(e => new { e.Element, e.Folder, e.ClientId }, "h_extensions_element_folder_clientid");

            entity.HasIndex(e => new { e.Type, e.Element, e.Folder, e.ClientId }, "h_extensions_extension");

            entity.Property(e => e.ExtensionId).HasColumnName("extension_id");
            entity.Property(e => e.Access)
                .HasDefaultValue(1L)
                .HasColumnName("access");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CustomData).HasColumnName("custom_data");
            entity.Property(e => e.Element)
                .HasMaxLength(100)
                .HasColumnName("element");
            entity.Property(e => e.Enabled)
                .HasDefaultValue((short)0)
                .HasColumnName("enabled");
            entity.Property(e => e.Folder)
                .HasMaxLength(100)
                .HasColumnName("folder");
            entity.Property(e => e.ManifestCache).HasColumnName("manifest_cache");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.PackageId)
                .HasDefaultValue(0L)
                .HasComment("Parent package ID for extensions installed as a package.")
                .HasColumnName("package_id");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.Protected)
                .HasDefaultValue((short)0)
                .HasColumnName("protected");
            entity.Property(e => e.State)
                .HasDefaultValue(0L)
                .HasColumnName("state");
            entity.Property(e => e.SystemData).HasColumnName("system_data");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<HField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_fields_pkey");

            entity.ToTable("h_fields");

            entity.HasIndex(e => e.Access, "h_fields_idx_access");

            entity.HasIndex(e => e.CheckedOut, "h_fields_idx_checked_out");

            entity.HasIndex(e => e.Context, "h_fields_idx_context");

            entity.HasIndex(e => e.CreatedUserId, "h_fields_idx_created_user_id");

            entity.HasIndex(e => e.Language, "h_fields_idx_language");

            entity.HasIndex(e => e.State, "h_fields_idx_state");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0L)
                .HasColumnName("access");
            entity.Property(e => e.AssetId)
                .HasDefaultValue(0L)
                .HasColumnName("asset_id");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.Context)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("context");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_time");
            entity.Property(e => e.CreatedUserId)
                .HasDefaultValue(0L)
                .HasColumnName("created_user_id");
            entity.Property(e => e.DefaultValue)
                .HasDefaultValueSql("''::text")
                .HasColumnName("default_value");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("''::text")
                .HasColumnName("description");
            entity.Property(e => e.Fieldparams)
                .HasDefaultValueSql("''::text")
                .HasColumnName("fieldparams");
            entity.Property(e => e.GroupId)
                .HasDefaultValue(0L)
                .HasColumnName("group_id");
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("label");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.ModifiedBy)
                .HasDefaultValue(0L)
                .HasColumnName("modified_by");
            entity.Property(e => e.ModifiedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified_time");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("note");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.Params)
                .HasDefaultValueSql("''::text")
                .HasColumnName("params");
            entity.Property(e => e.Required)
                .HasDefaultValue((short)0)
                .HasColumnName("required");
            entity.Property(e => e.State)
                .HasDefaultValue((short)0)
                .HasColumnName("state");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("'text'::character varying")
                .HasColumnName("type");
        });

        modelBuilder.Entity<HFieldsCategory>(entity =>
        {
            entity.HasKey(e => new { e.FieldId, e.CategoryId }).HasName("h_fields_categories_pkey");

            entity.ToTable("h_fields_categories");

            entity.Property(e => e.FieldId)
                .HasDefaultValue(0L)
                .HasColumnName("field_id");
            entity.Property(e => e.CategoryId)
                .HasDefaultValue(0L)
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<HFieldsGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_fields_groups_pkey");

            entity.ToTable("h_fields_groups");

            entity.HasIndex(e => e.Access, "h_fields_groups_idx_access");

            entity.HasIndex(e => e.CheckedOut, "h_fields_groups_idx_checked_out");

            entity.HasIndex(e => e.Context, "h_fields_groups_idx_context");

            entity.HasIndex(e => e.CreatedBy, "h_fields_groups_idx_created_by");

            entity.HasIndex(e => e.Language, "h_fields_groups_idx_language");

            entity.HasIndex(e => e.State, "h_fields_groups_idx_state");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(1L)
                .HasColumnName("access");
            entity.Property(e => e.AssetId)
                .HasDefaultValue(0L)
                .HasColumnName("asset_id");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.Context)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("context");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValue(0L)
                .HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy)
                .HasDefaultValue(0L)
                .HasColumnName("modified_by");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("note");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0)
                .HasColumnName("ordering");
            entity.Property(e => e.Params)
                .HasDefaultValueSql("''::text")
                .HasColumnName("params");
            entity.Property(e => e.State)
                .HasDefaultValue((short)0)
                .HasColumnName("state");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
        });

        modelBuilder.Entity<HFieldsValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_fields_values");

            entity.HasIndex(e => e.FieldId, "h_fields_values_idx_field_id");

            entity.HasIndex(e => e.ItemId, "h_fields_values_idx_item_id");

            entity.Property(e => e.FieldId)
                .HasDefaultValue(0L)
                .HasColumnName("field_id");
            entity.Property(e => e.ItemId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("item_id");
            entity.Property(e => e.Value)
                .HasDefaultValueSql("''::text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<HFinderFilter>(entity =>
        {
            entity.HasKey(e => e.FilterId).HasName("h_finder_filters_pkey");

            entity.ToTable("h_finder_filters");

            entity.Property(e => e.FilterId).HasColumnName("filter_id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasColumnName("alias");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedByAlias)
                .HasMaxLength(255)
                .HasColumnName("created_by_alias");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.MapCount)
                .HasDefaultValue(0)
                .HasColumnName("map_count");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy)
                .HasDefaultValue(0)
                .HasColumnName("modified_by");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.State)
                .HasDefaultValue((short)1)
                .HasColumnName("state");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<HFinderLink>(entity =>
        {
            entity.HasKey(e => e.LinkId).HasName("h_finder_links_pkey");

            entity.ToTable("h_finder_links");

            entity.HasIndex(e => e.Md5sum, "h_finder_links_idx_md5");

            entity.HasIndex(e => new { e.Published, e.State, e.Access, e.PublishStartDate, e.PublishEndDate, e.ListPrice }, "h_finder_links_idx_published_list");

            entity.HasIndex(e => new { e.Published, e.State, e.Access, e.PublishStartDate, e.PublishEndDate, e.SalePrice }, "h_finder_links_idx_published_sale");

            entity.HasIndex(e => e.Title, "h_finder_links_idx_title");

            entity.HasIndex(e => e.TypeId, "h_finder_links_idx_type");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0)
                .HasColumnName("access");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("''::text")
                .HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_date");
            entity.Property(e => e.Indexdate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("indexdate");
            entity.Property(e => e.Language)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.ListPrice)
                .HasPrecision(8, 2)
                .HasColumnName("list_price");
            entity.Property(e => e.Md5sum)
                .HasMaxLength(32)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("md5sum");
            entity.Property(e => e.Object).HasColumnName("object");
            entity.Property(e => e.PublishEndDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_end_date");
            entity.Property(e => e.PublishStartDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_start_date");
            entity.Property(e => e.Published)
                .HasDefaultValue((short)1)
                .HasColumnName("published");
            entity.Property(e => e.Route)
                .HasMaxLength(255)
                .HasColumnName("route");
            entity.Property(e => e.SalePrice)
                .HasPrecision(8, 2)
                .HasColumnName("sale_price");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_date");
            entity.Property(e => e.State)
                .HasDefaultValue(1)
                .HasColumnName("state");
            entity.Property(e => e.Title)
                .HasMaxLength(400)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("title");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<HFinderLinksTerms0>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms0_pkey");

            entity.ToTable("h_finder_links_terms0");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms0_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms0_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms1>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms1_pkey");

            entity.ToTable("h_finder_links_terms1");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms1_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms1_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms2>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms2_pkey");

            entity.ToTable("h_finder_links_terms2");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms2_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms2_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms3>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms3_pkey");

            entity.ToTable("h_finder_links_terms3");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms3_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms3_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms4>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms4_pkey");

            entity.ToTable("h_finder_links_terms4");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms4_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms4_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms5>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms5_pkey");

            entity.ToTable("h_finder_links_terms5");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms5_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms5_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms6>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms6_pkey");

            entity.ToTable("h_finder_links_terms6");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms6_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms6_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms7>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms7_pkey");

            entity.ToTable("h_finder_links_terms7");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms7_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms7_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms8>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms8_pkey");

            entity.ToTable("h_finder_links_terms8");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms8_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms8_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTerms9>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_terms9_pkey");

            entity.ToTable("h_finder_links_terms9");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_terms9_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_terms9_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTermsa>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_termsa_pkey");

            entity.ToTable("h_finder_links_termsa");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_termsa_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_termsa_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTermsb>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_termsb_pkey");

            entity.ToTable("h_finder_links_termsb");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_termsb_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_termsb_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTermsc>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_termsc_pkey");

            entity.ToTable("h_finder_links_termsc");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_termsc_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_termsc_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTermsd>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_termsd_pkey");

            entity.ToTable("h_finder_links_termsd");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_termsd_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_termsd_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTermse>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_termse_pkey");

            entity.ToTable("h_finder_links_termse");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_termse_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_termse_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderLinksTermsf>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.TermId }).HasName("h_finder_links_termsf_pkey");

            entity.ToTable("h_finder_links_termsf");

            entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "h_finder_links_termsf_idx_link_term_weight");

            entity.HasIndex(e => new { e.TermId, e.Weight }, "h_finder_links_termsf_idx_term_weight");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderTaxonomy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_finder_taxonomy_pkey");

            entity.ToTable("h_finder_taxonomy");

            entity.HasIndex(e => e.Access, "h_finder_taxonomy_access");

            entity.HasIndex(e => new { e.ParentId, e.State, e.Access }, "h_finder_taxonomy_idx_parent_published");

            entity.HasIndex(e => e.Ordering, "h_finder_taxonomy_ordering");

            entity.HasIndex(e => e.ParentId, "h_finder_taxonomy_parent_id");

            entity.HasIndex(e => e.State, "h_finder_taxonomy_state");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue((short)0)
                .HasColumnName("access");
            entity.Property(e => e.Ordering)
                .HasDefaultValue((short)0)
                .HasColumnName("ordering");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0)
                .HasColumnName("parent_id");
            entity.Property(e => e.State)
                .HasDefaultValue((short)1)
                .HasColumnName("state");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<HFinderTaxonomyMap>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.NodeId }).HasName("h_finder_taxonomy_map_pkey");

            entity.ToTable("h_finder_taxonomy_map");

            entity.HasIndex(e => e.LinkId, "h_finder_taxonomy_map_link_id");

            entity.HasIndex(e => e.NodeId, "h_finder_taxonomy_map_node_id");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.NodeId).HasColumnName("node_id");
        });

        modelBuilder.Entity<HFinderTerm>(entity =>
        {
            entity.HasKey(e => e.TermId).HasName("h_finder_terms_pkey");

            entity.ToTable("h_finder_terms");

            entity.HasIndex(e => new { e.Soundex, e.Phrase }, "h_finder_terms_idx_soundex_phrase");

            entity.HasIndex(e => new { e.Stem, e.Phrase }, "h_finder_terms_idx_stem_phrase");

            entity.HasIndex(e => e.Term, "h_finder_terms_idx_term").IsUnique();

            entity.HasIndex(e => new { e.Term, e.Phrase }, "h_finder_terms_idx_term_phrase");

            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Common)
                .HasDefaultValue((short)0)
                .HasColumnName("common");
            entity.Property(e => e.Language)
                .HasMaxLength(3)
                .HasColumnName("language");
            entity.Property(e => e.Links)
                .HasDefaultValue(0)
                .HasColumnName("links");
            entity.Property(e => e.Phrase)
                .HasDefaultValue((short)0)
                .HasColumnName("phrase");
            entity.Property(e => e.Soundex)
                .HasMaxLength(75)
                .HasColumnName("soundex");
            entity.Property(e => e.Stem)
                .HasMaxLength(75)
                .HasColumnName("stem");
            entity.Property(e => e.Term)
                .HasMaxLength(75)
                .HasColumnName("term");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderTermsCommon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_finder_terms_common");

            entity.HasIndex(e => e.Language, "h_finder_terms_common_idx_lang");

            entity.HasIndex(e => new { e.Term, e.Language }, "h_finder_terms_common_idx_word_lang");

            entity.Property(e => e.Language)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.Term)
                .HasMaxLength(75)
                .HasColumnName("term");
        });

        modelBuilder.Entity<HFinderToken>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_finder_tokens");

            entity.HasIndex(e => e.Context, "h_finder_tokens_idx_context");

            entity.HasIndex(e => e.Term, "h_finder_tokens_idx_word");

            entity.Property(e => e.Common)
                .HasDefaultValue((short)0)
                .HasColumnName("common");
            entity.Property(e => e.Context)
                .HasDefaultValue((short)2)
                .HasColumnName("context");
            entity.Property(e => e.Language)
                .HasMaxLength(3)
                .HasColumnName("language");
            entity.Property(e => e.Phrase)
                .HasDefaultValue((short)0)
                .HasColumnName("phrase");
            entity.Property(e => e.Stem)
                .HasMaxLength(75)
                .HasColumnName("stem");
            entity.Property(e => e.Term)
                .HasMaxLength(75)
                .HasColumnName("term");
            entity.Property(e => e.Weight)
                .HasPrecision(8, 2)
                .HasDefaultValueSql("1")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<HFinderTokensAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_finder_tokens_aggregate");

            entity.HasIndex(e => e.TermId, "_h_finder_tokens_aggregate_keyword_id");

            entity.HasIndex(e => e.Term, "h_finder_tokens_aggregate_token");

            entity.Property(e => e.Common)
                .HasDefaultValue((short)0)
                .HasColumnName("common");
            entity.Property(e => e.Context)
                .HasDefaultValue((short)2)
                .HasColumnName("context");
            entity.Property(e => e.ContextWeight)
                .HasPrecision(8, 2)
                .HasColumnName("context_weight");
            entity.Property(e => e.Language)
                .HasMaxLength(3)
                .HasColumnName("language");
            entity.Property(e => e.MapSuffix)
                .HasMaxLength(1)
                .HasColumnName("map_suffix");
            entity.Property(e => e.Phrase)
                .HasDefaultValue((short)0)
                .HasColumnName("phrase");
            entity.Property(e => e.Stem)
                .HasMaxLength(75)
                .HasColumnName("stem");
            entity.Property(e => e.Term)
                .HasMaxLength(75)
                .HasColumnName("term");
            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.TermWeight)
                .HasPrecision(8, 2)
                .HasColumnName("term_weight");
            entity.Property(e => e.TotalWeight)
                .HasPrecision(8, 2)
                .HasColumnName("total_weight");
        });

        modelBuilder.Entity<HFinderType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_finder_types_pkey");

            entity.ToTable("h_finder_types");

            entity.HasIndex(e => e.Title, "h_finder_types_title").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mime)
                .HasMaxLength(100)
                .HasColumnName("mime");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<HLanguage>(entity =>
        {
            entity.HasKey(e => e.LangId).HasName("h_languages_pkey");

            entity.ToTable("h_languages");

            entity.HasIndex(e => e.Access, "h_languages_idx_access");

            entity.HasIndex(e => e.LangCode, "h_languages_idx_langcode").IsUnique();

            entity.HasIndex(e => e.Ordering, "h_languages_idx_ordering");

            entity.HasIndex(e => e.Sef, "h_languages_idx_sef").IsUnique();

            entity.Property(e => e.LangId).HasColumnName("lang_id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0)
                .HasColumnName("access");
            entity.Property(e => e.AssetId)
                .HasDefaultValue(0L)
                .HasColumnName("asset_id");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .HasColumnName("image");
            entity.Property(e => e.LangCode)
                .HasMaxLength(7)
                .HasColumnName("lang_code");
            entity.Property(e => e.Metadesc).HasColumnName("metadesc");
            entity.Property(e => e.Metakey).HasColumnName("metakey");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.Published)
                .HasDefaultValue(0L)
                .HasColumnName("published");
            entity.Property(e => e.Sef)
                .HasMaxLength(50)
                .HasColumnName("sef");
            entity.Property(e => e.Sitename)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sitename");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.TitleNative)
                .HasMaxLength(50)
                .HasColumnName("title_native");
        });

        modelBuilder.Entity<HMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_menu_pkey");

            entity.ToTable("h_menu");

            entity.HasIndex(e => e.Alias, "h_menu_idx_alias");

            entity.HasIndex(e => new { e.ClientId, e.ParentId, e.Alias, e.Language }, "h_menu_idx_client_id_parent_id_alias_language").IsUnique();

            entity.HasIndex(e => new { e.ComponentId, e.Menutype, e.Published, e.Access }, "h_menu_idx_componentid");

            entity.HasIndex(e => e.Language, "h_menu_idx_language");

            entity.HasIndex(e => new { e.Lft, e.Rgt }, "h_menu_idx_left_right");

            entity.HasIndex(e => e.Menutype, "h_menu_idx_menutype");

            entity.HasIndex(e => e.Path, "h_menu_idx_path");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0L)
                .HasComment("The access level required to view the menu item.")
                .HasColumnName("access");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasComment("The SEF alias of the menu item.")
                .HasColumnName("alias");
            entity.Property(e => e.BrowserNav)
                .HasDefaultValue((short)0)
                .HasComment("The click behaviour of the link.")
                .HasColumnName("browserNav");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0)
                .HasComment("FK to #__users.id")
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasComment("The time the menu item was checked out.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.ClientId)
                .HasDefaultValue((short)0)
                .HasColumnName("client_id");
            entity.Property(e => e.ComponentId)
                .HasDefaultValue(0)
                .HasComment("FK to #__extensions.id")
                .HasColumnName("component_id");
            entity.Property(e => e.Home)
                .HasDefaultValue((short)0)
                .HasComment("Indicates if this menu item is the home or default page.")
                .HasColumnName("home");
            entity.Property(e => e.Img)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasComment("The image of the menu item.")
                .HasColumnName("img");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.Level)
                .HasDefaultValue(0)
                .HasComment("The relative level in the tree.")
                .HasColumnName("level");
            entity.Property(e => e.Lft)
                .HasDefaultValue(0L)
                .HasComment("Nested set lft.")
                .HasColumnName("lft");
            entity.Property(e => e.Link)
                .HasMaxLength(1024)
                .HasComment("The actually link the menu item refers to.")
                .HasColumnName("link");
            entity.Property(e => e.Menutype)
                .HasMaxLength(24)
                .HasComment("The type of menu this item belongs to. FK to #__menu_types.menutype")
                .HasColumnName("menutype");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("note");
            entity.Property(e => e.Params)
                .HasDefaultValueSql("''::text")
                .HasComment("JSON encoded data for the menu item.")
                .HasColumnName("params");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(1)
                .HasComment("The parent menu item in the menu tree.")
                .HasColumnName("parent_id");
            entity.Property(e => e.Path)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''::character varying")
                .HasComment("The computed path of the menu item based on the alias field.")
                .HasColumnName("path");
            entity.Property(e => e.Published)
                .HasDefaultValue((short)0)
                .HasComment("The published state of the menu link.")
                .HasColumnName("published");
            entity.Property(e => e.Rgt)
                .HasDefaultValue(0L)
                .HasComment("Nested set rgt.")
                .HasColumnName("rgt");
            entity.Property(e => e.TemplateStyleId)
                .HasDefaultValue(0)
                .HasColumnName("template_style_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasComment("The display title of the menu item.")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(16)
                .HasComment("The type of link: Component, URL, Alias, Separator")
                .HasColumnName("type");
        });

        modelBuilder.Entity<HMenuType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_menu_types_pkey");

            entity.ToTable("h_menu_types");

            entity.HasIndex(e => e.Menutype, "h_menu_types_idx_menutype").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssetId)
                .HasDefaultValue(0L)
                .HasColumnName("asset_id");
            entity.Property(e => e.ClientId)
                .HasDefaultValue(0)
                .HasColumnName("client_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("description");
            entity.Property(e => e.Menutype)
                .HasMaxLength(24)
                .HasColumnName("menutype");
            entity.Property(e => e.Title)
                .HasMaxLength(48)
                .HasColumnName("title");
        });

        modelBuilder.Entity<HMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("h_messages_pkey");

            entity.ToTable("h_messages");

            entity.HasIndex(e => new { e.UserIdTo, e.State }, "h_messages_useridto_state");

            entity.Property(e => e.MessageId).HasColumnName("message_id");
            entity.Property(e => e.DateTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_time");
            entity.Property(e => e.FolderId)
                .HasDefaultValue((short)0)
                .HasColumnName("folder_id");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Priority)
                .HasDefaultValue((short)0)
                .HasColumnName("priority");
            entity.Property(e => e.State)
                .HasDefaultValue((short)0)
                .HasColumnName("state");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("subject");
            entity.Property(e => e.UserIdFrom)
                .HasDefaultValue(0L)
                .HasColumnName("user_id_from");
            entity.Property(e => e.UserIdTo)
                .HasDefaultValue(0L)
                .HasColumnName("user_id_to");
        });

        modelBuilder.Entity<HMessagesCfg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_messages_cfg");

            entity.HasIndex(e => new { e.UserId, e.CfgName }, "h_messages_cfg_idx_user_var_name").IsUnique();

            entity.Property(e => e.CfgName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cfg_name");
            entity.Property(e => e.CfgValue)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cfg_value");
            entity.Property(e => e.UserId)
                .HasDefaultValue(0L)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<HModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_modules_pkey");

            entity.ToTable("h_modules");

            entity.HasIndex(e => e.Language, "h_modules_idx_language");

            entity.HasIndex(e => new { e.Module, e.Published }, "h_modules_newsfeeds");

            entity.HasIndex(e => new { e.Published, e.Access }, "h_modules_published");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0L)
                .HasColumnName("access");
            entity.Property(e => e.AssetId)
                .HasDefaultValue(0L)
                .HasColumnName("asset_id");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.ClientId)
                .HasDefaultValue((short)0)
                .HasColumnName("client_id");
            entity.Property(e => e.Content)
                .HasDefaultValueSql("''::text")
                .HasColumnName("content");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasColumnName("language");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("module");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("note");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("position");
            entity.Property(e => e.PublishDown)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_down");
            entity.Property(e => e.PublishUp)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_up");
            entity.Property(e => e.Published)
                .HasDefaultValue((short)0)
                .HasColumnName("published");
            entity.Property(e => e.Showtitle)
                .HasDefaultValue((short)1)
                .HasColumnName("showtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
        });

        modelBuilder.Entity<HModulesMenu>(entity =>
        {
            entity.HasKey(e => new { e.Moduleid, e.Menuid }).HasName("h_modules_menu_pkey");

            entity.ToTable("h_modules_menu");

            entity.Property(e => e.Moduleid)
                .HasDefaultValue(0L)
                .HasColumnName("moduleid");
            entity.Property(e => e.Menuid)
                .HasDefaultValue(0L)
                .HasColumnName("menuid");
        });

        modelBuilder.Entity<HNewsfeed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_newsfeeds_pkey");

            entity.ToTable("h_newsfeeds");

            entity.HasIndex(e => e.Access, "h_newsfeeds_idx_access");

            entity.HasIndex(e => e.Catid, "h_newsfeeds_idx_catid");

            entity.HasIndex(e => e.CheckedOut, "h_newsfeeds_idx_checkout");

            entity.HasIndex(e => e.CreatedBy, "h_newsfeeds_idx_createdby");

            entity.HasIndex(e => e.Language, "h_newsfeeds_idx_language");

            entity.HasIndex(e => e.Published, "h_newsfeeds_idx_state");

            entity.HasIndex(e => e.Xreference, "h_newsfeeds_idx_xreference");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0L)
                .HasColumnName("access");
            entity.Property(e => e.Alias)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("alias");
            entity.Property(e => e.CacheTime)
                .HasDefaultValue(3600L)
                .HasColumnName("cache_time");
            entity.Property(e => e.Catid)
                .HasDefaultValue(0L)
                .HasColumnName("catid");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValue(0)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedByAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("created_by_alias");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Hits)
                .HasDefaultValue(0L)
                .HasColumnName("hits");
            entity.Property(e => e.Images).HasColumnName("images");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.Link)
                .HasMaxLength(2048)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("link");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
            entity.Property(e => e.Metadesc).HasColumnName("metadesc");
            entity.Property(e => e.Metakey).HasColumnName("metakey");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy)
                .HasDefaultValue(0)
                .HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Numarticles)
                .HasDefaultValue(1L)
                .HasColumnName("numarticles");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.PublishDown)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_down");
            entity.Property(e => e.PublishUp)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_up");
            entity.Property(e => e.Published)
                .HasDefaultValue((short)0)
                .HasColumnName("published");
            entity.Property(e => e.Rtl)
                .HasDefaultValue((short)0)
                .HasColumnName("rtl");
            entity.Property(e => e.Version)
                .HasDefaultValue(1L)
                .HasColumnName("version");
            entity.Property(e => e.Xreference)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("A reference to enable linkages to external data sets.")
                .HasColumnName("xreference");
        });

        modelBuilder.Entity<HOverrider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_overrider_pkey");

            entity.ToTable("h_overrider");

            entity.Property(e => e.Id)
                .HasComment("Primary Key")
                .HasColumnName("id");
            entity.Property(e => e.Constant)
                .HasMaxLength(255)
                .HasColumnName("constant");
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .HasColumnName("file");
            entity.Property(e => e.String).HasColumnName("string");
        });

        modelBuilder.Entity<HPostinstallMessage>(entity =>
        {
            entity.HasKey(e => e.PostinstallMessageId).HasName("h_postinstall_messages_pkey");

            entity.ToTable("h_postinstall_messages");

            entity.Property(e => e.PostinstallMessageId).HasColumnName("postinstall_message_id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasComment("Action method name or URL")
                .HasColumnName("action");
            entity.Property(e => e.ActionFile)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasComment("RAD URI to the PHP file containing action method")
                .HasColumnName("action_file");
            entity.Property(e => e.ActionKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("action_key");
            entity.Property(e => e.ConditionFile)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasComment("RAD URI to file holding display condition method")
                .HasColumnName("condition_file");
            entity.Property(e => e.ConditionMethod)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasComment("Display condition method, must return boolean")
                .HasColumnName("condition_method");
            entity.Property(e => e.DescriptionKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasComment("Lang key for description")
                .HasColumnName("description_key");
            entity.Property(e => e.Enabled)
                .HasDefaultValue((short)1)
                .HasColumnName("enabled");
            entity.Property(e => e.ExtensionId)
                .HasDefaultValue(700L)
                .HasComment("FK to jos_extensions")
                .HasColumnName("extension_id");
            entity.Property(e => e.LanguageClientId)
                .HasDefaultValue((short)1)
                .HasColumnName("language_client_id");
            entity.Property(e => e.LanguageExtension)
                .HasMaxLength(255)
                .HasDefaultValueSql("'com_postinstall'::character varying")
                .HasComment("Extension holding lang keys")
                .HasColumnName("language_extension");
            entity.Property(e => e.TitleKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasComment("Lang key for the title")
                .HasColumnName("title_key");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasDefaultValueSql("'link'::character varying")
                .HasComment("Message type - message, link, action")
                .HasColumnName("type");
            entity.Property(e => e.VersionIntroduced)
                .HasMaxLength(255)
                .HasDefaultValueSql("'3.2.0'::character varying")
                .HasComment("Version when this message was introduced")
                .HasColumnName("version_introduced");
        });

        modelBuilder.Entity<HPrivacyConsent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_privacy_consents_pkey");

            entity.ToTable("h_privacy_consents");

            entity.HasIndex(e => e.UserId, "h_privacy_consents_idx_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created");
            entity.Property(e => e.Remind)
                .HasDefaultValue((short)0)
                .HasColumnName("remind");
            entity.Property(e => e.State)
                .HasDefaultValue((short)1)
                .HasColumnName("state");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("subject");
            entity.Property(e => e.Token)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("token");
            entity.Property(e => e.UserId)
                .HasDefaultValue(0L)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<HPrivacyRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_privacy_requests_pkey");

            entity.ToTable("h_privacy_requests");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConfirmToken)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("confirm_token");
            entity.Property(e => e.ConfirmTokenCreatedAt)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("confirm_token_created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email");
            entity.Property(e => e.RequestType)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("request_type");
            entity.Property(e => e.RequestedAt)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("requested_at");
            entity.Property(e => e.Status)
                .HasDefaultValue((short)0)
                .HasColumnName("status");
        });

        modelBuilder.Entity<HRedirectLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_redirect_links_pkey");

            entity.ToTable("h_redirect_links");

            entity.HasIndex(e => e.ModifiedDate, "h_redirect_links_idx_link_modifed");

            entity.HasIndex(e => e.OldUrl, "h_redirect_links_idx_old_url");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Header)
                .HasDefaultValue(301)
                .HasColumnName("header");
            entity.Property(e => e.Hits)
                .HasDefaultValue(0L)
                .HasColumnName("hits");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified_date");
            entity.Property(e => e.NewUrl)
                .HasMaxLength(2048)
                .HasColumnName("new_url");
            entity.Property(e => e.OldUrl)
                .HasMaxLength(2048)
                .HasColumnName("old_url");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Referer)
                .HasMaxLength(2048)
                .HasColumnName("referer");
        });

        modelBuilder.Entity<HSchema>(entity =>
        {
            entity.HasKey(e => new { e.ExtensionId, e.VersionId }).HasName("h_schemas_pkey");

            entity.ToTable("h_schemas");

            entity.Property(e => e.ExtensionId).HasColumnName("extension_id");
            entity.Property(e => e.VersionId)
                .HasMaxLength(20)
                .HasColumnName("version_id");
        });

        modelBuilder.Entity<HSession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("h_session_pkey");

            entity.ToTable("h_session");

            entity.HasIndex(e => new { e.ClientId, e.Guest }, "h_session_idx_client_id_guest");

            entity.HasIndex(e => e.Time, "h_session_time");

            entity.HasIndex(e => e.Userid, "h_session_userid");

            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Guest)
                .HasDefaultValue((short)1)
                .HasColumnName("guest");
            entity.Property(e => e.Time)
                .HasDefaultValue(0)
                .HasColumnName("time");
            entity.Property(e => e.Userid)
                .HasDefaultValue(0L)
                .HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("username");
        });

        modelBuilder.Entity<HTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_tags_pkey");

            entity.ToTable("h_tags");

            entity.HasIndex(e => new { e.Published, e.Access }, "h_tags_cat_idx");

            entity.HasIndex(e => e.Access, "h_tags_idx_access");

            entity.HasIndex(e => e.Alias, "h_tags_idx_alias");

            entity.HasIndex(e => e.CheckedOut, "h_tags_idx_checkout");

            entity.HasIndex(e => e.Language, "h_tags_idx_language");

            entity.HasIndex(e => new { e.Lft, e.Rgt }, "h_tags_idx_left_right");

            entity.HasIndex(e => e.Path, "h_tags_idx_path");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(0L)
                .HasColumnName("access");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("alias");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0L)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.CreatedByAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("created_by_alias");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_time");
            entity.Property(e => e.CreatedUserId)
                .HasDefaultValue(0)
                .HasColumnName("created_user_id");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("''::text")
                .HasColumnName("description");
            entity.Property(e => e.Hits)
                .HasDefaultValue(0)
                .HasColumnName("hits");
            entity.Property(e => e.Images).HasColumnName("images");
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("language");
            entity.Property(e => e.Level)
                .HasDefaultValue(0)
                .HasColumnName("level");
            entity.Property(e => e.Lft)
                .HasDefaultValue(0L)
                .HasColumnName("lft");
            entity.Property(e => e.Metadata)
                .HasMaxLength(2048)
                .HasColumnName("metadata");
            entity.Property(e => e.Metadesc)
                .HasMaxLength(1024)
                .HasColumnName("metadesc");
            entity.Property(e => e.Metakey)
                .HasMaxLength(1024)
                .HasColumnName("metakey");
            entity.Property(e => e.ModifiedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified_time");
            entity.Property(e => e.ModifiedUserId)
                .HasDefaultValue(0)
                .HasColumnName("modified_user_id");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("note");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0L)
                .HasColumnName("parent_id");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("path");
            entity.Property(e => e.PublishDown)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_down");
            entity.Property(e => e.PublishUp)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_up");
            entity.Property(e => e.Published)
                .HasDefaultValue((short)0)
                .HasColumnName("published");
            entity.Property(e => e.Rgt)
                .HasDefaultValue(0L)
                .HasColumnName("rgt");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Urls).HasColumnName("urls");
            entity.Property(e => e.Version)
                .HasDefaultValue(1L)
                .HasColumnName("version");
        });

        modelBuilder.Entity<HTemplateStyle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_template_styles_pkey");

            entity.ToTable("h_template_styles");

            entity.HasIndex(e => e.ClientId, "h_template_styles_idx_client_id");

            entity.HasIndex(e => new { e.ClientId, e.Home }, "h_template_styles_idx_client_id_home");

            entity.HasIndex(e => e.Template, "h_template_styles_idx_template");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasDefaultValue((short)0)
                .HasColumnName("client_id");
            entity.Property(e => e.Home)
                .HasMaxLength(7)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("home");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.Template)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("template");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
        });

        modelBuilder.Entity<HUcmBase>(entity =>
        {
            entity.HasKey(e => e.UcmId).HasName("h_ucm_base_pkey");

            entity.ToTable("h_ucm_base");

            entity.HasIndex(e => e.UcmItemId, "h_ucm_base_ucm_item_id");

            entity.HasIndex(e => e.UcmLanguageId, "h_ucm_base_ucm_language_id");

            entity.HasIndex(e => e.UcmTypeId, "h_ucm_base_ucm_type_id");

            entity.Property(e => e.UcmId).HasColumnName("ucm_id");
            entity.Property(e => e.UcmItemId).HasColumnName("ucm_item_id");
            entity.Property(e => e.UcmLanguageId).HasColumnName("ucm_language_id");
            entity.Property(e => e.UcmTypeId).HasColumnName("ucm_type_id");
        });

        modelBuilder.Entity<HUcmContent>(entity =>
        {
            entity.HasKey(e => e.CoreContentId).HasName("h_ucm_content_pkey");

            entity.ToTable("h_ucm_content");

            entity.HasIndex(e => e.CoreAccess, "h_ucm_content_idx_access");

            entity.HasIndex(e => e.CoreAlias, "h_ucm_content_idx_alias");

            entity.HasIndex(e => e.CoreTypeAlias, "h_ucm_content_idx_content_type");

            entity.HasIndex(e => e.CoreCheckedOutUserId, "h_ucm_content_idx_core_checked_out_user_id");

            entity.HasIndex(e => e.CoreCreatedUserId, "h_ucm_content_idx_core_created_user_id");

            entity.HasIndex(e => e.CoreModifiedUserId, "h_ucm_content_idx_core_modified_user_id");

            entity.HasIndex(e => e.CoreTypeId, "h_ucm_content_idx_core_type_id");

            entity.HasIndex(e => e.CoreCreatedTime, "h_ucm_content_idx_created_time");

            entity.HasIndex(e => e.CoreLanguage, "h_ucm_content_idx_language");

            entity.HasIndex(e => e.CoreModifiedTime, "h_ucm_content_idx_modified_time");

            entity.HasIndex(e => e.CoreTitle, "h_ucm_content_idx_title");

            entity.HasIndex(e => new { e.CoreTypeAlias, e.CoreContentItemId }, "h_ucm_content_idx_type_alias_item_id").IsUnique();

            entity.HasIndex(e => new { e.CoreState, e.CoreAccess }, "h_ucm_content_tag_idx");

            entity.Property(e => e.CoreContentId).HasColumnName("core_content_id");
            entity.Property(e => e.AssetId)
                .HasDefaultValue(0L)
                .HasColumnName("asset_id");
            entity.Property(e => e.CoreAccess)
                .HasDefaultValue(0L)
                .HasColumnName("core_access");
            entity.Property(e => e.CoreAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("core_alias");
            entity.Property(e => e.CoreBody)
                .HasDefaultValueSql("''::text")
                .HasColumnName("core_body");
            entity.Property(e => e.CoreCatid)
                .HasDefaultValue(0L)
                .HasColumnName("core_catid");
            entity.Property(e => e.CoreCheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("core_checked_out_time");
            entity.Property(e => e.CoreCheckedOutUserId)
                .HasDefaultValue(0L)
                .HasColumnName("core_checked_out_user_id");
            entity.Property(e => e.CoreContentItemId)
                .HasDefaultValue(0L)
                .HasColumnName("core_content_item_id");
            entity.Property(e => e.CoreCreatedByAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("core_created_by_alias");
            entity.Property(e => e.CoreCreatedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("core_created_time");
            entity.Property(e => e.CoreCreatedUserId)
                .HasDefaultValue(0L)
                .HasColumnName("core_created_user_id");
            entity.Property(e => e.CoreFeatured)
                .HasDefaultValue((short)0)
                .HasColumnName("core_featured");
            entity.Property(e => e.CoreHits)
                .HasDefaultValue(0L)
                .HasColumnName("core_hits");
            entity.Property(e => e.CoreImages)
                .HasDefaultValueSql("''::text")
                .HasColumnName("core_images");
            entity.Property(e => e.CoreLanguage)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("core_language");
            entity.Property(e => e.CoreMetadata)
                .HasDefaultValueSql("''::text")
                .HasColumnName("core_metadata");
            entity.Property(e => e.CoreMetadesc)
                .HasDefaultValueSql("''::text")
                .HasColumnName("core_metadesc");
            entity.Property(e => e.CoreMetakey)
                .HasDefaultValueSql("''::text")
                .HasColumnName("core_metakey");
            entity.Property(e => e.CoreModifiedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("core_modified_time");
            entity.Property(e => e.CoreModifiedUserId)
                .HasDefaultValue(0L)
                .HasColumnName("core_modified_user_id");
            entity.Property(e => e.CoreOrdering)
                .HasDefaultValue(0L)
                .HasColumnName("core_ordering");
            entity.Property(e => e.CoreParams)
                .HasDefaultValueSql("''::text")
                .HasColumnName("core_params");
            entity.Property(e => e.CorePublishDown)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("core_publish_down");
            entity.Property(e => e.CorePublishUp)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("core_publish_up");
            entity.Property(e => e.CoreState)
                .HasDefaultValue((short)0)
                .HasColumnName("core_state");
            entity.Property(e => e.CoreTitle)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("core_title");
            entity.Property(e => e.CoreTypeAlias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("core_type_alias");
            entity.Property(e => e.CoreTypeId)
                .HasDefaultValue(0L)
                .HasColumnName("core_type_id");
            entity.Property(e => e.CoreUrls)
                .HasDefaultValueSql("''::text")
                .HasColumnName("core_urls");
            entity.Property(e => e.CoreVersion)
                .HasDefaultValue(1L)
                .HasColumnName("core_version");
            entity.Property(e => e.CoreXreference)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("core_xreference");
        });

        modelBuilder.Entity<HUcmHistory>(entity =>
        {
            entity.HasKey(e => e.VersionId).HasName("h_ucm_history_pkey");

            entity.ToTable("h_ucm_history");

            entity.HasIndex(e => e.SaveDate, "h_ucm_history_idx_save_date");

            entity.HasIndex(e => new { e.UcmTypeId, e.UcmItemId }, "h_ucm_history_idx_ucm_item_id");

            entity.Property(e => e.VersionId).HasColumnName("version_id");
            entity.Property(e => e.CharacterCount)
                .HasDefaultValue(0)
                .HasComment("Number of characters in this version.")
                .HasColumnName("character_count");
            entity.Property(e => e.EditorUserId)
                .HasDefaultValue(0)
                .HasColumnName("editor_user_id");
            entity.Property(e => e.KeepForever)
                .HasDefaultValue((short)0)
                .HasComment("0=auto delete; 1=keep")
                .HasColumnName("keep_forever");
            entity.Property(e => e.SaveDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00-05'::timestamp with time zone")
                .HasColumnName("save_date");
            entity.Property(e => e.Sha1Hash)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("SHA1 hash of the version_data column.")
                .HasColumnName("sha1_hash");
            entity.Property(e => e.UcmItemId).HasColumnName("ucm_item_id");
            entity.Property(e => e.UcmTypeId).HasColumnName("ucm_type_id");
            entity.Property(e => e.VersionData)
                .HasComment("json-encoded string of version data")
                .HasColumnName("version_data");
            entity.Property(e => e.VersionNote)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasComment("Optional version name")
                .HasColumnName("version_note");
        });

        modelBuilder.Entity<HUpdate>(entity =>
        {
            entity.HasKey(e => e.UpdateId).HasName("h_updates_pkey");

            entity.ToTable("h_updates", tb => tb.HasComment("Available Updates"));

            entity.Property(e => e.UpdateId).HasColumnName("update_id");
            entity.Property(e => e.ClientId)
                .HasDefaultValue((short)0)
                .HasColumnName("client_id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Detailsurl).HasColumnName("detailsurl");
            entity.Property(e => e.Element)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("element");
            entity.Property(e => e.ExtensionId)
                .HasDefaultValue(0L)
                .HasColumnName("extension_id");
            entity.Property(e => e.ExtraQuery)
                .HasMaxLength(1000)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("extra_query");
            entity.Property(e => e.Folder)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("folder");
            entity.Property(e => e.Infourl).HasColumnName("infourl");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type");
            entity.Property(e => e.UpdateSiteId)
                .HasDefaultValue(0L)
                .HasColumnName("update_site_id");
            entity.Property(e => e.Version)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("version");
        });

        modelBuilder.Entity<HUpdateSite>(entity =>
        {
            entity.HasKey(e => e.UpdateSiteId).HasName("h_update_sites_pkey");

            entity.ToTable("h_update_sites", tb => tb.HasComment("Update Sites"));

            entity.Property(e => e.UpdateSiteId).HasColumnName("update_site_id");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(0L)
                .HasColumnName("enabled");
            entity.Property(e => e.ExtraQuery)
                .HasMaxLength(1000)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("extra_query");
            entity.Property(e => e.LastCheckTimestamp)
                .HasDefaultValue(0L)
                .HasColumnName("last_check_timestamp");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type");
        });

        modelBuilder.Entity<HUpdateSitesExtension>(entity =>
        {
            entity.HasKey(e => new { e.UpdateSiteId, e.ExtensionId }).HasName("h_update_sites_extensions_pkey");

            entity.ToTable("h_update_sites_extensions", tb => tb.HasComment("Links extensions to update sites"));

            entity.Property(e => e.UpdateSiteId)
                .HasDefaultValue(0L)
                .HasColumnName("update_site_id");
            entity.Property(e => e.ExtensionId)
                .HasDefaultValue(0L)
                .HasColumnName("extension_id");
        });

        modelBuilder.Entity<HUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_users_pkey");

            entity.ToTable("h_users");

            entity.HasIndex(e => e.Email, "h_users_email");

            entity.HasIndex(e => e.Block, "h_users_idx_block");

            entity.HasIndex(e => e.Name, "h_users_idx_name");

            entity.HasIndex(e => e.Username, "h_users_username");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('emp_eid_seq0'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Activation)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("activation");
            entity.Property(e => e.Block)
                .HasDefaultValue((short)0)
                .HasColumnName("block");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email");
            entity.Property(e => e.LastResetTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasComment("Date of last password reset")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastResetTime");
            entity.Property(e => e.LastvisitDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastvisitDate");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Otep)
                .HasMaxLength(1000)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("otep");
            entity.Property(e => e.OtpKey)
                .HasMaxLength(1000)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("otpKey");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("password");
            entity.Property(e => e.RegisterDate)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("registerDate");
            entity.Property(e => e.RequireReset)
                .HasDefaultValue((short)0)
                .HasComment("Require user to reset password on next login")
                .HasColumnName("requireReset");
            entity.Property(e => e.ResetCount)
                .HasDefaultValue(0L)
                .HasComment("Count of password resets since lastResetTime")
                .HasColumnName("resetCount");
            entity.Property(e => e.SendEmail)
                .HasDefaultValue((short)0)
                .HasColumnName("sendEmail");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("username");
        });

        modelBuilder.Entity<HUserKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_user_keys_pkey");

            entity.ToTable("h_user_keys");

            entity.HasIndex(e => e.UserId, "h_user_keys_idx_user_id");

            entity.HasIndex(e => e.Series, "h_user_keys_series").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Invalid).HasColumnName("invalid");
            entity.Property(e => e.Series)
                .HasMaxLength(255)
                .HasColumnName("series");
            entity.Property(e => e.Time)
                .HasMaxLength(200)
                .HasColumnName("time");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
            entity.Property(e => e.Uastring)
                .HasMaxLength(255)
                .HasColumnName("uastring");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<HUserNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_user_notes_pkey");

            entity.ToTable("h_user_notes");

            entity.HasIndex(e => e.Catid, "h_user_notes_idx_category_id");

            entity.HasIndex(e => e.UserId, "h_user_notes_idx_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.Catid)
                .HasDefaultValue(0)
                .HasColumnName("catid");
            entity.Property(e => e.CheckedOut)
                .HasDefaultValue(0)
                .HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checked_out_time");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_time");
            entity.Property(e => e.CreatedUserId)
                .HasDefaultValue(0)
                .HasColumnName("created_user_id");
            entity.Property(e => e.ModifiedTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modified_time");
            entity.Property(e => e.ModifiedUserId).HasColumnName("modified_user_id");
            entity.Property(e => e.PublishDown)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_down");
            entity.Property(e => e.PublishUp)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("publish_up");
            entity.Property(e => e.ReviewTime)
                .HasDefaultValueSql("'1970-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("review_time");
            entity.Property(e => e.State)
                .HasDefaultValue((short)0)
                .HasColumnName("state");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("subject");
            entity.Property(e => e.UserId)
                .HasDefaultValue(0)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<HUserProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_user_profiles", tb => tb.HasComment("Simple user profile storage table"));

            entity.HasIndex(e => new { e.UserId, e.ProfileKey }, "h_user_profiles_idx_user_id_profile_key").IsUnique();

            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.ProfileKey)
                .HasMaxLength(100)
                .HasColumnName("profile_key");
            entity.Property(e => e.ProfileValue).HasColumnName("profile_value");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<HUserUsergroupMap>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.GroupId }).HasName("h_user_usergroup_map_pkey");

            entity.ToTable("h_user_usergroup_map");

            entity.Property(e => e.UserId)
                .HasDefaultValue(0L)
                .HasComment("Foreign Key to #__users.id")
                .HasColumnName("user_id");
            entity.Property(e => e.GroupId)
                .HasDefaultValue(0L)
                .HasComment("Foreign Key to #__usergroups.id")
                .HasColumnName("group_id");
        });

        modelBuilder.Entity<HUsergroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_usergroups_pkey");

            entity.ToTable("h_usergroups");

            entity.HasIndex(e => e.ParentId, "h_usergroups_idx_usergroup_adjacency_lookup");

            entity.HasIndex(e => new { e.Lft, e.Rgt }, "h_usergroups_idx_usergroup_nested_set_lookup");

            entity.HasIndex(e => new { e.ParentId, e.Title }, "h_usergroups_idx_usergroup_parent_title_lookup").IsUnique();

            entity.HasIndex(e => e.Title, "h_usergroups_idx_usergroup_title_lookup");

            entity.Property(e => e.Id)
                .HasComment("Primary Key")
                .HasColumnName("id");
            entity.Property(e => e.Lft)
                .HasDefaultValue(0L)
                .HasComment("Nested set lft.")
                .HasColumnName("lft");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0L)
                .HasComment("Adjacency List Reference Id")
                .HasColumnName("parent_id");
            entity.Property(e => e.Rgt)
                .HasDefaultValue(0L)
                .HasComment("Nested set rgt.")
                .HasColumnName("rgt");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
        });

        modelBuilder.Entity<HViewlevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("h_viewlevels_pkey");

            entity.ToTable("h_viewlevels");

            entity.HasIndex(e => e.Title, "h_viewlevels_idx_assetgroup_title_lookup").IsUnique();

            entity.Property(e => e.Id)
                .HasComment("Primary Key")
                .HasColumnName("id");
            entity.Property(e => e.Ordering)
                .HasDefaultValue(0L)
                .HasColumnName("ordering");
            entity.Property(e => e.Rules)
                .HasMaxLength(5120)
                .HasComment("JSON encoded access control.")
                .HasColumnName("rules");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
        });
        modelBuilder.HasSequence("emp_eid_seq")
            .StartsAt(2L)
            .IncrementsBy(2);
        modelBuilder.HasSequence("emp_eid_seq0").StartsAt(1000L);
        modelBuilder.HasSequence("emp_eid_seq1").IncrementsBy(2);
        modelBuilder.HasSequence("emp_eid_seq2").StartsAt(10000L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
