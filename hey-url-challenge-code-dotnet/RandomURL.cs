using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.RandomCodeGenerator
{
    public class RandomURL
    {
        // List of characters and numbers to be used...          
        private static List<char> characters = new List<char>()
        {'A', 'B','C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
        'Q', 'R', 'S',  'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        public static string GetURL()
        {
            string URL = "";
            Random rand = new Random();
            // run the loop till I get a string of 5 characters  
            for (int i = 0; i < 5; i++)
            {
                // Get random numbers, to get either a character or a number...                  
                int random = rand.Next(0, characters.Count);
                URL += characters[random].ToString();
               
            }
            return URL;
        }
    }
}
