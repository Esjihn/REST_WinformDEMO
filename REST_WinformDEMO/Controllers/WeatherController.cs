using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using REST_WinformDEMO.Models;

namespace REST_WinformDEMO.Controllers
{
    // RESTful Controller
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public List<WeatherInfo> Get()
        {
            List<WeatherInfo> weatherList = new List<WeatherInfo>();
            for (int i = 0; i < 10; i++)
            {
                WeatherInfo info = new WeatherInfo
                {
                    Location = $"Location {i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()
                };

                weatherList.Add(info);
            }

            return weatherList;
        }

        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo
            {
                Location = $"Location {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }
    }
}
