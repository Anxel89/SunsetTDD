using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunset.Interface;
using Newtonsoft.Json;

namespace Sunset.Library
{
    public class ServiceSunsetCalculator : ISunsetCalculator
    {
        public DateTime GetSunrise(DateTime date)
        {
            throw new NotImplementedException();
        }

        public DateTime GetSunset(DateTime date)
        {
            // call the service
            // parse the "sunset"
            // convert the "sunset" value to Date Time
            throw new NotImplementedException();
        }

        public static string ParseSunset(string jsonContent)
        {
            dynamic data = JsonConvert.DeserializeObject(jsonContent);
            string sunset = data.results.sunset;
            return sunset;
        }
    }
}
