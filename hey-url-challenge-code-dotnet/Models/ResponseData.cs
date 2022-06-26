using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Models
{
    public enum EResponse
    {
        OK,
        NotFound,
        BadRequest,
        UnexpectedError,
        NoData,
        ValidationError,
        NoPermission,
        UnSuccess
    }
    public class ResponseData<T>
    {
        public string Code { get; set; } = "";
        public int Status { get; set; } = -1;
        public T[] Data { get; set; } = new T[1];
        public string Message { get; set; } = "";
    }
}
