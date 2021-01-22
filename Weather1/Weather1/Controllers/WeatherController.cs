using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using Weather1.Models;
using Newtonsoft.Json;

namespace Weather1.Controllers
{
    public class WeatherController : Controller
    {

        [HttpGet]
        [Route("GetCurrentWeather")]
        public WeatherCurrentModel GetCurrentWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Dnipro&appid=9769103b84d8c6ea2e29ec7af33de9e0";

            using (WebClient client = new WebClient())
            {
                string webServiceJsonString = client.DownloadString(url);

                var jsonObj = JsonConvert.DeserializeObject<JsonObjCurrent>(webServiceJsonString);

                WeatherCurrentModel weatherModel = new WeatherCurrentModel
                {
                    City = jsonObj.name,
                    Date = DateTime.Today,
                    Temperature = Math.Round(jsonObj.main.temp - 273.15, 2),
                    Wind_Speed = jsonObj.wind.speed,
                    Cloudy = jsonObj.clouds.all
                };

                return weatherModel;
            }
        }

        [HttpGet]
        [Route("GetForecastWeather")]
        public List<WeatherForecastModel> GetForecastWeather()
        {

            string url = "http://api.openweathermap.org/data/2.5/forecast?q=Dnipro&appid=9769103b84d8c6ea2e29ec7af33de9e0";

            using (WebClient client = new WebClient())
            {
                string webServiceJsonString = client.DownloadString(url);

                var jsonObjForecast = JsonConvert.DeserializeObject<JsonObjForecast>(webServiceJsonString);

                List<WeatherForecastModel> listForecast = new List<WeatherForecastModel>();

                foreach (var item in jsonObjForecast.list)
                {
                    WeatherForecastModel weatherForecastModel = new WeatherForecastModel
                    {
                        City = jsonObjForecast.city.name,
                        Date = Convert.ToDateTime(item.dt_txt),
                        Temperature_min = Math.Round(item.main.temp_min - 273.15, 2),
                        Temperature_max = Math.Round(item.main.temp_max - 273.15, 2),
                        Wind_Speed = item.wind.speed,
                        Cloudy = item.clouds.all
                    };
                    listForecast.Add(weatherForecastModel);
                }
                return listForecast;
            }
        }
    }
}