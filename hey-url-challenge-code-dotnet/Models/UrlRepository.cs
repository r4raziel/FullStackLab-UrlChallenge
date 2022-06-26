using HeyUrlChallengeCodeDotnet.Data;
using hey_url_challenge_code_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Models
{
    public class UrlRepository : IUrlRepository
    {
        private readonly ApplicationContext _db;

        public UrlRepository(ApplicationContext db)
        {

            _db = db;
        }

        public IQueryable<Url> Urls => _db.Urls;
        public IQueryable<Clicks> Clicks => _db.Clicks;

        public void Add<EntityType>(EntityType entity)
        {
            _db.Add(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public bool CheckUrlExists(Url model)
        {
            var record = _db.Urls.FirstOrDefault(x => x.OriginalUrl == model.OriginalUrl && x.ShortUrl == model.ShortUrl);

            if (record != null)
                return true;

            return false;

        }

        public Url GetUrlByShortName(string shortName)
        {
            return _db.Urls.FirstOrDefault(x => x.ShortUrl == shortName);
        }

        public async Task<ICollection<Clicks>> GetClicksByUrlId(Guid id)
        {
            return await Task.FromResult(_db.Clicks.Where(x => x.UrlId == id).ToList());
        }

        public Dictionary<string, int> GetClicksDataByMonth(Url url)
        {

            var monthlyClicks = (from c in _db.Clicks
                                 where c.UrlId == url.Id
                                 group c by new
                                 {
                                     ShortUrl = url.ShortUrl,
                                     Year = c.CreatedOn.Year,
                                     Month = c.CreatedOn.Month
                                 } into g
                                 select new
                                 {
                                     ShortUrl = g.Key.ShortUrl,
                                     Year = g.Key.Year,
                                     Month = g.Key.Month,
                                     Count = g.Count()

                                 }
                 ).Where(x => x.Year == DateTime.Now.Year).AsEnumerable();

            var clickDict = monthlyClicks.ToDictionary(x => {
                DateTime date = new DateTime(2020, x.Month, 1);
                return date.ToString("MMM"); 
            }, y => y.Count);

            return clickDict;           
        }

        public Dictionary<string, int> GetClicksDataByBrowser(Url url)
        {

            var browser = (from c in _db.Clicks
                                 where c.UrlId == url.Id
                                 group c by new
                                 {
                                     ShortUrl = url.ShortUrl,
                                     Year = c.CreatedOn.Year,                                     
                                     Browser = c.Browser
                                 } into g
                                 select new
                                 {
                                     ShortUrl = g.Key.ShortUrl,
                                     Browser = g.Key.Browser,
                                     Year = g.Key.Year,                                     
                                     Count = g.Count()

                                 }
                 ).Where(x => x.Year == DateTime.Now.Year).ToDictionary(x => x.Browser, y => y.Count);

            return browser;
           
        }

        public Dictionary<string, int> GetClicksDataByPlatform(Url url)
        {

            var platform = (from c in _db.Clicks
                           where c.UrlId == url.Id
                           group c by new
                           {
                               ShortUrl = url.ShortUrl,
                               Year = c.CreatedOn.Year,
                               Platform = c.Platform
                           } into g
                           select new
                           {
                               ShortUrl = g.Key.ShortUrl,
                               Platform = g.Key.Platform,
                               Year = g.Key.Year,
                               Count = g.Count()

                           }
                 ).Where(x => x.Year == DateTime.Now.Year).ToDictionary(x => x.Platform, y => y.Count);

            return platform;

        }

    }
}
