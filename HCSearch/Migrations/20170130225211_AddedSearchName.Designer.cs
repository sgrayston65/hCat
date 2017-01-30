using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HCSearch.Models;

namespace HCSearch.Migrations
{
    [DbContext(typeof(PersonInfoContext))]
    [Migration("20170130225211_AddedSearchName")]
    partial class AddedSearchName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HCSearch.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("HCSearch.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Dob");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Searchname");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("HCSearch.Models.Interest", b =>
                {
                    b.HasOne("HCSearch.Models.Person")
                        .WithMany("Interests")
                        .HasForeignKey("PersonId");
                });
        }
    }
}
