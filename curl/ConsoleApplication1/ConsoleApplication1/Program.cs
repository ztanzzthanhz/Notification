using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string data = "{\"registration_ids\":[\"c0OkfsNR5Ug:APA91bEm5Q4TZGFV-tvd3QqvL2XtOhvJXm0KfsrtR9O_ePKjsegrm3NFxWKfKJkVr-1flI8hJSRO_u2PMTRt1SZ8DcZAF03LgnvRQNhRX_ACbpqC0BKQ67U3PqRXd0iHVhj4o2GkJnLw\"]}";
            string data = "{" 
                        + "\"registration_ids\":[\"e30kPpDz-Eg:APA91bFOKfIpD-PinVpqxtamh3V0ECVaitPaEM_X0w3fjzHMkfycU1rLld5K61XdF9PRXxeNF8E9NXhMYyLgXIorDifPPr-B2NFifrvhTQXCrd0kD6HY58-o9z3Q7OIoZpWSpw2wdVNd\"],"
                        + "\"data\":{\"message\":\"abc\"}"
                        + "}";
            cUrl.Exec(data);
        }
    }
}
