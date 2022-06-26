using System;
using System.ComponentModel.DataAnnotations;

namespace hey_url_challenge_code_dotnet.Models
{
    public class Url
    {
        public Guid Id { get; set; }
        public string ShortUrl { get; set; }
        public int Count { get; set; }
        [Url]
        [Required(ErrorMessage = "Please enter url")]                
        [RegularExpression(@"^http(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$",
                            ErrorMessage = "Please enter a valid url")]
        public string OriginalUrl { get; set; }
        [Display()]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dddd, dd yyyy}")]
        public DateTime CreatedOn { get; set; }
    }
}
