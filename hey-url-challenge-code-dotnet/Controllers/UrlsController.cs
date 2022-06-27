using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using hey_url_challenge_code_dotnet.Models;
using hey_url_challenge_code_dotnet.Models.Api;
using hey_url_challenge_code_dotnet.ViewModels;
using hey_url_challenge_code_dotnet.RandomCodeGenerator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shyjus.BrowserDetection;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using hey_url_challenge_code_dotnet.Exceptions;
using hey_url_challenge_code_dotnet.JsonNamingPolicy;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace HeyUrlChallengeCodeDotnet.Controllers
{

    public class UrlsController : Controller
    {
       
        private static readonly Random getrandom = new Random();
        private readonly IBrowserDetector browserDetector;
        private IUrlRepository _repository;

        public void TestRepositorySet(IUrlRepository repository)
        {
            _repository = repository;
        }

        public UrlsController(IBrowserDetector browserDetector, IUrlRepository repository)
        {
            this.browserDetector = browserDetector;
            _repository = repository;
        }

        [Route("save")]
        [HttpPost]
        public IActionResult Save(HomeViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Url url = new Url
                    {
                        Id = Guid.NewGuid(),
                        Count = 0,
                        OriginalUrl = model.NewUrl.OriginalUrl,
                        ShortUrl = RandomURL.GetURL(),
                        CreatedOn = DateTime.Now
                    };

                    //check url exists with shortName
                    if (_repository.CheckUrlExists(url))
                    {
                        url.ShortUrl = RandomURL.GetURL();
                    }

                    _repository.Add(url);
                    _repository.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new DomaininternalServerException("Internal Server Error 500.Please contact administrator." + ex.Message);
                }

                ModelState.Clear();
                return View("Index", GetAllUrls());
            }
            else
            {
                return View("Index", GetAllUrls());
            }

        }

        public HomeViewModel GetAllUrls()
        {
            List<Url> urls = _repository.Urls.OrderBy(x=>x.CreatedOn).ToList();

            HomeViewModel model = new HomeViewModel {
                Urls = urls,
                NewUrl = new Url { OriginalUrl = "", ShortUrl = "" }
            };

            return model;

        }        

        [Route("/")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View(GetAllUrls());
        }

        [Route("/index/{url}")]
        public IActionResult Visit(string url)
        {

            var record = _repository.GetUrlByShortName(url);
            if (record != null)
            {
                record.Count++;
                var click = new Clicks {
                    Id = Guid.NewGuid(),
                    UrlId = record.Id,
                    Platform = this.browserDetector.Browser != null ? this.browserDetector.Browser.OS: "Windows",
                    Browser = this.browserDetector.Browser != null ? this.browserDetector.Browser.Name : "NUnit",
                    CreatedOn = DateTime.Now
                };
                _repository.Add(click);
                _repository.SaveChanges();
            }
            else {

                throw new DomainInvalidUrlException("Invalid Url. Please contact administrator.");
            }

            return View("Index", GetAllUrls());
        }
        [Route("urls/{url}")]
        public IActionResult Show(string url)
        {
            var record = _repository.GetUrlByShortName(url);
            if (record != null)
            {
                var dailyClicks = _repository.GetClicksDataByMonth(record);
                var browserClicks = _repository.GetClicksDataByBrowser(record);
                var platformClicks = _repository.GetClicksDataByPlatform(record);

                return View(new ShowViewModel()
                {
                    Url = record,
                    DailyClicks = dailyClicks,
                    BrowseClicks = browserClicks,
                    PlatformClicks = platformClicks
                });
            }
            else
            {
                throw new DomainInvalidUrlException("Invalid Url. Please contact administrator.");
            }
        }


        [HttpGet("/api/GetLast10Urls")]
        [Produces("application/json")]
        public async Task<JsonResult> GetAllData()
        {
            var urls = await _repository.Urls.OrderBy(x=>x.CreatedOn).ToListAsync();
            List<ApiResponseModel> apiResponseList = new List<ApiResponseModel>();
            foreach (var m in urls)
            {
                var apiModel = new ApiResponseModel
                {
                    Type = "urls",
                    Id = m.Id,
                    Attributes = new Attributes
                    {
                        CreatedAt = m.CreatedOn,
                        OriginalUrl = m.OriginalUrl,
                        Url = "https://domain/" + m.ShortUrl,
                        Clicks = m.Count.ToString()
                    },
                    Relationships = new Relationships
                    {
                        clicks = new ClicksApiModel<BasicModel>
                        {
                            Data = new List<BasicModel>() { new BasicModel { Id = m.Id, Type = "Clicks" } }.ToArray()
                        }
                    }
                };
                var clicksList = await _repository.GetClicksByUrlId(m.Id);

                if (clicksList.Count > 0)
                {
                    apiModel.Included = new List<ClicksApiAttributesModel>();
                    foreach (var c in clicksList)
                    {
                        var attribute = new ClicksApiAttributesModel
                        {
                            Id = c.Id,
                            Type = "cliks",
                            Attributes = new ClicksAttributes { Browser = c.Browser, Platform = c.Platform }
                        };

                        apiModel.Included.Add(attribute);
                    }
                }
                apiResponseList.Add(apiModel); 
            }
            return new JsonResult(new ResponseData<ApiResponseModel>()
            {

                Code = EResponse.OK.ToString(),
                Status = StatusCodes.Status200OK,
                Data = apiResponseList.ToArray(),
            },
            new JsonSerializerOptions() { PropertyNamingPolicy = new CustomJsonNamingPolicy() })
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

        [Route("/NotFound")]
        public IActionResult PageNotFound()
        {
            return View();
        }

        [Route("/InternalServer")]
        public IActionResult InternalServer()
        {
            return View();
        }
       
    }
}