using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;

namespace hey_url_challenge_code_dotnet.JsonNamingPolicy
{
    public class CustomJsonNamingPolicy : System.Text.Json.JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            var result = new StringBuilder();
            for (var i = 0; i < name.Length; i++)
            {
                var c = name[i];
                if (i == 0)
                {
                    result.Append(char.ToLower(c));
                }
                else
                {
                    if (char.IsUpper(c))
                    {
                        result.Append('-');
                        result.Append(char.ToLower(c));
                    }
                    else
                    {
                        result.Append(c);
                    }
                }
            }
            return result.ToString();
        }
    }
}
