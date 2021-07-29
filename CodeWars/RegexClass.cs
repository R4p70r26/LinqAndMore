using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    class RegexClass
    {
        public void Examp()
        {

            string str = "  Hello World_-";

            string pattern = "[_-]"; // matches those chars

            MatchCollection match = Regex.Matches(str, pattern);
            foreach (Match item in match)
            {
                Console.WriteLine(item);
            }

        }
    }
}


// https://www.c-sharpcorner.com/UploadFile/955025/regular-expression-in-C-Sharp/
// https://www.c-sharpcorner.com/article/c-sharp-regex-examples/
