﻿// <auto-generated />
using System;
using BlogWeb.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogWeb.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime?>("CreateOn");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("LastReplyTime");

                    b.Property<string>("LastReplyUserId");

                    b.Property<int>("NodeId");

                    b.Property<int>("ReplyCount");

                    b.Property<string>("Title");

                    b.Property<int>("Top");

                    b.Property<int>("Type");

                    b.Property<string>("UserId");

                    b.Property<int>("ViewCount");

                    b.HasKey("Id");

                    b.HasIndex("LastReplyUserId");

                    b.HasIndex("NodeId");

                    b.HasIndex("UserId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.TopicNode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateOn");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("NodeName");

                    b.Property<int>("Order");

                    b.Property<int>("ParentId");

                    b.HasKey("Id");

                    b.ToTable("TopicNode");
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.TopicReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateOn");

                    b.Property<string>("ReplyContent");

                    b.Property<string>("ReplyEmail");

                    b.Property<string>("ReplyUserId");

                    b.Property<int>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("ReplyUserId");

                    b.HasIndex("TopicId");

                    b.ToTable("TopicReply");
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("CreateOn");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("GitHub");

                    b.Property<DateTime?>("LastTime");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Profile");

                    b.Property<int>("Score");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("TopicCount");

                    b.Property<int>("TopicReplyCount");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("Url");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.UserCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateOn");

                    b.Property<int>("State");

                    b.Property<int>("TopicId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("UserCollection");
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.UserMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateOn");

                    b.Property<string>("ReceiveUserId");

                    b.Property<string>("SendUserId");

                    b.Property<int>("State");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ReceiveUserId");

                    b.HasIndex("SendUserId");

                    b.ToTable("UserMessage");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.Topic", b =>
                {
                    b.HasOne("Blog.Web.ApplicationCore.Entities.User", "LastReplyUser")
                        .WithMany()
                        .HasForeignKey("LastReplyUserId");

                    b.HasOne("Blog.Web.ApplicationCore.Entities.TopicNode", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Web.ApplicationCore.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.TopicReply", b =>
                {
                    b.HasOne("Blog.Web.ApplicationCore.Entities.User", "ReplyUser")
                        .WithMany()
                        .HasForeignKey("ReplyUserId");

                    b.HasOne("Blog.Web.ApplicationCore.Entities.Topic")
                        .WithMany("Replys")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.UserCollection", b =>
                {
                    b.HasOne("Blog.Web.ApplicationCore.Entities.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Web.ApplicationCore.Entities.UserMessage", b =>
                {
                    b.HasOne("Blog.Web.ApplicationCore.Entities.User", "ReceiveUser")
                        .WithMany()
                        .HasForeignKey("ReceiveUserId");

                    b.HasOne("Blog.Web.ApplicationCore.Entities.User", "SendUser")
                        .WithMany()
                        .HasForeignKey("SendUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Blog.Web.ApplicationCore.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Blog.Web.ApplicationCore.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Web.ApplicationCore.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Blog.Web.ApplicationCore.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
