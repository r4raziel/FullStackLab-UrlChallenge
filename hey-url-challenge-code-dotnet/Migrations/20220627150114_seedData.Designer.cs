﻿// <auto-generated />
using System;
using HeyUrlChallengeCodeDotnet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace hey_url_challenge_code_dotnet.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220627150114_seedDaata")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hey_url_challenge_code_dotnet.Models.Clicks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Browser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UrlId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Clicks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6d871b23-8641-4a3c-b674-b07c931688a3"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 1, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("39ec5ca2-ca84-411f-8a53-d3c4d71c5970"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("719e042c-993f-4c00-9866-ed76c6b2363a"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 3, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("81e5cbdc-b887-4c7e-bd7a-1c13512385dc"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 4, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("01ca4c22-9f49-42ff-a12c-805bbe6a806f"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 5, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("b7b8e5af-59c7-4737-88b5-4b3698df9173"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 6, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("64cffa01-8db2-40c2-a889-7c2a54d11f4d"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 7, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("acd7062b-c098-4d25-84d2-4904c7fc7750"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 8, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("53b62b57-09ea-4816-a866-72a0337bc5b8"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 9, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("a863dfc8-1711-442f-aab5-ade43e88e7e5"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 10, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("8ee92bd5-12aa-4b06-b840-e647acc3bcc5"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 11, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("0306cf9c-f9fb-455b-8d06-7cf3d1faebd1"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("715ec6e2-0e2b-498c-97a2-3644be890d10"),
                            Browser = "Firefox",
                            CreatedOn = new DateTime(2022, 1, 1, 10, 10, 0, 0, DateTimeKind.Unspecified),
                            Platform = "macOS",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("36309302-9a62-401c-b416-f953f05f085c"),
                            Browser = "Firefox",
                            CreatedOn = new DateTime(2022, 2, 1, 10, 10, 0, 0, DateTimeKind.Unspecified),
                            Platform = "macOS",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("bb28e46d-9518-4d5b-942a-7203e12df92b"),
                            Browser = "Firefox",
                            CreatedOn = new DateTime(2022, 3, 1, 10, 10, 0, 0, DateTimeKind.Unspecified),
                            Platform = "macOS",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("7ffdd7e9-3a52-4754-8dfe-60e1183f78fd"),
                            Browser = "IE",
                            CreatedOn = new DateTime(2022, 1, 1, 10, 11, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("aa299f3d-a7d4-4034-9b74-f6a8bbde3689"),
                            Browser = "IE",
                            CreatedOn = new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Windows",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("160fada9-ca42-4825-a7d4-46c1347e91f9"),
                            Browser = "Safari",
                            CreatedOn = new DateTime(2022, 1, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "macOS",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("89d1f436-2692-4def-b890-c0cc507abec9"),
                            Browser = "Safari",
                            CreatedOn = new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "macOS",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("7548b64f-d332-450a-b23d-e1526f060780"),
                            Browser = "Safari",
                            CreatedOn = new DateTime(2022, 3, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "macOS",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("9e604509-ccad-4b68-82cb-824ac6573ba4"),
                            Browser = "FireFox",
                            CreatedOn = new DateTime(2022, 1, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Ubuntu",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("462abe3e-a52e-4c5f-8c61-fc23d8f37329"),
                            Browser = "FireFox",
                            CreatedOn = new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Ubuntu",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("71bc5242-1eff-4df5-b9da-6078cd44246c"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 11, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Ubuntu",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        },
                        new
                        {
                            Id = new Guid("b712cce8-5ae4-4757-ae6e-a7652544c192"),
                            Browser = "Chrome",
                            CreatedOn = new DateTime(2022, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            Platform = "Ubuntu",
                            UrlId = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95")
                        });
                });

            modelBuilder.Entity("hey_url_challenge_code_dotnet.Models.Url", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("OriginalUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Urls");

                    b.HasData(
                        new
                        {
                            Id = new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 1, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.ign.com",
                            ShortUrl = "DQRKT"
                        },
                        new
                        {
                            Id = new Guid("ee64be23-0256-473a-8de7-29a0ca185999"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.bbc.com",
                            ShortUrl = "NVTHL"
                        },
                        new
                        {
                            Id = new Guid("a97d89fb-1cc2-41c2-81c4-fadd0837f7eb"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 3, 1, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.c-sharpcorner.com",
                            ShortUrl = "AHELK"
                        },
                        new
                        {
                            Id = new Guid("3af55419-0fa8-49bc-8208-b8e660489209"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 4, 4, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.stackoverflow.com",
                            ShortUrl = "OHDRB"
                        },
                        new
                        {
                            Id = new Guid("6bdaf583-afcd-42b0-9c4e-0eba7b21af0a"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 5, 5, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.codesandbox.io",
                            ShortUrl = "HTYHB"
                        },
                        new
                        {
                            Id = new Guid("8890f231-fbf0-4600-a2fb-7679cd66760d"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 6, 6, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.support.appflyer.com",
                            ShortUrl = "BKMLI"
                        },
                        new
                        {
                            Id = new Guid("927bf126-f8ea-4c0d-a3be-31258eba2332"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 7, 7, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.benalman.com",
                            ShortUrl = "TTUYH"
                        },
                        new
                        {
                            Id = new Guid("05dc18f5-afbe-46e2-afc1-265cb00228ac"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 8, 7, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.techtargetcodecity.com",
                            ShortUrl = "UJKIL"
                        },
                        new
                        {
                            Id = new Guid("74fe0975-5728-4bcf-91bf-9bde11cadf45"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 9, 7, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.sitepoint.com",
                            ShortUrl = "JNMKL"
                        },
                        new
                        {
                            Id = new Guid("f516248e-9e6d-4478-9d58-c8e47a25b839"),
                            Count = 0,
                            CreatedOn = new DateTime(2022, 10, 7, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            OriginalUrl = "http://www.gre.ac.uk",
                            ShortUrl = "JKMFD"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
