using System;
using hey_url_challenge_code_dotnet.Models;
using HeyUrlChallengeCodeDotnet.Controllers;
using HeyUrlChallengeCodeDotnet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Shyjus.BrowserDetection;

namespace tests
{
    public class UrlsControllerTest
    {
        private UrlsController _controller;
        private IUrlRepository _repository;


        private void Populate(ApplicationContext context)
        {
            var url = new Url { Id = Guid.NewGuid(), Count = 10, OriginalUrl = "http://www.test.com",ShortUrl = "KJHBN", CreatedOn = DateTime.Now};
            var click = new Clicks { Id = Guid.NewGuid(), UrlId = url.Id, CreatedOn = DateTime.Now, Browser = "Chrome", Platform = "Windows"};

            context.Add(url);
            context.Add(click);
            context.SaveChanges();
        }


        private IUrlRepository GetInMemoryRepository()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: "MockDB")
                .Options;

            var initContext = new ApplicationContext(options);

            initContext.Database.EnsureDeleted(); //clears all data

            Populate(initContext);

            //var repository = new DbRepository(initContext);

            var testContext = new ApplicationContext(options);
            var repository = new UrlRepository(initContext);


            return repository;
        }

        [SetUp]
        public void Setup()
        {
            _repository = GetInMemoryRepository();
            //_repository = new Mocks.MockRepository();
            _controller = new UrlsController(new BrowserDetector(new HttpContextAccessor()),_repository);
        }

        [Test]
        public void TestIndex()
        {
            Assert.Pass();
        }
    }
}