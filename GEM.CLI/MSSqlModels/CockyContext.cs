using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CE.Models;

public partial class CockyContext : DbContext
{
    public CockyContext()
    {
    }

    public CockyContext(DbContextOptions<CockyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Checkoutrequest> Checkoutrequests { get; set; }

    public virtual DbSet<CompanyCreditcard> CompanyCreditcards { get; set; }

    public virtual DbSet<CompanyCredittran> CompanyCredittrans { get; set; }

    public virtual DbSet<Countryhq> Countryhqs { get; set; }

    public virtual DbSet<Currencymark> Currencymarks { get; set; }

    public virtual DbSet<Currencytype> Currencytypes { get; set; }

    public virtual DbSet<Customerteam> Customerteams { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeReview> EmployeeReviews { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Indivtransaction> Indivtransactions { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Moviegenre> Moviegenres { get; set; }

    public virtual DbSet<OrderResult> OrderResults { get; set; }

    public virtual DbSet<Orderticket> Ordertickets { get; set; }

    public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Showtime> Showtimes { get; set; }

    public virtual DbSet<Soedetail> Soedetails { get; set; }

    public virtual DbSet<Soesummary> Soesummaries { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Teamtransaction> Teamtransactions { get; set; }

    public virtual DbSet<TestComment> TestComments { get; set; }

    public virtual DbSet<TestPost> TestPosts { get; set; }

    public virtual DbSet<TestUser> TestUsers { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TEAM4LAB2\\COCKYMSSQL;Initial Catalog=COCKY;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__carts__3213E83F5D419849");

            entity.ToTable("carts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TicketId).HasColumnName("ticketId");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Checkoutrequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__checkout__3214EC07BC298BB6");

            entity.ToTable("checkoutrequest");

            entity.Property(e => e.RequestDate)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CompanyCreditcard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83F1B109F47");

            entity.ToTable("company_creditcards");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("account_number");
            entity.Property(e => e.AccountSubaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("account_subaccount");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardtype");
            entity.Property(e => e.Expdate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("expdate");
            entity.Property(e => e.Pincode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pincode");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<CompanyCredittran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83FE5C8EBFA");

            entity.ToTable("company_credittrans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("account_number");
            entity.Property(e => e.AccountSubaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("account_subaccount");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardtype");
            entity.Property(e => e.Transamount).HasColumnName("transamount");
            entity.Property(e => e.Transdate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transdate");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Countryhq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__countryh__3213E83F502639F3");

            entity.ToTable("countryhq");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Hqaddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqaddress1");
            entity.Property(e => e.Hqaddress2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hqaddress2");
            entity.Property(e => e.Hqcity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqcity");
            entity.Property(e => e.Hqcountry)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqcountry");
            entity.Property(e => e.Hqid).HasColumnName("hqid");
            entity.Property(e => e.Hqregion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqregion");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Currencymark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__currency__3213E83FFC3683F8");

            entity.ToTable("currencymark");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currencydescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("currencydescription");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currencyid");
            entity.Property(e => e.Dollarmark).HasColumnName("dollarmark");
            entity.Property(e => e.Sterlingmark).HasColumnName("sterlingmark");
            entity.Property(e => e.Yuanmark).HasColumnName("yuanmark");
        });

        modelBuilder.Entity<Currencytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__currency__3213E83F8285FE20");

            entity.ToTable("currencytype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currencydescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("currencydescription");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currencyid");
            entity.Property(e => e.Exchangecorpid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exchangecorpid");
            entity.Property(e => e.Exchangecorpsubid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exchangecorpsubid");
        });

        modelBuilder.Entity<Customerteam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3213E83F1E223F1E");

            entity.ToTable("customerteams");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Jgroupid).HasColumnName("jgroupid");
            entity.Property(e => e.Storeorigination)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("storeorigination");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
            entity.Property(e => e.Teamdescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("teamdescription");
            entity.Property(e => e.Teamid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teamid");
            entity.Property(e => e.TeammanagerJid).HasColumnName("teammanagerJid");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83F1C01AE59");

            entity.ToTable("employees");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Employeefullname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeefullname");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Jid).HasColumnName("jid");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Middle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("middle");
            entity.Property(e => e.Ncrid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ncrid");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("postalcode");
            entity.Property(e => e.Regionstate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("regionstate");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<EmployeeReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83F817FEAA8");

            entity.ToTable("employee_reviews");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendaryear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("calendaryear");
            entity.Property(e => e.Employeefullname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeefullname");
            entity.Property(e => e.Notesondelivery)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("notesondelivery");
            entity.Property(e => e.Reviewdate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reviewdate");
            entity.Property(e => e.Reviewdetails)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reviewdetails");
            entity.Property(e => e.Reviewgivendate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reviewgivendate");
            entity.Property(e => e.Reviewimage)
                .HasMaxLength(1000)
                .HasColumnName("reviewimage");
            entity.Property(e => e.Reviewurl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("reviewurl");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__genres__3214EC07C5C0CAA8");

            entity.ToTable("genres");

            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Indivtransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__indivtra__3213E83FEBBD04D9");

            entity.ToTable("indivtransactions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adultqty).HasColumnName("adultqty");
            entity.Property(e => e.Branchmgrcomment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("branchmgrcomment");
            entity.Property(e => e.Childrenqty).HasColumnName("childrenqty");
            entity.Property(e => e.Cityregiontax).HasColumnName("cityregiontax");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currencyid");
            entity.Property(e => e.Custid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("custid");
            entity.Property(e => e.Erpsystemid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("erpsystemid");
            entity.Property(e => e.Erptransid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("erptransid");
            entity.Property(e => e.Fedtax).HasColumnName("fedtax");
            entity.Property(e => e.Othertax1).HasColumnName("othertax1");
            entity.Property(e => e.Othertax1descr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("othertax1descr");
            entity.Property(e => e.Othertax2).HasColumnName("othertax2");
            entity.Property(e => e.Othertax2descr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("othertax2descr");
            entity.Property(e => e.Seniorqty).HasColumnName("seniorqty");
            entity.Property(e => e.Statetx).HasColumnName("statetx");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
            entity.Property(e => e.Transamount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transamount");
            entity.Property(e => e.Transcomment1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transcomment1");
            entity.Property(e => e.Transcomment2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transcomment2");
            entity.Property(e => e.Transdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transdate");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__movies__3214EC07B538F7C2");

            entity.ToTable("movies");

            entity.Property(e => e.DateReleased)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("_imageUrl");
            entity.Property(e => e.ImageUrl1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ImageUrl");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Moviegenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__moviegen__3214EC07C85E9D75");

            entity.ToTable("moviegenres");

            entity.Property(e => e.GenreName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MoviesId).HasColumnName("MoviesID");
        });

        modelBuilder.Entity<OrderResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderRes__3214EC0723487D3F");

            entity.ToTable("OrderResult");

            entity.Property(e => e.Details)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TotalPrice)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Orderticket>(entity =>
        {
            entity.HasKey(e => e.OrderTicketId).HasName("PK__ordertic__2E41818CB2773F18");

            entity.ToTable("ordertickets");

            entity.Property(e => e.Price)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PaymentDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PaymentD__3214EC07A6010325");

            entity.Property(e => e.Amount)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CardHolderName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CardNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Cvv)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CVV");
            entity.Property(e => e.ExpiryDate)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__products__3213E83FE21C4575");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Discount1).HasColumnName("discount1");
            entity.Property(e => e.Discount2).HasColumnName("discount2");
            entity.Property(e => e.Discount3).HasColumnName("discount3");
            entity.Property(e => e.Discountid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("discountid");
            entity.Property(e => e.Prodid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prodid");
            entity.Property(e => e.Productdescr)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("productdescr");
            entity.Property(e => e.Productmrc).HasColumnName("productmrc");
            entity.Property(e => e.Productnrc).HasColumnName("productnrc");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ratings__3214EC076589FE71");

            entity.ToTable("ratings");

            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__region__3213E83F32C01D5C");

            entity.ToTable("region");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Hqaddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqaddress1");
            entity.Property(e => e.Hqaddress2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hqaddress2");
            entity.Property(e => e.Hqcity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqcity");
            entity.Property(e => e.Hqcountry)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqcountry");
            entity.Property(e => e.Hqregion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqregion");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__review__3214EC070C77778E");

            entity.ToTable("review");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Movie)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MovieId).HasColumnName("MovieID");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Showtime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__showtime__3214EC07D00DE827");

            entity.ToTable("showtime");

            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.MovieId).HasColumnName("MovieID");
            entity.Property(e => e.StartTime)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Soedetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__soedetai__3213E83FE8BACF9E");

            entity.ToTable("soedetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Detailid).HasColumnName("detailid");
            entity.Property(e => e.Invoiceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("invoiceid");
            entity.Property(e => e.Productid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("productid");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Subtotalmrc).HasColumnName("subtotalmrc");
            entity.Property(e => e.Subtotalnrc).HasColumnName("subtotalnrc");
            entity.Property(e => e.Subtotaltax).HasColumnName("subtotaltax");
        });

        modelBuilder.Entity<Soesummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__soesumma__3213E83F95CDF3C9");

            entity.ToTable("soesummary");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checkid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("checkid");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Creditdebit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("creditdebit");
            entity.Property(e => e.Invoiceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("invoiceid");
            entity.Property(e => e.Paypaltransid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paypaltransid");
            entity.Property(e => e.Paytype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("paytype");
            entity.Property(e => e.Purhcaseordernum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("purhcaseordernum");
            entity.Property(e => e.Soemrctotal).HasColumnName("soemrctotal");
            entity.Property(e => e.Soenrctotal).HasColumnName("soenrctotal");
            entity.Property(e => e.Stripetransid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("stripetransid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__stores__3213E83F3E0E096B");

            entity.ToTable("stores");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("region");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Teamtransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__teamtran__3213E83FF74ADF92");

            entity.ToTable("teamtransactions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adultqty).HasColumnName("adultqty");
            entity.Property(e => e.Branchmgrcomment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("branchmgrcomment");
            entity.Property(e => e.Childrenqty).HasColumnName("childrenqty");
            entity.Property(e => e.Cityregiontax).HasColumnName("cityregiontax");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currencyid");
            entity.Property(e => e.Erpsystemid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("erpsystemid");
            entity.Property(e => e.Erptransid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("erptransid");
            entity.Property(e => e.Fedtax).HasColumnName("fedtax");
            entity.Property(e => e.Othertax1).HasColumnName("othertax1");
            entity.Property(e => e.Othertax1descr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("othertax1descr");
            entity.Property(e => e.Othertax2).HasColumnName("othertax2");
            entity.Property(e => e.Othertax2descr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("othertax2descr");
            entity.Property(e => e.Seniorqty).HasColumnName("seniorqty");
            entity.Property(e => e.Statetx).HasColumnName("statetx");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
            entity.Property(e => e.Teamid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teamid");
            entity.Property(e => e.Transamount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transamount");
            entity.Property(e => e.Transcomment1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transcomment1");
            entity.Property(e => e.Transcomment2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transcomment2");
            entity.Property(e => e.Transdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transdate");
        });

        modelBuilder.Entity<TestComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__TestComm__C3B4DFAABE92E588");

            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Post).WithMany(p => p.TestComments)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__TestComme__PostI__02FC7413");

            entity.HasOne(d => d.User).WithMany(p => p.TestComments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__TestComme__UserI__03F0984C");
        });

        modelBuilder.Entity<TestPost>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__TestPost__AA126038F65CF240");

            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.TestPosts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__TestPosts__UserI__7F2BE32F");
        });

        modelBuilder.Entity<TestUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__TestUser__1788CCACA89E2502");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ticket__3214EC073EF74563");

            entity.ToTable("ticket");

            entity.Property(e => e.Price)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3214EC07DC394624");

            entity.ToTable("users");

            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
