using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;


namespace LemonadeStand
{/*
    class WeatherApi
    {
        public class WeatherInfo
        {
                        
            //public string temperature;
            //public string weatherDescription;
            //public City MyCity = new City();
            //public List MyList = new List();
            //using json2csharp
            public class Coord
            {
                public double lon { get; set; }
                public double lat { get; set; }
            }

            public class City
            {
                public int id { get; set; }
                public string name { get; set; }
                public Coord coord { get; set; }
                public string country { get; set; }
                public int population { get; set; }
            }

            public class Temp
            {
                public double day { get; set; }
                public double min { get; set; }
                public double max { get; set; }
                public double night { get; set; }
                public double eve { get; set; }
                public double morn { get; set; }
            }

            public class Weather
            {
                public int id { get; set; }
                public string main { get; set; }
                public string description { get; set; }
                public string icon { get; set; }
            }

            public class List
            {
                public int dt { get; set; }
                public Temp temp { get; set; }
                public double pressure { get; set; }
                public int humidity { get; set; }
                public List<Weather> weather { get; set; }
                public double speed { get; set; }
                public int deg { get; set; }
                public int clouds { get; set; }
                public double rain { get; set; }
            }

            public class RootObject
            {
                public City city { get; set; }
                public string cod { get; set; }
                public double message { get; set; }
                public int cnt { get; set; }
                public List<List> list { get; set; }
            }
        }

        //protected void GetWeatherInfo(object sender, EventArgs e)
        public void GetWeatherInfo()
        {
            string cityAndCountry;
            string appId = "542ffd081e67f4512b705f89d2a611b2";
            //my api key 1f6bccd83448bdf3a3b1a818c53bd659
            string inputCity = "milwaukee";
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", inputCity, appId);
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                WeatherInfo weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);                
                cityAndCountry = weatherInfo.city.name + "," + weatherInfo.city.country;
                //temperature = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.day, 1));
                //weatherDescription = weatherInfo.list[0].weather[0].description;
               
            }
            Console.WriteLine(cityAndCountry);
        }
    }
    */
}
