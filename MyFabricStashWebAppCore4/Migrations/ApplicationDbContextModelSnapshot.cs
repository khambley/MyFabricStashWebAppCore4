﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MyFabricStashWebAppCore4.Models;
using System;

namespace MyFabricStashWebAppCore4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFabricStashWebAppCore4.Models.Fabric", b =>
                {
                    b.Property<int>("FabricId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BackgroundColor");

                    b.Property<string>("Brand");

                    b.Property<string>("Colors");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Design");

                    b.Property<string>("ImagePath");

                    b.Property<string>("MainCategory");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<string>("SubCategory");

                    b.Property<string>("Type");

                    b.Property<string>("Weight");

                    b.Property<int>("Width");

                    b.HasKey("FabricId");

                    b.ToTable("Fabrics");
                });
#pragma warning restore 612, 618
        }
    }
}
