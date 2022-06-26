using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace hey_url_challenge_code_dotnet.Models
{
    
    public class Clicks
    {
        public Guid Id { get; set; }
       
        public Guid UrlId { get; set; }

        public string Platform { get; set; }

        public string Browser { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
