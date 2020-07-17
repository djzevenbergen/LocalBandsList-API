﻿// <auto-generated />
using LocalBandsList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBandsList.Migrations
{
  [DbContext(typeof(LocalBandsListContext))]
  [Migration("20200612154254_Initial")]
  partial class Initial
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
          .HasAnnotation("Relational:MaxIdentifierLength", 64);

      modelBuilder.Entity("LocalBandsList.Models.Band", b =>
          {
            b.Property<int>("BandId")
                      .ValueGeneratedOnAdd();

            b.Property<string>("Description");

            b.Property<string>("Name");

            b.Property<string>("PhoneNumber");

            b.Property<string>("Type");

            b.Property<string>("WebSite");

            b.HasKey("BandId");

            b.ToTable("Bands");
          });
#pragma warning restore 612, 618
    }
  }
}
