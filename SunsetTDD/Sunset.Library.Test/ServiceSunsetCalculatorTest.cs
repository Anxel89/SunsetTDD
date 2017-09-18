using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sunset.Interface;

namespace Sunset.Library.Test
{
    public class ServiceSunsetCalculatorTest
    {
        string goodData = "{\"results\":{\"sunrise\":\"6:37:49 AM\",\"sunset\":\"4:42:49 PM\",\"solar_noon\":\"11:40:19 AM\",\"day_length\":\"10:05:00.1530000\"},\"status\":\"OK\"}";


        [Test]
        public void ServiceSunsetCalculator_ImplementsISunsetCalculator()
        {
            var calculator = new ServiceSunsetCalculator();
            Assert.IsInstanceOf<ISunsetCalculator>(calculator);
        }

        [Test]
        public void ParseJsonSunsetValue_OnGoodData_ReturnExpectedString()
        {
            string expected = "4:42:49 PM";
            string result = ServiceSunsetCalculator.ParseSunset(goodData);
            Assert.AreEqual(expected, result);
        }
    }
}
