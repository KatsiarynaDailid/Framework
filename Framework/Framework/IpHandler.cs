using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
   public class IpHandler
    {

        private static string protocol = "http";
        private static string hostName = "ip-api.com";
        private static string pathToResource = "json/{ip}";
        private static string HttpMethod = "GET";

        public string GetIp()
        {
         //   var ipAddresses = new List<string>() { "155.120.20.3", "110.25.32.84", "123.32.54.6" };
            string ipAddress = "155.120.20.3";
            //foreach (var ipAddress in ipAddresses)
            //{
            string pathToResourceModified = pathToResource.Replace("{ip}", ipAddress);
            string requestUri = string.Format("{0}://{1}/{2}", protocol, hostName, pathToResourceModified);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.Method = HttpMethod;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string content = string.Empty;

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                content = reader.ReadToEnd();
            }

            IpData data = JsonConvert.DeserializeObject<IpData>(content);

            string message = "" + data.City;
            //  Console.WriteLine(string.Format("{0} is in {1} city of {2}, timezone {3}", ipAddress, data.City, data.Country, data.TimeZone));
            //}

            return message;
        }

        private class IpData
        {
            [JsonProperty("city", Required = Required.Always)]
            public string City { get; set; }

            [JsonProperty("country", Required = Required.Always)]
            public string Country { get; set; }

            [JsonProperty("timezone", Required = Required.Always)]
            public string TimeZone { get; set; }
        }

    }
}
