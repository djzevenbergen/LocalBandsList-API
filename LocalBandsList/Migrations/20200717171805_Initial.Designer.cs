﻿// <auto-generated />
using LocalBandsList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusinessLookup.Migrations
{
    [DbContext(typeof(LocalBandsListContext))]
    [Migration("20200717171805_Initial")]
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

                    b.Property<string>("Bio")
                        .HasMaxLength(300);

                    b.Property<string>("Email");

                    b.Property<string>("Genre")
                        .IsRequired();

                    b.Property<bool>("Gigging");

                    b.Property<string>("MusicLink");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Together");

                    b.Property<int>("UserId");

                    b.Property<string>("VideoLink");

                    b.Property<string>("YearFormed");

                    b.Property<string>("ZipCode");

                    b.HasKey("BandId");

                    b.ToTable("Bands");

                    b.HasData(
                        new
                        {
                            BandId = 10,
                            Bio = "Just me, bein' Deej.",
                            Genre = "indie",
                            Gigging = false,
                            MusicLink = "https://soundcloud.com/yourfrienddeej/i-fell-in-love-with-a-postcard",
                            Name = "Your Friend Deej",
                            Together = true,
                            UserId = 1,
                            VideoLink = "https://www.youtube.com/watch?v=zRmL4tVbs6Y",
                            YearFormed = "2015",
                            ZipCode = "98020"
                        },
                        new
                        {
                            BandId = 9,
                            Bio = "Jammy Jr. is an odd blend of chiptunes and whispery-soul",
                            Genre = "synth pop",
                            Gigging = false,
                            MusicLink = "https://soundcloud.com/jammyjr/5-computer-time-house",
                            Name = "Jammy Jr.",
                            Together = true,
                            UserId = 1,
                            VideoLink = "https://vimeo.com/286650646",
                            YearFormed = "2017",
                            ZipCode = "98020"
                        },
                        new
                        {
                            BandId = 8,
                            Bio = "Hopeful Mac Demarco-lookin asses trying to make something fun",
                            Genre = "indie pop",
                            Gigging = false,
                            MusicLink = "",
                            Name = "Dad Friendly",
                            Together = true,
                            UserId = 1,
                            VideoLink = "",
                            YearFormed = "2019",
                            ZipCode = "98109"
                        },
                        new
                        {
                            BandId = 7,
                            Bio = "A group of jabronies that liked to rock",
                            Genre = "rock",
                            Gigging = false,
                            MusicLink = "https://soundcloud.com/wearecon/allison",
                            Name = "CON",
                            Together = true,
                            UserId = 1,
                            VideoLink = "",
                            YearFormed = "2013"
                        },
                        new
                        {
                            BandId = 6,
                            Bio = "A well-oiled rock machine, pumping out tunes for early-morning smoke sessions",
                            Genre = "psychedelic rock",
                            Gigging = true,
                            MusicLink = "https://soundcloud.com/smoothrichard/lintfire",
                            Name = "Smooth Richard",
                            Together = true,
                            UserId = 1,
                            VideoLink = "",
                            YearFormed = "2017",
                            ZipCode = "98125"
                        },
                        new
                        {
                            BandId = 5,
                            Bio = "Vibe out with this understated electronic duo",
                            Genre = "IDM",
                            Gigging = true,
                            MusicLink = "https://soundcloud.com/crystalssquad/hover-board",
                            Name = "bad gravity",
                            Together = true,
                            UserId = 1,
                            VideoLink = "",
                            YearFormed = "2018",
                            ZipCode = "98109"
                        });
                });

            modelBuilder.Entity("LocalBandsList.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Token");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "David",
                            LastName = "Zevenbergen",
                            Password = "test",
                            Username = "DJTest"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
