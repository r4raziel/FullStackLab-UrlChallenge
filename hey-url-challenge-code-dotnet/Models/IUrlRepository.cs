using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Models
{
    public interface IUrlRepository
    {
        IQueryable<Url> Urls { get; }
        IQueryable<Clicks> Clicks { get; }

        bool CheckUrlExists(Url model);

        Url GetUrlByShortName(string shortName);

        Task<ICollection<Clicks>> GetClicksByUrlId(Guid id);

        Dictionary<string, int> GetClicksDataByMonth(Url url);
        Dictionary<string, int> GetClicksDataByBrowser(Url url);
        Dictionary<string, int> GetClicksDataByPlatform(Url url);

        void Add<EntityType>(EntityType entity);

        Task<StatusCodeResult> Update(Clicks model);

        void SaveChanges();


    }
}
