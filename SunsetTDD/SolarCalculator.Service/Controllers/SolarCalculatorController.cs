using SolarCalculator.Service.Library;
using SolarCalculator.Service.Models;
using System;
using System.Web.Http;

namespace SolarCalculator.Service.Controllers
{
    public class SolarCalculatorController : ApiController
    {
        // GET: api/SolarCalculator?lat=33.8361&lng=-117.8897&date=2016-03-31
        // GET: api/SolarCalculator/33.8361/-117.8897/2016-03-31
        public SolarCalculatorResult Get(double lat, double lng, DateTime date)
        {
            var result = SolarCalculatorProvider.GetSolarTimes(date, lat, lng);
            return result;
        }
    }
}
