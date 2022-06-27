using System;
using hey_url_challenge_code_dotnet.Models;
using hey_url_challenge_code_dotnet.ViewModels;
using HeyUrlChallengeCodeDotnet.Controllers;
using HeyUrlChallengeCodeDotnet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Shyjus.BrowserDetection;
using System.Linq;
using hey_url_challenge_code_dotnet.Models.Api;

namespace tests
{
    public class UrlsControllerTest
    {
        private UrlsController _controller;
        private IUrlRepository _repository;


        private void Populate(ApplicationContext context)
        {
            var url = new Url { 
                                Id = Guid.NewGuid(), Count = 10, 
                                OriginalUrl = "http://www.test.com",ShortUrl = "KJHBN",
                                CreatedOn = DateTime.Now};
            var click = new Clicks { 
                                Id = Guid.NewGuid(),
                                UrlId = url.Id,
                                CreatedOn = DateTime.Now,
                                Browser = "Chrome",
                Platform = "Windows"};

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
            Assert.AreEqual(1, _repository.Urls.CountAsync().Result);
            Assert.AreEqual("KJHBN", _repository.Urls.FirstOrDefaultAsync(x => x.ShortUrl == "KJHBN").Result.ShortUrl);
            Assert.AreEqual(10, _repository.Urls.FirstOrDefaultAsync(x => x.ShortUrl == "KJHBN").Result.Count);
        }

        [Test]
        public void TestSave()
        {
            _controller.Save(new HomeViewModel
            {
                NewUrl = new Url { OriginalUrl = "http://originaltest.com" }
            });
            Assert.AreEqual(2, _repository.Urls.CountAsync().Result);
            Assert.AreEqual("http://originaltest.com", _repository.Urls.FirstOrDefaultAsync(x => x.OriginalUrl == "http://originaltest.com").Result.OriginalUrl);
        
        }
        [Test]
        public void TestGetAllUrls()
        {
            HomeViewModel model = _controller.GetAllUrls();
            Assert.AreEqual(1, model.Urls.ToList().Count);
        }

        [Test]
        public void TestVist()
        {
            _controller.Visit("KJHBN");
            //check url.clicks count
            Assert.AreEqual(11, _repository.Urls.FirstOrDefaultAsync(x => x.ShortUrl == "KJHBN").Result.Count);
            //check clicks data
            Assert.AreEqual(2, _repository.Clicks.ToList().Count);
            Assert.AreEqual("Windows", _repository.Clicks.OrderByDescending(x=>x.CreatedOn).FirstOrDefault(x=>x.UrlId == _repository.Urls.FirstOrDefault(x => x.ShortUrl == "KJHBN").Id).Platform);
            Assert.AreEqual("NUnit", _repository.Clicks.OrderByDescending(x => x.CreatedOn).FirstOrDefault(x => x.UrlId == _repository.Urls.FirstOrDefault(x => x.ShortUrl == "KJHBN").Id).Browser);
        }

        [Test]
        public void GetLast10Urls()
        {
            var jsonResult = _controller.GetAllData().Result;
            var obj= jsonResult.Value as ResponseData<ApiResponseModel>;
            Assert.AreEqual(200, jsonResult.StatusCode);
            Assert.AreEqual("Chrome", obj.Data[0].Included[0].Attributes.Browser);
            Assert.AreEqual("Windows", obj.Data[0].Included[0].Attributes.Platform);
           
        }
    }
}