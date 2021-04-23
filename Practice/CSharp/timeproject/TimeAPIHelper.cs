using System.Net.Http;
using System.Threading.Tasks;
using Timeproject.Interface;
using Timeproject.Models;
using Newtonsoft.Json;
namespace Timeproject
{
    public class TimeAPIHelper : ITimeAPIHelper
    {
        private HttpClient client = new HttpClient();
        private readonly string uri;

        public string Uri => uri;

        public TimeAPIHelper(string uri)
        {
            this.uri = uri;
        }
        public override string ToString()
        {
            return uri.ToString();
        }
        public async Task<string> GetUTCTimeFromAPI()
        {
            
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var time = await response.Content.ReadAsStringAsync();
                var obj =  JsonConvert.DeserializeObject<WorldClockModel>(time);
                return obj.utc_datetime;
            }
            return string.Empty;
        }
        
    }
}