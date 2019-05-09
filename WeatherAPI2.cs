using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace LemonadeStand
{
    class WeatherAPI2
    {
        public void WeatherReport()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string cityName;
                string countryName;
                string weatherDescription;

                //http://api.openweathermap.org/data/2.5/forecast?q=milwaukee,840&units=metric&cnt=7&APPID=542ffd081e67f4512b705f89d2a611b2

                string appId = "542ffd081e67f4512b705f89d2a611b2";
                //my api key 1f6bccd83448bdf3a3b1a818c53bd659
                Console.WriteLine("What city is this lemonade stand going to be placed in?");
                string inputCity = Console.ReadLine();
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", inputCity, appId);
                var myJsonString = webClient.DownloadString(url);                
                var jo = JObject.Parse(myJsonString);

                cityName = jo["city"]["name"].ToString();
                countryName = jo["city"]["country"].ToString();
                weatherDescription = jo["list"][0]["weather"][0]["description"].ToString();
                Console.WriteLine(cityName + ", " + countryName);
                Console.WriteLine(weatherDescription);
                Console.Read();
            }
        }
    }
}

