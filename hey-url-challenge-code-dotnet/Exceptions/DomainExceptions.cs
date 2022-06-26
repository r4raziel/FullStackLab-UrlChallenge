using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Exceptions
{

    public abstract class DomainException : Exception
    {
        protected DomainException(string message) : base(message)
        {
        }
    }
    public class DomainInvalidUrlException : DomainException
    {

        public DomainInvalidUrlException(string message) : base(message)
        {
        }
    }
    public class DomaininternalServerException : DomainException
    {
        public DomaininternalServerException(string message) : base(message)
        {
        }

    }

    public class DomainBadRequestException : DomainException
    {

        public DomainBadRequestException(string message) : base(message)
        {
        }
    }
}
