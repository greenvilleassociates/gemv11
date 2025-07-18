using System;
using System.Collections.Generic;
using GEMAPI.ModelsCORP;
using Microsoft.EntityFrameworkCore;

namespace Enterprise.Models;

public partial class Gemcorp2Context : DbContext
{
    public Gemcorp2Context()
    {
    }

    public Gemcorp2Context(DbContextOptions<Gemcorp2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Activitydetail> Activitydetails { get; set; }

    public virtual DbSet<Apilog> Apilogs { get; set; }

    public virtual DbSet<Batch> Batches { get; set; }

    public virtual DbSet<Batchtype> Batchtypes { get; set; }

    public virtual DbSet<Bu> Bus { get; set; }

    public virtual DbSet<Certcalogue> Certcalogues { get; set; }

    public virtual DbSet<Certcompliance> Certcompliances { get; set; }

    public virtual DbSet<Certification> Certifications { get; set; }

    public virtual DbSet<Certrequirement> Certrequirements { get; set; }

    public virtual DbSet<Certtype> Certtypes { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Companyevent> Companyevents { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeReview> EmployeeReviews { get; set; }

    public virtual DbSet<Employeeprofile> Employeeprofiles { get; set; }

    public virtual DbSet<Gagridconfig> Gagridconfigs { get; set; }

    public virtual DbSet<Learndetail> Learndetails { get; set; }

    public virtual DbSet<Learningmodule> Learningmodules { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Proclassesdetail> Proclassesdetails { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Resdetail> Resdetails { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Shadowuser> Shadowusers { get; set; }

    public virtual DbSet<Skillsdetail> Skillsdetails { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Useraction> Useractions { get; set; }

    public virtual DbSet<Usergroup> Usergroups { get; set; }

    public virtual DbSet<Userhelp> Userhelps { get; set; }

    public virtual DbSet<Userlog> Userlogs { get; set; }

    public virtual DbSet<Userprofile> Userprofiles { get; set; }

    public virtual DbSet<Usersession> Usersessions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=gliops.glocation.info;Port=5434;Username=gridsa;Password=test12345;Database=gemcorp2");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activitydetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__activity__3213E83F187840E1");

            entity.ToTable("activitydetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .HasColumnName("category");
            entity.Property(e => e.Certauthority)
                .HasMaxLength(100)
                .HasColumnName("certauthority");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Emplid)
                .HasMaxLength(100)
                .HasColumnName("emplid");
            entity.Property(e => e.Employee).HasColumnName("employee");
            entity.Property(e => e.Enddate)
                .HasMaxLength(100)
                .HasColumnName("enddate");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
            entity.Property(e => e.Startdate)
                .HasMaxLength(100)
                .HasColumnName("startdate");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Apilog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__apilogs__3213E83F0E914DBC");

            entity.ToTable("apilogs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apirequestdetail)
                .HasMaxLength(500)
                .HasColumnName("apirequestdetail");
            entity.Property(e => e.Apiurl)
                .HasMaxLength(150)
                .HasColumnName("apiurl");
            entity.Property(e => e.Descr)
                .HasMaxLength(500)
                .HasColumnName("descr");
            entity.Property(e => e.Emplid).HasColumnName("emplid");
            entity.Property(e => e.EscalationId).HasColumnName("escalation_id");
            entity.Property(e => e.Fullname)
                .HasMaxLength(150)
                .HasColumnName("fullname");
            entity.Property(e => e.Logdate)
                .HasMaxLength(150)
                .HasColumnName("logdate");
            entity.Property(e => e.NocOpId).HasColumnName("noc_op_id");
            entity.Property(e => e.Noccomments)
                .HasMaxLength(500)
                .HasColumnName("noccomments");
            entity.Property(e => e.Secpriority).HasColumnName("secpriority");
            entity.Property(e => e.Triagecasenumber)
                .HasMaxLength(200)
                .HasColumnName("triagecasenumber");
        });

        modelBuilder.Entity<Batch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__batch__3213E83F092744A3");

            entity.ToTable("batch");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batchend).HasColumnName("batchend");
            entity.Property(e => e.Batchname)
                .HasMaxLength(150)
                .HasColumnName("batchname");
            entity.Property(e => e.Batchstart).HasColumnName("batchstart");
            entity.Property(e => e.Batchstatus).HasColumnName("batchstatus");
            entity.Property(e => e.Batchtype).HasColumnName("batchtype");
            entity.Property(e => e.Filelocationpath)
                .HasMaxLength(200)
                .HasColumnName("filelocationpath");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Qtyactual).HasColumnName("qtyactual");
            entity.Property(e => e.Qtyend).HasColumnName("qtyend");
            entity.Property(e => e.Qtyerror).HasColumnName("qtyerror");
            entity.Property(e => e.Qtyexpected).HasColumnName("qtyexpected");
            entity.Property(e => e.Qtystart).HasColumnName("qtystart");
        });

        modelBuilder.Entity<Batchtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__batchtyp__3213E83FD954BA5B");

            entity.ToTable("batchtype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batchtypename)
                .HasMaxLength(150)
                .HasColumnName("batchtypename");
        });

        modelBuilder.Entity<Bu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bu__3213E83F4E00786F");

            entity.ToTable("bu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Buhqaddress1)
                .HasMaxLength(150)
                .HasColumnName("buhqaddress1");
            entity.Property(e => e.Buhqaddress2)
                .HasMaxLength(150)
                .HasColumnName("buhqaddress2");
            entity.Property(e => e.Buhqcity)
                .HasMaxLength(100)
                .HasColumnName("buhqcity");
            entity.Property(e => e.Buhqpostal)
                .HasMaxLength(100)
                .HasColumnName("buhqpostal");
            entity.Property(e => e.Buhqstate)
                .HasMaxLength(100)
                .HasColumnName("buhqstate");
            entity.Property(e => e.Buname)
                .HasMaxLength(100)
                .HasColumnName("buname");
            entity.Property(e => e.Companyid).HasColumnName("companyid");
        });

        modelBuilder.Entity<Certcalogue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__certcalo__3213E83FC6A88CE8");

            entity.ToTable("certcalogue");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Certlevel)
                .HasMaxLength(100)
                .HasColumnName("certlevel");
            entity.Property(e => e.Certlistcost).HasColumnName("certlistcost");
            entity.Property(e => e.Certlistdiscountstd).HasColumnName("certlistdiscountstd");
            entity.Property(e => e.Certlistdiscountvprate).HasColumnName("certlistdiscountvprate");
            entity.Property(e => e.Certtype).HasColumnName("certtype");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("description");
            entity.Property(e => e.Enddate)
                .HasMaxLength(100)
                .HasColumnName("enddate");
            entity.Property(e => e.Endoflife).HasColumnName("endoflife");
            entity.Property(e => e.Precursortraining1)
                .HasMaxLength(100)
                .HasColumnName("precursortraining1");
            entity.Property(e => e.Precursortraining2)
                .HasMaxLength(100)
                .HasColumnName("precursortraining2");
            entity.Property(e => e.Sku)
                .HasMaxLength(150)
                .HasColumnName("sku");
            entity.Property(e => e.Trainingid).HasColumnName("trainingid");
            entity.Property(e => e.Vendor)
                .HasMaxLength(150)
                .HasColumnName("vendor");
            entity.Property(e => e.Version)
                .HasMaxLength(150)
                .HasColumnName("version");
        });

        modelBuilder.Entity<Certcompliance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__certcomp__3213E83FEE2D140B");

            entity.ToTable("certcompliance");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Branchid).HasColumnName("branchid");
            entity.Property(e => e.Bu).HasColumnName("bu");
            entity.Property(e => e.Certificateid).HasColumnName("certificateid");
            entity.Property(e => e.Certificatename)
                .HasMaxLength(250)
                .HasColumnName("certificatename");
            entity.Property(e => e.Companyid).HasColumnName("companyid");
            entity.Property(e => e.Compliancedate).HasColumnName("compliancedate");
            entity.Property(e => e.Complianceid)
                .HasMaxLength(100)
                .HasColumnName("complianceid");
            entity.Property(e => e.Compsource)
                .HasMaxLength(150)
                .HasColumnName("compsource");
            entity.Property(e => e.Customerid)
                .HasMaxLength(100)
                .HasColumnName("customerid");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Projectid)
                .HasMaxLength(100)
                .HasColumnName("projectid");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Responsiblepartyid).HasColumnName("responsiblepartyid");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(100)
                .HasColumnName("vendorid");
            entity.Property(e => e.Warningacknowledged).HasColumnName("warningacknowledged");
            entity.Property(e => e.Warningdate).HasColumnName("warningdate");
        });

        modelBuilder.Entity<Certification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__certific__3213E83FEE692C4F");

            entity.ToTable("certifications");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Branchid)
                .HasDefaultValue(1300)
                .HasColumnName("branchid");
            entity.Property(e => e.Bu)
                .HasDefaultValue(1)
                .HasColumnName("bu");
            entity.Property(e => e.Certdate).HasColumnName("certdate");
            entity.Property(e => e.Certificationbloburl)
                .HasMaxLength(150)
                .HasColumnName("certificationbloburl");
            entity.Property(e => e.Certlevel)
                .HasMaxLength(50)
                .HasColumnName("certlevel");
            entity.Property(e => e.Certname)
                .HasMaxLength(150)
                .HasColumnName("certname");
            entity.Property(e => e.Certype).HasColumnName("certype");
            entity.Property(e => e.Comments)
                .HasMaxLength(1000)
                .HasColumnName("comments");
            entity.Property(e => e.Companyid)
                .HasDefaultValue(1)
                .HasColumnName("companyid");
            entity.Property(e => e.Employee).HasColumnName("employee");
            entity.Property(e => e.EmployeeEmail).HasMaxLength(150);
            //entity.Property(e => e.Employeeemail)
              //  .HasMaxLength(150)
              //  .HasColumnName("employeeemail");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(100)
                .HasColumnName("employeeid");
            entity.Property(e => e.Employeeidasinteger).HasColumnName("employeeidasinteger");
            entity.Property(e => e.Fullname)
                .HasMaxLength(150)
                .HasColumnName("fullname");
            entity.Property(e => e.Managerid)
                .HasDefaultValue(2)
                .HasColumnName("managerid");
            entity.Property(e => e.Regionid)
                .HasDefaultValue(1)
                .HasColumnName("regionid");
            entity.Property(e => e.Revisedate).HasColumnName("revisedate");
            entity.Property(e => e.Revision)
                .HasMaxLength(50)
                .HasColumnName("revision");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Certrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__certrequ__3213E83FD8BF3F01");

            entity.ToTable("certrequirements");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Certid).HasColumnName("certid");
            entity.Property(e => e.Learnid1).HasColumnName("learnid1");
            entity.Property(e => e.Learnid2).HasColumnName("learnid2");
            entity.Property(e => e.Learnid3).HasColumnName("learnid3");
            entity.Property(e => e.Learnid4).HasColumnName("learnid4");
            entity.Property(e => e.Learnid5).HasColumnName("learnid5");
        });

        modelBuilder.Entity<Certtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__certtype__3213E83FD43A4C4C");

            entity.ToTable("certtype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("description");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company__3213E83F8560513E");

            entity.ToTable("company");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CertAuthority).HasMaxLength(150);
            //entity.Property(e => e.Certauthority)
              //  .HasMaxLength(150)
              //  .HasColumnName("certauthority");
            entity.Property(e => e.Companyname)
                .HasMaxLength(100)
                .HasColumnName("companyname");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(100)
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Ncralohaid)
                .HasMaxLength(100)
                .HasColumnName("ncralohaid");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(100)
                .HasColumnName("oracleid");
        });

        modelBuilder.Entity<Companyevent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__companye__3213E83F3D031F56");

            entity.ToTable("companyevents");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Eventid)
                .HasMaxLength(150)
                .HasColumnName("eventid");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83F8DB64DBE");

            entity.ToTable("employees");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alohaid)
                .HasMaxLength(150)
                .HasColumnName("alohaid");
            entity.Property(e => e.Azureid)
                .HasMaxLength(150)
                .HasColumnName("azureid");
            entity.Property(e => e.Btn)
                .HasMaxLength(150)
                .HasColumnName("btn");
            entity.Property(e => e.Buid).HasColumnName("buid");
            entity.Property(e => e.Companyid)
                .HasDefaultValue(1)
                .HasColumnName("companyid");
            entity.Property(e => e.Employee1).HasColumnName("employee");
            entity.Property(e => e.EmployeeEmail).HasMaxLength(150);
            entity.Property(e => e.EmployeeReturndate).HasColumnName("employee_returndate");
            //entity.Property(e => e.Employeeemail)
              //  .HasMaxLength(150)
              //  .HasColumnName("employeeemail");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(100)
                .HasColumnName("employeeid");
            entity.Property(e => e.Employeeidasint).HasColumnName("employeeidasint");
            entity.Property(e => e.Employeestartdate).HasColumnName("employeestartdate");
            entity.Property(e => e.Employeetenure)
                .HasMaxLength(50)
                .HasColumnName("employeetenure");
            entity.Property(e => e.Firstname)
                .HasMaxLength(150)
                .HasColumnName("firstname");
            entity.Property(e => e.Fullname)
                .HasMaxLength(150)
                .HasColumnName("fullname");
            entity.Property(e => e.Groupid1)
                .HasMaxLength(150)
                .HasColumnName("groupid1");
            entity.Property(e => e.Groupid2)
                .HasMaxLength(150)
                .HasColumnName("groupid2");
            entity.Property(e => e.Groupid3)
                .HasMaxLength(150)
                .HasColumnName("groupid3");
            entity.Property(e => e.Groupid4)
                .HasMaxLength(150)
                .HasColumnName("groupid4");
            entity.Property(e => e.Groupid5)
                .HasMaxLength(150)
                .HasColumnName("groupid5");
            entity.Property(e => e.Hashedpassword)
                .HasMaxLength(150)
                .HasColumnName("hashedpassword");
            entity.Property(e => e.Hrid)
                .HasMaxLength(100)
                .HasColumnName("hrid");
            entity.Property(e => e.Hrsystemconstring)
                .HasMaxLength(250)
                .HasColumnName("hrsystemconstring");
            entity.Property(e => e.Iscertified).HasColumnName("iscertified");
            entity.Property(e => e.Lastname)
                .HasMaxLength(150)
                .HasColumnName("lastname");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Ncrid)
                .HasMaxLength(150)
                .HasColumnName("ncrid");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(150)
                .HasColumnName("oracleid");
            entity.Property(e => e.Passwordtype).HasColumnName("passwordtype");
            entity.Property(e => e.Plainpassword)
                .HasMaxLength(50)
                .HasColumnName("plainpassword");
            entity.Property(e => e.Profileurl)
                .HasMaxLength(150)
                .HasColumnName("profileurl");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Resettoken)
                .HasMaxLength(500)
                .HasColumnName("resettoken");
            entity.Property(e => e.Role)
                .HasMaxLength(150)
                .HasColumnName("role");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Token)
                .HasMaxLength(500)
                .HasColumnName("token");
            entity.Property(e => e.Tokenexpiration).HasColumnName("tokenexpiration");
            entity.Property(e => e.Tokenprovider)
                .HasMaxLength(500)
                .HasColumnName("tokenprovider");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.Userprofileid).HasColumnName("userprofileid");
        });

        modelBuilder.Entity<EmployeeReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83FA439A81F");

            entity.ToTable("employee_reviews");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendaryear)
                .HasMaxLength(5)
                .HasColumnName("calendaryear");
            entity.Property(e => e.Employeefullname)
                .HasMaxLength(150)
                .HasColumnName("employeefullname");
            entity.Property(e => e.Notesondelivery)
                .HasMaxLength(1000)
                .HasColumnName("notesondelivery");
            entity.Property(e => e.Reviewdate)
                .HasMaxLength(100)
                .HasColumnName("reviewdate");
            entity.Property(e => e.Reviewdetails)
                .HasMaxLength(1000)
                .HasColumnName("reviewdetails");
            entity.Property(e => e.Reviewgivendate)
                .HasMaxLength(100)
                .HasColumnName("reviewgivendate");
            entity.Property(e => e.Reviewurl)
                .HasMaxLength(150)
                .HasColumnName("reviewurl");
        });

        modelBuilder.Entity<Employeeprofile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83F8DA84CA0");

            entity.ToTable("employeeprofile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(150)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(150)
                .HasColumnName("address2");
            entity.Property(e => e.Branchid).HasColumnName("branchid");
            entity.Property(e => e.Buid).HasColumnName("buid");
            entity.Property(e => e.Cellphone)
                .HasMaxLength(150)
                .HasColumnName("cellphone");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Companyid)
                .HasMaxLength(150)
                .HasColumnName("companyid");
            entity.Property(e => e.Country)
                .HasMaxLength(150)
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(150)
                .HasColumnName("employeeid");
            entity.Property(e => e.Facebookurl)
                .HasMaxLength(150)
                .HasColumnName("facebookurl");
            entity.Property(e => e.Googleurl)
                .HasMaxLength(150)
                .HasColumnName("googleurl");
            entity.Property(e => e.Instagramurl)
                .HasMaxLength(150)
                .HasColumnName("instagramurl");
            entity.Property(e => e.Linkedinurl)
                .HasMaxLength(150)
                .HasColumnName("linkedinurl");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Maritalstatus)
                .HasMaxLength(100)
                .HasColumnName("maritalstatus");
            entity.Property(e => e.Phone)
                .HasMaxLength(150)
                .HasColumnName("phone");
            entity.Property(e => e.Postalzip)
                .HasMaxLength(50)
                .HasColumnName("postalzip");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Sms).HasColumnName("sms");
            entity.Property(e => e.Stateregion)
                .HasMaxLength(150)
                .HasColumnName("stateregion");
            entity.Property(e => e.University1)
                .HasMaxLength(150)
                .HasColumnName("university1");
            entity.Property(e => e.University2)
                .HasMaxLength(150)
                .HasColumnName("university2");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vimeourl)
                .HasMaxLength(150)
                .HasColumnName("vimeourl");
        });

        modelBuilder.Entity<Gagridconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__gagridco__3213E83F662BEC4C");

            entity.ToTable("gagridconfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gridinstance)
                .HasMaxLength(100)
                .HasColumnName("gridinstance");
            entity.Property(e => e.Node1ip)
                .HasMaxLength(100)
                .HasColumnName("node1ip");
            entity.Property(e => e.Node1port)
                .HasMaxLength(10)
                .HasColumnName("node1port");
            entity.Property(e => e.Node2ip)
                .HasMaxLength(100)
                .HasColumnName("node2ip");
            entity.Property(e => e.Node2port)
                .HasMaxLength(10)
                .HasColumnName("node2port");
            entity.Property(e => e.Node3ip)
                .HasMaxLength(100)
                .HasColumnName("node3ip");
            entity.Property(e => e.Node3port)
                .HasMaxLength(10)
                .HasColumnName("node3port");
            entity.Property(e => e.Nodedbm1sid)
                .HasMaxLength(100)
                .HasColumnName("nodedbm1sid");
            entity.Property(e => e.Nodedbm2sid)
                .HasMaxLength(100)
                .HasColumnName("nodedbm2sid");
            entity.Property(e => e.Nodedbm3sid)
                .HasMaxLength(100)
                .HasColumnName("nodedbm3sid");
            entity.Property(e => e.Nodedbms1)
                .HasMaxLength(100)
                .HasColumnName("nodedbms1");
            entity.Property(e => e.Nodedbms2)
                .HasMaxLength(100)
                .HasColumnName("nodedbms2");
            entity.Property(e => e.Nodedbms3)
                .HasMaxLength(100)
                .HasColumnName("nodedbms3");
            entity.Property(e => e.Nodeid).HasColumnName("nodeid");
            entity.Property(e => e.Nodename)
                .HasMaxLength(100)
                .HasColumnName("nodename");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Sqllocaltype)
                .HasMaxLength(100)
                .HasColumnName("sqllocaltype");
        });

        modelBuilder.Entity<Learndetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__learndet__3213E83FCC53A3EA");

            entity.ToTable("learndetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cataloguesku)
                .HasMaxLength(150)
                .HasColumnName("cataloguesku");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("category");
            entity.Property(e => e.Certauthority)
                .HasMaxLength(100)
                .HasColumnName("certauthority");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("description");
            entity.Property(e => e.Emplid)
                .HasMaxLength(100)
                .HasColumnName("emplid");
            entity.Property(e => e.Employee).HasColumnName("employee");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(100)
                .HasColumnName("employeeid");
            entity.Property(e => e.Employeeidasint).HasColumnName("employeeidasint");
            entity.Property(e => e.Enddate)
                .HasMaxLength(100)
                .HasColumnName("enddate");
            entity.Property(e => e.Fullname)
                .HasMaxLength(150)
                .HasColumnName("fullname");
            entity.Property(e => e.Learningmodulesid).HasColumnName("learningmodulesid");
            entity.Property(e => e.Startdate)
                .HasMaxLength(100)
                .HasColumnName("startdate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Learningmodule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__learning__3213E83FD6B7E6C2");

            entity.ToTable("learningmodules");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .HasColumnName("author");
            entity.Property(e => e.Authorcomp).HasColumnName("authorcomp");
            entity.Property(e => e.Authorcontact)
                .HasMaxLength(400)
                .HasColumnName("authorcontact");
            entity.Property(e => e.Cataloguesku)
                .HasMaxLength(250)
                .HasColumnName("cataloguesku");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Emprequired).HasColumnName("emprequired");
            entity.Property(e => e.Uisection).HasColumnName("uisection");
            entity.Property(e => e.Videourl)
                .HasMaxLength(500)
                .HasColumnName("videourl");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__manager__3213E83F528A6CCB");

            entity.ToTable("manager");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Companyid).HasColumnName("companyid");
            entity.Property(e => e.Emplid).HasColumnName("emplid");
            entity.Property(e => e.Fullname)
                .HasMaxLength(150)
                .HasColumnName("fullname");
            entity.Property(e => e.Saddress1)
                .HasMaxLength(150)
                .HasColumnName("saddress1");
            entity.Property(e => e.Saddress2)
                .HasMaxLength(150)
                .HasColumnName("saddress2");
            entity.Property(e => e.Scity)
                .HasMaxLength(150)
                .HasColumnName("scity");
            entity.Property(e => e.Sstate)
                .HasMaxLength(150)
                .HasColumnName("sstate");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Szipcode)
                .HasMaxLength(150)
                .HasColumnName("szipcode");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Proclassesdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__proclass__3213E83F37F81A18");

            entity.ToTable("proclassesdetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Classid)
                .HasMaxLength(100)
                .HasColumnName("classid");
            entity.Property(e => e.Comments)
                .HasMaxLength(150)
                .HasColumnName("comments");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Instructorid).HasColumnName("instructorid");
            entity.Property(e => e.Providername)
                .HasMaxLength(100)
                .HasColumnName("providername");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Technicalcontactemail)
                .HasMaxLength(100)
                .HasColumnName("technicalcontactemail");
            entity.Property(e => e.Technicalcontactname)
                .HasMaxLength(100)
                .HasColumnName("technicalcontactname");
            entity.Property(e => e.Technicalcontactphone)
                .HasMaxLength(100)
                .HasColumnName("technicalcontactphone");
            entity.Property(e => e.Trainsiteid).HasColumnName("trainsiteid");
            entity.Property(e => e.Vendorid)
                .HasMaxLength(100)
                .HasColumnName("vendorid");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__regions__3213E83F14FFAB69");

            entity.ToTable("regions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bu).HasColumnName("bu");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Hqaddress1)
                .HasMaxLength(150)
                .HasColumnName("hqaddress1");
            entity.Property(e => e.Hqaddress2)
                .HasMaxLength(150)
                .HasColumnName("hqaddress2");
            entity.Property(e => e.Hqcity)
                .HasMaxLength(150)
                .HasColumnName("hqcity");
            entity.Property(e => e.Hqstate)
                .HasMaxLength(150)
                .HasColumnName("hqstate");
            entity.Property(e => e.Hqzipcode)
                .HasMaxLength(150)
                .HasColumnName("hqzipcode");
        });

        modelBuilder.Entity<Resdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__resdetai__3213E83F0C57D4D7");

            entity.ToTable("resdetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("category");
            entity.Property(e => e.Certauthority)
                .HasMaxLength(100)
                .HasColumnName("certauthority");
            entity.Property(e => e.Descr)
                .HasMaxLength(100)
                .HasColumnName("descr");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Emplid).HasColumnName("emplid");
            entity.Property(e => e.Employee).HasColumnName("employee");
            entity.Property(e => e.Enddate)
                .HasMaxLength(100)
                .HasColumnName("enddate");
            entity.Property(e => e.Fullname)
                .HasMaxLength(150)
                .HasColumnName("fullname");
            entity.Property(e => e.Location)
                .HasMaxLength(150)
                .HasColumnName("location");
            entity.Property(e => e.Startdate)
                .HasMaxLength(100)
                .HasColumnName("startdate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__roles__3213E83F0B41B7D7");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Roledescription)
                .HasMaxLength(500)
                .HasColumnName("roledescription");
            entity.Property(e => e.Roleid)
                .HasMaxLength(150)
                .HasColumnName("roleid");
        });

        modelBuilder.Entity<Shadowuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shadowuser_pkey");

            entity.ToTable("shadowuser");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Params)
                .HasMaxLength(150)
                .HasColumnName("params");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Registerdate).HasColumnName("registerdate");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Skillsdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__skillsde__3213E83F407678B0");

            entity.ToTable("skillsdetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .HasColumnName("category");
            entity.Property(e => e.Certauthority)
                .HasMaxLength(100)
                .HasColumnName("certauthority");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Emplid)
                .HasMaxLength(100)
                .HasColumnName("emplid");
            entity.Property(e => e.Employee).HasColumnName("employee");
            entity.Property(e => e.Enddate)
                .HasMaxLength(100)
                .HasColumnName("enddate");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
            entity.Property(e => e.Startdate)
                .HasMaxLength(100)
                .HasColumnName("startdate");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__stores__3213E83FB79848BE");

            entity.ToTable("stores");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(150)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(150)
                .HasColumnName("address2");
            entity.Property(e => e.Bu).HasColumnName("bu");
            entity.Property(e => e.City)
                .HasMaxLength(150)
                .HasColumnName("city");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.State)
                .HasMaxLength(150)
                .HasColumnName("state");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(150)
                .HasColumnName("zipcode");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F96DA4CA5");

            entity.ToTable("users");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.HasIndex(e => e.Username, "username").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Azureid)
                .HasMaxLength(100)
                .HasColumnName("azureid");
            entity.Property(e => e.Btn)
                .HasMaxLength(150)
                .HasDefaultValueSql("'XXX-XXX-XXX-XXXX'::character varying")
                .HasColumnName("BTN");
            entity.Property(e => e.Companyid)
                .HasDefaultValue(1)
                .HasColumnName("companyid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Employee)
                .HasDefaultValue((short)0)
                .HasColumnName("employee");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(100)
                .HasColumnName("employeeid");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .HasColumnName("fullname");
            entity.Property(e => e.Groupid1)
                .HasMaxLength(150)
                .HasColumnName("groupid1");
            entity.Property(e => e.Groupid2)
                .HasMaxLength(150)
                .HasColumnName("groupid2");
            entity.Property(e => e.Groupid3)
                .HasMaxLength(150)
                .HasColumnName("groupid3");
            entity.Property(e => e.Groupid4)
                .HasMaxLength(150)
                .HasColumnName("groupid4");
            entity.Property(e => e.Groupid5)
                .HasMaxLength(150)
                .HasColumnName("groupid5");
            entity.Property(e => e.Hashedpassword)
                .HasMaxLength(150)
                .HasColumnName("hashedpassword");
            entity.Property(e => e.Iscertified)
                .HasDefaultValue((short)0)
                .HasColumnName("iscertified");
            entity.Property(e => e.Jid).HasColumnName("jid");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Microsoftid)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NA'::character varying")
                .HasColumnName("microsoftid");
            entity.Property(e => e.Ncrid)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NA'::character varying")
                .HasColumnName("ncrid");
            entity.Property(e => e.Oracleid)
                .HasMaxLength(100)
                .HasColumnName("oracleid");
            entity.Property(e => e.Passwordtype).HasColumnName("passwordtype");
            entity.Property(e => e.Plainpassword)
                .HasMaxLength(150)
                .HasColumnName("plainpassword");
            entity.Property(e => e.Profileurl)
                .HasMaxLength(150)
                .HasColumnName("profileurl");
            entity.Property(e => e.Resettoken)
                .HasMaxLength(200)
                .HasColumnName("resettoken");
            entity.Property(e => e.Resettokenexpiration).HasColumnName("resettokenexpiration");
            entity.Property(e => e.Role)
                .HasMaxLength(150)
                .HasColumnName("role");
            entity.Property(e => e.Somerole)
                .HasMaxLength(150)
                .HasColumnName("somerole");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Useraction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__useracti__3213E83FA741FB5D");

            entity.ToTable("useractions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acknowledged).HasColumnName("acknowledged");
            entity.Property(e => e.Actiondate)
                .HasMaxLength(100)
                .HasColumnName("actiondate");
            entity.Property(e => e.Actionpriority).HasColumnName("actionpriority");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Usergroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usergrou__3213E83FCF17ABC6");

            entity.ToTable("usergroups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Groupcompanyid)
                .HasMaxLength(150)
                .HasColumnName("groupcompanyid");
            entity.Property(e => e.Groupdescription)
                .HasMaxLength(500)
                .HasColumnName("groupdescription");
            entity.Property(e => e.Groupid)
                .HasMaxLength(150)
                .HasColumnName("groupid");
            entity.Property(e => e.Groupownerid).HasColumnName("groupownerid");
        });

        modelBuilder.Entity<Userhelp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userhelp__3213E83FBE92D400");

            entity.ToTable("userhelp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bestcontactnumber)
                .HasMaxLength(100)
                .HasColumnName("bestcontactnumber");
            entity.Property(e => e.Descr)
                .HasMaxLength(500)
                .HasColumnName("descr");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Emplid).HasColumnName("emplid");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.Replied)
                .HasMaxLength(150)
                .HasColumnName("replied");
            entity.Property(e => e.Repliedmanageremail)
                .HasMaxLength(150)
                .HasColumnName("repliedmanageremail");
            entity.Property(e => e.Repliedmanagerid)
                .HasMaxLength(150)
                .HasColumnName("repliedmanagerid");
            entity.Property(e => e.Repliedmanagerphone)
                .HasMaxLength(150)
                .HasColumnName("repliedmanagerphone");
            entity.Property(e => e.Responsedate).HasColumnName("responsedate");
            entity.Property(e => e.Severity).HasColumnName("severity");
            entity.Property(e => e.Ticketdate).HasColumnName("ticketdate");
            entity.Property(e => e.Ticketid)
                .HasMaxLength(100)
                .HasColumnName("ticketid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Userlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userlogs__3213E83F0B3CC5C1");

            entity.ToTable("userlogs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descr)
                .HasMaxLength(500)
                .HasColumnName("descr");
            entity.Property(e => e.Emplid).HasColumnName("emplid");
            entity.Property(e => e.EscalationId).HasColumnName("escalation_id");
            entity.Property(e => e.Fullname)
                .HasMaxLength(150)
                .HasColumnName("fullname");
            entity.Property(e => e.Logdate)
                .HasMaxLength(150)
                .HasColumnName("logdate");
            entity.Property(e => e.NocOpId).HasColumnName("noc_op_id");
            entity.Property(e => e.Noccomments)
                .HasMaxLength(500)
                .HasColumnName("noccomments");
            entity.Property(e => e.Role)
                .HasMaxLength(150)
                .HasColumnName("role");
            entity.Property(e => e.Secpriority).HasColumnName("secpriority");
            entity.Property(e => e.Triagecasenumber)
                .HasMaxLength(200)
                .HasColumnName("triagecasenumber");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Userprofile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userprof__3213E83F92265540");

            entity.ToTable("userprofile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activepictureurl)
                .HasMaxLength(150)
                .HasColumnName("activepictureurl");
            entity.Property(e => e.Address1)
                .HasMaxLength(150)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(150)
                .HasColumnName("address2");
            entity.Property(e => e.Branchid).HasColumnName("branchid");
            entity.Property(e => e.Buid).HasColumnName("buid");
            entity.Property(e => e.Cellphone)
                .HasMaxLength(150)
                .HasColumnName("cellphone");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Companyid)
                .HasMaxLength(150)
                .HasColumnName("companyid");
            entity.Property(e => e.Country)
                .HasMaxLength(150)
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(150)
                .HasColumnName("employeeid");
            entity.Property(e => e.Facebookurl)
                .HasMaxLength(150)
                .HasColumnName("facebookurl");
            entity.Property(e => e.Googleurl)
                .HasMaxLength(150)
                .HasColumnName("googleurl");
            entity.Property(e => e.Instagramurl)
                .HasMaxLength(150)
                .HasColumnName("instagramurl");
            entity.Property(e => e.Linkedinurl)
                .HasMaxLength(150)
                .HasColumnName("linkedinurl");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Maritalstatus)
                .HasMaxLength(100)
                .HasColumnName("maritalstatus");
            entity.Property(e => e.Phone)
                .HasMaxLength(150)
                .HasColumnName("phone");
            entity.Property(e => e.Postalzip)
                .HasMaxLength(50)
                .HasColumnName("postalzip");
            entity.Property(e => e.Pronoun)
                .HasMaxLength(150)
                .HasColumnName("pronoun");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Sms).HasColumnName("sms");
            entity.Property(e => e.Stateregion)
                .HasMaxLength(150)
                .HasColumnName("stateregion");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.Title2)
                .HasMaxLength(150)
                .HasColumnName("title2");
            entity.Property(e => e.University)
                .HasMaxLength(150)
                .HasColumnName("university");
            entity.Property(e => e.University1)
                .HasMaxLength(150)
                .HasColumnName("university1");
            entity.Property(e => e.University2)
                .HasMaxLength(150)
                .HasColumnName("university2");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vimeourl)
                .HasMaxLength(150)
                .HasColumnName("vimeourl");
        });

        modelBuilder.Entity<Usersession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usersess__3213E83F08046578");

            entity.ToTable("usersessions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acknowledged).HasColumnName("acknowledged");
            entity.Property(e => e.Actionpriority).HasColumnName("actionpriority");
            entity.Property(e => e.Sessioncomplete)
                .HasDefaultValue((short)0)
                .HasColumnName("sessioncomplete");
            entity.Property(e => e.Sessiondescription)
                .HasMaxLength(100)
                .HasColumnName("sessiondescription");
            entity.Property(e => e.Sessionemail)
                .HasMaxLength(150)
                .HasColumnName("sessionemail");
            entity.Property(e => e.Sessionend).HasColumnName("sessionend");
            entity.Property(e => e.Sessionfirstname)
                .HasMaxLength(150)
                .HasColumnName("sessionfirstname");
            entity.Property(e => e.Sessionfullname)
                .HasMaxLength(150)
                .HasColumnName("sessionfullname");
            entity.Property(e => e.Sessionlastname)
                .HasMaxLength(150)
                .HasColumnName("sessionlastname");
            entity.Property(e => e.Sessionrecorded).HasColumnName("sessionrecorded");
            entity.Property(e => e.Sessionrecordurl)
                .HasMaxLength(200)
                .HasColumnName("sessionrecordurl");
            entity.Property(e => e.Sessionstart).HasColumnName("sessionstart");
            entity.Property(e => e.Sessionusername)
                .HasMaxLength(100)
                .HasColumnName("sessionusername");
            entity.Property(e => e.Token)
                .HasMaxLength(500)
                .HasColumnName("token");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
