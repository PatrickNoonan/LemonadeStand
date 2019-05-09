using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace LemonadeStand
{
    class WeatherAPI
    {
        //has this
        public string inputCity;
        public string countryCode;
        public string weatherTemp;
        public double weatherTempDouble;
        public string weatherDescription;
        public string foreCastUrl;
        public string appId;
        public List<string> weatherInfo;

        //constructor
        public WeatherAPI()
        {
            weatherInfo = new List<string> { };
            //my api key 1f6bccd83448bdf3a3b1a818c53bd659
            appId = "542ffd081e67f4512b705f89d2a611b2";
            countryCode = "860";
        }

        //does this        
        public void ForecastReport()
        {
            using (var webClient = new System.Net.WebClient())
            {
                Console.WriteLine("What city would you like the forecast for?");
                inputCity = Console.ReadLine();
                foreCastUrl = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0},{1}&units=imperial&cnt=7&APPID={2}", inputCity, countryCode, appId);
                var myJsonForecast = webClient.DownloadString(foreCastUrl);
                var forecastJO = JObject.Parse(myJsonForecast);

                for (int i = 0; i < 7; i++)
                {
                    weatherDescription = forecastJO["list"][i]["weather"][0]["main"].ToString();
                    weatherTemp = forecastJO["list"][i]["main"]["temp_max"].ToString();
                    weatherTempDouble = Math.Round(Convert.ToDouble(weatherTemp));

                    Console.WriteLine($"For day {i+1} the temperature will be {weatherTempDouble} and the condition will be {weatherDescription}.");
                }
                Console.Read();
            }
        }       
        public List<string> WeatherReport(int dayNum)
        {
            using (var webClient = new System.Net.WebClient())
            {
               
                Console.WriteLine("What city are you parked in today?");
                inputCity = Console.ReadLine();
                foreCastUrl = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0},{1}&units=imperial&cnt=7&APPID={2}", inputCity, countryCode, appId);
                var myJsonForecast = webClient.DownloadString(foreCastUrl);
                var forecastJO = JObject.Parse(myJsonForecast);

                    weatherDescription = forecastJO["list"][dayNum-1]["weather"][0]["main"].ToString();
                    weatherTemp = forecastJO["list"][dayNum-1]["main"]["temp_max"].ToString();
                    weatherTempDouble = Math.Round(Convert.ToDouble(weatherTemp));

                Console.WriteLine($"{inputCity} is {Math.Round(weatherTempDouble)} and the condition is {weatherDescription}. ");
                Console.Read();
                weatherInfo.Add(weatherTemp);
                weatherInfo.Add(weatherDescription);

                return weatherInfo;
               
            }
        }
    }
}

