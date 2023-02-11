using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using WebDemo.Interface;
using WebDemo.Models;

namespace WebDemo.Service
{
    public class DataService : IData
    {
        public DataService()
        {
        }
        public async Task<List<DataModel>?> GetDatas()
        {
            List<DataModel>? datas = new List<DataModel>();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("http://172.20.10.3:8082/datas");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            if (responseBody != null) { 
                datas = JsonConvert.DeserializeObject<List<DataModel>>(responseBody);
            }
            return datas;
        }
    }
}
