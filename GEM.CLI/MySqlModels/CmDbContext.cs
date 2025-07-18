using System;
using System.Collections.Generic;
using CE.MYSQLMODELS;
using Microsoft.EntityFrameworkCore;

namespace CE.Data;

public partial class CmDbContext : DbContext
{
    public CmDbContext()
    {
    }

    public CmDbContext(DbContextOptions<CmDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Checkoutrequest> Checkoutrequests { get; set; }

    public virtual DbSet<Checkoutrequest1> Checkoutrequests1 { get; set; }

    public virtual DbSet<CompanyCreditcard> CompanyCreditcards { get; set; }

    public virtual DbSet<CompanyCredittran> CompanyCredittrans { get; set; }

    public virtual DbSet<CorpUser> CorpUsers { get; set; }

    public virtual DbSet<Countryhq> Countryhqs { get; set; }

    public virtual DbSet<Currencymark> Currencymarks { get; set; }

    public virtual DbSet<Currencytype> Currencytypes { get; set; }

    public virtual DbSet<Customerteam> Customerteams { get; set; }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeReview> EmployeeReviews { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Indivtransaction> Indivtransactions { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Moviegenre> Moviegenres { get; set; }

    public virtual DbSet<Orderresult> Orderresults { get; set; }

    public virtual DbSet<Orderticket> Ordertickets { get; set; }

    public virtual DbSet<Paymentdetail> Paymentdetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Rating1> Ratings1 { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Review1> Reviews1 { get; set; }

    public virtual DbSet<Showtime> Showtimes { get; set; }

    public virtual DbSet<Showtime1> Showtimes1 { get; set; }

    public virtual DbSet<Soedetail> Soedetails { get; set; }

    public virtual DbSet<Soesummary> Soesummaries { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Teamtransaction> Teamtransactions { get; set; }

    public virtual DbSet<Testpost> Testposts { get; set; }

    public virtual DbSet<Testuser> Testusers { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VeloUser> VeloUsers { get; set; }

    public virtual DbSet<VeloUserUsergroupMap> VeloUserUsergroupMaps { get; set; }

    public virtual DbSet<VeloUsergroup> VeloUsergroups { get; set; }

    public virtual DbSet<VeloUsersCreditcard> VeloUsersCreditcards { get; set; }

    public virtual DbSet<VeloUsersCredittran> VeloUsersCredittrans { get; set; }

    public virtual DbSet<VeloUsersMovie> VeloUsersMovies { get; set; }

    public virtual DbSet<VeloUsersMoviereview> VeloUsersMoviereviews { get; set; }

    public virtual DbSet<VeloUsersMoviesTime> VeloUsersMoviesTimes { get; set; }

    public virtual DbSet<VeloUsersMoviestar> VeloUsersMoviestars { get; set; }

    public virtual DbSet<VeloUsersMusic> VeloUsersMusics { get; set; }

    public virtual DbSet<VeloUsersMusicreview> VeloUsersMusicreviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("User Id=root;Host=127.0.0.1;Port=3307;Database=cm_db;password=test12345");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("carts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cartid).HasColumnName("cartid");
            entity.Property(e => e.TicketId).HasColumnName("ticketId");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Checkoutrequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("checkoutrequest");

            entity.HasIndex(e => e.PaymentDetailsId, "IX_CheckoutRequest_PaymentDetailsId");

            entity.Property(e => e.RequestDate).HasMaxLength(250);

            entity.HasOne(d => d.PaymentDetails).WithMany(p => p.Checkoutrequests)
                .HasForeignKey(d => d.PaymentDetailsId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CheckoutRequest_PaymentDetails_PaymentDetailsId");
        });

        modelBuilder.Entity<Checkoutrequest1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("checkoutrequests");

            entity.Property(e => e.RequestDate).HasMaxLength(250);
        });

        modelBuilder.Entity<CompanyCreditcard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("company_creditcards");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .HasColumnName("account_number");
            entity.Property(e => e.AccountSubaccount)
                .HasMaxLength(50)
                .HasColumnName("account_subaccount");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(50)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(50)
                .HasColumnName("cardtype");
            entity.Property(e => e.Expdate)
                .HasMaxLength(50)
                .HasColumnName("expdate");
            entity.Property(e => e.Pincode)
                .HasMaxLength(50)
                .HasColumnName("pincode");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<CompanyCredittran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("company_credittrans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .HasColumnName("account_number");
            entity.Property(e => e.AccountSubaccount)
                .HasMaxLength(50)
                .HasColumnName("account_subaccount");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(50)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(50)
                .HasColumnName("cardtype");
            entity.Property(e => e.Transamount).HasColumnName("transamount");
            entity.Property(e => e.Transdate)
                .HasMaxLength(50)
                .HasColumnName("transdate");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<CorpUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("corp_users");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(250)
                .HasColumnName("display_name");
            entity.Property(e => e.UserActivationKey)
                .HasMaxLength(255)
                .HasColumnName("user_activation_key");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasColumnName("user_email");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(60)
                .HasColumnName("user_login");
            entity.Property(e => e.UserNicename)
                .HasMaxLength(50)
                .HasColumnName("user_nicename");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasColumnName("user_pass");
            entity.Property(e => e.UserRegistered)
                .HasColumnType("datetime")
                .HasColumnName("user_registered");
            entity.Property(e => e.UserStatus).HasColumnName("user_status");
            entity.Property(e => e.UserUrl)
                .HasMaxLength(100)
                .HasColumnName("user_url");
        });

        modelBuilder.Entity<Countryhq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("countryhq");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .HasColumnName("companyid");
            entity.Property(e => e.Hqaddress1)
                .HasMaxLength(100)
                .HasColumnName("hqaddress1");
            entity.Property(e => e.Hqaddress2)
                .HasMaxLength(200)
                .HasColumnName("hqaddress2");
            entity.Property(e => e.Hqcity)
                .HasMaxLength(100)
                .HasColumnName("hqcity");
            entity.Property(e => e.Hqcountry)
                .HasMaxLength(100)
                .HasColumnName("hqcountry");
            entity.Property(e => e.Hqid).HasColumnName("hqid");
            entity.Property(e => e.Hqregion)
                .HasMaxLength(100)
                .HasColumnName("hqregion");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Currencymark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("currencymark");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currencydescription)
                .HasMaxLength(200)
                .HasColumnName("currencydescription");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .HasColumnName("currencyid");
            entity.Property(e => e.Dollarmark).HasColumnName("dollarmark");
            entity.Property(e => e.Sterlingmark).HasColumnName("sterlingmark");
            entity.Property(e => e.Yuanmark).HasColumnName("yuanmark");
        });

        modelBuilder.Entity<Currencytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("currencytype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currencydescription)
                .HasMaxLength(200)
                .HasColumnName("currencydescription");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .HasColumnName("currencyid");
            entity.Property(e => e.Exchangecorpid)
                .HasMaxLength(50)
                .HasColumnName("exchangecorpid");
            entity.Property(e => e.Exchangecorpsubid)
                .HasMaxLength(50)
                .HasColumnName("exchangecorpsubid");
        });

        modelBuilder.Entity<Customerteam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("customerteams");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .HasColumnName("companyid");
            entity.Property(e => e.Jgroupid).HasColumnName("jgroupid");
            entity.Property(e => e.Storeorigination)
                .HasMaxLength(50)
                .HasColumnName("storeorigination");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .HasColumnName("subaccount");
            entity.Property(e => e.Teamdescription)
                .HasMaxLength(100)
                .HasColumnName("teamdescription");
            entity.Property(e => e.Teamid)
                .HasMaxLength(50)
                .HasColumnName("teamid");
            entity.Property(e => e.TeammanagerJid).HasColumnName("teammanagerJid");
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employees");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .HasColumnName("companyid");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(50)
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Employeefullname)
                .HasMaxLength(200)
                .HasColumnName("employeefullname");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Jid).HasColumnName("jid");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("lastname");
            entity.Property(e => e.Middle)
                .HasMaxLength(50)
                .HasColumnName("middle");
            entity.Property(e => e.Ncrid)
                .HasMaxLength(50)
                .HasColumnName("ncrid");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(50)
                .HasColumnName("postalcode");
            entity.Property(e => e.Regionstate)
                .HasMaxLength(50)
                .HasColumnName("regionstate");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<EmployeeReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee_reviews");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendaryear)
                .HasMaxLength(50)
                .HasColumnName("calendaryear");
            entity.Property(e => e.Employeefullname)
                .HasMaxLength(200)
                .HasColumnName("employeefullname");
            entity.Property(e => e.Notesondelivery)
                .HasMaxLength(200)
                .HasColumnName("notesondelivery");
            entity.Property(e => e.Reviewdate)
                .HasMaxLength(50)
                .HasColumnName("reviewdate");
            entity.Property(e => e.Reviewdetails)
                .HasMaxLength(50)
                .HasColumnName("reviewdetails");
            entity.Property(e => e.Reviewgivendate)
                .HasMaxLength(50)
                .HasColumnName("reviewgivendate");
            entity.Property(e => e.Reviewimage)
                .HasMaxLength(1000)
                .HasColumnName("reviewimage");
            entity.Property(e => e.Reviewurl)
                .HasMaxLength(200)
                .HasColumnName("reviewurl");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("genres");

            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<Indivtransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("indivtransactions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adultqty).HasColumnName("adultqty");
            entity.Property(e => e.Branchmgrcomment)
                .HasMaxLength(100)
                .HasColumnName("branchmgrcomment");
            entity.Property(e => e.Childrenqty).HasColumnName("childrenqty");
            entity.Property(e => e.Cityregiontax).HasColumnName("cityregiontax");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .HasColumnName("companyid");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .HasColumnName("currencyid");
            entity.Property(e => e.Custid)
                .HasMaxLength(50)
                .HasColumnName("custid");
            entity.Property(e => e.Erpsystemid)
                .HasMaxLength(100)
                .HasColumnName("erpsystemid");
            entity.Property(e => e.Erptransid)
                .HasMaxLength(100)
                .HasColumnName("erptransid");
            entity.Property(e => e.Fedtax).HasColumnName("fedtax");
            entity.Property(e => e.Othertax1).HasColumnName("othertax1");
            entity.Property(e => e.Othertax1descr)
                .HasMaxLength(100)
                .HasColumnName("othertax1descr");
            entity.Property(e => e.Othertax2).HasColumnName("othertax2");
            entity.Property(e => e.Othertax2descr)
                .HasMaxLength(100)
                .HasColumnName("othertax2descr");
            entity.Property(e => e.Seniorqty).HasColumnName("seniorqty");
            entity.Property(e => e.Statetx).HasColumnName("statetx");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .HasColumnName("subaccount");
            entity.Property(e => e.Transamount)
                .HasMaxLength(50)
                .HasColumnName("transamount");
            entity.Property(e => e.Transcomment1)
                .HasMaxLength(100)
                .HasColumnName("transcomment1");
            entity.Property(e => e.Transcomment2)
                .HasMaxLength(100)
                .HasColumnName("transcomment2");
            entity.Property(e => e.Transdate)
                .HasMaxLength(100)
                .HasColumnName("transdate");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("movies");

            entity.Property(e => e.DateReleased).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(250)
                .HasColumnName("_imageUrl");
            entity.Property(e => e.ImageUrl1)
                .HasMaxLength(250)
                .HasColumnName("ImageUrl");
            entity.Property(e => e.Title).HasMaxLength(250);
        });

        modelBuilder.Entity<Moviegenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("moviegenres");

            entity.Property(e => e.GenreName).HasMaxLength(250);
            entity.Property(e => e.MoviesId).HasColumnName("MoviesID");
        });

        modelBuilder.Entity<Orderresult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("orderresult");

            entity.HasIndex(e => e.UserId, "IX_OrderResult_UserId");

            entity.Property(e => e.Details).HasMaxLength(250);
            entity.Property(e => e.ProcessedDate).HasMaxLength(250);
            entity.Property(e => e.TotalPrice).HasMaxLength(250);
            entity.Property(e => e.Username).HasMaxLength(250);
        });

        modelBuilder.Entity<Orderticket>(entity =>
        {
            entity.HasKey(e => e.OrderTicketId).HasName("PRIMARY");

            entity.ToTable("ordertickets");

            entity.Property(e => e.Price).HasMaxLength(250);
        });

        modelBuilder.Entity<Paymentdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("paymentdetails");

            entity.Property(e => e.Amount).HasMaxLength(250);
            entity.Property(e => e.CardHolderName).HasMaxLength(250);
            entity.Property(e => e.CardNumber).HasMaxLength(250);
            entity.Property(e => e.Cvv)
                .HasMaxLength(250)
                .HasColumnName("CVV");
            entity.Property(e => e.ExpiryDate).HasMaxLength(250);
            entity.Property(e => e.PaymentDate).HasMaxLength(250);
            entity.Property(e => e.PaymentMethod).HasMaxLength(250);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("products");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Price).HasPrecision(10);
            entity.Property(e => e.ProductName).HasMaxLength(255);
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rating");

            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<Rating1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ratings");

            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("region");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .HasColumnName("companyid");
            entity.Property(e => e.Hqaddress1)
                .HasMaxLength(100)
                .HasColumnName("hqaddress1");
            entity.Property(e => e.Hqaddress2)
                .HasMaxLength(200)
                .HasColumnName("hqaddress2");
            entity.Property(e => e.Hqcity)
                .HasMaxLength(100)
                .HasColumnName("hqcity");
            entity.Property(e => e.Hqcountry)
                .HasMaxLength(100)
                .HasColumnName("hqcountry");
            entity.Property(e => e.Hqregion)
                .HasMaxLength(100)
                .HasColumnName("hqregion");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("review");

            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Movie).HasMaxLength(250);
            entity.Property(e => e.MovieId).HasColumnName("MovieID");
            entity.Property(e => e.Title).HasMaxLength(250);
        });

        modelBuilder.Entity<Review1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("reviews");

            entity.HasIndex(e => e.MovieId, "IX_Reviews_MovieId");

            entity.HasOne(d => d.Movie).WithMany(p => p.Review1s)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_Reviews_Movies_MovieId");
        });

        modelBuilder.Entity<Showtime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("showtime");

            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.MovieId).HasColumnName("MovieID");
            entity.Property(e => e.StartTime).HasMaxLength(250);
        });

        modelBuilder.Entity<Showtime1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("showtimes");

            entity.Property(e => e.MovieId).HasColumnName("MovieID");
            entity.Property(e => e.StartTime).HasMaxLength(250);
        });

        modelBuilder.Entity<Soedetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("soedetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Detailid).HasColumnName("detailid");
            entity.Property(e => e.Invoiceid)
                .HasMaxLength(50)
                .HasColumnName("invoiceid");
            entity.Property(e => e.Productid)
                .HasMaxLength(50)
                .HasColumnName("productid");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Subtotalmrc).HasColumnName("subtotalmrc");
            entity.Property(e => e.Subtotalnrc).HasColumnName("subtotalnrc");
            entity.Property(e => e.Subtotaltax).HasColumnName("subtotaltax");
        });

        modelBuilder.Entity<Soesummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("soesummary");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checkid)
                .HasMaxLength(50)
                .HasColumnName("checkid");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .HasColumnName("companyid");
            entity.Property(e => e.Creditdebit)
                .HasMaxLength(100)
                .HasColumnName("creditdebit");
            entity.Property(e => e.Invoiceid)
                .HasMaxLength(50)
                .HasColumnName("invoiceid");
            entity.Property(e => e.Paypaltransid)
                .HasMaxLength(100)
                .HasColumnName("paypaltransid");
            entity.Property(e => e.Paytype)
                .HasMaxLength(10)
                .HasColumnName("paytype");
            entity.Property(e => e.Purhcaseordernum)
                .HasMaxLength(50)
                .HasColumnName("purhcaseordernum");
            entity.Property(e => e.Soemrctotal).HasColumnName("soemrctotal");
            entity.Property(e => e.Soenrctotal).HasColumnName("soenrctotal");
            entity.Property(e => e.Stripetransid)
                .HasMaxLength(100)
                .HasColumnName("stripetransid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stores");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(200)
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .HasColumnName("companyid");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(100)
                .HasColumnName("managername");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Regionstate)
                .HasMaxLength(100)
                .HasColumnName("regionstate");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Teamtransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("teamtransactions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adultqty).HasColumnName("adultqty");
            entity.Property(e => e.Branchmgrcomment)
                .HasMaxLength(100)
                .HasColumnName("branchmgrcomment");
            entity.Property(e => e.Childrenqty).HasColumnName("childrenqty");
            entity.Property(e => e.Cityregiontax).HasColumnName("cityregiontax");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .HasColumnName("companyid");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .HasColumnName("currencyid");
            entity.Property(e => e.Erpsystemid)
                .HasMaxLength(100)
                .HasColumnName("erpsystemid");
            entity.Property(e => e.Erptransid)
                .HasMaxLength(100)
                .HasColumnName("erptransid");
            entity.Property(e => e.Fedtax).HasColumnName("fedtax");
            entity.Property(e => e.Othertax1).HasColumnName("othertax1");
            entity.Property(e => e.Othertax1descr)
                .HasMaxLength(100)
                .HasColumnName("othertax1descr");
            entity.Property(e => e.Othertax2).HasColumnName("othertax2");
            entity.Property(e => e.Othertax2descr)
                .HasMaxLength(100)
                .HasColumnName("othertax2descr");
            entity.Property(e => e.Seniorqty).HasColumnName("seniorqty");
            entity.Property(e => e.Statetx).HasColumnName("statetx");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .HasColumnName("subaccount");
            entity.Property(e => e.Teamid)
                .HasMaxLength(50)
                .HasColumnName("teamid");
            entity.Property(e => e.Transamount)
                .HasMaxLength(50)
                .HasColumnName("transamount");
            entity.Property(e => e.Transcomment1)
                .HasMaxLength(100)
                .HasColumnName("transcomment1");
            entity.Property(e => e.Transcomment2)
                .HasMaxLength(100)
                .HasColumnName("transcomment2");
            entity.Property(e => e.Transdate)
                .HasMaxLength(100)
                .HasColumnName("transdate");
        });

        modelBuilder.Entity<Testpost>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PRIMARY");

            entity.ToTable("testposts");

            entity.HasIndex(e => e.UserId, "UserID");

            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.Content).HasColumnType("text");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Testposts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("testposts_ibfk_1");
        });

        modelBuilder.Entity<Testuser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("testusers");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ticket");

            entity.Property(e => e.Price).HasMaxLength(250);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.DateOfBirth).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Username).HasMaxLength(250);
        });

        modelBuilder.Entity<VeloUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activation)
                .HasMaxLength(100)
                .HasColumnName("activation");
            entity.Property(e => e.AuthProvider)
                .HasMaxLength(100)
                .HasColumnName("authProvider");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.LastResetTime)
                .HasColumnType("datetime")
                .HasColumnName("lastResetTime");
            entity.Property(e => e.LastvisitDate)
                .HasColumnType("datetime")
                .HasColumnName("lastvisitDate");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Otep)
                .HasMaxLength(1000)
                .HasColumnName("otep");
            entity.Property(e => e.OtpKey)
                .HasMaxLength(1000)
                .HasColumnName("otpKey");
            entity.Property(e => e.Params)
                .HasColumnType("text")
                .HasColumnName("params");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.RegisterDate)
                .HasColumnType("datetime")
                .HasColumnName("registerDate");
            entity.Property(e => e.RequireReset).HasColumnName("requireReset");
            entity.Property(e => e.ResetCount).HasColumnName("resetCount");
            entity.Property(e => e.SendEmail).HasColumnName("sendEmail");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<VeloUserUsergroupMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_user_usergroup_map");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<VeloUsergroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_usergroups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lft).HasColumnName("lft");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Rgt).HasColumnName("rgt");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<VeloUsersCreditcard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users_creditcards");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .HasColumnName("account_number");
            entity.Property(e => e.AccountSubaccount)
                .HasMaxLength(50)
                .HasColumnName("account_subaccount");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(50)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(50)
                .HasColumnName("cardtype");
            entity.Property(e => e.Expdate)
                .HasMaxLength(50)
                .HasColumnName("expdate");
            entity.Property(e => e.Pincode)
                .HasMaxLength(50)
                .HasColumnName("pincode");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<VeloUsersCredittran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users_credittrans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .HasColumnName("account_number");
            entity.Property(e => e.AccountSubaccount)
                .HasMaxLength(50)
                .HasColumnName("account_subaccount");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(50)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(50)
                .HasColumnName("cardtype");
            entity.Property(e => e.Transamount).HasColumnName("transamount");
            entity.Property(e => e.Transdate)
                .HasMaxLength(50)
                .HasColumnName("transdate");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<VeloUsersMovie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users_movies");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Femaleleadid).HasColumnName("femaleleadid");
            entity.Property(e => e.Maleleadid).HasColumnName("maleleadid");
            entity.Property(e => e.Moviegeneration)
                .HasMaxLength(100)
                .HasColumnName("moviegeneration");
            entity.Property(e => e.Movieid).HasColumnName("movieid");
            entity.Property(e => e.Moviename)
                .HasMaxLength(150)
                .IsFixedLength()
                .HasColumnName("moviename");
            entity.Property(e => e.Moviepicture1url)
                .HasMaxLength(150)
                .HasColumnName("moviepicture1url");
            entity.Property(e => e.Moviepicture2url)
                .HasMaxLength(150)
                .HasColumnName("moviepicture2url");
            entity.Property(e => e.Moviepicture3url)
                .HasMaxLength(150)
                .HasColumnName("moviepicture3url");
            entity.Property(e => e.Movietype)
                .HasMaxLength(100)
                .HasColumnName("movietype");
            entity.Property(e => e.Youtubeurl)
                .HasMaxLength(150)
                .HasColumnName("youtubeurl");
        });

        modelBuilder.Entity<VeloUsersMoviereview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users_moviereviews");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Authemail)
                .HasMaxLength(100)
                .HasColumnName("authemail");
            entity.Property(e => e.Authfax)
                .HasMaxLength(100)
                .HasColumnName("authfax");
            entity.Property(e => e.Authphone)
                .HasMaxLength(100)
                .HasColumnName("authphone");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.Femalestarid).HasColumnName("femalestarid");
            entity.Property(e => e.Fullreview)
                .HasColumnType("text")
                .HasColumnName("fullreview");
            entity.Property(e => e.Malestarid).HasColumnName("malestarid");
            entity.Property(e => e.Moviegeneration)
                .HasMaxLength(100)
                .HasColumnName("moviegeneration");
            entity.Property(e => e.Movieid).HasColumnName("movieid");
            entity.Property(e => e.Moviename)
                .HasMaxLength(150)
                .IsFixedLength()
                .HasColumnName("moviename");
            entity.Property(e => e.Moviestars).HasColumnName("moviestars");
            entity.Property(e => e.Movietype)
                .HasMaxLength(100)
                .HasColumnName("movietype");
            entity.Property(e => e.Reviewtime)
                .HasMaxLength(100)
                .HasColumnName("reviewtime");
            entity.Property(e => e.Totalhits).HasColumnName("totalhits");
            entity.Property(e => e.Uid).HasColumnName("uid");
        });

        modelBuilder.Entity<VeloUsersMoviesTime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users_movies_times");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Movieid).HasColumnName("movieid");
            entity.Property(e => e.Moviename)
                .HasMaxLength(150)
                .IsFixedLength()
                .HasColumnName("moviename");
            entity.Property(e => e.Moviepicture1url)
                .HasMaxLength(150)
                .HasColumnName("moviepicture1url");
            entity.Property(e => e.Moviepicture2url)
                .HasMaxLength(150)
                .HasColumnName("moviepicture2url");
            entity.Property(e => e.Moviepicture3url)
                .HasMaxLength(150)
                .HasColumnName("moviepicture3url");
            entity.Property(e => e.Timesfive)
                .HasMaxLength(250)
                .HasColumnName("timesfive");
            entity.Property(e => e.Timesfour)
                .HasMaxLength(250)
                .HasColumnName("timesfour");
            entity.Property(e => e.Timesone)
                .HasMaxLength(250)
                .HasColumnName("timesone");
            entity.Property(e => e.Timesseven)
                .HasMaxLength(250)
                .HasColumnName("timesseven");
            entity.Property(e => e.Timessix)
                .HasMaxLength(250)
                .HasColumnName("timessix");
            entity.Property(e => e.Timesthree)
                .HasMaxLength(250)
                .HasColumnName("timesthree");
            entity.Property(e => e.Timestwo)
                .HasMaxLength(250)
                .HasColumnName("timestwo");
            entity.Property(e => e.Youtubeurl)
                .HasMaxLength(150)
                .HasColumnName("youtubeurl");
        });

        modelBuilder.Entity<VeloUsersMoviestar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users_moviestars");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Otherwork1).HasColumnName("otherwork1");
            entity.Property(e => e.Otherwork2).HasColumnName("otherwork2");
            entity.Property(e => e.Otherwork3).HasColumnName("otherwork3");
            entity.Property(e => e.Pictureurl)
                .HasMaxLength(100)
                .HasColumnName("pictureurl");
            entity.Property(e => e.Starbirthdayyear)
                .HasMaxLength(4)
                .HasColumnName("starbirthdayyear");
            entity.Property(e => e.Starid).HasColumnName("starid");
            entity.Property(e => e.Starname)
                .HasMaxLength(100)
                .HasColumnName("starname");
        });

        modelBuilder.Entity<VeloUsersMusic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users_music");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Femaleleadid).HasColumnName("femaleleadid");
            entity.Property(e => e.Maleleadid).HasColumnName("maleleadid");
            entity.Property(e => e.Muscid).HasColumnName("muscid");
            entity.Property(e => e.Music1url1)
                .HasMaxLength(150)
                .HasColumnName("music1url1");
            entity.Property(e => e.Music1url2)
                .HasMaxLength(150)
                .HasColumnName("music1url2");
            entity.Property(e => e.Music3url3)
                .HasMaxLength(150)
                .HasColumnName("music3url3");
            entity.Property(e => e.Musicgeneration)
                .HasMaxLength(100)
                .HasColumnName("musicgeneration");
            entity.Property(e => e.Musicname)
                .HasMaxLength(150)
                .IsFixedLength()
                .HasColumnName("musicname");
            entity.Property(e => e.Musictype)
                .HasMaxLength(100)
                .HasColumnName("musictype");
            entity.Property(e => e.Youtubeurl)
                .HasMaxLength(150)
                .HasColumnName("youtubeurl");
        });

        modelBuilder.Entity<VeloUsersMusicreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("velo_users_musicreviews");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Authemail)
                .HasMaxLength(100)
                .HasColumnName("authemail");
            entity.Property(e => e.Authfax)
                .HasMaxLength(100)
                .HasColumnName("authfax");
            entity.Property(e => e.Authphone)
                .HasMaxLength(100)
                .HasColumnName("authphone");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.Femalestarid).HasColumnName("femalestarid");
            entity.Property(e => e.Fullreview)
                .HasColumnType("text")
                .HasColumnName("fullreview");
            entity.Property(e => e.Malestarid).HasColumnName("malestarid");
            entity.Property(e => e.Musicgeneration)
                .HasMaxLength(100)
                .HasColumnName("musicgeneration");
            entity.Property(e => e.Musicid).HasColumnName("musicid");
            entity.Property(e => e.Musicname)
                .HasMaxLength(150)
                .IsFixedLength()
                .HasColumnName("musicname");
            entity.Property(e => e.Musicstars).HasColumnName("musicstars");
            entity.Property(e => e.Musictype)
                .HasMaxLength(100)
                .HasColumnName("musictype");
            entity.Property(e => e.Playlist).HasColumnName("playlist");
            entity.Property(e => e.Reviewtime)
                .HasMaxLength(100)
                .HasColumnName("reviewtime");
            entity.Property(e => e.Totalhits).HasColumnName("totalhits");
            entity.Property(e => e.Uid).HasColumnName("uid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
