using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hey_url_challenge_code_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace hey_url_challenge_code_dotnet.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var url = new Url
            {
                Id = Guid.NewGuid(),
                OriginalUrl = "http://www.ign.com",
                ShortUrl = "DQRKT",
                CreatedOn = DateTime.Parse("01/01/2022 10:05 AM"),
                Count = 0
            };

            modelBuilder.Entity<Url>().HasData(
                url,
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.bbc.com",
                    ShortUrl = "NVTHL",
                    CreatedOn = DateTime.Parse("02/01/2022 10:05 AM"),
                    Count = 0
                },
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.c-sharpcorner.com",
                    ShortUrl = "AHELK",
                    CreatedOn = DateTime.Parse("03/01/2022 10:05 AM"),
                    Count = 0
                },
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.stackoverflow.com",
                    ShortUrl = "OHDRB",
                    CreatedOn = DateTime.Parse("04/04/2022 10:05 AM"),
                    Count = 0
                },
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.codesandbox.io",
                    ShortUrl = "HTYHB",
                    CreatedOn = DateTime.Parse("05/05/2022 10:05 AM"),
                    Count = 0
                },
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.support.appflyer.com",
                    ShortUrl = "BKMLI",
                    CreatedOn = DateTime.Parse("06/06/2022 10:05 AM"),
                    Count = 0
                },
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.benalman.com",
                    ShortUrl = "TTUYH",
                    CreatedOn = DateTime.Parse("07/07/2022 10:05 AM"),
                    Count = 0
                },
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.techtargetcodecity.com",
                    ShortUrl = "UJKIL",
                    CreatedOn = DateTime.Parse("08/07/2022 10:05 AM"),
                    Count = 0
                },
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.sitepoint.com",
                    ShortUrl = "JNMKL",
                    CreatedOn = DateTime.Parse("09/07/2022 10:05 AM"),
                    Count = 0
                },
                new Url
                {
                    Id = Guid.NewGuid(),
                    OriginalUrl = "http://www.gre.ac.uk",
                    ShortUrl = "JKMFD",
                    CreatedOn = DateTime.Parse("10/07/2022 10:05 AM"),
                    Count = 0
                });

            modelBuilder.Entity<Clicks>().HasData(
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id,Browser ="Chrome",Platform = "Windows", CreatedOn = DateTime.Parse("01/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("02/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("03/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("04/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("05/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("06/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("07/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("08/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("09/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("10/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("11/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Windows", CreatedOn = DateTime.Parse("12/01/2022 10:05 AM") },

                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Firefox", Platform = "macOS",  CreatedOn = DateTime.Parse("01/01/2022 10:10 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Firefox", Platform = "macOS",  CreatedOn = DateTime.Parse("02/01/2022 10:10 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Firefox", Platform = "macOS",  CreatedOn = DateTime.Parse("03/01/2022 10:10 AM") },


                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "IE",     Platform = "Windows", CreatedOn = DateTime.Parse("01/01/2022 10:11 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "IE",     Platform = "Windows", CreatedOn = DateTime.Parse("02/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Safari", Platform = "macOS",   CreatedOn = DateTime.Parse("01/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Safari", Platform = "macOS",   CreatedOn = DateTime.Parse("02/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Safari", Platform = "macOS",   CreatedOn = DateTime.Parse("03/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "FireFox", Platform = "Ubuntu", CreatedOn = DateTime.Parse("01/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "FireFox", Platform = "Ubuntu", CreatedOn = DateTime.Parse("02/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Ubuntu", CreatedOn = DateTime.Parse("11/01/2022 10:05 AM") },
                new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, Browser = "Chrome", Platform = "Ubuntu", CreatedOn = DateTime.Parse("12/01/2022 10:05 AM") }
            );

        }
    }
}
