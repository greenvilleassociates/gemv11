using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GEMWP.Models;

public partial class GemwpContext : DbContext
{
    public GemwpContext()
    {
    }

    public GemwpContext(DbContextOptions<GemwpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WpComment> WpComments { get; set; }

    public virtual DbSet<WpCommentmetum> WpCommentmeta { get; set; }

    public virtual DbSet<WpLink> WpLinks { get; set; }

    public virtual DbSet<WpOption> WpOptions { get; set; }

    public virtual DbSet<WpPost> WpPosts { get; set; }

    public virtual DbSet<WpPostmetum> WpPostmeta { get; set; }

    public virtual DbSet<WpTerm> WpTerms { get; set; }

    public virtual DbSet<WpTermRelationship> WpTermRelationships { get; set; }

    public virtual DbSet<WpTermTaxonomy> WpTermTaxonomies { get; set; }

    public virtual DbSet<WpTermmetum> WpTermmeta { get; set; }

    public virtual DbSet<WpUser> WpUsers { get; set; }

    public virtual DbSet<WpUsermetum> WpUsermeta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=gliops.glocation.info;Port=5434;Username=gridsa;Password=test12345;Database=gemwp");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WpComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("wp_comments_pkey");

            entity.ToTable("wp_comments");

            entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt }, "wp_comments_comment_approved_date_gmt");

            entity.HasIndex(e => e.CommentAuthorEmail, "wp_comments_comment_author_email");

            entity.HasIndex(e => e.CommentDateGmt, "wp_comments_comment_date_gmt");

            entity.HasIndex(e => e.CommentParent, "wp_comments_comment_parent");

            entity.HasIndex(e => e.CommentPostId, "wp_comments_comment_post_ID");

            entity.Property(e => e.CommentId).HasColumnName("comment_ID");
            entity.Property(e => e.CommentAgent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("comment_agent");
            entity.Property(e => e.CommentApproved)
                .HasMaxLength(20)
                .HasDefaultValueSql("'1'::character varying")
                .HasColumnName("comment_approved");
            entity.Property(e => e.CommentAuthor).HasColumnName("comment_author");
            entity.Property(e => e.CommentAuthorEmail)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("comment_author_email");
            entity.Property(e => e.CommentAuthorIp)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("comment_author_ip");
            entity.Property(e => e.CommentAuthorUrl)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("comment_author_url");
            entity.Property(e => e.CommentContent).HasColumnName("comment_content");
            entity.Property(e => e.CommentDate)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("comment_date");
            entity.Property(e => e.CommentDateGmt)
                .HasDefaultValueSql("timezone('gmt'::text, now())")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("comment_date_gmt");
            entity.Property(e => e.CommentKarma)
                .HasDefaultValue(0)
                .HasColumnName("comment_karma");
            entity.Property(e => e.CommentParent)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("comment_parent");
            entity.Property(e => e.CommentPostId)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("comment_post_ID");
            entity.Property(e => e.CommentType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'comment'::character varying")
                .HasColumnName("comment_type");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<WpCommentmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("wp_commentmeta_pkey");

            entity.ToTable("wp_commentmeta");

            entity.HasIndex(e => e.CommentId, "wp_commentmeta_comment_id");

            entity.HasIndex(e => e.MetaKey, "wp_commentmeta_meta_key");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.CommentId)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("comment_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<WpLink>(entity =>
        {
            entity.HasKey(e => e.LinkId).HasName("wp_links_pkey");

            entity.ToTable("wp_links");

            entity.HasIndex(e => e.LinkVisible, "wp_links_link_visible");

            entity.Property(e => e.LinkId).HasColumnName("link_id");
            entity.Property(e => e.LinkDescription)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("link_description");
            entity.Property(e => e.LinkImage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("link_image");
            entity.Property(e => e.LinkName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("link_name");
            entity.Property(e => e.LinkNotes).HasColumnName("link_notes");
            entity.Property(e => e.LinkOwner)
                .HasDefaultValueSql("'1'::bigint")
                .HasColumnName("link_owner");
            entity.Property(e => e.LinkRating)
                .HasDefaultValue(0)
                .HasColumnName("link_rating");
            entity.Property(e => e.LinkRel)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("link_rel");
            entity.Property(e => e.LinkRss)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("link_rss");
            entity.Property(e => e.LinkTarget)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("link_target");
            entity.Property(e => e.LinkUpdated)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("link_updated");
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("link_url");
            entity.Property(e => e.LinkVisible)
                .HasMaxLength(20)
                .HasDefaultValueSql("'Y'::character varying")
                .HasColumnName("link_visible");
        });

        modelBuilder.Entity<WpOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("wp_options_pkey");

            entity.ToTable("wp_options");

            entity.HasIndex(e => e.Autoload, "wp_options_autoload");

            entity.HasIndex(e => e.OptionName, "wp_options_option_name").IsUnique();

            entity.Property(e => e.OptionId).HasColumnName("option_id");
            entity.Property(e => e.Autoload)
                .HasMaxLength(20)
                .HasDefaultValueSql("'yes'::character varying")
                .HasColumnName("autoload");
            entity.Property(e => e.OptionName)
                .HasMaxLength(191)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("option_name");
            entity.Property(e => e.OptionValue).HasColumnName("option_value");
        });

        modelBuilder.Entity<WpPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wp_posts_pkey");

            entity.ToTable("wp_posts");

            entity.HasIndex(e => e.PostAuthor, "wp_posts_post_author");

            entity.HasIndex(e => e.PostName, "wp_posts_post_name");

            entity.HasIndex(e => e.PostParent, "wp_posts_post_parent");

            entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id }, "wp_posts_type_status_date");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommentCount)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("comment_count");
            entity.Property(e => e.CommentStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'open'::character varying")
                .HasColumnName("comment_status");
            entity.Property(e => e.Guid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("guid");
            entity.Property(e => e.MenuOrder)
                .HasDefaultValue(0)
                .HasColumnName("menu_order");
            entity.Property(e => e.PingStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'open'::character varying")
                .HasColumnName("ping_status");
            entity.Property(e => e.Pinged).HasColumnName("pinged");
            entity.Property(e => e.PostAuthor)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("post_author");
            entity.Property(e => e.PostContent).HasColumnName("post_content");
            entity.Property(e => e.PostContentFiltered).HasColumnName("post_content_filtered");
            entity.Property(e => e.PostDate)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("post_date");
            entity.Property(e => e.PostDateGmt)
                .HasDefaultValueSql("timezone('gmt'::text, now())")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("post_date_gmt");
            entity.Property(e => e.PostExcerpt).HasColumnName("post_excerpt");
            entity.Property(e => e.PostMimeType)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("post_mime_type");
            entity.Property(e => e.PostModified)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("post_modified");
            entity.Property(e => e.PostModifiedGmt)
                .HasDefaultValueSql("timezone('gmt'::text, now())")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("post_modified_gmt");
            entity.Property(e => e.PostName)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("post_name");
            entity.Property(e => e.PostParent)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("post_parent");
            entity.Property(e => e.PostPassword)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("post_password");
            entity.Property(e => e.PostStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'publish'::character varying")
                .HasColumnName("post_status");
            entity.Property(e => e.PostTitle).HasColumnName("post_title");
            entity.Property(e => e.PostType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'post'::character varying")
                .HasColumnName("post_type");
            entity.Property(e => e.ToPing).HasColumnName("to_ping");
        });

        modelBuilder.Entity<WpPostmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("wp_postmeta_pkey");

            entity.ToTable("wp_postmeta");

            entity.HasIndex(e => e.MetaKey, "wp_postmeta_meta_key");

            entity.HasIndex(e => e.PostId, "wp_postmeta_post_id");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.PostId)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("post_id");
        });

        modelBuilder.Entity<WpTerm>(entity =>
        {
            entity.HasKey(e => e.TermId).HasName("wp_terms_pkey");

            entity.ToTable("wp_terms");

            entity.HasIndex(e => e.Name, "wp_terms_name");

            entity.HasIndex(e => e.Slug, "wp_terms_slug");

            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Slug)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("slug");
            entity.Property(e => e.TermGroup)
                .HasDefaultValue(0L)
                .HasColumnName("term_group");
        });

        modelBuilder.Entity<WpTermRelationship>(entity =>
        {
            entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId }).HasName("wp_term_relationships_pkey");

            entity.ToTable("wp_term_relationships");

            entity.HasIndex(e => e.TermTaxonomyId, "wp_term_relationships_term_taxonomy_id");

            entity.Property(e => e.ObjectId)
                .HasDefaultValue(0L)
                .HasColumnName("object_id");
            entity.Property(e => e.TermTaxonomyId)
                .HasDefaultValue(0L)
                .HasColumnName("term_taxonomy_id");
            entity.Property(e => e.TermOrder)
                .HasDefaultValue(0)
                .HasColumnName("term_order");
        });

        modelBuilder.Entity<WpTermTaxonomy>(entity =>
        {
            entity.HasKey(e => e.TermTaxonomyId).HasName("wp_term_taxonomy_pkey");

            entity.ToTable("wp_term_taxonomy");

            entity.HasIndex(e => e.Taxonomy, "wp_term_taxonomy_taxonomy");

            entity.HasIndex(e => new { e.TermId, e.Taxonomy }, "wp_term_taxonomy_term_id_taxonomy").IsUnique();

            entity.Property(e => e.TermTaxonomyId).HasColumnName("term_taxonomy_id");
            entity.Property(e => e.Count)
                .HasDefaultValue(0L)
                .HasColumnName("count");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Parent)
                .HasDefaultValue(0L)
                .HasColumnName("parent");
            entity.Property(e => e.Taxonomy)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("taxonomy");
            entity.Property(e => e.TermId)
                .HasDefaultValue(0L)
                .HasColumnName("term_id");
        });

        modelBuilder.Entity<WpTermmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("wp_termmeta_pkey");

            entity.ToTable("wp_termmeta");

            entity.HasIndex(e => e.MetaKey, "wp_termmeta_meta_key");

            entity.HasIndex(e => e.TermId, "wp_termmeta_term_id");

            entity.Property(e => e.MetaId).HasColumnName("meta_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.TermId)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("term_id");
        });

        modelBuilder.Entity<WpUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wp_users_pkey");

            entity.ToTable("wp_users");

            entity.HasIndex(e => e.UserEmail, "wp_users_user_email");

            entity.HasIndex(e => e.UserLogin, "wp_users_user_login_key");

            entity.HasIndex(e => e.UserNicename, "wp_users_user_nicename");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("display_name");
            entity.Property(e => e.UserActivationKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user_activation_key");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user_email");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(60)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user_login");
            entity.Property(e => e.UserNicename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user_nicename");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user_pass");
            entity.Property(e => e.UserRegistered)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("user_registered");
            entity.Property(e => e.UserStatus)
                .HasDefaultValue(0)
                .HasColumnName("user_status");
            entity.Property(e => e.UserUrl)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user_url");
        });

        modelBuilder.Entity<WpUsermetum>(entity =>
        {
            entity.HasKey(e => e.UmetaId).HasName("wp_usermeta_pkey");

            entity.ToTable("wp_usermeta");

            entity.HasIndex(e => e.MetaKey, "wp_usermeta_meta_key");

            entity.HasIndex(e => e.UserId, "wp_usermeta_user_id");

            entity.Property(e => e.UmetaId).HasColumnName("umeta_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'0'::bigint")
                .HasColumnName("user_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
