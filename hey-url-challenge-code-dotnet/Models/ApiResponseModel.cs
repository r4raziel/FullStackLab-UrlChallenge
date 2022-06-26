using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Models.Api
{
    public class Attributes {
        
        public DateTime CreatedAt { get; set; }       
        public string OriginalUrl { get; set; }
        public string Url { get; set; }
        public string Clicks { get; set; } 
    
    }

    public class ClicksApiModel<T> {

        public T[] Data { get; set; } = new T[1];
    }

    public class BasicModel {
        public Guid Id { get; set; }
        public string Type { get; set; }

    }
    public class Relationships {
        public ClicksApiModel<BasicModel> clicks { get; set;}
    }

    public class ClicksApiAttributesModel {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public ClicksAttributes Attributes { get; set; }

    }
    public class ClicksAttributes { 
    
        public string Browser { get; set; }
        public string Platform { get; set; }
    
    }
    public class ApiResponseModel
    {
        public Guid Id{ get; set; }
        public string Type { get; set; }
        public Attributes Attributes { get; set; }
        public Relationships Relationships { get; set; }

        public List<ClicksApiAttributesModel> Included { get; set; }
    }
}
