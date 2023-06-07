﻿// <auto-generated />
using DatabaseExperimentsLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseExperimentsLib.Migrations
{
    [DbContext(typeof(AppDbCtx))]
    [Migration("20230607162405_AddUniqueIndexes")]
    partial class AddUniqueIndexes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<long>("AuthorBooksId")
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.HasKey("AuthorBooksId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("DatabaseExperimentsLib.Entities.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("FirstName", "LastName")
                        .IsUnique();

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DatabaseExperimentsLib.Entities.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BookTypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("PublisherId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookTypeId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("Title", "Year")
                        .IsUnique();

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DatabaseExperimentsLib.Entities.BookType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("DatabaseExperimentsLib.Entities.Publisher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("DatabaseExperimentsLib.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("AuthorBooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseExperimentsLib.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseExperimentsLib.Entities.Book", b =>
                {
                    b.HasOne("DatabaseExperimentsLib.Entities.BookType", "BookType")
                        .WithMany("BooksOfType")
                        .HasForeignKey("BookTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseExperimentsLib.Entities.Publisher", "Publisher")
                        .WithMany("PublisherBooks")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookType");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("DatabaseExperimentsLib.Entities.BookType", b =>
                {
                    b.Navigation("BooksOfType");
                });

            modelBuilder.Entity("DatabaseExperimentsLib.Entities.Publisher", b =>
                {
                    b.Navigation("PublisherBooks");
                });
#pragma warning restore 612, 618
        }
    }
}