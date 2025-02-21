using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using InstaSham.Models;

namespace InstaSham.DAL;

public partial class InstaShamContext : DbContext
{
    public InstaShamContext()
    {
    }

    public InstaShamContext(DbContextOptions<InstaShamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<DirectMessage> DirectMessages { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostLike> PostLikes { get; set; }

    public virtual DbSet<Story> Stories { get; set; }

    public virtual DbSet<StoryLike> StoryLikes { get; set; }

    public virtual DbSet<StoryView> StoryViews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-IOE0U3K\\SQLEXPRESS;Database=InstaSham;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comment__3214EC078C16E081");

            entity.ToTable("Comment");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Content)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.PostId).HasColumnName("postId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comment__postId__48CFD27E");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comment__userId__49C3F6B7");
        });

        modelBuilder.Entity<DirectMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DirectMe__3214EC07B76A65D1");

            entity.ToTable("DirectMessage");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Content)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Receiver).HasColumnName("receiver");
            entity.Property(e => e.Sender).HasColumnName("sender");

            entity.HasOne(d => d.ReceiverNavigation).WithMany(p => p.DirectMessageReceiverNavigations)
                .HasForeignKey(d => d.Receiver)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DirectMes__recei__3B75D760");

            entity.HasOne(d => d.SenderNavigation).WithMany(p => p.DirectMessageSenderNavigations)
                .HasForeignKey(d => d.Sender)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DirectMes__sende__3A81B327");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Post__3214EC074C747049");

            entity.ToTable("Post");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Content)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Photo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("photo");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Post__userId__3F466844");
        });

        modelBuilder.Entity<PostLike>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PostLike__3214EC07A0380445");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.IsLiked).HasColumnName("is_liked");
            entity.Property(e => e.PostId).HasColumnName("postId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Post).WithMany(p => p.PostLikes)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PostLikes__postI__440B1D61");

            entity.HasOne(d => d.User).WithMany(p => p.PostLikes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PostLikes__userI__44FF419A");
        });

        modelBuilder.Entity<Story>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Story__3214EC0773F10AA4");

            entity.ToTable("Story");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Content)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Photo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("photo");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Stories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Story__userId__4D94879B");
        });

        modelBuilder.Entity<StoryLike>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StoryLik__3214EC07EB6782F4");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.IsLiked).HasColumnName("is_liked");
            entity.Property(e => e.StoryId).HasColumnName("storyId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Story).WithMany(p => p.StoryLikes)
                .HasForeignKey(d => d.StoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StoryLike__story__6477ECF3");

            entity.HasOne(d => d.User).WithMany(p => p.StoryLikes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StoryLike__userI__656C112C");
        });

        modelBuilder.Entity<StoryView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StoryVie__3214EC07AFD47C54");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.StoryId).HasColumnName("storyId");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Viewed).HasColumnName("viewed");

            entity.HasOne(d => d.Story).WithMany(p => p.StoryViews)
                .HasForeignKey(d => d.StoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StoryView__story__5812160E");

            entity.HasOne(d => d.User).WithMany(p => p.StoryViews)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StoryView__userI__571DF1D5");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07587394BE");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Bio)
                .IsUnicode(false)
                .HasColumnName("bio");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.ProfilePicture)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("profilePicture");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("userPassword");
            entity.Property(e => e.Username)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasMany(d => d.Followers).WithMany(p => p.Followings)
                .UsingEntity<Dictionary<string, object>>(
                    "Follow",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Follows__Followe__5EBF139D"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("FollowingId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Follows__Followi__5FB337D6"),
                    j =>
                    {
                        j.HasKey("FollowerId", "FollowingId").HasName("PK__Follows__79CB0335F4981B5D");
                        j.ToTable("Follows");
                    });

            entity.HasMany(d => d.Followings).WithMany(p => p.Followers)
                .UsingEntity<Dictionary<string, object>>(
                    "Follow",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("FollowingId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Follows__Followi__5FB337D6"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Follows__Followe__5EBF139D"),
                    j =>
                    {
                        j.HasKey("FollowerId", "FollowingId").HasName("PK__Follows__79CB0335F4981B5D");
                        j.ToTable("Follows");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
