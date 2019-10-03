﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagement.Data;

namespace SchoolManagement.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20190626063740_schooldetails")]
    partial class schooldetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolManagement.Data.School", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CreationTime");

                    b.Property<double>("Lattitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("MobileNumber")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModificationTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(18);

                    b.Property<int>("PinCode");

                    b.Property<string>("State")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("SchoolInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
